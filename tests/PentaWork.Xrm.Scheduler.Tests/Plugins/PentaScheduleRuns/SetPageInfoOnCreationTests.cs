using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using PentaWork.Xrm.Scheduler.Plugins;
using PentaWork.Xrm.Scheduler.Plugins.PentaScheduleRuns;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.Scheduler.Tests.Fake;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Tests.Plugins.PentaScheduleRuns
{
    [TestClass]
    public class SetPageInfoOnCreationTests
    {
        [TestMethod]
        public void ShouldSetPageInfosSuccessfully()
        {
            // Arrange
            var schedule = FakePentaSchedule.Create();
            schedule.ScheduleType = PentaSchedule.egScheduleType.Action;
            schedule.FetchXML = "<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\" distinct=\"false\" count=\"5\">\r\n" +
                "<entity name=\"account\">\r\n<attribute name=\"name\"/>\r\n<attribute name=\"primarycontactid\"/>\r\n" +
                "<attribute name=\"telephone1\"/>\r\n<order attribute=\"name\" descending=\"false\"/>\r\n</entity>\r\n</fetch>";

            var scheduleRun = FakePentaScheduleRun.Create();
            scheduleRun.PentaSchedule = schedule.ToEntityReference();

            // Act
            FakeContext.ExecutePlugin<PluginController, SetPageInfoOnCreation>(
                MessageName.Create,
                Stage.PreOperation,
                PluginMode.Synchronous,
                scheduleRun, null, new List<Entity> { schedule });

            // Assert
            Assert.AreEqual(5, scheduleRun.PageSize);
            Assert.AreEqual(1, scheduleRun.CurrentPage);
            Assert.AreEqual(1, scheduleRun.TotalPages);
        }

        [TestMethod]
        public void ShouldSetPageInfosWithEntitiesSuccessfully()
        {
            // Arrange
            var account = FakeAccount.Create();

            var schedule = FakePentaSchedule.Create();
            schedule.ScheduleType = PentaSchedule.egScheduleType.Action;
            schedule.FetchXML = "<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\" distinct=\"false\" count=\"5\">\r\n" +
                "<entity name=\"account\">\r\n<attribute name=\"name\"/>\r\n<attribute name=\"primarycontactid\"/>\r\n" +
                "<attribute name=\"telephone1\"/>\r\n<order attribute=\"name\" descending=\"false\"/>\r\n</entity>\r\n</fetch>";

            var scheduleRun = FakePentaScheduleRun.Create();
            scheduleRun.PentaSchedule = schedule.ToEntityReference();

            // Act
            FakeContext.ExecutePlugin<PluginController, SetPageInfoOnCreation>(
                MessageName.Create,
                Stage.PreOperation,
                PluginMode.Synchronous,
                scheduleRun, null, new List<Entity> { schedule, account });

            // Assert
            Assert.AreEqual(5, scheduleRun.PageSize);
            Assert.AreEqual(1, scheduleRun.CurrentPage);
            Assert.AreEqual(1, scheduleRun.TotalPages);
        }

        [TestMethod]
        public void ShouldSetPageInfosForGlobalActionSuccessfully()
        {
            // Arrange
            var schedule = FakePentaSchedule.Create();
            schedule.ScheduleType = PentaSchedule.egScheduleType.GlobalAction;

            var scheduleRun = FakePentaScheduleRun.Create();
            scheduleRun.PentaSchedule = schedule.ToEntityReference();

            // Act
            FakeContext.ExecutePlugin<PluginController, SetPageInfoOnCreation>(
                MessageName.Create,
                Stage.PreOperation,
                PluginMode.Synchronous,
                scheduleRun, null, new List<Entity> { schedule });

            // Assert
            Assert.AreEqual(0, scheduleRun.PageSize);
            Assert.AreEqual(0, scheduleRun.CurrentPage);
            Assert.AreEqual(0, scheduleRun.TotalPages);
        }
    }
}
