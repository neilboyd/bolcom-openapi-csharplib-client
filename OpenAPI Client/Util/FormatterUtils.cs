using Bol.OpenAPI.Request.Common;
using System.Text;

namespace Bol.OpenAPI.Util
{
    class FormatterUtils
    {
        public static string CombineCategoryAndRefinementIds(string categoryId, string[] refinementIds)
        {
            StringBuilder sb = new StringBuilder();
            if (categoryId != null)
            {
                sb.Append(categoryId);
            }
            if (refinementIds != null)
            {
                sb.Append(',');

                for (int i = 0; i < refinementIds.Length; i++)
                {
                    sb.Append(refinementIds[i]);

                    if (i + 1 < refinementIds.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }

        public static string FormatIds(string[] ids)
        {
            StringBuilder sb = new StringBuilder();
            if (ids != null)
            {
                for (int i = 0; i < ids.Length; i++)
                {
                    sb.Append(ids[i]);

                    if (i + 1 < ids.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }

        public static string FormatDataOutput(EnumTypes.DataOutputType[] dataOutputs)
        {
            StringBuilder sb = new StringBuilder();
            if (dataOutputs != null)
            {
                for (int i = 0; i < dataOutputs.Length; i++)
                {
                    sb.Append(EnumUtils.StringValueOf(dataOutputs[i]));

                    if (i + 1 < dataOutputs.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }

        public static string FormatOffer(EnumTypes.OfferType[] offers)
        {
            StringBuilder sb = new StringBuilder();
            if (offers != null)
            {

                for (int i = 0; i < offers.Length; i++)
                {
                    sb.Append(EnumUtils.StringValueOf(offers[i]));

                    if (i + 1 < offers.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }

        public static string FormatDataSet(EnumTypes.DataSetType[] dataSet)
        {
            StringBuilder sb = new StringBuilder();
            if (dataSet != null)
            {

                for (int i = 0; i < dataSet.Length; i++)
                {
                    sb.Append(EnumUtils.StringValueOf(dataSet[i]));

                    if (i + 1 < dataSet.Length)
                    {
                        sb.Append(',');
                    }
                }
            }

            return sb.ToString();
        }
    }
}
