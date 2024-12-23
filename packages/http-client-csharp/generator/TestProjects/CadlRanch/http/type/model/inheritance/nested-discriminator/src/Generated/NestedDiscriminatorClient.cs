// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;
using _Type.Model.Inheritance.NestedDiscriminator.Models;

namespace _Type.Model.Inheritance.NestedDiscriminator
{
    public partial class NestedDiscriminatorClient
    {
        public NestedDiscriminatorClient() : this(new Uri("http://localhost:3000"), new NestedDiscriminatorClientOptions()) => throw null;

        public NestedDiscriminatorClient(Uri endpoint, NestedDiscriminatorClientOptions options) => throw null;

        public ClientPipeline Pipeline => throw null;

        public virtual ClientResult GetModel(RequestOptions options) => throw null;

        public virtual Task<ClientResult> GetModelAsync(RequestOptions options) => throw null;

        public virtual ClientResult<Fish> GetModel() => throw null;

        public virtual Task<ClientResult<Fish>> GetModelAsync() => throw null;

        public virtual ClientResult PutModel(BinaryContent content, RequestOptions options = null) => throw null;

        public virtual Task<ClientResult> PutModelAsync(BinaryContent content, RequestOptions options = null) => throw null;

        public virtual ClientResult PutModel(Fish input) => throw null;

        public virtual Task<ClientResult> PutModelAsync(Fish input) => throw null;

        public virtual ClientResult GetRecursiveModel(RequestOptions options) => throw null;

        public virtual Task<ClientResult> GetRecursiveModelAsync(RequestOptions options) => throw null;

        public virtual ClientResult<Fish> GetRecursiveModel() => throw null;

        public virtual Task<ClientResult<Fish>> GetRecursiveModelAsync() => throw null;

        public virtual ClientResult PutRecursiveModel(BinaryContent content, RequestOptions options = null) => throw null;

        public virtual Task<ClientResult> PutRecursiveModelAsync(BinaryContent content, RequestOptions options = null) => throw null;

        public virtual ClientResult PutRecursiveModel(Fish input) => throw null;

        public virtual Task<ClientResult> PutRecursiveModelAsync(Fish input) => throw null;

        public virtual ClientResult GetMissingDiscriminator(RequestOptions options) => throw null;

        public virtual Task<ClientResult> GetMissingDiscriminatorAsync(RequestOptions options) => throw null;

        public virtual ClientResult<Fish> GetMissingDiscriminator() => throw null;

        public virtual Task<ClientResult<Fish>> GetMissingDiscriminatorAsync() => throw null;

        public virtual ClientResult GetWrongDiscriminator(RequestOptions options) => throw null;

        public virtual Task<ClientResult> GetWrongDiscriminatorAsync(RequestOptions options) => throw null;

        public virtual ClientResult<Fish> GetWrongDiscriminator() => throw null;

        public virtual Task<ClientResult<Fish>> GetWrongDiscriminatorAsync() => throw null;
    }
}
