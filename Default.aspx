﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdvisorBookingServiceMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
          <form id="form1" runat="server">
        
          <div class="post" id="post-5">
            <div class="post-title">
              <center><h2><a href="#">Main Page Information</a></h2></center>
            </div>
            <div class="post-entry">
              <div class="post-entry-top">
                <div class="post-entry-bottom">
             




                    <table style="width: 100%">
                        <tr>
                            <td style="width: 137px; text-align: right" valign="middle">
                                &nbsp;</td>
                            <td style="width: 221px" valign="middle">
<<<<<<< HEAD
                                <asp:DropDownList ID="DropDownList1" runat="server" 
                                    DataSourceID="SqlDataSource1" DataTextField="Student_ID" 
                                    DataValueField="Student_ID">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                                    SelectCommand="SELECT [Student_ID] FROM [Registeration]">
                                </asp:SqlDataSource>
                            </td>
=======
                                &nbsp;</td>
>>>>>>> origin/master
                            <td valign="middle">
                                &nbsp;</td>
                        </tr>
                                  
                       
                    </table>
             




                </div>
              </div>
            </div>
          </div>
          <div class="navigation">
            <div class="navigation-previous"></div>
            <div class="navigation-next"></div>
          </div>
          <div class="clear"></div>
        
    
</form>
        
    
</asp:Content>

