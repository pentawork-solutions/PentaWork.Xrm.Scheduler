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
    public class RunScheduleWorkflowTests
    {
        private PentaSchedule _schedule = FakePentaSchedule.Create();
        private PentaScheduleRun _scheduleRun = FakePentaScheduleRun.Create();
        private Process _process = FakeProcess.Create();
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
        }
        #endregion

        [TestMethod]
        public void ShouldExecutWorklowScheduleSuccessfully()
        {
            // Arrange
            var workflow = FakeProcess.Create();
            workflow.Category = Process.eCategory.Workflow;
            workflow.PrimaryEntity = Account.LogicalName;

            _schedule.Frequency = PentaSchedule.egFrequency.Daily;
            _schedule.ScheduleType = PentaSchedule.egScheduleType.Workflow;
            _schedule.Workflow = workflow.ToEntityReference();

            _knownEntities.Add(workflow);
            _knownEntities.AddRange(new List<Entity> { FakeAccount.Create(), FakeAccount.Create(), FakeAccount.Create() });

            // Act
            var fakeContext = FakeContext.ExecuteCodeActivity<RunSchedule>(_scheduleRun, _knownEntities, null, new Dictionary<string, object> { { "WebhookId", new EntityReference() } });

            // Assert
            Assert.AreEqual(3, fakeContext.CreateQuery<SystemJob>().Count(s => s.Message == "ExecuteWorkflow"));
        }
    }
}
