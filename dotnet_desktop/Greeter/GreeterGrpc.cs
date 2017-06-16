// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Greeter/protos/greeter.proto
// Original file comments:
// Copyright 2017, Google Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Com.Example.Grpc {
  public static class GreetingService
  {
    static readonly string __ServiceName = "com.example.grpc.GreetingService";

    static readonly Marshaller<global::Com.Example.Grpc.HelloRequest> __Marshaller_HelloRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.HelloRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Com.Example.Grpc.HelloResponse> __Marshaller_HelloResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.Example.Grpc.HelloResponse.Parser.ParseFrom);

    static readonly Method<global::Com.Example.Grpc.HelloRequest, global::Com.Example.Grpc.HelloResponse> __Method_greeting = new Method<global::Com.Example.Grpc.HelloRequest, global::Com.Example.Grpc.HelloResponse>(
        MethodType.Unary,
        __ServiceName,
        "greeting",
        __Marshaller_HelloRequest,
        __Marshaller_HelloResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.Example.Grpc.GreeterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GreetingService</summary>
    public abstract class GreetingServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Com.Example.Grpc.HelloResponse> greeting(global::Com.Example.Grpc.HelloRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GreetingService</summary>
    public class GreetingServiceClient : ClientBase<GreetingServiceClient>
    {
      /// <summary>Creates a new client for GreetingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreetingServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GreetingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreetingServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreetingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreetingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Com.Example.Grpc.HelloResponse greeting(global::Com.Example.Grpc.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return greeting(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.Example.Grpc.HelloResponse greeting(global::Com.Example.Grpc.HelloRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_greeting, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Com.Example.Grpc.HelloResponse> greetingAsync(global::Com.Example.Grpc.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return greetingAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Com.Example.Grpc.HelloResponse> greetingAsync(global::Com.Example.Grpc.HelloRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_greeting, null, options, request);
      }
      protected override GreetingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreetingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(GreetingServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_greeting, serviceImpl.greeting).Build();
    }

  }
}
#endregion