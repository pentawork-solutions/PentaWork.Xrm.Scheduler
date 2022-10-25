using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using PentaWork.Xrm.Scheduler.CodeActivities;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.Scheduler.Tests.Fake;
using System.Collections.Generic;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Tests.CodeActivities
{
    [TestClass]
    public class RunScheduleActionTests
    {
        private PentaSchedule _schedule = FakePentaSchedule.Create();
        private PentaScheduleRun _scheduleRun = FakePentaScheduleRun.Create();
        private Process _process = FakeProcess.Create();
        private SdkMessage _sdkMessage = FakeSdkMessage.Create();
        private List<Entity> _knownEntities = new List<Entity>();

        #region TestInitialize
        [TestInitialize]
        public void TestInit()
        {
            _schedule.FetchXML = 
                @"<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"" distinct=""false"">
                  <entity name=""account"">
                    <attribute name=""name"" />
                  </entity>
                </fetch>";

            _scheduleRun.CurrentPage = 1;
            _scheduleRun.PentaSchedule = _schedule.ToEntityReference();

            _process.ProcessName = "Execute Schedule";

            _knownEntities.Add(_schedule);
            _knownEntities.Add(_scheduleRun);
            _knownEntities.Add(_process);
            _knownEntities.Add(_sdkMessage);
        }
        #endregion
                
        [TestMethod]
        public void ShouldExecuteActionScheduleSuccessfully()
        {
            // Arrange
            var action = FakeProcess.Create();
            action.Category = Process.eCategory.Action;
            action.PrimaryEntity = Account.LogicalName;
            action.SDKMessage = _sdkMessage.ToEntityReference();
            
            _schedule.Frequency = PentaSchedule.egFrequency.Daily;
            _schedule.ScheduleType = PentaSchedule.egScheduleType.Action;
            _schedule.Action = action.ToEntityReference();

            _knownEntities.Add(action);
            _knownEntities.AddRange(new List<Entity> { FakeAccount.Create(), FakeAccount.Create(), FakeAccount.Create() });

            // Act
            var fakeContext = FakeContext.ExecuteCodeActivity<RunSchedule>(_scheduleRun, _knownEntities, null, new Dictionary<string, object> { { "WebhookId", new EntityReference() } });

            // Assert
            Assert.AreEqual(3, fakeContext.CreateQuery<SystemJob>().Count(s => s.Message == _sdkMessage.Name));
        }

        [TestMethod]
        public void ShouldExecuteGlobalActionScheduleSuccessfully()
        {
            // Arrange
            var globalAction = FakeProcess.Create();
            globalAction.Category = Process.eCategory.Action;
            globalAction.PrimaryEntity = "";
            globalAction.SDKMessage = _sdkMessage.ToEntityReference();

            _schedule.Frequency = PentaSchedule.egFrequency.Daily;
            _schedule.ScheduleType = PentaSchedule.egScheduleType.GlobalAction;
            _schedule.GlobalAction = globalAction.ToEntityReference();

            _knownEntities.Add(globalAction);

            // Act
            var fakeContext = FakeContext.ExecuteCodeActivity<RunSchedule>(_scheduleRun, _knownEntities, null, new Dictionary<string, object> { { "WebhookId", new EntityReference() } });

            // Assert
            Assert.AreEqual(1, fakeContext.CreateQuery<SystemJob>().Count(s => s.Message == _sdkMessage.Name));
        }
    }
}
