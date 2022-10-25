using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using PentaWork.Xrm.Scheduler.CodeActivities;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.Scheduler.Tests.Fake;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Tests.CodeActivities
{
    [TestClass]
    public class RunScheduleFrequencyTests
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
        public void ShouldSetNextRunTimeOnceSuccessfully()
        {
            // Arrange
            var action = FakeProcess.Create();
            action.Category = Process.eCategory.Action;
            action.PrimaryEntity = Account.LogicalName;
            action.SDKMessage = _sdkMessage.ToEntityReference();

            _schedule.Frequency = PentaSchedule.egFrequency.Once;
            _schedule.ScheduleType = PentaSchedule.egScheduleType.Action;
            _schedule.Action = action.ToEntityReference();

            _knownEntities.Add(action);

            // Act
            var fakeContext = FakeContext.ExecuteCodeActivity<RunSchedule>(_scheduleRun, _knownEntities, null, new Dictionary<string, object> { { "WebhookId", new EntityReference() } });
            _schedule = fakeContext.CreateQuery<PentaSchedule>().Single(p => p.Id == _schedule.Id);

            // Assert
            Assert.AreEqual(PentaSchedule.eStatusReason.Ended_Active, _schedule.StatusReason);
            Assert.AreEqual(1, fakeContext.CreateQuery<PentaScheduleRun>().Count());
        }

        [TestMethod]
        public void ShouldSetNextRunTimeDailySuccessfully()
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

            // Act
            var fakeContext = FakeContext.ExecuteCodeActivity<RunSchedule>(_scheduleRun, _knownEntities, null, new Dictionary<string, object> { { "WebhookId", new EntityReference() } });
            var scheduleRun = fakeContext.CreateQuery<PentaScheduleRun>().OrderBy(r => r.CreatedOn).First();
            _schedule = fakeContext.CreateQuery<PentaSchedule>().Single(p => p.Id == _schedule.Id);

            // Assert
            var startDate = _schedule.StartDateTime.Value;
            Assert.AreEqual(_schedule.LastRunDateTime.Value.AddDays(1).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second), scheduleRun.RunDateTime);
        }
    }
}
