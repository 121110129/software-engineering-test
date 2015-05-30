<%@ Control Language="C#" AutoEventWireup="true" CodeFile="weatherWidget.ascx.cs" Inherits="Web_weatherWidget" %>
<style>
    .weather-font {
        font-family:'Microsoft YaHei';
        font-size:12px;
    }
    .left-align {
        text-align:left;
    }
    .right-align {
        text-align:right;
    }
</style>

<table runat="server" id="weatherTb">
    <thead>
        <tr>
            <td colspan="2" class="weather-font" style="font-size:16px;" id="city" runat="server">
                北京市
            </td>
        </tr>
    </thead>
    <tr>
        <td class="weather-font left-align">
            <span>天气状况：</span>
        </td>
        <td class="weather-font right-align">
            <span id="weather" runat="server">68%</span>
        </td>
    </tr>
    <tr>
        <td class="weather-font left-align">
            <span>风向/风力：</span>
        </td>
        <td class="weather-font right-align">
            <span id="wind" runat="server">西风 5级</span>
        </td>
    </tr>
    <tr>
        <td class="weather-font left-align">
            <span style="vertical-align:middle">温度/天气：</span>
        </td>
        <td class="weather-font right-align">
            <span style="vertical-align:baseline">
                <i runat="server" id="temperature" style="font-style:normal">-4~-1℃</i>
                <span id="weather_pic" style="background-image:url(../images/weather/28.gif);width:20px;height:20px;display:inline-block;vertical-align:bottom" runat="server"></span>
            </span>
        </td>
    </tr>
</table>