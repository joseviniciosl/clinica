/*
               File: Agenda
        Description: Agenda
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:33.84
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
   public class agenda : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_4( A41ClinicaCodigo) ;
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
         Form.Meta.addItem("Description", "Agenda", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtClinicaCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Fantastic");
      }

      public agenda( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public agenda( IGxContext context )
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
            UserMain( ) ;
            if ( ! isFullAjaxMode( ) )
            {
               Draw( ) ;
            }
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
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            wb_table1_2_1857( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1857e( bool wbgen )
      {
         if ( wbgen )
         {
            RenderHtmlCloseForm1857( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1857( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1857( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1857e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Agenda"+"</legend>") ;
            wb_table3_27_1857( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1857e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1857e( true) ;
         }
         else
         {
            wb_table1_2_1857e( false) ;
         }
      }

      protected void wb_table3_27_1857( bool wbgen )
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
            wb_table4_33_1857( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1857e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Agenda.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Agenda.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1857e( true) ;
         }
         else
         {
            wb_table3_27_1857e( false) ;
         }
      }

      protected void wb_table4_33_1857( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Agenda.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockagendaid_Internalname, "Id", "", "", lblTextblockagendaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtAgendaId_Internalname, StringUtil.RTrim( A56AgendaId), StringUtil.RTrim( context.localUtil.Format( A56AgendaId, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtAgendaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtAgendaId_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockagendanombre_Internalname, "Nombre", "", "", lblTextblockagendanombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246AgendaNombre", A246AgendaNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtAgendaNombre_Internalname, StringUtil.RTrim( A246AgendaNombre), StringUtil.RTrim( context.localUtil.Format( A246AgendaNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtAgendaNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtAgendaNombre_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockagendainicial_Internalname, "Inicia", "", "", lblTextblockagendainicial_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230AgendaInicial", context.localUtil.TToC( A230AgendaInicial, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtAgendaInicial_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtAgendaInicial_Internalname, context.localUtil.Format(A230AgendaInicial, "99/99/99 99:99"), context.localUtil.Format( A230AgendaInicial, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(53);\"", "", "", "", "", edtAgendaInicial_Jsonclick, 0, ClassString, StyleString, "", 1, edtAgendaInicial_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_Agenda.htm");
            GxWebStd.gx_bitmap( context, edtAgendaInicial_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtAgendaInicial_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Agenda.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockagendafinal_Internalname, "Finaliza", "", "", lblTextblockagendafinal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231AgendaFinal", context.localUtil.TToC( A231AgendaFinal, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtAgendaFinal_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtAgendaFinal_Internalname, context.localUtil.Format(A231AgendaFinal, "99/99/99 99:99"), context.localUtil.Format( A231AgendaFinal, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(58);\"", "", "", "", "", edtAgendaFinal_Jsonclick, 0, ClassString, StyleString, "", 1, edtAgendaFinal_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_Agenda.htm");
            GxWebStd.gx_bitmap( context, edtAgendaFinal_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtAgendaFinal_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Agenda.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockagendaobs_Internalname, "Observaciones", "", "", lblTextblockagendaobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232AgendaObs", A232AgendaObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtAgendaObs_Internalname, StringUtil.RTrim( A232AgendaObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", 0, 1, edtAgendaObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_Agenda.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1857e( true) ;
         }
         else
         {
            wb_table4_33_1857e( false) ;
         }
      }

      protected void wb_table2_5_1857( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01l0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"AGENDAID"+"'), id:'"+"AGENDAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01l0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"AGENDAID"+"'), id:'"+"AGENDAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Agenda.htm");
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
            wb_table2_5_1857e( true) ;
         }
         else
         {
            wb_table2_5_1857e( false) ;
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
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A56AgendaId = cgiGet( edtAgendaId_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
               A246AgendaNombre = cgiGet( edtAgendaNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246AgendaNombre", A246AgendaNombre);
               if ( context.localUtil.VCDateTime( cgiGet( edtAgendaInicial_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Inicia"}), 1, "AGENDAINICIAL");
                  AnyError = 1 ;
                  GX_FocusControl = edtAgendaInicial_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A230AgendaInicial = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230AgendaInicial", context.localUtil.TToC( A230AgendaInicial, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A230AgendaInicial = context.localUtil.CToT( cgiGet( edtAgendaInicial_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230AgendaInicial", context.localUtil.TToC( A230AgendaInicial, 8, 5, 0, 3, "/", ":", " "));
               }
               if ( context.localUtil.VCDateTime( cgiGet( edtAgendaFinal_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Finaliza"}), 1, "AGENDAFINAL");
                  AnyError = 1 ;
                  GX_FocusControl = edtAgendaFinal_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A231AgendaFinal = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231AgendaFinal", context.localUtil.TToC( A231AgendaFinal, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A231AgendaFinal = context.localUtil.CToT( cgiGet( edtAgendaFinal_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231AgendaFinal", context.localUtil.TToC( A231AgendaFinal, 8, 5, 0, 3, "/", ":", " "));
               }
               A232AgendaObs = cgiGet( edtAgendaObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232AgendaObs", A232AgendaObs);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z56AgendaId = cgiGet( "Z56AgendaId") ;
               Z246AgendaNombre = cgiGet( "Z246AgendaNombre") ;
               Z230AgendaInicial = context.localUtil.CToT( cgiGet( "Z230AgendaInicial"), 0) ;
               Z231AgendaFinal = context.localUtil.CToT( cgiGet( "Z231AgendaFinal"), 0) ;
               Z232AgendaObs = cgiGet( "Z232AgendaObs") ;
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
                  A41ClinicaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
                  A56AgendaId = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
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
               if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
               {
                  sEvtType = StringUtil.Right( sEvt, 1) ;
                  if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                  {
                     sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                     if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1857( ) ;
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
         DisableAttributes1857( ) ;
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

      protected void ResetCaption180( )
      {
      }

      protected void ZM1857( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z246AgendaNombre = T00183_A246AgendaNombre[0] ;
               Z230AgendaInicial = T00183_A230AgendaInicial[0] ;
               Z231AgendaFinal = T00183_A231AgendaFinal[0] ;
               Z232AgendaObs = T00183_A232AgendaObs[0] ;
            }
            else
            {
               Z246AgendaNombre = A246AgendaNombre ;
               Z230AgendaInicial = A230AgendaInicial ;
               Z231AgendaFinal = A231AgendaFinal ;
               Z232AgendaObs = A232AgendaObs ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z56AgendaId = A56AgendaId ;
            Z246AgendaNombre = A246AgendaNombre ;
            Z230AgendaInicial = A230AgendaInicial ;
            Z231AgendaFinal = A231AgendaFinal ;
            Z232AgendaObs = A232AgendaObs ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00g0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
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

      protected void Load1857( )
      {
         /* Using cursor T00185 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A56AgendaId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound57 = 1 ;
            A246AgendaNombre = T00185_A246AgendaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246AgendaNombre", A246AgendaNombre);
            A230AgendaInicial = T00185_A230AgendaInicial[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230AgendaInicial", context.localUtil.TToC( A230AgendaInicial, 8, 5, 0, 3, "/", ":", " "));
            A231AgendaFinal = T00185_A231AgendaFinal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231AgendaFinal", context.localUtil.TToC( A231AgendaFinal, 8, 5, 0, 3, "/", ":", " "));
            A232AgendaObs = T00185_A232AgendaObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232AgendaObs", A232AgendaObs);
            ZM1857( -3) ;
         }
         pr_default.close(3);
         OnLoadActions1857( ) ;
      }

      protected void OnLoadActions1857( )
      {
      }

      protected void CheckExtendedTable1857( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00184 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A230AgendaInicial) || ( A230AgendaInicial >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Inicia fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A231AgendaFinal) || ( A231AgendaFinal >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Finaliza fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1857( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( String A41ClinicaCodigo )
      {
         /* Using cursor T00186 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError41 == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey1857( )
      {
         /* Using cursor T00187 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A56AgendaId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound57 = 1 ;
         }
         else
         {
            RcdFound57 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00183 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A56AgendaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1857( 3) ;
            RcdFound57 = 1 ;
            A56AgendaId = T00183_A56AgendaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
            A246AgendaNombre = T00183_A246AgendaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246AgendaNombre", A246AgendaNombre);
            A230AgendaInicial = T00183_A230AgendaInicial[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230AgendaInicial", context.localUtil.TToC( A230AgendaInicial, 8, 5, 0, 3, "/", ":", " "));
            A231AgendaFinal = T00183_A231AgendaFinal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231AgendaFinal", context.localUtil.TToC( A231AgendaFinal, 8, 5, 0, 3, "/", ":", " "));
            A232AgendaObs = T00183_A232AgendaObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232AgendaObs", A232AgendaObs);
            A41ClinicaCodigo = T00183_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z56AgendaId = A56AgendaId ;
            sMode57 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1857( ) ;
            Gx_mode = sMode57 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound57 = 0 ;
            InitializeNonKey1857( ) ;
            sMode57 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode57 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1857( ) ;
         if ( RcdFound57 == 0 )
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
         RcdFound57 = 0 ;
         /* Using cursor T00188 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A56AgendaId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00188_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00188_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00188_A56AgendaId[0], A56AgendaId) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00188_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00188_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00188_A56AgendaId[0], A56AgendaId) > 0 ) ) )
            {
               A41ClinicaCodigo = T00188_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A56AgendaId = T00188_A56AgendaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
               RcdFound57 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound57 = 0 ;
         /* Using cursor T00189 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A56AgendaId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00189_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00189_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00189_A56AgendaId[0], A56AgendaId) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00189_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00189_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00189_A56AgendaId[0], A56AgendaId) < 0 ) ) )
            {
               A41ClinicaCodigo = T00189_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A56AgendaId = T00189_A56AgendaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
               RcdFound57 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1857( ) ;
         if ( RcdFound57 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A56AgendaId, Z56AgendaId) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A56AgendaId = Z56AgendaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update1857( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A56AgendaId, Z56AgendaId) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1857( ) ;
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
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "CLINICACODIGO");
                  AnyError = 1 ;
                  GX_FocusControl = edtClinicaCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtClinicaCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1857( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A56AgendaId, Z56AgendaId) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A56AgendaId = Z56AgendaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
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
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtAgendaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1857( ) ;
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAgendaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1857( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAgendaNombre_Internalname ;
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
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAgendaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1857( ) ;
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound57 != 0 )
            {
               ScanNext1857( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAgendaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1857( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1857( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001810 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A56AgendaId});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Agenda"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z246AgendaNombre, T001810_A246AgendaNombre[0]) != 0 ) || ( Z230AgendaInicial != T001810_A230AgendaInicial[0] ) || ( Z231AgendaFinal != T001810_A231AgendaFinal[0] ) || ( StringUtil.StrCmp(Z232AgendaObs, T001810_A232AgendaObs[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Agenda"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1857( )
      {
         BeforeValidate1857( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1857( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1857( 0) ;
            CheckOptimisticConcurrency1857( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1857( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1857( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001811 */
                     pr_default.execute(9, new Object[] {A56AgendaId, A246AgendaNombre, A230AgendaInicial, A231AgendaFinal, A232AgendaObs, A41ClinicaCodigo});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 1) )
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
                           ResetCaption180( ) ;
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
               Load1857( ) ;
            }
            EndLevel1857( ) ;
         }
         CloseExtendedTableCursors1857( ) ;
      }

      protected void Update1857( )
      {
         BeforeValidate1857( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1857( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1857( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1857( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1857( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001812 */
                     pr_default.execute(10, new Object[] {A246AgendaNombre, A230AgendaInicial, A231AgendaFinal, A232AgendaObs, A41ClinicaCodigo, A56AgendaId});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Agenda"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1857( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption180( ) ;
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
            EndLevel1857( ) ;
         }
         CloseExtendedTableCursors1857( ) ;
      }

      protected void DeferredUpdate1857( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1857( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1857( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1857( ) ;
            AfterConfirm1857( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1857( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001813 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A56AgendaId});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound57 == 0 )
                        {
                           InitAll1857( ) ;
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
                        ResetCaption180( ) ;
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
         sMode57 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1857( ) ;
         Gx_mode = sMode57 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1857( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1857( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1857( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("Agenda");
            if ( AnyError == 0 )
            {
               ConfirmValues180( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("Agenda");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1857( )
      {
         /* Using cursor T001814 */
         pr_default.execute(12);
         RcdFound57 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound57 = 1 ;
            A41ClinicaCodigo = T001814_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A56AgendaId = T001814_A56AgendaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1857( )
      {
         pr_default.readNext(12);
         RcdFound57 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound57 = 1 ;
            A41ClinicaCodigo = T001814_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A56AgendaId = T001814_A56AgendaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
         }
      }

      protected void ScanEnd1857( )
      {
      }

      protected void AfterConfirm1857( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1857( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1857( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1857( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1857( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1857( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1857( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtAgendaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgendaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgendaId_Enabled), 5, 0)));
         edtAgendaNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgendaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgendaNombre_Enabled), 5, 0)));
         edtAgendaInicial_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgendaInicial_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgendaInicial_Enabled), 5, 0)));
         edtAgendaFinal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgendaFinal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgendaFinal_Enabled), 5, 0)));
         edtAgendaObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAgendaObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAgendaObs_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues180( )
      {
      }

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      protected void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( "Agenda") ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
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
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;") ;
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("agenda.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm1857( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z56AgendaId", StringUtil.RTrim( Z56AgendaId));
         GxWebStd.gx_hidden_field( context, "Z246AgendaNombre", StringUtil.RTrim( Z246AgendaNombre));
         GxWebStd.gx_hidden_field( context, "Z230AgendaInicial", context.localUtil.TToC( Z230AgendaInicial, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z231AgendaFinal", context.localUtil.TToC( Z231AgendaFinal, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z232AgendaObs", StringUtil.RTrim( Z232AgendaObs));
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      protected void InitializeNonKey1857( )
      {
         A246AgendaNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A246AgendaNombre", A246AgendaNombre);
         A230AgendaInicial = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230AgendaInicial", context.localUtil.TToC( A230AgendaInicial, 8, 5, 0, 3, "/", ":", " "));
         A231AgendaFinal = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231AgendaFinal", context.localUtil.TToC( A231AgendaFinal, 8, 5, 0, 3, "/", ":", " "));
         A232AgendaObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232AgendaObs", A232AgendaObs);
      }

      protected void InitAll1857( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A56AgendaId = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56AgendaId", A56AgendaId);
         InitializeNonKey1857( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1563529");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("agenda.js", "?1563529");
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
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO" ;
         lblTextblockagendaid_Internalname = "TEXTBLOCKAGENDAID" ;
         edtAgendaId_Internalname = "AGENDAID" ;
         lblTextblockagendanombre_Internalname = "TEXTBLOCKAGENDANOMBRE" ;
         edtAgendaNombre_Internalname = "AGENDANOMBRE" ;
         lblTextblockagendainicial_Internalname = "TEXTBLOCKAGENDAINICIAL" ;
         edtAgendaInicial_Internalname = "AGENDAINICIAL" ;
         lblTextblockagendafinal_Internalname = "TEXTBLOCKAGENDAFINAL" ;
         edtAgendaFinal_Internalname = "AGENDAFINAL" ;
         lblTextblockagendaobs_Internalname = "TEXTBLOCKAGENDAOBS" ;
         edtAgendaObs_Internalname = "AGENDAOBS" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_Internalname = "PROMPT_41" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
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
         edtAgendaObs_Enabled = 1 ;
         edtAgendaFinal_Jsonclick = "" ;
         edtAgendaFinal_Enabled = 1 ;
         edtAgendaInicial_Jsonclick = "" ;
         edtAgendaInicial_Enabled = 1 ;
         edtAgendaNombre_Jsonclick = "" ;
         edtAgendaNombre_Enabled = 1 ;
         edtAgendaId_Jsonclick = "" ;
         edtAgendaId_Enabled = 1 ;
         imgprompt_41_Visible = 1 ;
         imgprompt_41_Link = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Enabled = 1 ;
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
         /* Using cursor T001815 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(13) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(13);
         GX_FocusControl = edtAgendaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T001815 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(13) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(13);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Agendaid( String GX_Parm1 ,
                                  String GX_Parm2 ,
                                  String GX_Parm3 ,
                                  DateTime GX_Parm4 ,
                                  DateTime GX_Parm5 ,
                                  String GX_Parm6 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A56AgendaId = GX_Parm2 ;
         A246AgendaNombre = GX_Parm3 ;
         A230AgendaInicial = GX_Parm4 ;
         A231AgendaFinal = GX_Parm5 ;
         A232AgendaObs = GX_Parm6 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A246AgendaNombre)));
         isValidOutput.Add((Object)(context.localUtil.Format(A230AgendaInicial, "99/99/99 99:99")));
         isValidOutput.Add((Object)(context.localUtil.Format(A231AgendaFinal, "99/99/99 99:99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A232AgendaObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z56AgendaId)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z246AgendaNombre)));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z230AgendaInicial, 10, 8, 0, 0, "/", ":", " ")));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z231AgendaFinal, 10, 8, 0, 0, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z232AgendaObs)));
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
         pr_default.close(12);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
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
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblockagendaid_Jsonclick = "" ;
         A56AgendaId = "" ;
         lblTextblockagendanombre_Jsonclick = "" ;
         A246AgendaNombre = "" ;
         lblTextblockagendainicial_Jsonclick = "" ;
         A230AgendaInicial = (DateTime)(DateTime.MinValue) ;
         lblTextblockagendafinal_Jsonclick = "" ;
         A231AgendaFinal = (DateTime)(DateTime.MinValue) ;
         lblTextblockagendaobs_Jsonclick = "" ;
         A232AgendaObs = "" ;
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
         Z41ClinicaCodigo = "" ;
         Z56AgendaId = "" ;
         Z246AgendaNombre = "" ;
         Z230AgendaInicial = (DateTime)(DateTime.MinValue) ;
         Z231AgendaFinal = (DateTime)(DateTime.MinValue) ;
         Z232AgendaObs = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00185_A56AgendaId = new String[] {""} ;
         T00185_A246AgendaNombre = new String[] {""} ;
         T00185_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         T00185_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         T00185_A232AgendaObs = new String[] {""} ;
         T00185_A41ClinicaCodigo = new String[] {""} ;
         T00184_A41ClinicaCodigo = new String[] {""} ;
         T00186_A41ClinicaCodigo = new String[] {""} ;
         T00187_A41ClinicaCodigo = new String[] {""} ;
         T00187_A56AgendaId = new String[] {""} ;
         T00183_A56AgendaId = new String[] {""} ;
         T00183_A246AgendaNombre = new String[] {""} ;
         T00183_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         T00183_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         T00183_A232AgendaObs = new String[] {""} ;
         T00183_A41ClinicaCodigo = new String[] {""} ;
         sMode57 = "" ;
         T00188_A41ClinicaCodigo = new String[] {""} ;
         T00188_A56AgendaId = new String[] {""} ;
         T00189_A41ClinicaCodigo = new String[] {""} ;
         T00189_A56AgendaId = new String[] {""} ;
         T001810_A56AgendaId = new String[] {""} ;
         T001810_A246AgendaNombre = new String[] {""} ;
         T001810_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         T001810_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         T001810_A232AgendaObs = new String[] {""} ;
         T001810_A41ClinicaCodigo = new String[] {""} ;
         T001814_A41ClinicaCodigo = new String[] {""} ;
         T001814_A56AgendaId = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         T001815_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.agenda__default(),
            new Object[][] {
                new Object[] {
               T00182_A56AgendaId, T00182_A246AgendaNombre, T00182_A230AgendaInicial, T00182_A231AgendaFinal, T00182_A232AgendaObs, T00182_A41ClinicaCodigo
               }
               , new Object[] {
               T00183_A56AgendaId, T00183_A246AgendaNombre, T00183_A230AgendaInicial, T00183_A231AgendaFinal, T00183_A232AgendaObs, T00183_A41ClinicaCodigo
               }
               , new Object[] {
               T00184_A41ClinicaCodigo
               }
               , new Object[] {
               T00185_A56AgendaId, T00185_A246AgendaNombre, T00185_A230AgendaInicial, T00185_A231AgendaFinal, T00185_A232AgendaObs, T00185_A41ClinicaCodigo
               }
               , new Object[] {
               T00186_A41ClinicaCodigo
               }
               , new Object[] {
               T00187_A41ClinicaCodigo, T00187_A56AgendaId
               }
               , new Object[] {
               T00188_A41ClinicaCodigo, T00188_A56AgendaId
               }
               , new Object[] {
               T00189_A41ClinicaCodigo, T00189_A56AgendaId
               }
               , new Object[] {
               T001810_A56AgendaId, T001810_A246AgendaNombre, T001810_A230AgendaInicial, T001810_A231AgendaFinal, T001810_A232AgendaObs, T001810_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001814_A41ClinicaCodigo, T001814_A56AgendaId
               }
               , new Object[] {
               T001815_A41ClinicaCodigo
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
      private short RcdFound57 ;
      private short Gx_BScreen ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int imgprompt_41_Visible ;
      private int edtAgendaId_Enabled ;
      private int edtAgendaNombre_Enabled ;
      private int edtAgendaInicial_Enabled ;
      private int edtAgendaFinal_Enabled ;
      private int edtAgendaObs_Enabled ;
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
      private int AnyError41 ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtClinicaCodigo_Internalname ;
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
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String imgprompt_41_Internalname ;
      private String imgprompt_41_Link ;
      private String lblTextblockagendaid_Internalname ;
      private String lblTextblockagendaid_Jsonclick ;
      private String edtAgendaId_Internalname ;
      private String edtAgendaId_Jsonclick ;
      private String lblTextblockagendanombre_Internalname ;
      private String lblTextblockagendanombre_Jsonclick ;
      private String edtAgendaNombre_Internalname ;
      private String edtAgendaNombre_Jsonclick ;
      private String lblTextblockagendainicial_Internalname ;
      private String lblTextblockagendainicial_Jsonclick ;
      private String edtAgendaInicial_Internalname ;
      private String edtAgendaInicial_Jsonclick ;
      private String lblTextblockagendafinal_Internalname ;
      private String lblTextblockagendafinal_Jsonclick ;
      private String edtAgendaFinal_Internalname ;
      private String edtAgendaFinal_Jsonclick ;
      private String lblTextblockagendaobs_Internalname ;
      private String lblTextblockagendaobs_Jsonclick ;
      private String edtAgendaObs_Internalname ;
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
      private String sMode57 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A230AgendaInicial ;
      private DateTime A231AgendaFinal ;
      private DateTime Z230AgendaInicial ;
      private DateTime Z231AgendaFinal ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A56AgendaId ;
      private String A246AgendaNombre ;
      private String A232AgendaObs ;
      private String Z41ClinicaCodigo ;
      private String Z56AgendaId ;
      private String Z246AgendaNombre ;
      private String Z232AgendaObs ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00185_A56AgendaId ;
      private String[] T00185_A246AgendaNombre ;
      private DateTime[] T00185_A230AgendaInicial ;
      private DateTime[] T00185_A231AgendaFinal ;
      private String[] T00185_A232AgendaObs ;
      private String[] T00185_A41ClinicaCodigo ;
      private String[] T00184_A41ClinicaCodigo ;
      private String[] T00186_A41ClinicaCodigo ;
      private String[] T00187_A41ClinicaCodigo ;
      private String[] T00187_A56AgendaId ;
      private String[] T00183_A56AgendaId ;
      private String[] T00183_A246AgendaNombre ;
      private DateTime[] T00183_A230AgendaInicial ;
      private DateTime[] T00183_A231AgendaFinal ;
      private String[] T00183_A232AgendaObs ;
      private String[] T00183_A41ClinicaCodigo ;
      private String[] T00188_A41ClinicaCodigo ;
      private String[] T00188_A56AgendaId ;
      private String[] T00189_A41ClinicaCodigo ;
      private String[] T00189_A56AgendaId ;
      private String[] T001810_A56AgendaId ;
      private String[] T001810_A246AgendaNombre ;
      private DateTime[] T001810_A230AgendaInicial ;
      private DateTime[] T001810_A231AgendaFinal ;
      private String[] T001810_A232AgendaObs ;
      private String[] T001810_A41ClinicaCodigo ;
      private String[] T001814_A41ClinicaCodigo ;
      private String[] T001814_A56AgendaId ;
      private String[] T001815_A41ClinicaCodigo ;
      private String[] T00182_A56AgendaId ;
      private String[] T00182_A246AgendaNombre ;
      private DateTime[] T00182_A230AgendaInicial ;
      private DateTime[] T00182_A231AgendaFinal ;
      private String[] T00182_A232AgendaObs ;
      private String[] T00182_A41ClinicaCodigo ;
   }

   public class agenda__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00182 ;
          prmT00182 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00185 ;
          prmT00185 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00184 ;
          prmT00184 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00186 ;
          prmT00186 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00187 ;
          prmT00187 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00183 ;
          prmT00183 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00188 ;
          prmT00188 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00189 ;
          prmT00189 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001810 ;
          prmT001810 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001811 ;
          prmT001811 = new Object[] {
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AgendaInicial",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AgendaFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AgendaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001812 ;
          prmT001812 = new Object[] {
          new Object[] {"@AgendaNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AgendaInicial",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AgendaFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AgendaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001813 ;
          prmT001813 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001814 ;
          prmT001814 = new Object[] {
          } ;
          Object[] prmT001815 ;
          prmT001815 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00182", "SELECT [AgendaId], [AgendaNombre], [AgendaInicial], [AgendaFinal], [AgendaObs], [ClinicaCodigo] FROM [Agenda] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00182,1,0,true,false )
             ,new CursorDef("T00183", "SELECT [AgendaId], [AgendaNombre], [AgendaInicial], [AgendaFinal], [AgendaObs], [ClinicaCodigo] FROM [Agenda] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00183,1,0,true,false )
             ,new CursorDef("T00184", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00184,1,0,true,false )
             ,new CursorDef("T00185", "SELECT TM1.[AgendaId], TM1.[AgendaNombre], TM1.[AgendaInicial], TM1.[AgendaFinal], TM1.[AgendaObs], TM1.[ClinicaCodigo] FROM [Agenda] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[AgendaId] = @AgendaId ORDER BY TM1.[ClinicaCodigo], TM1.[AgendaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00185,100,0,true,false )
             ,new CursorDef("T00186", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00186,1,0,true,false )
             ,new CursorDef("T00187", "SELECT [ClinicaCodigo], [AgendaId] FROM [Agenda] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00187,1,0,true,false )
             ,new CursorDef("T00188", "SELECT TOP 1 [ClinicaCodigo], [AgendaId] FROM [Agenda] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [AgendaId] > @AgendaId) ORDER BY [ClinicaCodigo], [AgendaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00188,1,0,true,true )
             ,new CursorDef("T00189", "SELECT TOP 1 [ClinicaCodigo], [AgendaId] FROM [Agenda] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [AgendaId] < @AgendaId) ORDER BY [ClinicaCodigo] DESC, [AgendaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00189,1,0,true,true )
             ,new CursorDef("T001810", "SELECT [AgendaId], [AgendaNombre], [AgendaInicial], [AgendaFinal], [AgendaObs], [ClinicaCodigo] FROM [Agenda] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001810,1,0,true,false )
             ,new CursorDef("T001811", "INSERT INTO [Agenda] ([AgendaId], [AgendaNombre], [AgendaInicial], [AgendaFinal], [AgendaObs], [ClinicaCodigo]) VALUES (@AgendaId, @AgendaNombre, @AgendaInicial, @AgendaFinal, @AgendaObs, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT001811)
             ,new CursorDef("T001812", "UPDATE [Agenda] SET [AgendaNombre]=@AgendaNombre, [AgendaInicial]=@AgendaInicial, [AgendaFinal]=@AgendaFinal, [AgendaObs]=@AgendaObs  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId", GxErrorMask.GX_NOMASK,prmT001812)
             ,new CursorDef("T001813", "DELETE FROM [Agenda]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId", GxErrorMask.GX_NOMASK,prmT001813)
             ,new CursorDef("T001814", "SELECT [ClinicaCodigo], [AgendaId] FROM [Agenda] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [AgendaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001814,100,0,true,false )
             ,new CursorDef("T001815", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001815,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 13 :
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
