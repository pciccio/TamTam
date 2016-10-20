using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TamTam.Utils
{
    public static class Url
    {
        public static string BuildUrlParameters(object instance, bool collectByAttibute = false)
        {
            var collectedProperties = CollectFilledProperties(instance, collectByAttibute);
            var sb = new StringBuilder();
            foreach (var collectedPropertie in collectedProperties)
            {
                sb.AppendFormat("{0}={1}", collectedPropertie.Key, collectedPropertie.Value);
                if (collectedPropertie.Key != collectedProperties.LastOrDefault().Key)
                    sb.Append("&");
            }
            return sb.ToString();
        }

        public static Dictionary<string, object> CollectFilledProperties(object instance, bool collectByAttibute = false)
        {
            var filledProperties = new Dictionary<string, object>();

            var properties = instance.GetType().GetProperties();
            foreach (var property in properties)
            {
                var data = property.GetValue(instance, null);

                if (data == null)
                {
                    // Nullable fields without a value i.e. (still null) are ignored.
                    continue;
                }
                
                if (property.PropertyType.BaseType == typeof(Enum))
                {
                    var enumData = data as Enum;
                    var description = enumData.Description();
                    if (!String.IsNullOrWhiteSpace(description))
                        data = description;
                }

                if (collectByAttibute)
                {
                    if (property.GetCustomAttributes(true).Length > 0)
                    {
                        var jsonPropertyAttribute = property.GetCustomAttributes(true)[0] as JsonPropertyAttribute;
                        if (jsonPropertyAttribute != null)
                        {
                            filledProperties[jsonPropertyAttribute.PropertyName] = data;
                        }
                    }
                }
                else
                    filledProperties[property.Name] = data;
            }

            return filledProperties;
        }

    }
}
