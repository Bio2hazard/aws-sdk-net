/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations;
using Amazon.ApplicationAutoScaling.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ApplicationAutoScaling
{
    /// <summary>
    /// Implementation for accessing ApplicationAutoScaling
    ///
    /// With Application Auto Scaling, you can configure automatic scaling for your scalable
    /// resources. You can use Application Auto Scaling to accomplish the following tasks:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Define scaling policies to automatically scale your AWS or custom resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale your resources in response to CloudWatch alarms
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Schedule one-time or recurring scaling actions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View the history of your scaling events
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Application Auto Scaling can scale the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon ECS services. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-auto-scaling.html">Service
    /// Auto Scaling</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EC2 Spot fleets. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/fleet-auto-scaling.html">Automatic
    /// Scaling for Spot Fleet</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EMR clusters. For more information, see <a href="https://docs.aws.amazon.com/ElasticMapReduce/latest/ManagementGuide/emr-automatic-scaling.html">Using
    /// Automatic Scaling in Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AppStream 2.0 fleets. For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/autoscaling.html">Fleet
    /// Auto Scaling for Amazon AppStream 2.0</a> in the <i>Amazon AppStream 2.0 Developer
    /// Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provisioned read and write capacity for Amazon DynamoDB tables and global secondary
    /// indexes. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/AutoScaling.html">Managing
    /// Throughput Capacity Automatically with DynamoDB Auto Scaling</a> in the <i>Amazon
    /// DynamoDB Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Aurora Replicas. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Integrating.AutoScaling.html">Using
    /// Amazon Aurora Auto Scaling with Aurora Replicas</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SageMaker endpoint variants. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/endpoint-auto-scaling.html">Automatically
    /// Scaling Amazon SageMaker Models</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom resources provided by your own applications or services. More information is
    /// available in our <a href="https://github.com/aws/aws-auto-scaling-custom-resource">GitHub
    /// repository</a>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To learn more about Application Auto Scaling, including information about granting
    /// IAM users required permissions for Application Auto Scaling actions, see the <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/what-is-application-auto-scaling.html">Application
    /// Auto Scaling User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonApplicationAutoScalingClient : AmazonServiceClient, IAmazonApplicationAutoScaling
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationAutoScalingMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonApplicationAutoScalingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationAutoScalingConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationAutoScalingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationAutoScalingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonApplicationAutoScalingClient Configuration Object</param>
        public AmazonApplicationAutoScalingClient(AmazonApplicationAutoScalingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationAutoScalingClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationAutoScalingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Credentials and an
        /// AmazonApplicationAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationAutoScalingClient Configuration Object</param>
        public AmazonApplicationAutoScalingClient(AWSCredentials credentials, AmazonApplicationAutoScalingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationAutoScalingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationAutoScalingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationAutoScalingClient Configuration Object</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationAutoScalingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationAutoScalingClient Configuration Object</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  DeleteScalingPolicy

        internal virtual DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public virtual Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScheduledAction

        internal virtual DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduledActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterScalableTarget

        internal virtual DeregisterScalableTargetResponse DeregisterScalableTarget(DeregisterScalableTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterScalableTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterScalableTargetResponseUnmarshaller.Instance;

            return Invoke<DeregisterScalableTargetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterScalableTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeregisterScalableTarget">REST API Reference for DeregisterScalableTarget Operation</seealso>
        public virtual Task<DeregisterScalableTargetResponse> DeregisterScalableTargetAsync(DeregisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterScalableTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterScalableTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterScalableTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalableTargets

        internal virtual DescribeScalableTargetsResponse DescribeScalableTargets(DescribeScalableTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalableTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalableTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeScalableTargetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalableTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalableTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalableTargets">REST API Reference for DescribeScalableTargets Operation</seealso>
        public virtual Task<DescribeScalableTargetsResponse> DescribeScalableTargetsAsync(DescribeScalableTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalableTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalableTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalableTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingActivities

        internal virtual DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingActivitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingActivitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingPolicies

        internal virtual DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        public virtual Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledActions

        internal virtual DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledActionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy

        internal virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutScheduledAction

        internal virtual PutScheduledActionResponse PutScheduledAction(PutScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledActionResponseUnmarshaller.Instance;

            return Invoke<PutScheduledActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScheduledAction">REST API Reference for PutScheduledAction Operation</seealso>
        public virtual Task<PutScheduledActionResponse> PutScheduledActionAsync(PutScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<PutScheduledActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterScalableTarget

        internal virtual RegisterScalableTargetResponse RegisterScalableTarget(RegisterScalableTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterScalableTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterScalableTargetResponseUnmarshaller.Instance;

            return Invoke<RegisterScalableTargetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterScalableTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/RegisterScalableTarget">REST API Reference for RegisterScalableTarget Operation</seealso>
        public virtual Task<RegisterScalableTargetResponse> RegisterScalableTargetAsync(RegisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterScalableTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterScalableTargetResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterScalableTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}