﻿using System;
using System.ComponentModel;

namespace PentaWork.Xrm.Scheduler.Plugins
{
    public abstract class CrmEventAttribute : Attribute
    {
        public Stage Stage { get; protected set; }
        public MessageName MessageName { get; protected set; }
        public PluginMode PluginMode { get; protected set; }
        public int ExecutionDepth { get; protected set; }
        public string MethodName { get; protected set; }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class EventAttribute : CrmEventAttribute
    {
        public EventAttribute(
            Stage stage, MessageName messageName, PluginMode pluginMode,
            int executionDepth, string methodName, params string[] eventFieldNames)
        {
            Stage = stage;
            MessageName = messageName;
            PluginMode = pluginMode;
            ExecutionDepth = executionDepth;
            MethodName = methodName;
            EventFieldNames = eventFieldNames;
        }

        public string[] EventFieldNames { get; private set; }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class RelateEventAttribute : CrmEventAttribute
    {
        public RelateEventAttribute(
            string schemaName,
            Stage stage, MessageName messageName, PluginMode pluginMode,
            int executionDepth, string methodName)
        {
            Stage = stage;
            MessageName = messageName;
            PluginMode = pluginMode;
            ExecutionDepth = executionDepth;
            MethodName = methodName;
            SchemaName = schemaName;
        }

        public string SchemaName { get; private set; }
    }

    public enum PluginMode
    {
        Synchronous = 0,
        Asynchronous = 1
    }

    public enum Stage
    {
        PreValidation = 10,
        PreOperation = 20,
        PostOperation = 40
    }

    public enum MessageName
    {
        [Description("Associate")]
        Associate,
        [Description("Assign")]
        Assign,
        [Description("Create")]
        Create,
        [Description("Update")]
        Update,
        [Description("Delete")]
        Delete,
        [Description("Disassociate")]
        Disassociate,
        [Description("GrantAccess")]
        GrantAccess,
        [Description("ModifyAccess")]
        ModifyAccess,
        [Description("Retrieve")]
        Retrieve,
        [Description("RetrieveMultiple")]
        RetrieveMultiple,
        [Description("RetrievePrincipalAccess")]
        RetrievePrincipalAccess,
        [Description("RetrieveSharedPrincipalsAndAccess")]
        RetrieveSharedPrincipalsAndAccess,
        [Description("RevokeAccess")]
        RevokeAccess,
        [Description("SetState")]
        SetState,
        [Description("SetStateDynamicEntity")]
        SetStateDynamicEntity,
        [Description("Win")]
        Win
    }
}
