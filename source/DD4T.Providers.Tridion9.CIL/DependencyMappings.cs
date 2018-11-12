using DD4T.Core.Contracts.DependencyInjection;
using System;
using System.Collections.Generic;
using DD4T.ContentModel.Contracts.Providers;

namespace DD4T.Providers.Tridion9.CIL
{
	public class DependencyMappings : IDependencyMapper
	{
		private IDictionary<Type, Type> Mappings()
		{
			var mappings = new Dictionary<Type, Type>
			{
				{ typeof(IProvider), typeof(BaseProvider) },
				{ typeof(IPageProvider), typeof(TridionPageProvider) },
				{ typeof(IProvidersCommonServices), typeof(ProvidersCommonServices) },
				{ typeof(IComponentPresentationProvider), typeof(TridionComponentPresentationProvider) },
				{ typeof(IBinaryProvider), typeof(TridionBinaryProvider) },
				{ typeof(ILinkProvider), typeof(TridionLinkProvider) },
				{ typeof(ITaxonomyProvider), typeof(TridionTaxonomyProvider) }
			};

			return mappings;
		}

		/// <inheritdoc />
		public IDictionary<Type, Type> SingleInstanceMappings { get; set; }

		/// <inheritdoc />
		public IDictionary<Type, Type> PerHttpRequestMappings { get; }

		/// <inheritdoc />
		public IDictionary<Type, Type> PerLifeTimeMappings => Mappings();

		/// <inheritdoc />
		public IDictionary<Type, Type> PerDependencyMappings { get; }
	}
}
