using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using PentaWork.Xrm.Scheduler.Plugins;
using PentaWork.Xrm.Scheduler.Plugins.PentaSchedules;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.Scheduler.Tests.Fake;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Tests.Plugins.PentaSchedules
{
    [TestClass]
    public class UpdateRunOnSaveTests
    {
        [TestMethod]
        public void ShouldCreateRunOnPentaScheduleCreationSuccessfully()
        {
            // Arrange
            var schedule = FakePentaSchedule.Create();
            schedule.StatusReason = PentaSchedule.eStatusReason.Active_Active;
            schedule.StartDateTime = DateTime.Now.AddDays(1);

            // Act
            var fakeContext = FakeContext.ExecutePlugin<PluginController>(
                typeof(UpdateRunOnSave),
                MessageName.Create,
                Stage.PostOperation,
                PluginMode.Synchronous,
                schedule, null, new List<Entity> { schedule });
            schedule = fakeContext.CreateQuery<PentaSchedule>().Single(p => p.Id == schedule.Id);

            // Assert
            Assert.AreEqual(1, fakeContext.CreateQuery<PentaScheduleRun>().Count());
            Assert.IsNotNull(schedule.NextRun);
        }

        [TestMethod]
        public void ShouldDeleteRunOnPentaScheduleDraftSuccessfully()
        {
            // Arrange
            var scheduleRun = FakePentaScheduleRun.Create();
            scheduleRun.Status = PentaScheduleRun.eStatus.Active;

            var schedule = FakePentaSchedule.Create();
            schedule.StatusReason = PentaSchedule.eStatusReason.Draft_Active;
            schedule.StartDateTime = DateTime.Now.AddDays(1);
            schedule.NextRun = scheduleRun.ToEntityReference();

            var preSchedule = FakePentaSchedule.Create();
            preSchedule.Status = PentaSchedule.eStatus.Inactive;

            scheduleRun.PentaSchedule = schedule.ToEntityReference();

            // Act
            var fakeContext = FakeContext.ExecutePlugin<PluginController>(
                typeof(UpdateRunOnSave),
                MessageName.Update,
                Stage.PostOperation,
                PluginMode.Synchronous,
                schedule, preSchedule, new List<Entity> { schedule, scheduleRun });
            schedule = fakeContext.CreateQuery<PentaSchedule>().Single(p => p.Id == schedule.Id);

            // Assert
            Assert.AreEqual(0, fakeContext.CreateQuery<PentaScheduleRun>().Count());
            Assert.IsNull(schedule.NextRun);
        }

        [TestMethod]
        public void ShouldDeleteRunOnPentaScheduleDeactivationSuccessfully()
        {
            // Arrange
            var scheduleRun = FakePentaScheduleRun.Create();
            scheduleRun.Status = PentaScheduleRun.eStatus.Active;

            var schedule = FakePentaSchedule.Create();
            schedule.StatusReason = PentaSchedule.eStatusReason.Inactive_Inactive;
            schedule.StartDateTime = DateTime.Now.AddDays(1);
            schedule.NextRun = scheduleRun.ToEntityReference();

            var preSchedule = FakePentaSchedule.Create();
            preSchedule.Status = PentaSchedule.eStatus.Inactive;

            scheduleRun.PentaSchedule = schedule.ToEntityReference();

            // Act
            var fakeContext = FakeContext.ExecutePlugin<PluginController>(
                typeof(UpdateRunOnSave),
                MessageName.Update,
                Stage.PostOperation,
                PluginMode.Synchronous,
                schedule, preSchedule, new List<Entity> { schedule, scheduleRun });
            schedule = fakeContext.CreateQuery<PentaSchedule>().Single(p => p.Id == schedule.Id);

            // Assert
            Assert.AreEqual(0, fakeContext.CreateQuery<PentaScheduleRun>().Count());
            Assert.IsNull(schedule.NextRun);
        }
    }
}
