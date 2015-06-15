<%@ Page Title="" Language="C#" MasterPageFile="~/UI/CityInfoMaster.Master" AutoEventWireup="true" CodeBehind="CityEntryPage.aspx.cs" Inherits="CityInfoApp.UI.CityEntryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/CityEntry.css" rel="stylesheet" />
    <div class="citycontainer">
        <h1>City Information</h1><br/><br/>
        <table style="height: 215px">
            <tr>
                <td>
                    <asp:Label runat="server">City Name</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID= "cityNameTextBox" runat="server" Width="172px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server">About</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID= "aboutTextBox" runat="server" TextMode="MultiLine" Width="172px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server">No. Of Dwellers</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="dewellersTextBox" runat="server" Width="172px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server">Location</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="locationTextBox" runat="server" Width="172px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server">Weather</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="weatherTextBox" TextMode="MultiLine"  Width="172px" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server">Country</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="allCountryDropDownlist" runat="server" Height="16px" Width="171px">
                    </asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="saveButton" Text="Save" runat="server" OnClick="saveButton_Click"/>&nbsp;&nbsp;
                     <asp:Button ID="cancelButton" Text="Cancel" runat="server" OnClick="cancelButton_Click"/>
                </td>
                
            </tr>
            
        </table><br/><br/><br/>
        <asp:GridView ID="cityGridView" CssClass="cityGridViews" GridLines="None" runat="server" CellPadding="4" ForeColor="#333333" Height="136px" Width="370px">
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
