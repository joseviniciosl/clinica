/*
               File: Appointment
        Description: Agenda de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/10/2019 15:21:40.3
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class appointment : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Agenda de Pacientes", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtAppointmentCode_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Fantastic");
      }

      public appointment( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public appointment( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_1B59( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1B59e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1B59( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1B59( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1B59e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Agenda de Pacientes"+"</legend>") ;
            wb_table3_27_1B59( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1B59e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1B59e( true) ;
         }
         else
         {
            wb_table1_2_1B59e( false) ;
         }
      }

      protected void wb_table3_27_1B59( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_33_1B59( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1B59e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Appointment.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Appointment.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1B59e( true) ;
         }
         else
         {
            wb_table3_27_1B59e( false) ;
         }
      }

      protected void wb_table4_33_1B59( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockappointmentcode_Internalname, "Cita", "", "", lblTextblockappointmentcode_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtAppointmentCode_Internalname, StringUtil.RTrim( A240AppointmentCode), StringUtil.RTrim( context.localUtil.Format( A240AppointmentCode, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtAppointmentCode_Jsonclick, 0, ClassString, StyleString, "", 1, edtAppointmentCode_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")), ((edtPacienteId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtPacienteId_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockappointmentstartdate_Internalname, "Inicia", "", "", lblTextblockappointmentstartdate_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtAppointmentStartDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtAppointmentStartDate_Internalname, context.localUtil.Format(A244AppointmentStartDate, "99/99/99 99:99"), context.localUtil.Format( A244AppointmentStartDate, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(48);\"", "", "", "", "", edtAppointmentStartDate_Jsonclick, 0, ClassString, StyleString, "", 1, edtAppointmentStartDate_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_Appointment.htm");
            GxWebStd.gx_bitmap( context, edtAppointmentStartDate_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtAppointmentStartDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Appointment.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockappointmentenddate_Internalname, "Finaliza", "", "", lblTextblockappointmentenddate_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtAppointmentEndDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtAppointmentEndDate_Internalname, context.localUtil.Format(A242AppointmentEndDate, "99/99/99 99:99"), context.localUtil.Format( A242AppointmentEndDate, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(53);\"", "", "", "", "", edtAppointmentEndDate_Jsonclick, 0, ClassString, StyleString, "", 1, edtAppointmentEndDate_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_Appointment.htm");
            GxWebStd.gx_bitmap( context, edtAppointmentEndDate_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtAppointmentEndDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Appointment.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockappointmentobs_Internalname, "Obs", "", "", lblTextblockappointmentobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243AppointmentObs", A243AppointmentObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtAppointmentObs_Internalname, StringUtil.RTrim( A243AppointmentObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", 0, 1, edtAppointmentObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_Appointment.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1B59e( true) ;
         }
         else
         {
            wb_table4_33_1B59e( false) ;
         }
      }

      protected void wb_table2_5_1B59( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"APPOINTMENTCODE"+"'), id:'"+"APPOINTMENTCODE"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"APPOINTMENTCODE"+"'), id:'"+"APPOINTMENTCODE"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Appointment.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_1B59e( true) ;
         }
         else
         {
            wb_table2_5_1B59e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111B2 */
         E111B2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A240AppointmentCode = cgiGet( edtAppointmentCode_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
               if ( ( ( context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PACIENTEID");
                  AnyError = 1 ;
                  GX_FocusControl = edtPacienteId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A67PacienteId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
               }
               else
               {
                  A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
               }
               if ( context.localUtil.VCDateTime( cgiGet( edtAppointmentStartDate_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Inicia"}), 1, "APPOINTMENTSTARTDATE");
                  AnyError = 1 ;
                  GX_FocusControl = edtAppointmentStartDate_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A244AppointmentStartDate = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A244AppointmentStartDate = context.localUtil.CToT( cgiGet( edtAppointmentStartDate_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
               }
               if ( context.localUtil.VCDateTime( cgiGet( edtAppointmentEndDate_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Finaliza"}), 1, "APPOINTMENTENDDATE");
                  AnyError = 1 ;
                  GX_FocusControl = edtAppointmentEndDate_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A242AppointmentEndDate = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A242AppointmentEndDate = context.localUtil.CToT( cgiGet( edtAppointmentEndDate_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
               }
               A243AppointmentObs = cgiGet( edtAppointmentObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243AppointmentObs", A243AppointmentObs);
               /* Read saved values. */
               Z240AppointmentCode = cgiGet( "Z240AppointmentCode") ;
               Z67PacienteId = (int)(context.localUtil.CToN( cgiGet( "Z67PacienteId"), ".", ",")) ;
               Z244AppointmentStartDate = context.localUtil.CToT( cgiGet( "Z244AppointmentStartDate"), 0) ;
               Z242AppointmentEndDate = context.localUtil.CToT( cgiGet( "Z242AppointmentEndDate"), 0) ;
               Z243AppointmentObs = cgiGet( "Z243AppointmentObs") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A240AppointmentCode = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E111B2 */
                           E111B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E121B2 */
                           E121B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: E121B2 */
            E121B2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1B59( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         imgBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_Visible), 5, 0)));
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_Visible), 5, 0)));
         imgBtn_last_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_separator_Visible), 5, 0)));
         imgBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Visible), 5, 0)));
            imgBtn_enter2_separator_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_separator_Visible), 5, 0)));
            bttBtn_enter_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
         }
         DisableAttributes1B59( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "");
            }
         }
      }

      protected void ResetCaption1B0( )
      {
      }

      protected void E111B2( )
      {
         /* Start Routine */
      }

      protected void E121B2( )
      {
         /* After Trn Routine */
      }

      protected void ZM1B59( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z67PacienteId = T001B3_A67PacienteId[0] ;
               Z244AppointmentStartDate = T001B3_A244AppointmentStartDate[0] ;
               Z242AppointmentEndDate = T001B3_A242AppointmentEndDate[0] ;
               Z243AppointmentObs = T001B3_A243AppointmentObs[0] ;
            }
            else
            {
               Z67PacienteId = A67PacienteId ;
               Z244AppointmentStartDate = A244AppointmentStartDate ;
               Z242AppointmentEndDate = A242AppointmentEndDate ;
               Z243AppointmentObs = A243AppointmentObs ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z240AppointmentCode = A240AppointmentCode ;
            Z67PacienteId = A67PacienteId ;
            Z244AppointmentStartDate = A244AppointmentStartDate ;
            Z242AppointmentEndDate = A242AppointmentEndDate ;
            Z243AppointmentObs = A243AppointmentObs ;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_enter2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
      }

      protected void Load1B59( )
      {
         /* Using cursor T001B4 */
         pr_default.execute(2, new Object[] {A240AppointmentCode});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound59 = 1 ;
            A67PacienteId = T001B4_A67PacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            A244AppointmentStartDate = T001B4_A244AppointmentStartDate[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
            A242AppointmentEndDate = T001B4_A242AppointmentEndDate[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
            A243AppointmentObs = T001B4_A243AppointmentObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243AppointmentObs", A243AppointmentObs);
            ZM1B59( -3) ;
         }
         pr_default.close(2);
         OnLoadActions1B59( ) ;
      }

      protected void OnLoadActions1B59( )
      {
      }

      protected void CheckExtendedTable1B59( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A244AppointmentStartDate) || ( A244AppointmentStartDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Inicia fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A242AppointmentEndDate) || ( A242AppointmentEndDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Finaliza fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1B59( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1B59( )
      {
         /* Using cursor T001B5 */
         pr_default.execute(3, new Object[] {A240AppointmentCode});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound59 = 1 ;
         }
         else
         {
            RcdFound59 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001B3 */
         pr_default.execute(1, new Object[] {A240AppointmentCode});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1B59( 3) ;
            RcdFound59 = 1 ;
            A240AppointmentCode = T001B3_A240AppointmentCode[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
            A67PacienteId = T001B3_A67PacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            A244AppointmentStartDate = T001B3_A244AppointmentStartDate[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
            A242AppointmentEndDate = T001B3_A242AppointmentEndDate[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
            A243AppointmentObs = T001B3_A243AppointmentObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243AppointmentObs", A243AppointmentObs);
            Z240AppointmentCode = A240AppointmentCode ;
            sMode59 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1B59( ) ;
            Gx_mode = sMode59 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound59 = 0 ;
            InitializeNonKey1B59( ) ;
            sMode59 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode59 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1B59( ) ;
         if ( RcdFound59 == 0 )
         {
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound59 = 0 ;
         /* Using cursor T001B6 */
         pr_default.execute(4, new Object[] {A240AppointmentCode});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T001B6_A240AppointmentCode[0], A240AppointmentCode) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T001B6_A240AppointmentCode[0], A240AppointmentCode) > 0 ) ) )
            {
               A240AppointmentCode = T001B6_A240AppointmentCode[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
               RcdFound59 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound59 = 0 ;
         /* Using cursor T001B7 */
         pr_default.execute(5, new Object[] {A240AppointmentCode});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T001B7_A240AppointmentCode[0], A240AppointmentCode) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T001B7_A240AppointmentCode[0], A240AppointmentCode) < 0 ) ) )
            {
               A240AppointmentCode = T001B7_A240AppointmentCode[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
               RcdFound59 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1B59( ) ;
         if ( RcdFound59 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "APPOINTMENTCODE");
               AnyError = 1 ;
               GX_FocusControl = edtAppointmentCode_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(A240AppointmentCode, Z240AppointmentCode) != 0 )
            {
               A240AppointmentCode = Z240AppointmentCode ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "APPOINTMENTCODE");
               AnyError = 1 ;
               GX_FocusControl = edtAppointmentCode_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtAppointmentCode_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update1B59( ) ;
               GX_FocusControl = edtAppointmentCode_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A240AppointmentCode, Z240AppointmentCode) != 0 )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtAppointmentCode_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1B59( ) ;
               if ( AnyError == 1 )
               {
                  GX_FocusControl = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "APPOINTMENTCODE");
                  AnyError = 1 ;
                  GX_FocusControl = edtAppointmentCode_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtAppointmentCode_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1B59( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( StringUtil.StrCmp(A240AppointmentCode, Z240AppointmentCode) != 0 )
         {
            A240AppointmentCode = Z240AppointmentCode ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "APPOINTMENTCODE");
            AnyError = 1 ;
            GX_FocusControl = edtAppointmentCode_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtAppointmentCode_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound59 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "APPOINTMENTCODE");
            AnyError = 1 ;
         }
         GX_FocusControl = edtPacienteId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1B59( ) ;
         if ( RcdFound59 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPacienteId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1B59( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound59 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPacienteId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound59 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPacienteId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1B59( ) ;
         if ( RcdFound59 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound59 != 0 )
            {
               ScanNext1B59( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPacienteId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1B59( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1B59( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001B8 */
            pr_default.execute(6, new Object[] {A240AppointmentCode});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Appointment"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( Z67PacienteId != T001B8_A67PacienteId[0] ) || ( Z244AppointmentStartDate != T001B8_A244AppointmentStartDate[0] ) || ( Z242AppointmentEndDate != T001B8_A242AppointmentEndDate[0] ) || ( StringUtil.StrCmp(Z243AppointmentObs, T001B8_A243AppointmentObs[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Appointment"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1B59( )
      {
         BeforeValidate1B59( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1B59( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1B59( 0) ;
            CheckOptimisticConcurrency1B59( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1B59( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1B59( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001B9 */
                     pr_default.execute(7, new Object[] {A240AppointmentCode, A67PacienteId, A244AppointmentStartDate, A242AppointmentEndDate, A243AppointmentObs});
                     pr_default.close(7);
                     if ( (pr_default.getStatus(7) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                           ResetCaption1B0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load1B59( ) ;
            }
            EndLevel1B59( ) ;
         }
         CloseExtendedTableCursors1B59( ) ;
      }

      protected void Update1B59( )
      {
         BeforeValidate1B59( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1B59( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1B59( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1B59( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1B59( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001B10 */
                     pr_default.execute(8, new Object[] {A67PacienteId, A244AppointmentStartDate, A242AppointmentEndDate, A243AppointmentObs, A240AppointmentCode});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Appointment"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1B59( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption1B0( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel1B59( ) ;
         }
         CloseExtendedTableCursors1B59( ) ;
      }

      protected void DeferredUpdate1B59( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1B59( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1B59( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1B59( ) ;
            AfterConfirm1B59( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1B59( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001B11 */
                  pr_default.execute(9, new Object[] {A240AppointmentCode});
                  pr_default.close(9);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound59 == 0 )
                        {
                           InitAll1B59( ) ;
                           Gx_mode = "INS" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), 0, "");
                        ResetCaption1B0( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode59 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1B59( ) ;
         Gx_mode = sMode59 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1B59( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1B59( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1B59( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("Appointment");
            if ( AnyError == 0 )
            {
               ConfirmValues1B0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("Appointment");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1B59( )
      {
         /* Using cursor T001B12 */
         pr_default.execute(10);
         RcdFound59 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound59 = 1 ;
            A240AppointmentCode = T001B12_A240AppointmentCode[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1B59( )
      {
         pr_default.readNext(10);
         RcdFound59 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound59 = 1 ;
            A240AppointmentCode = T001B12_A240AppointmentCode[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
         }
      }

      protected void ScanEnd1B59( )
      {
      }

      protected void AfterConfirm1B59( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1B59( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1B59( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1B59( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1B59( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1B59( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1B59( )
      {
         edtAppointmentCode_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAppointmentCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAppointmentCode_Enabled), 5, 0)));
         edtPacienteId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteId_Enabled), 5, 0)));
         edtAppointmentStartDate_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAppointmentStartDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAppointmentStartDate_Enabled), 5, 0)));
         edtAppointmentEndDate_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAppointmentEndDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAppointmentEndDate_Enabled), 5, 0)));
         edtAppointmentObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAppointmentObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAppointmentObs_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1B0( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?58720");
            context.AddJavascriptSource("gxfxSD.js", "?58720");
            context.AddJavascriptSource("gxtypesSD.js", "?58720");
            context.AddJavascriptSource("gxpopupSD.js", "?58720");
            context.AddJavascriptSource("gxfrmutlSD.js", "?58720");
            context.AddJavascriptSource("gxgridSD.js", "?58720");
            context.AddJavascriptSource("JavaScripTableSD.js", "?58720");
            context.AddJavascriptSource("rijndaelSD.js", "?58720");
            context.AddJavascriptSource("gxgralSD.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         context.AddJavascriptSource("calendar.js", "?58720");
         context.AddJavascriptSource("calendar-setup.js", "?58720");
         context.AddJavascriptSource("calendar-es.js", "?58720");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("appointment.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z240AppointmentCode", StringUtil.RTrim( Z240AppointmentCode));
         GxWebStd.gx_hidden_field( context, "Z67PacienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z67PacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z244AppointmentStartDate", context.localUtil.TToC( Z244AppointmentStartDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z242AppointmentEndDate", context.localUtil.TToC( Z242AppointmentEndDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z243AppointmentObs", StringUtil.RTrim( Z243AppointmentObs));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Appointment" ;
      }

      public override String GetPgmdesc( )
      {
         return "Agenda de Pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("appointment.aspx")  ;
      }

      protected void InitializeNonKey1B59( )
      {
         A67PacienteId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
         A244AppointmentStartDate = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244AppointmentStartDate", context.localUtil.TToC( A244AppointmentStartDate, 8, 5, 0, 3, "/", ":", " "));
         A242AppointmentEndDate = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242AppointmentEndDate", context.localUtil.TToC( A242AppointmentEndDate, 8, 5, 0, 3, "/", ":", " "));
         A243AppointmentObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A243AppointmentObs", A243AppointmentObs);
      }

      protected void InitAll1B59( )
      {
         A240AppointmentCode = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240AppointmentCode", A240AppointmentCode);
         InitializeNonKey1B59( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?15214131");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("appointment.js", "?15214131");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgBtn_first_Internalname = "BTN_FIRST" ;
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_Internalname = "BTN_PREVIOUS" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         imgBtn_next_Internalname = "BTN_NEXT" ;
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_last_Internalname = "BTN_LAST" ;
         imgBtn_last_separator_Internalname = "BTN_LAST_SEPARATOR" ;
         imgBtn_select_Internalname = "BTN_SELECT" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         imgBtn_enter2_Internalname = "BTN_ENTER2" ;
         imgBtn_enter2_separator_Internalname = "BTN_ENTER2_SEPARATOR" ;
         imgBtn_cancel2_Internalname = "BTN_CANCEL2" ;
         imgBtn_cancel2_separator_Internalname = "BTN_CANCEL2_SEPARATOR" ;
         imgBtn_delete2_Internalname = "BTN_DELETE2" ;
         imgBtn_delete2_separator_Internalname = "BTN_DELETE2_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockappointmentcode_Internalname = "TEXTBLOCKAPPOINTMENTCODE" ;
         edtAppointmentCode_Internalname = "APPOINTMENTCODE" ;
         lblTextblockpacienteid_Internalname = "TEXTBLOCKPACIENTEID" ;
         edtPacienteId_Internalname = "PACIENTEID" ;
         lblTextblockappointmentstartdate_Internalname = "TEXTBLOCKAPPOINTMENTSTARTDATE" ;
         edtAppointmentStartDate_Internalname = "APPOINTMENTSTARTDATE" ;
         lblTextblockappointmentenddate_Internalname = "TEXTBLOCKAPPOINTMENTENDDATE" ;
         edtAppointmentEndDate_Internalname = "APPOINTMENTENDDATE" ;
         lblTextblockappointmentobs_Internalname = "TEXTBLOCKAPPOINTMENTOBS" ;
         edtAppointmentObs_Internalname = "APPOINTMENTOBS" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Agenda de Pacientes" ;
         imgBtn_delete2_separator_Visible = 1 ;
         imgBtn_delete2_Enabled = 1 ;
         imgBtn_delete2_Visible = 1 ;
         imgBtn_cancel2_separator_Visible = 1 ;
         imgBtn_cancel2_Visible = 1 ;
         imgBtn_enter2_separator_Visible = 1 ;
         imgBtn_enter2_Enabled = 1 ;
         imgBtn_enter2_Visible = 1 ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_select_Visible = 1 ;
         imgBtn_last_separator_Visible = 1 ;
         imgBtn_last_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         imgBtn_next_Visible = 1 ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_previous_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         imgBtn_first_Visible = 1 ;
         edtAppointmentObs_Enabled = 1 ;
         edtAppointmentEndDate_Jsonclick = "" ;
         edtAppointmentEndDate_Enabled = 1 ;
         edtAppointmentStartDate_Jsonclick = "" ;
         edtAppointmentStartDate_Enabled = 1 ;
         edtPacienteId_Jsonclick = "" ;
         edtPacienteId_Enabled = 1 ;
         edtAppointmentCode_Jsonclick = "" ;
         edtAppointmentCode_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtPacienteId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Appointmentcode( String GX_Parm1 ,
                                         int GX_Parm2 ,
                                         DateTime GX_Parm3 ,
                                         DateTime GX_Parm4 ,
                                         String GX_Parm5 )
      {
         A240AppointmentCode = GX_Parm1 ;
         A67PacienteId = GX_Parm2 ;
         A244AppointmentStartDate = GX_Parm3 ;
         A242AppointmentEndDate = GX_Parm4 ;
         A243AppointmentObs = GX_Parm5 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.Format(A244AppointmentStartDate, "99/99/99 99:99")));
         isValidOutput.Add((Object)(context.localUtil.Format(A242AppointmentEndDate, "99/99/99 99:99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A243AppointmentObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z240AppointmentCode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z67PacienteId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z244AppointmentStartDate, 10, 8, 0, 0, "/", ":", " ")));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z242AppointmentEndDate, 10, 8, 0, 0, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z243AppointmentObs)));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(10);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXKey = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockappointmentcode_Jsonclick = "" ;
         A240AppointmentCode = "" ;
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockappointmentstartdate_Jsonclick = "" ;
         A244AppointmentStartDate = (DateTime)(DateTime.MinValue) ;
         lblTextblockappointmentenddate_Jsonclick = "" ;
         A242AppointmentEndDate = (DateTime)(DateTime.MinValue) ;
         lblTextblockappointmentobs_Jsonclick = "" ;
         A243AppointmentObs = "" ;
         imgBtn_first_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         imgBtn_next_Jsonclick = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_last_Jsonclick = "" ;
         imgBtn_last_separator_Jsonclick = "" ;
         imgBtn_select_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         imgBtn_enter2_Jsonclick = "" ;
         imgBtn_enter2_separator_Jsonclick = "" ;
         imgBtn_cancel2_Jsonclick = "" ;
         imgBtn_cancel2_separator_Jsonclick = "" ;
         imgBtn_delete2_Jsonclick = "" ;
         imgBtn_delete2_separator_Jsonclick = "" ;
         Z240AppointmentCode = "" ;
         Z244AppointmentStartDate = (DateTime)(DateTime.MinValue) ;
         Z242AppointmentEndDate = (DateTime)(DateTime.MinValue) ;
         Z243AppointmentObs = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T001B4_A240AppointmentCode = new String[] {""} ;
         T001B4_A67PacienteId = new int[1] ;
         T001B4_A244AppointmentStartDate = new DateTime[] {DateTime.MinValue} ;
         T001B4_A242AppointmentEndDate = new DateTime[] {DateTime.MinValue} ;
         T001B4_A243AppointmentObs = new String[] {""} ;
         T001B5_A240AppointmentCode = new String[] {""} ;
         T001B3_A240AppointmentCode = new String[] {""} ;
         T001B3_A67PacienteId = new int[1] ;
         T001B3_A244AppointmentStartDate = new DateTime[] {DateTime.MinValue} ;
         T001B3_A242AppointmentEndDate = new DateTime[] {DateTime.MinValue} ;
         T001B3_A243AppointmentObs = new String[] {""} ;
         sMode59 = "" ;
         T001B6_A240AppointmentCode = new String[] {""} ;
         T001B7_A240AppointmentCode = new String[] {""} ;
         T001B8_A240AppointmentCode = new String[] {""} ;
         T001B8_A67PacienteId = new int[1] ;
         T001B8_A244AppointmentStartDate = new DateTime[] {DateTime.MinValue} ;
         T001B8_A242AppointmentEndDate = new DateTime[] {DateTime.MinValue} ;
         T001B8_A243AppointmentObs = new String[] {""} ;
         T001B12_A240AppointmentCode = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.appointment__default(),
            new Object[][] {
                new Object[] {
               T001B2_A240AppointmentCode, T001B2_A67PacienteId, T001B2_A244AppointmentStartDate, T001B2_A242AppointmentEndDate, T001B2_A243AppointmentObs
               }
               , new Object[] {
               T001B3_A240AppointmentCode, T001B3_A67PacienteId, T001B3_A244AppointmentStartDate, T001B3_A242AppointmentEndDate, T001B3_A243AppointmentObs
               }
               , new Object[] {
               T001B4_A240AppointmentCode, T001B4_A67PacienteId, T001B4_A244AppointmentStartDate, T001B4_A242AppointmentEndDate, T001B4_A243AppointmentObs
               }
               , new Object[] {
               T001B5_A240AppointmentCode
               }
               , new Object[] {
               T001B6_A240AppointmentCode
               }
               , new Object[] {
               T001B7_A240AppointmentCode
               }
               , new Object[] {
               T001B8_A240AppointmentCode, T001B8_A67PacienteId, T001B8_A244AppointmentStartDate, T001B8_A242AppointmentEndDate, T001B8_A243AppointmentObs
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001B12_A240AppointmentCode
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound59 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtAppointmentCode_Enabled ;
      private int A67PacienteId ;
      private int edtPacienteId_Enabled ;
      private int edtAppointmentStartDate_Enabled ;
      private int edtAppointmentEndDate_Enabled ;
      private int edtAppointmentObs_Enabled ;
      private int imgBtn_first_Visible ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int imgBtn_next_Visible ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_last_Visible ;
      private int imgBtn_last_separator_Visible ;
      private int imgBtn_select_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int imgBtn_enter2_Visible ;
      private int imgBtn_enter2_Enabled ;
      private int imgBtn_enter2_separator_Visible ;
      private int imgBtn_cancel2_Visible ;
      private int imgBtn_cancel2_separator_Visible ;
      private int imgBtn_delete2_Visible ;
      private int imgBtn_delete2_Enabled ;
      private int imgBtn_delete2_separator_Visible ;
      private int Z67PacienteId ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtAppointmentCode_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockappointmentcode_Internalname ;
      private String lblTextblockappointmentcode_Jsonclick ;
      private String edtAppointmentCode_Jsonclick ;
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtPacienteId_Internalname ;
      private String edtPacienteId_Jsonclick ;
      private String lblTextblockappointmentstartdate_Internalname ;
      private String lblTextblockappointmentstartdate_Jsonclick ;
      private String edtAppointmentStartDate_Internalname ;
      private String edtAppointmentStartDate_Jsonclick ;
      private String lblTextblockappointmentenddate_Internalname ;
      private String lblTextblockappointmentenddate_Jsonclick ;
      private String edtAppointmentEndDate_Internalname ;
      private String edtAppointmentEndDate_Jsonclick ;
      private String lblTextblockappointmentobs_Internalname ;
      private String lblTextblockappointmentobs_Jsonclick ;
      private String edtAppointmentObs_Internalname ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_Internalname ;
      private String imgBtn_first_Jsonclick ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_Internalname ;
      private String imgBtn_previous_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String imgBtn_next_Internalname ;
      private String imgBtn_next_Jsonclick ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_last_Internalname ;
      private String imgBtn_last_Jsonclick ;
      private String imgBtn_last_separator_Internalname ;
      private String imgBtn_last_separator_Jsonclick ;
      private String imgBtn_select_Internalname ;
      private String imgBtn_select_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String imgBtn_enter2_Internalname ;
      private String imgBtn_enter2_Jsonclick ;
      private String imgBtn_enter2_separator_Internalname ;
      private String imgBtn_enter2_separator_Jsonclick ;
      private String imgBtn_cancel2_Internalname ;
      private String imgBtn_cancel2_Jsonclick ;
      private String imgBtn_cancel2_separator_Internalname ;
      private String imgBtn_cancel2_separator_Jsonclick ;
      private String imgBtn_delete2_Internalname ;
      private String imgBtn_delete2_Jsonclick ;
      private String imgBtn_delete2_separator_Internalname ;
      private String imgBtn_delete2_separator_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode59 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A244AppointmentStartDate ;
      private DateTime A242AppointmentEndDate ;
      private DateTime Z244AppointmentStartDate ;
      private DateTime Z242AppointmentEndDate ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A240AppointmentCode ;
      private String A243AppointmentObs ;
      private String Z240AppointmentCode ;
      private String Z243AppointmentObs ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T001B4_A240AppointmentCode ;
      private int[] T001B4_A67PacienteId ;
      private DateTime[] T001B4_A244AppointmentStartDate ;
      private DateTime[] T001B4_A242AppointmentEndDate ;
      private String[] T001B4_A243AppointmentObs ;
      private String[] T001B5_A240AppointmentCode ;
      private String[] T001B3_A240AppointmentCode ;
      private int[] T001B3_A67PacienteId ;
      private DateTime[] T001B3_A244AppointmentStartDate ;
      private DateTime[] T001B3_A242AppointmentEndDate ;
      private String[] T001B3_A243AppointmentObs ;
      private String[] T001B6_A240AppointmentCode ;
      private String[] T001B7_A240AppointmentCode ;
      private String[] T001B8_A240AppointmentCode ;
      private int[] T001B8_A67PacienteId ;
      private DateTime[] T001B8_A244AppointmentStartDate ;
      private DateTime[] T001B8_A242AppointmentEndDate ;
      private String[] T001B8_A243AppointmentObs ;
      private String[] T001B12_A240AppointmentCode ;
      private String[] T001B2_A240AppointmentCode ;
      private int[] T001B2_A67PacienteId ;
      private DateTime[] T001B2_A244AppointmentStartDate ;
      private DateTime[] T001B2_A242AppointmentEndDate ;
      private String[] T001B2_A243AppointmentObs ;
      private GXWebForm Form ;
   }

   public class appointment__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001B2 ;
          prmT001B2 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B4 ;
          prmT001B4 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B5 ;
          prmT001B5 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B3 ;
          prmT001B3 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B6 ;
          prmT001B6 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B7 ;
          prmT001B7 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B8 ;
          prmT001B8 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B9 ;
          prmT001B9 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AppointmentStartDate",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AppointmentEndDate",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AppointmentObs",SqlDbType.VarChar,600,0}
          } ;
          Object[] prmT001B10 ;
          prmT001B10 = new Object[] {
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AppointmentStartDate",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AppointmentEndDate",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AppointmentObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B11 ;
          prmT001B11 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001B12 ;
          prmT001B12 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T001B2", "SELECT [AppointmentCode], [PacienteId], [AppointmentStartDate], [AppointmentEndDate], [AppointmentObs] FROM [Appointment] WITH (UPDLOCK) WHERE [AppointmentCode] = @AppointmentCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001B2,1,0,true,false )
             ,new CursorDef("T001B3", "SELECT [AppointmentCode], [PacienteId], [AppointmentStartDate], [AppointmentEndDate], [AppointmentObs] FROM [Appointment] WITH (NOLOCK) WHERE [AppointmentCode] = @AppointmentCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001B3,1,0,true,false )
             ,new CursorDef("T001B4", "SELECT TM1.[AppointmentCode], TM1.[PacienteId], TM1.[AppointmentStartDate], TM1.[AppointmentEndDate], TM1.[AppointmentObs] FROM [Appointment] TM1 WITH (NOLOCK) WHERE TM1.[AppointmentCode] = @AppointmentCode ORDER BY TM1.[AppointmentCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B4,100,0,true,false )
             ,new CursorDef("T001B5", "SELECT [AppointmentCode] FROM [Appointment] WITH (NOLOCK) WHERE [AppointmentCode] = @AppointmentCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B5,1,0,true,false )
             ,new CursorDef("T001B6", "SELECT TOP 1 [AppointmentCode] FROM [Appointment] WITH (NOLOCK) WHERE ( [AppointmentCode] > @AppointmentCode) ORDER BY [AppointmentCode]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B6,1,0,true,true )
             ,new CursorDef("T001B7", "SELECT TOP 1 [AppointmentCode] FROM [Appointment] WITH (NOLOCK) WHERE ( [AppointmentCode] < @AppointmentCode) ORDER BY [AppointmentCode] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B7,1,0,true,true )
             ,new CursorDef("T001B8", "SELECT [AppointmentCode], [PacienteId], [AppointmentStartDate], [AppointmentEndDate], [AppointmentObs] FROM [Appointment] WITH (UPDLOCK) WHERE [AppointmentCode] = @AppointmentCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001B8,1,0,true,false )
             ,new CursorDef("T001B9", "INSERT INTO [Appointment] ([AppointmentCode], [PacienteId], [AppointmentStartDate], [AppointmentEndDate], [AppointmentObs]) VALUES (@AppointmentCode, @PacienteId, @AppointmentStartDate, @AppointmentEndDate, @AppointmentObs)", GxErrorMask.GX_NOMASK,prmT001B9)
             ,new CursorDef("T001B10", "UPDATE [Appointment] SET [PacienteId]=@PacienteId, [AppointmentStartDate]=@AppointmentStartDate, [AppointmentEndDate]=@AppointmentEndDate, [AppointmentObs]=@AppointmentObs  WHERE [AppointmentCode] = @AppointmentCode", GxErrorMask.GX_NOMASK,prmT001B10)
             ,new CursorDef("T001B11", "DELETE FROM [Appointment]  WHERE [AppointmentCode] = @AppointmentCode", GxErrorMask.GX_NOMASK,prmT001B11)
             ,new CursorDef("T001B12", "SELECT [AppointmentCode] FROM [Appointment] WITH (NOLOCK) ORDER BY [AppointmentCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001B12,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
