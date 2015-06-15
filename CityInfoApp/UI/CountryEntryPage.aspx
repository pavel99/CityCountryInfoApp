<%@ Page Title="" Language="C#" MasterPageFile="~/UI/CityInfoMaster.Master" AutoEventWireup="true" CodeBehind="CountryEntryPage.aspx.cs" Inherits="CityInfoApp.UI.CountryEntryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/CountryEntry.css" rel="stylesheet" />
    
    <div class="container">
        <h1>Country Information</h1><br/><br/>
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" >Country Name</asp:Label><br/><br/>
                </td>
                <td>
                    <asp:TextBox ID="countryNameTextbox" runat="server" Width="222px"></asp:TextBox><br/><br/>
                </td>

                
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" >About</asp:Label><br/><br/>
                    
                </td>
                <td>
                     <asp:TextBox ID="aboutTextbox" runat="server" TextMode="MultiLine" Width="223px"></asp:TextBox><br/>
                    
                </td>
                
            </tr>
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button ID="saveButton"  Text="Save" runat="server" OnClick="saveButton_Click"/>&nbsp;&nbsp;
                    <asp:Button ID="cancelButton" Text="Cancel" runat="server" OnClick="cancelButton_Click"/>
                </td>
            </tr>
        </table><br /><br/><br/>
        <asp:GridView CssClass="countryGridviews" ID="countryGridView"  GridLines="None" runat="server" CellPadding="4" Width="398px" Height="252px" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
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
