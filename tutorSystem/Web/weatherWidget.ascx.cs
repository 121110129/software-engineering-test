using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_weatherWidget : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        showWeatherData();   
    }
    //正式发布版
    private void showWeatherData()
    {
        //Response.Write("<script>alert('" + ipAddress + "')</script>");
        if (Session["Weather"] == null)
        {
            String ipAddress = getIpAddress();
            //Country city
            String[] cc;
            WeatherWS.WeatherWS weatherService = new WeatherWS.WeatherWS();
            IpAddressSearchWebService.IpAddressSearchWebService ipService = new IpAddressSearchWebService.IpAddressSearchWebService();
            //测试ip
            try
            {
                cc = ipService.getCountryCityByIp(ipAddress);
                String temp = cc[1].Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0];
                temp = temp.Split(new String[] { "省" }, StringSplitOptions.RemoveEmptyEntries)[1];
                temp = temp.Split(new String[] { "市" }, StringSplitOptions.RemoveEmptyEntries)[0];
                String[] weatherTemp = weatherService.getWeather(temp, "");
                Session["Weather"] = new ArrayList(weatherTemp);
            }
            catch
            {
                weatherErrHandler();
                return;
            }
        }
        ArrayList weatherData = (ArrayList)Session["Weather"];
        city.InnerText = (String)(weatherData[0]);
        weather.InnerText = ((String)weatherData[7]).Split(new String[] { " " }, StringSplitOptions.None)[1];
        wind.InnerText = (String)weatherData[9];
        temperature.InnerText = (String)weatherData[8];
        weather_pic.Style.Add(HtmlTextWriterStyle.BackgroundImage, "url(../images/weather/" + weatherData[10] + ")");
    }
    //本地测试用
    //private void showWeatherData()
    //{
    //    //String ipAddress = getIpAddress();

    //    //Response.Write("<script>alert('" + ipAddress + "')</script>");
    //    if (Session["Weather"] == null)
    //    {
    //        WeatherWS.WeatherWS weatherService = new WeatherWS.WeatherWS();
    //        IpAddressSearchWebService.IpAddressSearchWebService ipService = new IpAddressSearchWebService.IpAddressSearchWebService();
    //        //测试ip
    //        String ipAddress = "221.2.164.6";
    //        String[] cc = ipService.getCountryCityByIp(ipAddress);
    //        String temp = cc[1].Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0];
    //        temp = temp.Split(new String[] { "省" }, StringSplitOptions.RemoveEmptyEntries)[1];
    //        temp = temp.Split(new String[] { "市" }, StringSplitOptions.RemoveEmptyEntries)[0];
    //        String[] weatherTemp = weatherService.getWeather(temp, "");
    //        Session["Weather"] = new ArrayList(weatherTemp);
    //    }
    //    ArrayList weatherData = (ArrayList)Session["Weather"];
    //    city.InnerText = (String)(weatherData[0]);
    //    weather.InnerText = ((String)weatherData[7]).Split(new String[] { " " }, StringSplitOptions.None)[1];
    //    wind.InnerText = (String)weatherData[9];
    //    temperature.InnerText = (String)weatherData[8];
    //    weather_pic.Style.Add(HtmlTextWriterStyle.BackgroundImage, "url(../images/weather/" + weatherData[10] + ")");
    //}
    private void weatherErrHandler()
    {
        city.InnerText = "北京市(定位失败)";
    }
    private String getIpAddress()
    {
        String result = String.Empty;

        result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (string.IsNullOrEmpty(result))
        {
            result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        }
        if (string.IsNullOrEmpty(result))
        {
            result = HttpContext.Current.Request.UserHostAddress;
        }
        if (string.IsNullOrEmpty(result))
        {
            return "127.0.0.1";
        }
        return result;
    }
}