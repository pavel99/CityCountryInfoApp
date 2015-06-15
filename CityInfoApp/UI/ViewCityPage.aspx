<%@ Page Title="" Language="C#" MasterPageFile="~/UI/CityInfoMaster.Master" AutoEventWireup="true" CodeBehind="ViewCityPage.aspx.cs" Inherits="CityInfoApp.UI.ViewCityPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/ViewCity.css" rel="stylesheet" />
    <div class="viewCityContainer">
        <h1>View City Information</h1>
        <fieldset>
            <legend>Search Criteria</legend>
            <asp:RadioButton ID="cityRadioButton" runat="server" GroupName="searchRadioButtonGroup" />
            <asp:TextBox ID="cityTextBox" runat="server"></asp:TextBox><br/><br/>

            <asp:RadioButton ID="countryRadioButton" runat="server" GroupName="searchRadioButtonGroup" />

            <asp:DropDownList ID="countryDropDownList" runat="server"></asp:DropDownList>&nbsp;
             
            <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
            

            
        </fieldset>
        <asp:GridView CssClass="viewCityGridView" ID="viewCityGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
        <%--<asp:Label ID="test" runat="server"></asp:Label>--%>
    
    </div>
</asp:Content>
