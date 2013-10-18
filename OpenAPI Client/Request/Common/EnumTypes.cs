using System.ComponentModel;

namespace Bol.OpenAPI.Request.Common
{
    public class EnumTypes
    {
        public enum SortingMethod
        {
            [DescriptionAttribute("rankasc")]
            RANK_ASC,
            [DescriptionAttribute("rankdesc")]
            RANK_DESC,
            [DescriptionAttribute("priceasc")]
            PRICE_ASC,
            [DescriptionAttribute("pricedesc")]
            PRICE_DESC,
            [DescriptionAttribute("titleasc")]
            TITLE_ASC,
            [DescriptionAttribute("titledesc")]
            TITLE_DESC,
            [DescriptionAttribute("dateasc")]
            DATE_ASC,
            [DescriptionAttribute("datedesc")]
            DATE_DESC,
            [DescriptionAttribute("ratingasc")]
            RATING_ASC,
            [DescriptionAttribute("ratingdesc")]
            RATING_DESC
        }

        public enum DataOutputType
        {
            [DescriptionAttribute("products")]
            PRODUCTS,
            [DescriptionAttribute("categories")]
            CATEGORIES,
            [DescriptionAttribute("refinements")]
            REFINEMENTS
        }

        public enum OfferType
        {
            [DescriptionAttribute("cheapest")]
            CHEAPEST,
            [DescriptionAttribute("secondhand")]
            SECOND_HAND,
            [DescriptionAttribute("plazanew")]
            PLAZA_NEW,
            [DescriptionAttribute("bolcom")]
            BOL_COM,
            [DescriptionAttribute("all")]
            ALL
        }

        public enum ListType
        {
            [DescriptionAttribute("toplist_default")]
            DEFAULT,
            [DescriptionAttribute("toplist_overall")]
            OVERALL,
            [DescriptionAttribute("toplist_last_week")]
            LAST_WEEK,
            [DescriptionAttribute("toplist_last_two_months")]
            LAST_TWO_MONTHS,
            [DescriptionAttribute("new")]
            NEW,
            [DescriptionAttribute("preorder")]
            PREORDER
        }

        public enum FieldType
        {
            [DescriptionAttribute("author")]
            AUTHOR,
            [DescriptionAttribute("artist")]
            ARTIST,
            [DescriptionAttribute("title")]
            TITLE,
            [DescriptionAttribute("brand")]
            BRAND,
            [DescriptionAttribute("songtitle")]
            SONG_TITLE,
            [DescriptionAttribute("actor")]
            ACTOR,
            [DescriptionAttribute("director")]
            DIRECTOR
        }

        public enum DataSetType
        {
            [DescriptionAttribute("productfamily")]
            PRODUCT_FAMILY,
            [DescriptionAttribute("accessories")]
            ACCESSORIES
        }
    }
}
