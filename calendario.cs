/*
               File: Calendario
        Description: Calendario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/10/2019 15:21:34.84
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
   public class calendario : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_15") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A67PacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_15( A41ClinicaCodigo, A67PacienteId) ;
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
         if ( ! entryPointCalled )
         {
            Gx_mode = gxfirstwebparm ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7ClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClinicaCodigo", AV7ClinicaCodigo);
               AV8CalendarioCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8CalendarioCodigo", AV8CalendarioCodigo);
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            GxWebError = 1 ;
            context.HttpContext.Response.StatusDescription = 403.ToString();
            context.WriteHtmlText( "<title>403 Forbidden</title>") ;
            context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
            context.WriteHtmlText( "<p /><hr />") ;
         }
         if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXDecQS = Crypto.Decrypt64( context.GetRequestQueryString( ), GXKey) ;
            if ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 )
            {
               SetQueryString( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6))) ;
            }
            else
            {
               GxWebError = 1 ;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
            }
         }
         if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            if ( ! entryPointCalled )
            {
               Gx_mode = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV7ClinicaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClinicaCodigo", AV7ClinicaCodigo);
                  AV8CalendarioCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8CalendarioCodigo", AV8CalendarioCodigo);
               }
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Calendario", 0) ;
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

      public calendario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public calendario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           String aP1_ClinicaCodigo ,
                           String aP2_CalendarioCodigo )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7ClinicaCodigo = aP1_ClinicaCodigo;
         this.AV8CalendarioCodigo = aP2_CalendarioCodigo;
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
            wb_table1_2_1958( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1958e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1958( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1958( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1958e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Calendario"+"</legend>") ;
            wb_table3_27_1958( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1958e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1958e( true) ;
         }
         else
         {
            wb_table1_2_1958e( false) ;
         }
      }

      protected void wb_table3_27_1958( bool wbgen )
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
            wb_table4_33_1958( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1958e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1958e( true) ;
         }
         else
         {
            wb_table3_27_1958e( false) ;
         }
      }

      protected void wb_table4_33_1958( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 1, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcalendariocodigo_Internalname, "Id", "", "", lblTextblockcalendariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCalendarioCodigo_Internalname, StringUtil.RTrim( A233CalendarioCodigo), StringUtil.RTrim( context.localUtil.Format( A233CalendarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtCalendarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCalendarioCodigo_Enabled, 1, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcalendarioobs_Internalname, "Observaciones", "", "", lblTextblockcalendarioobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234CalendarioObs", A234CalendarioObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtCalendarioObs_Internalname, StringUtil.RTrim( A234CalendarioObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", 0, 1, edtCalendarioObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(53);\"", "", "", "", "", edtPacienteId_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteId_Enabled, 1, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Calendario.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_67_Internalname, "prompt.gif", imgprompt_41_67_Link, "", "", "Fantastic", imgprompt_41_67_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcalendarioinicio_Internalname, "Inicia", "", "", lblTextblockcalendarioinicio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtCalendarioInicio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCalendarioInicio_Internalname, context.localUtil.Format(A235CalendarioInicio, "99/99/99 99:99"), context.localUtil.Format( A235CalendarioInicio, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(58);\"", "", "", "", "", edtCalendarioInicio_Jsonclick, 0, ClassString, StyleString, "", 1, edtCalendarioInicio_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_Calendario.htm");
            GxWebStd.gx_bitmap( context, edtCalendarioInicio_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtCalendarioInicio_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Calendario.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcalendariofinal_Internalname, "Final", "", "", lblTextblockcalendariofinal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Calendario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtCalendarioFinal_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCalendarioFinal_Internalname, context.localUtil.Format(A236CalendarioFinal, "99/99/99 99:99"), context.localUtil.Format( A236CalendarioFinal, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(63);\"", "", "", "", "", edtCalendarioFinal_Jsonclick, 0, ClassString, StyleString, "", 1, edtCalendarioFinal_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_Calendario.htm");
            GxWebStd.gx_bitmap( context, edtCalendarioFinal_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtCalendarioFinal_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Calendario.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1958e( true) ;
         }
         else
         {
            wb_table4_33_1958e( false) ;
         }
      }

      protected void wb_table2_5_1958( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01m0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CALENDARIOCODIGO"+"'), id:'"+"CALENDARIOCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01m0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CALENDARIOCODIGO"+"'), id:'"+"CALENDARIOCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Calendario.htm");
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
            wb_table2_5_1958e( true) ;
         }
         else
         {
            wb_table2_5_1958e( false) ;
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
         /* Execute user event: E11192 */
         E11192 ();
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
               A233CalendarioCodigo = cgiGet( edtCalendarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
               A234CalendarioObs = cgiGet( edtCalendarioObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234CalendarioObs", A234CalendarioObs);
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
               if ( context.localUtil.VCDateTime( cgiGet( edtCalendarioInicio_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Inicia"}), 1, "CALENDARIOINICIO");
                  AnyError = 1 ;
                  GX_FocusControl = edtCalendarioInicio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A235CalendarioInicio = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A235CalendarioInicio = context.localUtil.CToT( cgiGet( edtCalendarioInicio_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
               }
               if ( context.localUtil.VCDateTime( cgiGet( edtCalendarioFinal_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Final"}), 1, "CALENDARIOFINAL");
                  AnyError = 1 ;
                  GX_FocusControl = edtCalendarioFinal_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A236CalendarioFinal = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A236CalendarioFinal = context.localUtil.CToT( cgiGet( edtCalendarioFinal_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
               }
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z233CalendarioCodigo = cgiGet( "Z233CalendarioCodigo") ;
               Z234CalendarioObs = cgiGet( "Z234CalendarioObs") ;
               Z235CalendarioInicio = context.localUtil.CToT( cgiGet( "Z235CalendarioInicio"), 0) ;
               Z236CalendarioFinal = context.localUtil.CToT( cgiGet( "Z236CalendarioFinal"), 0) ;
               Z67PacienteId = (int)(context.localUtil.CToN( cgiGet( "Z67PacienteId"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               N67PacienteId = (int)(context.localUtil.CToN( cgiGet( "N67PacienteId"), ".", ",")) ;
               AV7ClinicaCodigo = cgiGet( "vCLINICACODIGO") ;
               AV8CalendarioCodigo = cgiGet( "vCALENDARIOCODIGO") ;
               AV13Insert_PacienteId = (int)(context.localUtil.CToN( cgiGet( "vINSERT_PACIENTEID"), ".", ",")) ;
               AV16Pgmname = cgiGet( "vPGMNAME") ;
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
                  A233CalendarioCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode58 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode58 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound58 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_190( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "CLINICACODIGO");
                        AnyError = 1 ;
                     }
                  }
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
                           /* Execute user event: E11192 */
                           E11192 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12192 */
                           E12192 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_delete( ) ;
                           }
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
            /* Execute user event: E12192 */
            E12192 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1958( ) ;
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
         if ( ( StringUtil.StrCmp(sMode58, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode58, "DLT") == 0 ) )
         {
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
            DisableAttributes1958( ) ;
         }
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

      protected void CONFIRM_190( )
      {
         BeforeValidate1958( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1958( ) ;
            }
            else
            {
               CheckExtendedTable1958( ) ;
               CloseExtendedTableCursors1958( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption190( )
      {
      }

      protected void E11192( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV16Pgmname, out  AV10IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10IsAuthorized", StringUtil.BoolToStr( AV10IsAuthorized));
         if ( ! AV10IsAuthorized )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV16Pgmname)) ;
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), "");
         AV13Insert_PacienteId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_PacienteId), 9, 0)));
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            while ( AV17GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((SdtTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV17GXV1)) ;
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "PacienteId") == 0 )
               {
                  AV13Insert_PacienteId = (int)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_PacienteId), 9, 0)));
               }
               AV17GXV1 = (int)(AV17GXV1+1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            }
         }
      }

      protected void E12192( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwcalendario.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM1958( short GX_JID )
      {
         if ( ( GX_JID == 14 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z234CalendarioObs = T00193_A234CalendarioObs[0] ;
               Z235CalendarioInicio = T00193_A235CalendarioInicio[0] ;
               Z236CalendarioFinal = T00193_A236CalendarioFinal[0] ;
               Z67PacienteId = T00193_A67PacienteId[0] ;
            }
            else
            {
               Z234CalendarioObs = A234CalendarioObs ;
               Z235CalendarioInicio = A235CalendarioInicio ;
               Z236CalendarioFinal = A236CalendarioFinal ;
               Z67PacienteId = A67PacienteId ;
            }
         }
         if ( GX_JID == -14 )
         {
            Z233CalendarioCodigo = A233CalendarioCodigo ;
            Z234CalendarioObs = A234CalendarioObs ;
            Z235CalendarioInicio = A235CalendarioInicio ;
            Z236CalendarioFinal = A236CalendarioFinal ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z67PacienteId = A67PacienteId ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_67_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PACIENTEID"+"'), id:'"+"PACIENTEID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7ClinicaCodigo)) )
         {
            A41ClinicaCodigo = AV7ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7ClinicaCodigo)) )
         {
            edtClinicaCodigo_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         }
         else
         {
            edtClinicaCodigo_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7ClinicaCodigo)) )
         {
            edtClinicaCodigo_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8CalendarioCodigo)) )
         {
            A233CalendarioCodigo = AV8CalendarioCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8CalendarioCodigo)) )
         {
            edtCalendarioCodigo_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioCodigo_Enabled), 5, 0)));
         }
         else
         {
            edtCalendarioCodigo_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioCodigo_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8CalendarioCodigo)) )
         {
            edtCalendarioCodigo_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioCodigo_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_PacienteId) )
         {
            edtPacienteId_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteId_Enabled), 5, 0)));
         }
         else
         {
            edtPacienteId_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteId_Enabled), 5, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_PacienteId) )
         {
            A67PacienteId = AV13Insert_PacienteId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV16Pgmname = "Calendario" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         }
      }

      protected void Load1958( )
      {
         /* Using cursor T00195 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound58 = 1 ;
            A234CalendarioObs = T00195_A234CalendarioObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234CalendarioObs", A234CalendarioObs);
            A235CalendarioInicio = T00195_A235CalendarioInicio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
            A236CalendarioFinal = T00195_A236CalendarioFinal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
            A67PacienteId = T00195_A67PacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            ZM1958( -14) ;
         }
         pr_default.close(3);
         OnLoadActions1958( ) ;
      }

      protected void OnLoadActions1958( )
      {
         AV16Pgmname = "Calendario" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
      }

      protected void CheckExtendedTable1958( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV16Pgmname = "Calendario" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         /* Using cursor T00194 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError67 = 1 ;
            GX_msglist.addItem("No existe 'Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError67 == 0 ) )
         {
         }
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A235CalendarioInicio) || ( A235CalendarioInicio >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Inicia fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A236CalendarioFinal) || ( A236CalendarioFinal >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Final fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1958( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_15( String A41ClinicaCodigo ,
                                int A67PacienteId )
      {
         /* Using cursor T00196 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            AnyError67 = 1 ;
            GX_msglist.addItem("No existe 'Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError67 == 0 ) )
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

      protected void GetKey1958( )
      {
         /* Using cursor T00197 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound58 = 1 ;
         }
         else
         {
            RcdFound58 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00193 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1958( 14) ;
            RcdFound58 = 1 ;
            A233CalendarioCodigo = T00193_A233CalendarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
            A234CalendarioObs = T00193_A234CalendarioObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234CalendarioObs", A234CalendarioObs);
            A235CalendarioInicio = T00193_A235CalendarioInicio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
            A236CalendarioFinal = T00193_A236CalendarioFinal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
            A41ClinicaCodigo = T00193_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A67PacienteId = T00193_A67PacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z233CalendarioCodigo = A233CalendarioCodigo ;
            sMode58 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load1958( ) ;
            Gx_mode = sMode58 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound58 = 0 ;
            InitializeNonKey1958( ) ;
            sMode58 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode58 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1958( ) ;
         if ( RcdFound58 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound58 = 0 ;
         /* Using cursor T00198 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00198_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00198_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00198_A233CalendarioCodigo[0], A233CalendarioCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00198_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00198_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00198_A233CalendarioCodigo[0], A233CalendarioCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T00198_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A233CalendarioCodigo = T00198_A233CalendarioCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
               RcdFound58 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound58 = 0 ;
         /* Using cursor T00199 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00199_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00199_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00199_A233CalendarioCodigo[0], A233CalendarioCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00199_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00199_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00199_A233CalendarioCodigo[0], A233CalendarioCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T00199_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A233CalendarioCodigo = T00199_A233CalendarioCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
               RcdFound58 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1958( ) ;
         if ( RcdFound58 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A233CalendarioCodigo, Z233CalendarioCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A233CalendarioCodigo = Z233CalendarioCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
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
               /* Update record */
               Update1958( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A233CalendarioCodigo, Z233CalendarioCodigo) != 0 ) )
            {
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1958( ) ;
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
                  /* Insert record */
                  GX_FocusControl = edtClinicaCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1958( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A233CalendarioCodigo, Z233CalendarioCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A233CalendarioCodigo = Z233CalendarioCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
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
         }
      }

      protected void CheckOptimisticConcurrency1958( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001910 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Calendario"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z234CalendarioObs, T001910_A234CalendarioObs[0]) != 0 ) || ( Z235CalendarioInicio != T001910_A235CalendarioInicio[0] ) || ( Z236CalendarioFinal != T001910_A236CalendarioFinal[0] ) || ( Z67PacienteId != T001910_A67PacienteId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Calendario"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1958( )
      {
         BeforeValidate1958( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1958( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1958( 0) ;
            CheckOptimisticConcurrency1958( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1958( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1958( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001911 */
                     pr_default.execute(9, new Object[] {A233CalendarioCodigo, A234CalendarioObs, A235CalendarioInicio, A236CalendarioFinal, A41ClinicaCodigo, A67PacienteId});
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
                           ResetCaption190( ) ;
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
               Load1958( ) ;
            }
            EndLevel1958( ) ;
         }
         CloseExtendedTableCursors1958( ) ;
      }

      protected void Update1958( )
      {
         BeforeValidate1958( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1958( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1958( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1958( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1958( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001912 */
                     pr_default.execute(10, new Object[] {A234CalendarioObs, A235CalendarioInicio, A236CalendarioFinal, A67PacienteId, A41ClinicaCodigo, A233CalendarioCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Calendario"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1958( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
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
            }
            EndLevel1958( ) ;
         }
         CloseExtendedTableCursors1958( ) ;
      }

      protected void DeferredUpdate1958( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1958( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1958( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1958( ) ;
            AfterConfirm1958( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1958( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001913 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A233CalendarioCodigo});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1 ;
                           }
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
         }
         sMode58 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1958( ) ;
         Gx_mode = sMode58 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1958( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "Calendario" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         }
      }

      protected void EndLevel1958( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1958( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("Calendario");
            if ( AnyError == 0 )
            {
               ConfirmValues190( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("Calendario");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1958( )
      {
         /* Using cursor T001914 */
         pr_default.execute(12);
         RcdFound58 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound58 = 1 ;
            A41ClinicaCodigo = T001914_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A233CalendarioCodigo = T001914_A233CalendarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1958( )
      {
         pr_default.readNext(12);
         RcdFound58 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound58 = 1 ;
            A41ClinicaCodigo = T001914_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A233CalendarioCodigo = T001914_A233CalendarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
         }
      }

      protected void ScanEnd1958( )
      {
      }

      protected void AfterConfirm1958( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1958( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1958( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1958( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1958( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1958( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1958( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtCalendarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioCodigo_Enabled), 5, 0)));
         edtCalendarioObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioObs_Enabled), 5, 0)));
         edtPacienteId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteId_Enabled), 5, 0)));
         edtCalendarioInicio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioInicio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioInicio_Enabled), 5, 0)));
         edtCalendarioFinal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCalendarioFinal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCalendarioFinal_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues190( )
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
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7ClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV8CalendarioCodigo)) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("calendario.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z233CalendarioCodigo", StringUtil.RTrim( Z233CalendarioCodigo));
         GxWebStd.gx_hidden_field( context, "Z234CalendarioObs", StringUtil.RTrim( Z234CalendarioObs));
         GxWebStd.gx_hidden_field( context, "Z235CalendarioInicio", context.localUtil.TToC( Z235CalendarioInicio, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z236CalendarioFinal", context.localUtil.TToC( Z236CalendarioFinal, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z67PacienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z67PacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "N67PacienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV7ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vCALENDARIOCODIGO", StringUtil.RTrim( AV8CalendarioCodigo));
         GxWebStd.gx_hidden_field( context, "vINSERT_PACIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_PacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV16Pgmname));
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
         return "Calendario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Calendario" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV7ClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV8CalendarioCodigo)) ;
         return formatLink("calendario.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void InitializeNonKey1958( )
      {
         A67PacienteId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
         A234CalendarioObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234CalendarioObs", A234CalendarioObs);
         A235CalendarioInicio = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235CalendarioInicio", context.localUtil.TToC( A235CalendarioInicio, 8, 5, 0, 3, "/", ":", " "));
         A236CalendarioFinal = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236CalendarioFinal", context.localUtil.TToC( A236CalendarioFinal, 8, 5, 0, 3, "/", ":", " "));
      }

      protected void InitAll1958( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A233CalendarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233CalendarioCodigo", A233CalendarioCodigo);
         InitializeNonKey1958( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?15213672");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("calendario.js", "?15213672");
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
         lblTextblockcalendariocodigo_Internalname = "TEXTBLOCKCALENDARIOCODIGO" ;
         edtCalendarioCodigo_Internalname = "CALENDARIOCODIGO" ;
         lblTextblockcalendarioobs_Internalname = "TEXTBLOCKCALENDARIOOBS" ;
         edtCalendarioObs_Internalname = "CALENDARIOOBS" ;
         lblTextblockpacienteid_Internalname = "TEXTBLOCKPACIENTEID" ;
         edtPacienteId_Internalname = "PACIENTEID" ;
         lblTextblockcalendarioinicio_Internalname = "TEXTBLOCKCALENDARIOINICIO" ;
         edtCalendarioInicio_Internalname = "CALENDARIOINICIO" ;
         lblTextblockcalendariofinal_Internalname = "TEXTBLOCKCALENDARIOFINAL" ;
         edtCalendarioFinal_Internalname = "CALENDARIOFINAL" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_67_Internalname = "PROMPT_41_67" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Calendario" ;
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
         edtCalendarioFinal_Jsonclick = "" ;
         edtCalendarioFinal_Enabled = 1 ;
         edtCalendarioInicio_Jsonclick = "" ;
         edtCalendarioInicio_Enabled = 1 ;
         imgprompt_41_67_Visible = 1 ;
         imgprompt_41_67_Link = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtPacienteId_Enabled = 1 ;
         edtCalendarioObs_Enabled = 1 ;
         edtCalendarioCodigo_Jsonclick = "" ;
         edtCalendarioCodigo_Enabled = 1 ;
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

      public void Valid_Pacienteid( String GX_Parm1 ,
                                    int GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A67PacienteId = GX_Parm2 ;
         /* Using cursor T001915 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(13) == 101) )
         {
            AnyError41 = 1 ;
            AnyError67 = 1 ;
            GX_msglist.addItem("No existe 'Pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError67 == 0 ) )
         {
         }
         pr_default.close(13);
         dynload_actions( ) ;
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
         wcpOGx_mode = "" ;
         wcpOAV7ClinicaCodigo = "" ;
         wcpOAV8CalendarioCodigo = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         GXKey = "" ;
         GXDecQS = "" ;
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
         lblTextblockcalendariocodigo_Jsonclick = "" ;
         A233CalendarioCodigo = "" ;
         lblTextblockcalendarioobs_Jsonclick = "" ;
         A234CalendarioObs = "" ;
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockcalendarioinicio_Jsonclick = "" ;
         A235CalendarioInicio = (DateTime)(DateTime.MinValue) ;
         lblTextblockcalendariofinal_Jsonclick = "" ;
         A236CalendarioFinal = (DateTime)(DateTime.MinValue) ;
         GXt_char1 = "" ;
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
         Z233CalendarioCodigo = "" ;
         Z234CalendarioObs = "" ;
         Z235CalendarioInicio = (DateTime)(DateTime.MinValue) ;
         Z236CalendarioFinal = (DateTime)(DateTime.MinValue) ;
         AV16Pgmname = "" ;
         sMode58 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXEncryptionTmp = "" ;
         AV11TrnContext = new SdtTransactionContext(context);
         AV12WebSession = new GxWebSession( context);
         AV14TrnContextAtt = new SdtTransactionContext_Attribute(context);
         T00195_A233CalendarioCodigo = new String[] {""} ;
         T00195_A234CalendarioObs = new String[] {""} ;
         T00195_A235CalendarioInicio = new DateTime[] {DateTime.MinValue} ;
         T00195_A236CalendarioFinal = new DateTime[] {DateTime.MinValue} ;
         T00195_A41ClinicaCodigo = new String[] {""} ;
         T00195_A67PacienteId = new int[1] ;
         T00194_A41ClinicaCodigo = new String[] {""} ;
         T00196_A41ClinicaCodigo = new String[] {""} ;
         T00197_A41ClinicaCodigo = new String[] {""} ;
         T00197_A233CalendarioCodigo = new String[] {""} ;
         T00193_A233CalendarioCodigo = new String[] {""} ;
         T00193_A234CalendarioObs = new String[] {""} ;
         T00193_A235CalendarioInicio = new DateTime[] {DateTime.MinValue} ;
         T00193_A236CalendarioFinal = new DateTime[] {DateTime.MinValue} ;
         T00193_A41ClinicaCodigo = new String[] {""} ;
         T00193_A67PacienteId = new int[1] ;
         T00198_A41ClinicaCodigo = new String[] {""} ;
         T00198_A233CalendarioCodigo = new String[] {""} ;
         T00199_A41ClinicaCodigo = new String[] {""} ;
         T00199_A233CalendarioCodigo = new String[] {""} ;
         T001910_A233CalendarioCodigo = new String[] {""} ;
         T001910_A234CalendarioObs = new String[] {""} ;
         T001910_A235CalendarioInicio = new DateTime[] {DateTime.MinValue} ;
         T001910_A236CalendarioFinal = new DateTime[] {DateTime.MinValue} ;
         T001910_A41ClinicaCodigo = new String[] {""} ;
         T001910_A67PacienteId = new int[1] ;
         T001914_A41ClinicaCodigo = new String[] {""} ;
         T001914_A233CalendarioCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char3 = "" ;
         T001915_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calendario__default(),
            new Object[][] {
                new Object[] {
               T00192_A233CalendarioCodigo, T00192_A234CalendarioObs, T00192_A235CalendarioInicio, T00192_A236CalendarioFinal, T00192_A41ClinicaCodigo, T00192_A67PacienteId
               }
               , new Object[] {
               T00193_A233CalendarioCodigo, T00193_A234CalendarioObs, T00193_A235CalendarioInicio, T00193_A236CalendarioFinal, T00193_A41ClinicaCodigo, T00193_A67PacienteId
               }
               , new Object[] {
               T00194_A41ClinicaCodigo
               }
               , new Object[] {
               T00195_A233CalendarioCodigo, T00195_A234CalendarioObs, T00195_A235CalendarioInicio, T00195_A236CalendarioFinal, T00195_A41ClinicaCodigo, T00195_A67PacienteId
               }
               , new Object[] {
               T00196_A41ClinicaCodigo
               }
               , new Object[] {
               T00197_A41ClinicaCodigo, T00197_A233CalendarioCodigo
               }
               , new Object[] {
               T00198_A41ClinicaCodigo, T00198_A233CalendarioCodigo
               }
               , new Object[] {
               T00199_A41ClinicaCodigo, T00199_A233CalendarioCodigo
               }
               , new Object[] {
               T001910_A233CalendarioCodigo, T001910_A234CalendarioObs, T001910_A235CalendarioInicio, T001910_A236CalendarioFinal, T001910_A41ClinicaCodigo, T001910_A67PacienteId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001914_A41ClinicaCodigo, T001914_A233CalendarioCodigo
               }
               , new Object[] {
               T001915_A41ClinicaCodigo
               }
            }
         );
         AV16Pgmname = "Calendario" ;
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound58 ;
      private short gxcookieaux ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A67PacienteId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtCalendarioCodigo_Enabled ;
      private int edtCalendarioObs_Enabled ;
      private int edtPacienteId_Enabled ;
      private int imgprompt_41_67_Visible ;
      private int edtCalendarioInicio_Enabled ;
      private int edtCalendarioFinal_Enabled ;
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
      private int N67PacienteId ;
      private int AV13Insert_PacienteId ;
      private int AV17GXV1 ;
      private int AnyError41 ;
      private int AnyError67 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String GXDecQS ;
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
      private String lblTextblockcalendariocodigo_Internalname ;
      private String lblTextblockcalendariocodigo_Jsonclick ;
      private String edtCalendarioCodigo_Internalname ;
      private String edtCalendarioCodigo_Jsonclick ;
      private String lblTextblockcalendarioobs_Internalname ;
      private String lblTextblockcalendarioobs_Jsonclick ;
      private String edtCalendarioObs_Internalname ;
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtPacienteId_Internalname ;
      private String edtPacienteId_Jsonclick ;
      private String imgprompt_41_67_Internalname ;
      private String imgprompt_41_67_Link ;
      private String lblTextblockcalendarioinicio_Internalname ;
      private String lblTextblockcalendarioinicio_Jsonclick ;
      private String edtCalendarioInicio_Internalname ;
      private String edtCalendarioInicio_Jsonclick ;
      private String lblTextblockcalendariofinal_Internalname ;
      private String lblTextblockcalendariofinal_Jsonclick ;
      private String edtCalendarioFinal_Internalname ;
      private String edtCalendarioFinal_Jsonclick ;
      private String GXt_char1 ;
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
      private String AV16Pgmname ;
      private String sMode58 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXEncryptionTmp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char3 ;
      private DateTime A235CalendarioInicio ;
      private DateTime A236CalendarioFinal ;
      private DateTime Z235CalendarioInicio ;
      private DateTime Z236CalendarioFinal ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool AV10IsAuthorized ;
      private bool returnInSub ;
      private String wcpOAV7ClinicaCodigo ;
      private String wcpOAV8CalendarioCodigo ;
      private String A41ClinicaCodigo ;
      private String AV7ClinicaCodigo ;
      private String AV8CalendarioCodigo ;
      private String A233CalendarioCodigo ;
      private String A234CalendarioObs ;
      private String Z41ClinicaCodigo ;
      private String Z233CalendarioCodigo ;
      private String Z234CalendarioObs ;
      private GxWebSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00195_A233CalendarioCodigo ;
      private String[] T00195_A234CalendarioObs ;
      private DateTime[] T00195_A235CalendarioInicio ;
      private DateTime[] T00195_A236CalendarioFinal ;
      private String[] T00195_A41ClinicaCodigo ;
      private int[] T00195_A67PacienteId ;
      private String[] T00194_A41ClinicaCodigo ;
      private String[] T00196_A41ClinicaCodigo ;
      private String[] T00197_A41ClinicaCodigo ;
      private String[] T00197_A233CalendarioCodigo ;
      private String[] T00193_A233CalendarioCodigo ;
      private String[] T00193_A234CalendarioObs ;
      private DateTime[] T00193_A235CalendarioInicio ;
      private DateTime[] T00193_A236CalendarioFinal ;
      private String[] T00193_A41ClinicaCodigo ;
      private int[] T00193_A67PacienteId ;
      private String[] T00198_A41ClinicaCodigo ;
      private String[] T00198_A233CalendarioCodigo ;
      private String[] T00199_A41ClinicaCodigo ;
      private String[] T00199_A233CalendarioCodigo ;
      private String[] T001910_A233CalendarioCodigo ;
      private String[] T001910_A234CalendarioObs ;
      private DateTime[] T001910_A235CalendarioInicio ;
      private DateTime[] T001910_A236CalendarioFinal ;
      private String[] T001910_A41ClinicaCodigo ;
      private int[] T001910_A67PacienteId ;
      private String[] T001914_A41ClinicaCodigo ;
      private String[] T001914_A233CalendarioCodigo ;
      private String[] T001915_A41ClinicaCodigo ;
      private String[] T00192_A233CalendarioCodigo ;
      private String[] T00192_A234CalendarioObs ;
      private DateTime[] T00192_A235CalendarioInicio ;
      private DateTime[] T00192_A236CalendarioFinal ;
      private String[] T00192_A41ClinicaCodigo ;
      private int[] T00192_A67PacienteId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV11TrnContext ;
      private SdtTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class calendario__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00192 ;
          prmT00192 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00195 ;
          prmT00195 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00194 ;
          prmT00194 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00196 ;
          prmT00196 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00197 ;
          prmT00197 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00193 ;
          prmT00193 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00198 ;
          prmT00198 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00199 ;
          prmT00199 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001910 ;
          prmT001910 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001911 ;
          prmT001911 = new Object[] {
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@CalendarioInicio",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CalendarioFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001912 ;
          prmT001912 = new Object[] {
          new Object[] {"@CalendarioObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@CalendarioInicio",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CalendarioFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001913 ;
          prmT001913 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CalendarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001914 ;
          prmT001914 = new Object[] {
          } ;
          Object[] prmT001915 ;
          prmT001915 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00192", "SELECT [CalendarioCodigo], [CalendarioObs], [CalendarioInicio], [CalendarioFinal], [ClinicaCodigo], [PacienteId] FROM [Calendario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00192,1,0,true,false )
             ,new CursorDef("T00193", "SELECT [CalendarioCodigo], [CalendarioObs], [CalendarioInicio], [CalendarioFinal], [ClinicaCodigo], [PacienteId] FROM [Calendario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00193,1,0,true,false )
             ,new CursorDef("T00194", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00194,1,0,true,false )
             ,new CursorDef("T00195", "SELECT TM1.[CalendarioCodigo], TM1.[CalendarioObs], TM1.[CalendarioInicio], TM1.[CalendarioFinal], TM1.[ClinicaCodigo], TM1.[PacienteId] FROM [Calendario] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CalendarioCodigo] = @CalendarioCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[CalendarioCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00195,100,0,true,false )
             ,new CursorDef("T00196", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00196,1,0,true,false )
             ,new CursorDef("T00197", "SELECT [ClinicaCodigo], [CalendarioCodigo] FROM [Calendario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00197,1,0,true,false )
             ,new CursorDef("T00198", "SELECT TOP 1 [ClinicaCodigo], [CalendarioCodigo] FROM [Calendario] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CalendarioCodigo] > @CalendarioCodigo) ORDER BY [ClinicaCodigo], [CalendarioCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00198,1,0,true,true )
             ,new CursorDef("T00199", "SELECT TOP 1 [ClinicaCodigo], [CalendarioCodigo] FROM [Calendario] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CalendarioCodigo] < @CalendarioCodigo) ORDER BY [ClinicaCodigo] DESC, [CalendarioCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00199,1,0,true,true )
             ,new CursorDef("T001910", "SELECT [CalendarioCodigo], [CalendarioObs], [CalendarioInicio], [CalendarioFinal], [ClinicaCodigo], [PacienteId] FROM [Calendario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001910,1,0,true,false )
             ,new CursorDef("T001911", "INSERT INTO [Calendario] ([CalendarioCodigo], [CalendarioObs], [CalendarioInicio], [CalendarioFinal], [ClinicaCodigo], [PacienteId]) VALUES (@CalendarioCodigo, @CalendarioObs, @CalendarioInicio, @CalendarioFinal, @ClinicaCodigo, @PacienteId)", GxErrorMask.GX_NOMASK,prmT001911)
             ,new CursorDef("T001912", "UPDATE [Calendario] SET [CalendarioObs]=@CalendarioObs, [CalendarioInicio]=@CalendarioInicio, [CalendarioFinal]=@CalendarioFinal, [PacienteId]=@PacienteId  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo", GxErrorMask.GX_NOMASK,prmT001912)
             ,new CursorDef("T001913", "DELETE FROM [Calendario]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CalendarioCodigo] = @CalendarioCodigo", GxErrorMask.GX_NOMASK,prmT001913)
             ,new CursorDef("T001914", "SELECT [ClinicaCodigo], [CalendarioCodigo] FROM [Calendario] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CalendarioCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001914,100,0,true,false )
             ,new CursorDef("T001915", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001915,1,0,true,false )
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
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(6, (int)parms[5]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
