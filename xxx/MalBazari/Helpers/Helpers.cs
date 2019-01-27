using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MalBazari.Helpers
{
    public static class Helpers
    {
        public static IHtmlContent HtmlInput()
        {
            HtmlString htmlLabel = new HtmlString("<input style=\"color:yellow;font-size:24px\"></input>");
            return htmlLabel;
        }
        public static IHtmlContent HtmlButton ()
        {
            HtmlString htmlButton = new HtmlString("<button type=\"button\" class=\"btn btn - primary\">Primary</button>");
            return htmlButton;
        }

        public static IHtmlContent HtmlContent()
        {
            string sallert = "<div role=\"alert\" class=\"alert alert-success\">Deneme</div>";
            HtmlString helper = new HtmlString(sallert);
            return helper;
        }
        public static IHtmlContent HtmlShowImage(int resimref, string id, string name, string controler, string action, int height, int width, string sourge = "images/m1.jpg")
        {
            string simageshower = "<div class=\"col - md - 4 product - men mt - 5\"> " +
                                  "      <div class=\"men-pro-item simpleCart_shelfItem\"> " +
                                  "      <div class=\"men-thumb-item text-center\"> " +
                                  "      <img src = \""+ sourge +"\" alt=\"\"> " +
                                  "      <div class=\"men-cart-pro\"> " +
                                  "          <div class=\"inner-men-cart-pro\"> " +
                                  "              <a href = \"@Url.Action(" + action +", " + controler + ")\" class=\"link-product-add-cart\">Quick View</a> " +
                                  "          </div> " +
                                  "      </div> " +
                                  "  </div> " +
                                  "  <div class=\"item-info-product text-center border-top mt-4\"> " +
                                  "      <h4 class=\"pt-1\"> " +
                                  "          <a href = \"@Url.Action(" + action +", "+ controler +")\">Samsung Galaxy J7</a> " +
                                  "      </h4> " +
                                  "      <div class=\"info-product-price my-2\"> " +
                                  "          <span class=\"item_price\">$200.00</span> " +
                                  "          <del>$280.00</del> " +
                                  "      </div> " +
                                  "      <div class=\"snipcart-details top_brand_home_details item_add single-item hvr-outline-out\"> " +
                                  "          <form action = \"#\" method=\"post\"> " +
                                  "              <fieldset> " +
                                  "                  <input type = \"hidden\" name=\"cmd\" value=\"_cart\" /> " +
                                  "                  <input type = \"hidden\" name=\"add\" value=\"1\" /> " +
                                  "                  <input type = \"hidden\" name=\"business\" value=\" \" /> " +
                                  "                  <input type = \"hidden\" name=\"item_name\" value=\"Samsung Galaxy J7\" /> " +
                                  "                  <input type = \"hidden\" name=\"amount\" value=\"200.00\" /> " +
                                  "                  <input type = \"hidden\" name=\"discount_amount\" value=\"1.00\" /> " +
                                  "                  <input type = \"hidden\" name=\"currency_code\" value=\"USD\" /> " +
                                  "                  <input type = \"hidden\" name=\"return\" value=\" \" /> " +
                                  "                  <input type = \"hidden\" name=\"cancel_return\" value=\" \" /> " +
                                  "                  <input type = \"submit\" name=\"submit\" value=\"Add to cart\" class=\"button btn\" /> " +
                                  "              </fieldset> " +
                                  "          </form> " +
                                  "      </div> " +
                                  "  </div> " +
                                    "</div> " +
                                "</div>";
            HtmlString htmlImageviewer = new HtmlString(simageshower);
            return htmlImageviewer;
        }
    }
}
