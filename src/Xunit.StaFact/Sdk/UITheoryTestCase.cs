﻿// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the Ms-PL license. See LICENSE.txt file in the project root for full license information.

#if !NET45

namespace Xunit.Sdk
{
    using System.Threading;
    using System.Threading.Tasks;
    using Abstractions;

    public class UITheoryTestCase : XunitTheoryTestCase
    {
        public UITheoryTestCase(IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, TestMethodDisplayOptions defaultMethodDisplayOptions, ITestMethod testMethod)
            : base(diagnosticMessageSink, defaultMethodDisplay, defaultMethodDisplayOptions, testMethod)
        {
        }

        public override Task<RunSummary> RunAsync(IMessageSink diagnosticMessageSink, IMessageBus messageBus, object[] constructorArguments, ExceptionAggregator aggregator, CancellationTokenSource cancellationTokenSource)
            => new UITheoryTestCaseRunner(this, this.DisplayName, this.SkipReason, constructorArguments, diagnosticMessageSink, messageBus, aggregator, cancellationTokenSource).RunAsync();
    }
}

#endif
