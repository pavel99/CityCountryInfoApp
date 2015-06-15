<%@ Page Title="" Language="C#" MasterPageFile="~/UI/CityInfoMaster.Master" AutoEventWireup="true" CodeBehind="ViewCountryPage.aspx.cs" Inherits="CityInfoApp.UI.ViewCountryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/ViewCountry.css" rel="stylesheet" />
    <div class="viewCountryContainer">
        <h1>View Country Information</h1>
        <fieldset>
            <legend>Search Criteria</legend>
            <asp:Label runat="server">Country Name:</asp:Label>
            <asp:TextBox ID="searchCountryTextBox" runat="server"></asp:TextBox>&nbsp;
            <asp:Button  ID="searchCountryButton" Text="Search" runat="server" OnClick="searchCountryButton_Click"/>
        </fieldset>
        <br/><br/><br/>
        <asp:GridView CssClass="viewCountryGridView" ID="countryGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    
    </div>
</asp:Content>
