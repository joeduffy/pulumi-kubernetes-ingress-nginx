// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.KubernetesIngressNginx.Inputs
{

    public sealed class ContollerAdmissionWebhooksArgs : global::Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("certificate")]
        public Input<string>? Certificate { get; set; }

        [Input("createSecretJob")]
        public Input<Inputs.ControllerAdmissionWebhooksCreateSecretJobArgs>? CreateSecretJob { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Use an existing PSP instead of creating one.
        /// </summary>
        [Input("existingPsp")]
        public Input<string>? ExistingPsp { get; set; }

        [Input("failurePolicy")]
        public Input<string>? FailurePolicy { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("namespaceSelector")]
        private InputMap<ImmutableDictionary<string, string>>? _namespaceSelector;
        public InputMap<ImmutableDictionary<string, string>> NamespaceSelector
        {
            get => _namespaceSelector ?? (_namespaceSelector = new InputMap<ImmutableDictionary<string, string>>());
            set => _namespaceSelector = value;
        }

        [Input("objectSelector")]
        private InputMap<ImmutableDictionary<string, string>>? _objectSelector;
        public InputMap<ImmutableDictionary<string, string>> ObjectSelector
        {
            get => _objectSelector ?? (_objectSelector = new InputMap<ImmutableDictionary<string, string>>());
            set => _objectSelector = value;
        }

        [Input("patch")]
        public Input<Inputs.ControllerAdmissionWebhooksPatchArgs>? Patch { get; set; }

        [Input("patchWebhookJob")]
        public Input<Inputs.ControllerAdmissionWebhooksPatchWebhbookJobArgs>? PatchWebhookJob { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("service")]
        public Input<Inputs.ControllerAdmissionWebhooksServiceArgs>? Service { get; set; }

        [Input("timeoutSeconds")]
        public Input<int>? TimeoutSeconds { get; set; }

        public ContollerAdmissionWebhooksArgs()
        {
        }
        public static new ContollerAdmissionWebhooksArgs Empty => new ContollerAdmissionWebhooksArgs();
    }
}
