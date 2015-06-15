<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityInfo.aspx.cs" Inherits="CityInfoApp.UI.CityInfo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/meyer.css" rel="stylesheet" />
    <link href="../Content/CityInfo.css" rel="stylesheet" />
    
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="Wrapper">
        <header>
           <%-- <div class="logo">--%>
                <img src="../Content/city.jpg" width="960px" height="100px" />
                
           <%-- </div>--%>
            <%--<div class="banner">
                 <h1> City Information </h1>
                
                
            </div>--%>
        </header>
        <nav>
            <ul>
                <li><a href="#">Home</a></li>
                <li><a href="CountryEntry.aspx">Country Entry</a></li>
                <li><a href="CityEntry.aspx">City Entry</a></li>
                <li><a href="ViewCity.aspx">View City</a></li>
                <li><a href="ViewCountry.aspx">View Country</a></li>
            </ul>
        </nav>
        <div class="container">
            
        </div>
        <footer>
            <p>Design & Developed By RGB</p>
            
        </footer>
        
    
    </div>
    </form>
</body>
</html>
