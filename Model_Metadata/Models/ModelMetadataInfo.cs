using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;

namespace Model_Metadata.Models
{
	public class ModelMetadataInfo
	{
		public ModelMetadata ModelMetadata { get; private set; }
		public Expression<Func<ModelMetadata, object>>[] PropertyAccessors { get; private set; }

		public ModelMetadataInfo(Type modelType, params Expression<Func<ModelMetadata, object>>[] propertyAccessors) {
			this.ModelMetadata = new ModelMetadata(ModelMetadataProviders.Current, null, null, modelType, null);
			this.PropertyAccessors = propertyAccessors;
		}
	}

}