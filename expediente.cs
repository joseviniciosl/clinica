/*
               File: Expediente
        Description: Expediente Médico Físico
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:56.24
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
   public class expediente : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A67PacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_4( A41ClinicaCodigo, A67PacienteId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A4UsuarioCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A4UsuarioCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridexpediente_expedientedet") == 0 )
         {
            nRC_Gridexpediente_expedientedet = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_75_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_75_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridexpediente_expedientedet_newrow( nRC_Gridexpediente_expedientedet, nGXsfl_75_idx, sGXsfl_75_idx) ;
            return  ;
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
         Form.Meta.addItem("Description", "Expediente Médico Físico", 0) ;
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

      public expediente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public expediente( IGxContext context )
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
            wb_table1_2_1046( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1046e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1046( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1046( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1046e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Expediente Médico Físico"+"</legend>") ;
            wb_table3_27_1046( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1046e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1046e( true) ;
         }
         else
         {
            wb_table1_2_1046e( false) ;
         }
      }

      protected void wb_table3_27_1046( bool wbgen )
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
            wb_table4_33_1046( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1046e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Expediente.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Expediente.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1046e( true) ;
         }
         else
         {
            wb_table3_27_1046e( false) ;
         }
      }

      protected void wb_table4_33_1046( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockexpedienteid_Internalname, "Expediente", "", "", lblTextblockexpedienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtExpedienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A167ExpedienteId), 9, 0, ".", "")), ((edtExpedienteId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A167ExpedienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A167ExpedienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtExpedienteId_Jsonclick, 0, ClassString, StyleString, "", 1, edtExpedienteId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockexpedientefecha_Internalname, "Fecha", "", "", lblTextblockexpedientefecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168ExpedienteFecha", context.localUtil.Format(A168ExpedienteFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtExpedienteFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtExpedienteFecha_Internalname, context.localUtil.Format(A168ExpedienteFecha, "99/99/99"), context.localUtil.Format( A168ExpedienteFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(48);\"", "", "", "", "", edtExpedienteFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtExpedienteFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Expediente.htm");
            GxWebStd.gx_bitmap( context, edtExpedienteFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtExpedienteFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Expediente.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockexpedientehora_Internalname, "Hora", "", "", lblTextblockexpedientehora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169ExpedienteHora", A169ExpedienteHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtExpedienteHora_Internalname, StringUtil.RTrim( A169ExpedienteHora), StringUtil.RTrim( context.localUtil.Format( A169ExpedienteHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtExpedienteHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtExpedienteHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPacienteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")), ((edtPacienteId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(58);\"", "", "", "", "", edtPacienteId_Jsonclick, 0, ClassString, StyleString, "", 1, edtPacienteId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Expediente.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_67_Internalname, "prompt.gif", imgprompt_41_67_Link, "", "", "Fantastic", imgprompt_41_67_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Expediente.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockexpedienteobs_Internalname, "Observaciones", "", "", lblTextblockexpedienteobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176ExpedienteObs", A176ExpedienteObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtExpedienteObs_Internalname, StringUtil.RTrim( A176ExpedienteObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, 1, edtExpedienteObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_71_1046( true) ;
         }
         return  ;
      }

      protected void wb_table5_71_1046e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridexpediente_expedientedetContainer.AddObjectProperty("GridName", "Gridexpediente_expedientedet");
            Gridexpediente_expedientedetContainer.AddObjectProperty("Class", "Grid");
            Gridexpediente_expedientedetContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexpediente_expedientedet_Backcolorstyle), 1, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddObjectProperty("CmpContext", "");
            Gridexpediente_expedientedetContainer.AddObjectProperty("InMasterPage", "false");
            Gridexpediente_expedientedetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridexpediente_expedientedetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A170ExpedienteLinea), 4, 0, ".", "")));
            Gridexpediente_expedientedetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteLinea_Enabled), 5, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddColumnProperties(Gridexpediente_expedientedetColumn);
            Gridexpediente_expedientedetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridexpediente_expedientedetColumn.AddObjectProperty("Value", StringUtil.RTrim( A171ExpedienteArchivo));
            Gridexpediente_expedientedetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteArchivo_Enabled), 5, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddColumnProperties(Gridexpediente_expedientedetColumn);
            Gridexpediente_expedientedetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridexpediente_expedientedetColumn.AddObjectProperty("Value", StringUtil.RTrim( A172ExpedienteDescripcion));
            Gridexpediente_expedientedetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteDescripcion_Enabled), 5, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddColumnProperties(Gridexpediente_expedientedetColumn);
            Gridexpediente_expedientedetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridexpediente_expedientedetColumn.AddObjectProperty("Value", context.localUtil.Format(A173ExpedienteFechaL, "99/99/99"));
            Gridexpediente_expedientedetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteFechaL_Enabled), 5, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddColumnProperties(Gridexpediente_expedientedetColumn);
            Gridexpediente_expedientedetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridexpediente_expedientedetColumn.AddObjectProperty("Value", StringUtil.RTrim( A174ExpedienteHoraL));
            Gridexpediente_expedientedetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteHoraL_Enabled), 5, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddColumnProperties(Gridexpediente_expedientedetColumn);
            Gridexpediente_expedientedetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridexpediente_expedientedetColumn.AddObjectProperty("Value", StringUtil.RTrim( A175UsuarioCodigoL));
            Gridexpediente_expedientedetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtUsuarioCodigoL_Enabled), 5, 0, ".", "")));
            Gridexpediente_expedientedetContainer.AddColumnProperties(Gridexpediente_expedientedetColumn);
            Gridexpediente_expedientedetContainer.AddObjectProperty("Allowselection", "false");
            Gridexpediente_expedientedetContainer.AddObjectProperty("Allowcollapsing", ((subGridexpediente_expedientedet_Allowcollapsing==1) ? "true" : "false"));
            Gridexpediente_expedientedetContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridexpediente_expedientedet_Collapsed), 9, 0, ".", "")));
            nGXsfl_75_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount47 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_47 = 1 ;
                  ScanStart1047( ) ;
                  while ( RcdFound47 != 0 )
                  {
                     init_level_properties47( ) ;
                     getByPrimaryKey1047( ) ;
                     AddRow1047( ) ;
                     ScanNext1047( ) ;
                  }
                  ScanEnd1047( ) ;
                  nBlankRcdCount47 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal1047( ) ;
               standaloneModal1047( ) ;
               sMode47 = Gx_mode ;
               while ( nGXsfl_75_idx < nRC_Gridexpediente_expedientedet )
               {
                  ReadRow1047( ) ;
                  edtExpedienteLinea_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTELINEA_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  edtExpedienteArchivo_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  edtExpedienteDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  edtExpedienteFechaL_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTEFECHAL_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  edtExpedienteHoraL_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTEHORAL_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  edtUsuarioCodigoL_Enabled = (int)(context.localUtil.CToN( cgiGet( "USUARIOCODIGOL_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_47 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal1047( ) ;
                  }
                  SendRow1047( ) ;
               }
               Gx_mode = sMode47 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount47 = 5 ;
               nRcdExists_47 = 1 ;
               ScanStart1047( ) ;
               while ( RcdFound47 != 0 )
               {
                  init_level_properties47( ) ;
                  getByPrimaryKey1047( ) ;
                  standaloneNotModal1047( ) ;
                  standaloneModal1047( ) ;
                  AddRow1047( ) ;
                  ScanNext1047( ) ;
               }
               ScanEnd1047( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode47 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll1047( ) ;
            init_level_properties47( ) ;
            standaloneNotModal1047( ) ;
            standaloneModal1047( ) ;
            nRcdExists_47 = 0 ;
            nIsMod_47 = 0 ;
            nBlankRcdCount47 = (short)(nBlankRcdUsr47+nBlankRcdCount47) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount47 > 0 )
            {
               AddRow1047( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtExpedienteLinea_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount47 = (short)(nBlankRcdCount47-1) ;
            }
            Gx_mode = sMode47 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridexpediente_expedientedetContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridexpediente_expedientedet", (Object)(Gridexpediente_expedientedetContainer));
            GxWebStd.gx_hidden_field( context, "Gridexpediente_expedientedetContainerData", Gridexpediente_expedientedetContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridexpediente_expedientedetContainerData"+"V", Gridexpediente_expedientedetContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridexpediente_expedientedetContainerData"+"V"+"\" value='"+Gridexpediente_expedientedetContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1046e( true) ;
         }
         else
         {
            wb_table4_33_1046e( false) ;
         }
      }

      protected void wb_table5_71_1046( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table95", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitleexpedientedet_Internalname, "Detalle del Expediente Médico Físico", "", "", lblTitleexpedientedet_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Expediente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_71_1046e( true) ;
         }
         else
         {
            wb_table5_71_1046e( false) ;
         }
      }

      protected void wb_table2_5_1046( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"EXPEDIENTEID"+"'), id:'"+"EXPEDIENTEID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"EXPEDIENTEID"+"'), id:'"+"EXPEDIENTEID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Expediente.htm");
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
            wb_table2_5_1046e( true) ;
         }
         else
         {
            wb_table2_5_1046e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtExpedienteId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtExpedienteId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EXPEDIENTEID");
                  AnyError = 1 ;
                  GX_FocusControl = edtExpedienteId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A167ExpedienteId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
               }
               else
               {
                  A167ExpedienteId = (int)(context.localUtil.CToN( cgiGet( edtExpedienteId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtExpedienteFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "EXPEDIENTEFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtExpedienteFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A168ExpedienteFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168ExpedienteFecha", context.localUtil.Format(A168ExpedienteFecha, "99/99/99"));
               }
               else
               {
                  A168ExpedienteFecha = context.localUtil.CToD( cgiGet( edtExpedienteFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168ExpedienteFecha", context.localUtil.Format(A168ExpedienteFecha, "99/99/99"));
               }
               A169ExpedienteHora = cgiGet( edtExpedienteHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169ExpedienteHora", A169ExpedienteHora);
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
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               A176ExpedienteObs = cgiGet( edtExpedienteObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176ExpedienteObs", A176ExpedienteObs);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z167ExpedienteId = (int)(context.localUtil.CToN( cgiGet( "Z167ExpedienteId"), ".", ",")) ;
               Z168ExpedienteFecha = context.localUtil.CToD( cgiGet( "Z168ExpedienteFecha"), 0) ;
               Z169ExpedienteHora = cgiGet( "Z169ExpedienteHora") ;
               Z176ExpedienteObs = cgiGet( "Z176ExpedienteObs") ;
               Z67PacienteId = (int)(context.localUtil.CToN( cgiGet( "Z67PacienteId"), ".", ",")) ;
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridexpediente_expedientedet = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridexpediente_expedientedet"), ".", ",")) ;
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
                  A167ExpedienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
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
               /* Check if conditions changed and reset current page numbers */
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
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
                        sEvtType = StringUtil.Right( sEvt, 4) ;
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
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
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1046( ) ;
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
         DisableAttributes1046( ) ;
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

      protected void CONFIRM_1047( )
      {
         nGXsfl_75_idx = 0 ;
         while ( nGXsfl_75_idx < nRC_Gridexpediente_expedientedet )
         {
            ReadRow1047( ) ;
            if ( ( nRcdExists_47 != 0 ) || ( nIsMod_47 != 0 ) )
            {
               GetKey1047( ) ;
               if ( ( nRcdExists_47 == 0 ) && ( nRcdDeleted_47 == 0 ) )
               {
                  if ( RcdFound47 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate1047( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1047( ) ;
                        CloseExtendedTableCursors1047( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1 ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtExpedienteLinea_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound47 != 0 )
                  {
                     if ( nRcdDeleted_47 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey1047( ) ;
                        Load1047( ) ;
                        BeforeValidate1047( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1047( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_47 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate1047( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1047( ) ;
                              CloseExtendedTableCursors1047( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1 ;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_47 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtExpedienteLinea_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtExpedienteLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A170ExpedienteLinea), 4, 0, ".", ""))) ;
            ChangePostValue( edtExpedienteArchivo_Internalname, StringUtil.RTrim( A171ExpedienteArchivo)) ;
            ChangePostValue( edtExpedienteDescripcion_Internalname, StringUtil.RTrim( A172ExpedienteDescripcion)) ;
            ChangePostValue( edtExpedienteFechaL_Internalname, context.localUtil.Format(A173ExpedienteFechaL, "99/99/99")) ;
            ChangePostValue( edtExpedienteHoraL_Internalname, StringUtil.RTrim( A174ExpedienteHoraL)) ;
            ChangePostValue( edtUsuarioCodigoL_Internalname, StringUtil.RTrim( A175UsuarioCodigoL)) ;
            ChangePostValue( "ZT_"+"Z170ExpedienteLinea_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z170ExpedienteLinea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z172ExpedienteDescripcion_"+sGXsfl_75_idx, StringUtil.RTrim( Z172ExpedienteDescripcion)) ;
            ChangePostValue( "ZT_"+"Z173ExpedienteFechaL_"+sGXsfl_75_idx, context.localUtil.DToC( Z173ExpedienteFechaL, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z174ExpedienteHoraL_"+sGXsfl_75_idx, StringUtil.RTrim( Z174ExpedienteHoraL)) ;
            ChangePostValue( "ZT_"+"Z175UsuarioCodigoL_"+sGXsfl_75_idx, StringUtil.RTrim( Z175UsuarioCodigoL)) ;
            ChangePostValue( "nRcdDeleted_47_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_47), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_47_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_47), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_47_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_47), 4, 0, ".", ""))) ;
            if ( nIsMod_47 != 0 )
            {
               ChangePostValue( "EXPEDIENTELINEA_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteLinea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteArchivo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteDescripcion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXPEDIENTEFECHAL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteFechaL_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXPEDIENTEHORAL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteHoraL_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "USUARIOCODIGOL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtUsuarioCodigoL_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption100( )
      {
      }

      protected void ZM1046( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z168ExpedienteFecha = T00105_A168ExpedienteFecha[0] ;
               Z169ExpedienteHora = T00105_A169ExpedienteHora[0] ;
               Z176ExpedienteObs = T00105_A176ExpedienteObs[0] ;
               Z67PacienteId = T00105_A67PacienteId[0] ;
               Z4UsuarioCodigo = T00105_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z168ExpedienteFecha = A168ExpedienteFecha ;
               Z169ExpedienteHora = A169ExpedienteHora ;
               Z176ExpedienteObs = A176ExpedienteObs ;
               Z67PacienteId = A67PacienteId ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z167ExpedienteId = A167ExpedienteId ;
            Z168ExpedienteFecha = A168ExpedienteFecha ;
            Z169ExpedienteHora = A169ExpedienteHora ;
            Z176ExpedienteObs = A176ExpedienteObs ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z67PacienteId = A67PacienteId ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_67_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00n0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"PACIENTEID"+"'), id:'"+"PACIENTEID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_4_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOCODIGO"+"'), id:'"+"USUARIOCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load1046( )
      {
         /* Using cursor T00108 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound46 = 1 ;
            A168ExpedienteFecha = T00108_A168ExpedienteFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168ExpedienteFecha", context.localUtil.Format(A168ExpedienteFecha, "99/99/99"));
            A169ExpedienteHora = T00108_A169ExpedienteHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169ExpedienteHora", A169ExpedienteHora);
            A176ExpedienteObs = T00108_A176ExpedienteObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176ExpedienteObs", A176ExpedienteObs);
            A67PacienteId = T00108_A67PacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            A4UsuarioCodigo = T00108_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM1046( -3) ;
         }
         pr_default.close(6);
         OnLoadActions1046( ) ;
      }

      protected void OnLoadActions1046( )
      {
      }

      protected void CheckExtendedTable1046( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00106 */
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
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A168ExpedienteFecha) || ( A168ExpedienteFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T00107 */
         pr_default.execute(5, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(5);
      }

      protected void CloseExtendedTableCursors1046( )
      {
         pr_default.close(4);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( String A41ClinicaCodigo ,
                               int A67PacienteId )
      {
         /* Using cursor T00109 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(7) == 101) )
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
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void gxLoad_5( String A4UsuarioCodigo )
      {
         /* Using cursor T001010 */
         pr_default.execute(8, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(8) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError4 == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void GetKey1046( )
      {
         /* Using cursor T001011 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound46 = 1 ;
         }
         else
         {
            RcdFound46 = 0 ;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00105 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM1046( 3) ;
            RcdFound46 = 1 ;
            A167ExpedienteId = T00105_A167ExpedienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
            A168ExpedienteFecha = T00105_A168ExpedienteFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168ExpedienteFecha", context.localUtil.Format(A168ExpedienteFecha, "99/99/99"));
            A169ExpedienteHora = T00105_A169ExpedienteHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169ExpedienteHora", A169ExpedienteHora);
            A176ExpedienteObs = T00105_A176ExpedienteObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176ExpedienteObs", A176ExpedienteObs);
            A41ClinicaCodigo = T00105_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A67PacienteId = T00105_A67PacienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
            A4UsuarioCodigo = T00105_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z167ExpedienteId = A167ExpedienteId ;
            sMode46 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1046( ) ;
            Gx_mode = sMode46 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound46 = 0 ;
            InitializeNonKey1046( ) ;
            sMode46 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode46 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey1046( ) ;
         if ( RcdFound46 == 0 )
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
         RcdFound46 = 0 ;
         /* Using cursor T001012 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T001012_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001012_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001012_A167ExpedienteId[0] < A167ExpedienteId ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T001012_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001012_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001012_A167ExpedienteId[0] > A167ExpedienteId ) ) )
            {
               A41ClinicaCodigo = T001012_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A167ExpedienteId = T001012_A167ExpedienteId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
               RcdFound46 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound46 = 0 ;
         /* Using cursor T001013 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T001013_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001013_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001013_A167ExpedienteId[0] > A167ExpedienteId ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T001013_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001013_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001013_A167ExpedienteId[0] < A167ExpedienteId ) ) )
            {
               A41ClinicaCodigo = T001013_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A167ExpedienteId = T001013_A167ExpedienteId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
               RcdFound46 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1046( ) ;
         if ( RcdFound46 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A167ExpedienteId != Z167ExpedienteId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A167ExpedienteId = Z167ExpedienteId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
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
               Update1046( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A167ExpedienteId != Z167ExpedienteId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1046( ) ;
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
                  Insert1046( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A167ExpedienteId != Z167ExpedienteId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A167ExpedienteId = Z167ExpedienteId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
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
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtExpedienteFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1046( ) ;
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtExpedienteFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1046( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtExpedienteFecha_Internalname ;
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
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtExpedienteFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1046( ) ;
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound46 != 0 )
            {
               ScanNext1046( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtExpedienteFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1046( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1046( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001014 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
            if ( (pr_default.getStatus(12) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Expediente"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(12) == 101) || ( Z168ExpedienteFecha != T001014_A168ExpedienteFecha[0] ) || ( StringUtil.StrCmp(Z169ExpedienteHora, T001014_A169ExpedienteHora[0]) != 0 ) || ( StringUtil.StrCmp(Z176ExpedienteObs, T001014_A176ExpedienteObs[0]) != 0 ) || ( Z67PacienteId != T001014_A67PacienteId[0] ) || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001014_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Expediente"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1046( )
      {
         BeforeValidate1046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1046( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1046( 0) ;
            CheckOptimisticConcurrency1046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001015 */
                     pr_default.execute(13, new Object[] {A167ExpedienteId, A168ExpedienteFecha, A169ExpedienteHora, A176ExpedienteObs, A41ClinicaCodigo, A67PacienteId, A4UsuarioCodigo});
                     pr_default.close(13);
                     if ( (pr_default.getStatus(13) == 1) )
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
                           ProcessLevel1046( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption100( ) ;
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
            else
            {
               Load1046( ) ;
            }
            EndLevel1046( ) ;
         }
         CloseExtendedTableCursors1046( ) ;
      }

      protected void Update1046( )
      {
         BeforeValidate1046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1046( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001016 */
                     pr_default.execute(14, new Object[] {A168ExpedienteFecha, A169ExpedienteHora, A176ExpedienteObs, A67PacienteId, A4UsuarioCodigo, A41ClinicaCodigo, A167ExpedienteId});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Expediente"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1046( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1046( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption100( ) ;
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
            EndLevel1046( ) ;
         }
         CloseExtendedTableCursors1046( ) ;
      }

      protected void DeferredUpdate1046( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1046( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1046( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1046( ) ;
            AfterConfirm1046( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1046( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart1047( ) ;
                  while ( RcdFound47 != 0 )
                  {
                     getByPrimaryKey1047( ) ;
                     Delete1047( ) ;
                     ScanNext1047( ) ;
                  }
                  ScanEnd1047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001017 */
                     pr_default.execute(15, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
                     pr_default.close(15);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound46 == 0 )
                           {
                              InitAll1046( ) ;
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
                           ResetCaption100( ) ;
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
         }
         sMode46 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1046( ) ;
         Gx_mode = sMode46 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1046( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel1047( )
      {
         nGXsfl_75_idx = 0 ;
         while ( nGXsfl_75_idx < nRC_Gridexpediente_expedientedet )
         {
            ReadRow1047( ) ;
            if ( ( nRcdExists_47 != 0 ) || ( nIsMod_47 != 0 ) )
            {
               standaloneNotModal1047( ) ;
               GetKey1047( ) ;
               if ( ( nRcdExists_47 == 0 ) && ( nRcdDeleted_47 == 0 ) )
               {
                  if ( RcdFound47 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert1047( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtExpedienteLinea_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound47 != 0 )
                  {
                     if ( ( nRcdDeleted_47 != 0 ) && ( nRcdExists_47 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete1047( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_47 != 0 ) && ( nRcdExists_47 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update1047( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_47 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtExpedienteLinea_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtExpedienteLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A170ExpedienteLinea), 4, 0, ".", ""))) ;
            ChangePostValue( edtExpedienteArchivo_Internalname, StringUtil.RTrim( A171ExpedienteArchivo)) ;
            ChangePostValue( edtExpedienteDescripcion_Internalname, StringUtil.RTrim( A172ExpedienteDescripcion)) ;
            ChangePostValue( edtExpedienteFechaL_Internalname, context.localUtil.Format(A173ExpedienteFechaL, "99/99/99")) ;
            ChangePostValue( edtExpedienteHoraL_Internalname, StringUtil.RTrim( A174ExpedienteHoraL)) ;
            ChangePostValue( edtUsuarioCodigoL_Internalname, StringUtil.RTrim( A175UsuarioCodigoL)) ;
            ChangePostValue( "ZT_"+"Z170ExpedienteLinea_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z170ExpedienteLinea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z172ExpedienteDescripcion_"+sGXsfl_75_idx, StringUtil.RTrim( Z172ExpedienteDescripcion)) ;
            ChangePostValue( "ZT_"+"Z173ExpedienteFechaL_"+sGXsfl_75_idx, context.localUtil.DToC( Z173ExpedienteFechaL, 0, "/")) ;
            ChangePostValue( "ZT_"+"Z174ExpedienteHoraL_"+sGXsfl_75_idx, StringUtil.RTrim( Z174ExpedienteHoraL)) ;
            ChangePostValue( "ZT_"+"Z175UsuarioCodigoL_"+sGXsfl_75_idx, StringUtil.RTrim( Z175UsuarioCodigoL)) ;
            ChangePostValue( "nRcdDeleted_47_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_47), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_47_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_47), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_47_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_47), 4, 0, ".", ""))) ;
            if ( nIsMod_47 != 0 )
            {
               ChangePostValue( "EXPEDIENTELINEA_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteLinea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteArchivo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteDescripcion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXPEDIENTEFECHAL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteFechaL_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "EXPEDIENTEHORAL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteHoraL_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "USUARIOCODIGOL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtUsuarioCodigoL_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1047( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_47 = 0 ;
         nIsMod_47 = 0 ;
         nRcdDeleted_47 = 0 ;
      }

      protected void ProcessLevel1046( )
      {
         /* Save parent mode. */
         sMode46 = Gx_mode ;
         ProcessNestedLevel1047( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode46 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel1046( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1046( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(11);
            pr_default.close(10);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("Expediente");
            if ( AnyError == 0 )
            {
               ConfirmValues100( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(11);
            pr_default.close(10);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("Expediente");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1046( )
      {
         /* Using cursor T001018 */
         pr_default.execute(16);
         RcdFound46 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound46 = 1 ;
            A41ClinicaCodigo = T001018_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A167ExpedienteId = T001018_A167ExpedienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1046( )
      {
         pr_default.readNext(16);
         RcdFound46 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound46 = 1 ;
            A41ClinicaCodigo = T001018_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A167ExpedienteId = T001018_A167ExpedienteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
         }
      }

      protected void ScanEnd1046( )
      {
      }

      protected void AfterConfirm1046( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1046( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1046( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1046( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1046( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1046( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1046( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtExpedienteId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExpedienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExpedienteId_Enabled), 5, 0)));
         edtExpedienteFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExpedienteFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExpedienteFecha_Enabled), 5, 0)));
         edtExpedienteHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExpedienteHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExpedienteHora_Enabled), 5, 0)));
         edtPacienteId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPacienteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPacienteId_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
         edtExpedienteObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtExpedienteObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtExpedienteObs_Enabled), 5, 0)));
      }

      protected void ZM1047( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z172ExpedienteDescripcion = T00103_A172ExpedienteDescripcion[0] ;
               Z173ExpedienteFechaL = T00103_A173ExpedienteFechaL[0] ;
               Z174ExpedienteHoraL = T00103_A174ExpedienteHoraL[0] ;
               Z175UsuarioCodigoL = T00103_A175UsuarioCodigoL[0] ;
            }
            else
            {
               Z172ExpedienteDescripcion = A172ExpedienteDescripcion ;
               Z173ExpedienteFechaL = A173ExpedienteFechaL ;
               Z174ExpedienteHoraL = A174ExpedienteHoraL ;
               Z175UsuarioCodigoL = A175UsuarioCodigoL ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z167ExpedienteId = A167ExpedienteId ;
            Z170ExpedienteLinea = A170ExpedienteLinea ;
            Z171ExpedienteArchivo = A171ExpedienteArchivo ;
            Z172ExpedienteDescripcion = A172ExpedienteDescripcion ;
            Z173ExpedienteFechaL = A173ExpedienteFechaL ;
            Z174ExpedienteHoraL = A174ExpedienteHoraL ;
            Z175UsuarioCodigoL = A175UsuarioCodigoL ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
         }
      }

      protected void standaloneNotModal1047( )
      {
      }

      protected void standaloneModal1047( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtExpedienteLinea_Enabled = 0 ;
         }
         else
         {
            edtExpedienteLinea_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode47, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode47, "DLT") == 0 ) )
         {
            DisableAttributes1047( ) ;
         }
      }

      protected void Load1047( )
      {
         /* Using cursor T001019 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo, A167ExpedienteId, A170ExpedienteLinea});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound47 = 1 ;
            A172ExpedienteDescripcion = T001019_A172ExpedienteDescripcion[0] ;
            A173ExpedienteFechaL = T001019_A173ExpedienteFechaL[0] ;
            A174ExpedienteHoraL = T001019_A174ExpedienteHoraL[0] ;
            A175UsuarioCodigoL = T001019_A175UsuarioCodigoL[0] ;
            A171ExpedienteArchivo = T001019_A171ExpedienteArchivo[0] ;
            ZM1047( -6) ;
         }
         pr_default.close(17);
         OnLoadActions1047( ) ;
      }

      protected void OnLoadActions1047( )
      {
      }

      protected void CheckExtendedTable1047( )
      {
         Gx_BScreen = 1 ;
         standaloneModal1047( ) ;
         if ( ! ( (DateTime.MinValue==A173ExpedienteFechaL) || ( A173ExpedienteFechaL >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1047( )
      {
      }

      protected void enableDisable1047( )
      {
      }

      protected void GetKey1047( )
      {
         /* Using cursor T001020 */
         pr_default.execute(18, new Object[] {A41ClinicaCodigo, A167ExpedienteId, A170ExpedienteLinea});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound47 = 1 ;
         }
         else
         {
            RcdFound47 = 0 ;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey1047( )
      {
         /* Using cursor T00103 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A167ExpedienteId, A170ExpedienteLinea});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1047( 6) ;
            RcdFound47 = 1 ;
            InitializeNonKey1047( ) ;
            A170ExpedienteLinea = T00103_A170ExpedienteLinea[0] ;
            A172ExpedienteDescripcion = T00103_A172ExpedienteDescripcion[0] ;
            A173ExpedienteFechaL = T00103_A173ExpedienteFechaL[0] ;
            A174ExpedienteHoraL = T00103_A174ExpedienteHoraL[0] ;
            A175UsuarioCodigoL = T00103_A175UsuarioCodigoL[0] ;
            A171ExpedienteArchivo = T00103_A171ExpedienteArchivo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z167ExpedienteId = A167ExpedienteId ;
            Z170ExpedienteLinea = A170ExpedienteLinea ;
            sMode47 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1047( ) ;
            Load1047( ) ;
            Gx_mode = sMode47 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound47 = 0 ;
            InitializeNonKey1047( ) ;
            sMode47 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1047( ) ;
            Gx_mode = sMode47 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1047( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00102 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A167ExpedienteId, A170ExpedienteLinea});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ExpedienteDet"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z172ExpedienteDescripcion, T00102_A172ExpedienteDescripcion[0]) != 0 ) || ( Z173ExpedienteFechaL != T00102_A173ExpedienteFechaL[0] ) || ( StringUtil.StrCmp(Z174ExpedienteHoraL, T00102_A174ExpedienteHoraL[0]) != 0 ) || ( StringUtil.StrCmp(Z175UsuarioCodigoL, T00102_A175UsuarioCodigoL[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ExpedienteDet"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1047( )
      {
         BeforeValidate1047( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1047( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1047( 0) ;
            CheckOptimisticConcurrency1047( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1047( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001021 */
                     pr_default.execute(19, new Object[] {A167ExpedienteId, A170ExpedienteLinea, A171ExpedienteArchivo, A172ExpedienteDescripcion, A173ExpedienteFechaL, A174ExpedienteHoraL, A175UsuarioCodigoL, A41ClinicaCodigo});
                     pr_default.close(19);
                     if ( (pr_default.getStatus(19) == 1) )
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
               Load1047( ) ;
            }
            EndLevel1047( ) ;
         }
         CloseExtendedTableCursors1047( ) ;
      }

      protected void Update1047( )
      {
         BeforeValidate1047( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1047( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1047( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1047( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1047( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001022 */
                     pr_default.execute(20, new Object[] {A172ExpedienteDescripcion, A173ExpedienteFechaL, A174ExpedienteHoraL, A175UsuarioCodigoL, A41ClinicaCodigo, A167ExpedienteId, A170ExpedienteLinea});
                     pr_default.close(20);
                     if ( (pr_default.getStatus(20) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ExpedienteDet"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1047( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1047( ) ;
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
            EndLevel1047( ) ;
         }
         CloseExtendedTableCursors1047( ) ;
      }

      protected void DeferredUpdate1047( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T001023 */
            pr_default.execute(21, new Object[] {A171ExpedienteArchivo, A41ClinicaCodigo, A167ExpedienteId, A170ExpedienteLinea});
            pr_default.close(21);
         }
      }

      protected void Delete1047( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1047( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1047( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1047( ) ;
            AfterConfirm1047( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1047( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001024 */
                  pr_default.execute(22, new Object[] {A41ClinicaCodigo, A167ExpedienteId, A170ExpedienteLinea});
                  pr_default.close(22);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode47 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1047( ) ;
         Gx_mode = sMode47 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1047( )
      {
         standaloneModal1047( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1047( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1047( )
      {
         /* Using cursor T001025 */
         pr_default.execute(23, new Object[] {A41ClinicaCodigo, A167ExpedienteId});
         RcdFound47 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound47 = 1 ;
            A170ExpedienteLinea = T001025_A170ExpedienteLinea[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1047( )
      {
         pr_default.readNext(23);
         RcdFound47 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound47 = 1 ;
            A170ExpedienteLinea = T001025_A170ExpedienteLinea[0] ;
         }
      }

      protected void ScanEnd1047( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm1047( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1047( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1047( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1047( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1047( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1047( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1047( )
      {
         edtExpedienteLinea_Enabled = 0 ;
         edtExpedienteArchivo_Enabled = 0 ;
         edtExpedienteDescripcion_Enabled = 0 ;
         edtExpedienteFechaL_Enabled = 0 ;
         edtExpedienteHoraL_Enabled = 0 ;
         edtUsuarioCodigoL_Enabled = 0 ;
      }

      protected void AddRow1047( )
      {
         nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtExpedienteLinea_Internalname = "EXPEDIENTELINEA_"+sGXsfl_75_idx ;
         edtExpedienteArchivo_Internalname = "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx ;
         edtExpedienteDescripcion_Internalname = "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx ;
         edtExpedienteFechaL_Internalname = "EXPEDIENTEFECHAL_"+sGXsfl_75_idx ;
         edtExpedienteHoraL_Internalname = "EXPEDIENTEHORAL_"+sGXsfl_75_idx ;
         edtUsuarioCodigoL_Internalname = "USUARIOCODIGOL_"+sGXsfl_75_idx ;
         SendRow1047( ) ;
      }

      protected void SendRow1047( )
      {
         Gridexpediente_expedientedetRow = GXWebRow.GetNew(context) ;
         if ( subGridexpediente_expedientedet_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridexpediente_expedientedet_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridexpediente_expedientedet_Class, "") != 0 )
            {
               subGridexpediente_expedientedet_Linesclass = subGridexpediente_expedientedet_Class+"Odd" ;
            }
         }
         else if ( subGridexpediente_expedientedet_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridexpediente_expedientedet_Backstyle = 0 ;
            subGridexpediente_expedientedet_Backcolor = subGridexpediente_expedientedet_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridexpediente_expedientedetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridexpediente_expedientedet_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridexpediente_expedientedet_Class, "") != 0 )
            {
               subGridexpediente_expedientedet_Linesclass = subGridexpediente_expedientedet_Class+"Uniform" ;
            }
         }
         else if ( subGridexpediente_expedientedet_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridexpediente_expedientedet_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridexpediente_expedientedet_Class, "") != 0 )
            {
               subGridexpediente_expedientedet_Linesclass = subGridexpediente_expedientedet_Class+"Odd" ;
            }
            subGridexpediente_expedientedet_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridexpediente_expedientedetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridexpediente_expedientedet_Backcolor), 9, 0)));
         }
         else if ( subGridexpediente_expedientedet_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridexpediente_expedientedet_Backstyle = 1 ;
            if ( ((int)(nGXsfl_75_idx) % (2)) == 0 )
            {
               subGridexpediente_expedientedet_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridexpediente_expedientedetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridexpediente_expedientedet_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridexpediente_expedientedet_Class, "") != 0 )
               {
                  subGridexpediente_expedientedet_Linesclass = subGridexpediente_expedientedet_Class+"Even" ;
               }
            }
            else
            {
               subGridexpediente_expedientedet_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridexpediente_expedientedetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridexpediente_expedientedet_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridexpediente_expedientedet_Class, "") != 0 )
               {
                  subGridexpediente_expedientedet_Linesclass = subGridexpediente_expedientedet_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_47_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridexpediente_expedientedetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A170ExpedienteLinea), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A170ExpedienteLinea), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(76);\"",(String)"",(String)"",(String)"",(String)"",(String)edtExpedienteLinea_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtExpedienteLinea_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)75,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         ClassString = "Image" ;
         StyleString = "" ;
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_47_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         edtExpedienteArchivo_Filetype = "JPG" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A171ExpedienteArchivo)) )
         {
            gxblobfileaux.Source = A171ExpedienteArchivo ;
            gxblobfileaux.SetExtension(StringUtil.Trim( edtExpedienteArchivo_Filetype));
            if ( gxblobfileaux.ErrCode == 0 )
            {
               A171ExpedienteArchivo = gxblobfileaux.GetAbsoluteName() ;
            }
         }
         Gridexpediente_expedientedetRow.AddColumnProperties("blob", 2, isAjaxCallMode( ), new Object[] {(String)edtExpedienteArchivo_Internalname,StringUtil.RTrim( A171ExpedienteArchivo),context.PathToRelativeUrl( A171ExpedienteArchivo),(String.IsNullOrEmpty(StringUtil.RTrim( edtExpedienteArchivo_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtExpedienteArchivo_Filetype)) ? A171ExpedienteArchivo : edtExpedienteArchivo_Filetype)) : edtExpedienteArchivo_Contenttype),(bool)false,(String)"",(String)edtExpedienteArchivo_Parameters,(short)0,(int)edtExpedienteArchivo_Enabled,(short)-1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)60,(String)"px",(short)0,(short)0,(short)0,(String)edtExpedienteArchivo_Jsonclick,(String)"",(String)StyleString,(String)ClassString,""+TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(77);\"",(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_47_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridexpediente_expedientedetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteDescripcion_Internalname,StringUtil.RTrim( A172ExpedienteDescripcion),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"",(String)"",(String)"",(String)"",(String)"",(String)edtExpedienteDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtExpedienteDescripcion_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)75,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_47_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridexpediente_expedientedetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteFechaL_Internalname,context.localUtil.Format(A173ExpedienteFechaL, "99/99/99"),context.localUtil.Format( A173ExpedienteFechaL, "99/99/99"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(79);\"",(String)"",(String)"",(String)"",(String)"",(String)edtExpedienteFechaL_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtExpedienteFechaL_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)75,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_47_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridexpediente_expedientedetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteHoraL_Internalname,StringUtil.RTrim( A174ExpedienteHoraL),StringUtil.RTrim( context.localUtil.Format( A174ExpedienteHoraL, "XXXXXXXX")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(80);\"",(String)"",(String)"",(String)"",(String)"",(String)edtExpedienteHoraL_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtExpedienteHoraL_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)75,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_47_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridexpediente_expedientedetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioCodigoL_Internalname,StringUtil.RTrim( A175UsuarioCodigoL),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(81);\"",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioCodigoL_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtUsuarioCodigoL_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)75,(short)1,(short)-1,(bool)true,(String)"left"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridexpediente_expedientedetRow);
         GXCCtl = "Z170ExpedienteLinea_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z170ExpedienteLinea), 4, 0, ".", "")));
         GXCCtl = "Z172ExpedienteDescripcion_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z172ExpedienteDescripcion));
         GXCCtl = "Z173ExpedienteFechaL_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, context.localUtil.DToC( Z173ExpedienteFechaL, 0, "/"));
         GXCCtl = "Z174ExpedienteHoraL_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z174ExpedienteHoraL));
         GXCCtl = "Z175UsuarioCodigoL_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z175UsuarioCodigoL));
         GXCCtl = "nRcdDeleted_47_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_47), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_47_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_47), 4, 0, ".", "")));
         GXCCtl = "nIsMod_47_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_47), 4, 0, ".", "")));
         GXCCtl = "gxBlobEXPEDIENTEARCHIVO_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( A171ExpedienteArchivo));
         GXCCtl = "EXPEDIENTEARCHIVO_Filename_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( edtExpedienteArchivo_Filename));
         GXCCtl = "EXPEDIENTEARCHIVO_Filetype_" + sGXsfl_75_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( edtExpedienteArchivo_Filetype));
         GxWebStd.gx_hidden_field( context, "EXPEDIENTELINEA_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteLinea_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteArchivo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteDescripcion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EXPEDIENTEFECHAL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteFechaL_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "EXPEDIENTEHORAL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtExpedienteHoraL_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "USUARIOCODIGOL_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtUsuarioCodigoL_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridexpediente_expedientedetContainer.AddRow(Gridexpediente_expedientedetRow);
      }

      protected void ReadRow1047( )
      {
         nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtExpedienteLinea_Internalname = "EXPEDIENTELINEA_"+sGXsfl_75_idx ;
         edtExpedienteArchivo_Internalname = "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx ;
         edtExpedienteDescripcion_Internalname = "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx ;
         edtExpedienteFechaL_Internalname = "EXPEDIENTEFECHAL_"+sGXsfl_75_idx ;
         edtExpedienteHoraL_Internalname = "EXPEDIENTEHORAL_"+sGXsfl_75_idx ;
         edtUsuarioCodigoL_Internalname = "USUARIOCODIGOL_"+sGXsfl_75_idx ;
         edtExpedienteLinea_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTELINEA_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
         edtExpedienteArchivo_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
         edtExpedienteDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
         edtExpedienteFechaL_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTEFECHAL_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
         edtExpedienteHoraL_Enabled = (int)(context.localUtil.CToN( cgiGet( "EXPEDIENTEHORAL_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
         edtUsuarioCodigoL_Enabled = (int)(context.localUtil.CToN( cgiGet( "USUARIOCODIGOL_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
         GXCCtl = "EXPEDIENTEARCHIVO_Filename_" + sGXsfl_75_idx ;
         edtExpedienteArchivo_Filename = cgiGet( GXCCtl) ;
         GXCCtl = "EXPEDIENTEARCHIVO_Filetype_" + sGXsfl_75_idx ;
         edtExpedienteArchivo_Filetype = cgiGet( GXCCtl) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtExpedienteLinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtExpedienteLinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "EXPEDIENTELINEA");
            AnyError = 1 ;
            GX_FocusControl = edtExpedienteLinea_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A170ExpedienteLinea = 0 ;
         }
         else
         {
            A170ExpedienteLinea = (short)(context.localUtil.CToN( cgiGet( edtExpedienteLinea_Internalname), ".", ",")) ;
         }
         A171ExpedienteArchivo = cgiGet( edtExpedienteArchivo_Internalname) ;
         A172ExpedienteDescripcion = cgiGet( edtExpedienteDescripcion_Internalname) ;
         if ( context.localUtil.VCDate( cgiGet( edtExpedienteFechaL_Internalname), 2) == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "EXPEDIENTEFECHAL");
            AnyError = 1 ;
            GX_FocusControl = edtExpedienteFechaL_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A173ExpedienteFechaL = DateTime.MinValue ;
         }
         else
         {
            A173ExpedienteFechaL = context.localUtil.CToD( cgiGet( edtExpedienteFechaL_Internalname), 2) ;
         }
         A174ExpedienteHoraL = cgiGet( edtExpedienteHoraL_Internalname) ;
         A175UsuarioCodigoL = cgiGet( edtUsuarioCodigoL_Internalname) ;
         GXCCtl = "Z170ExpedienteLinea_" + sGXsfl_75_idx ;
         Z170ExpedienteLinea = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z172ExpedienteDescripcion_" + sGXsfl_75_idx ;
         Z172ExpedienteDescripcion = cgiGet( GXCCtl) ;
         GXCCtl = "Z173ExpedienteFechaL_" + sGXsfl_75_idx ;
         Z173ExpedienteFechaL = context.localUtil.CToD( cgiGet( GXCCtl), 0) ;
         GXCCtl = "Z174ExpedienteHoraL_" + sGXsfl_75_idx ;
         Z174ExpedienteHoraL = cgiGet( GXCCtl) ;
         GXCCtl = "Z175UsuarioCodigoL_" + sGXsfl_75_idx ;
         Z175UsuarioCodigoL = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_47_" + sGXsfl_75_idx ;
         nRcdDeleted_47 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_47_" + sGXsfl_75_idx ;
         nRcdExists_47 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_47_" + sGXsfl_75_idx ;
         nIsMod_47 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         if ( ( nIsMod_47 == 1 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( A171ExpedienteArchivo)) )
         {
            edtExpedienteArchivo_Filename = (String)(CGIGetFileName(edtExpedienteArchivo_Internalname)) ;
            edtExpedienteArchivo_Filetype = (String)(CGIGetFileType(edtExpedienteArchivo_Internalname)) ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A171ExpedienteArchivo)) )
         {
            GXCCtl = "gxBlobEXPEDIENTEARCHIVO_" + sGXsfl_75_idx ;
            A171ExpedienteArchivo = cgiGet( GXCCtl) ;
         }
      }

      protected void assign_properties_default( )
      {
         defedtExpedienteLinea_Enabled = edtExpedienteLinea_Enabled ;
      }

      protected void ConfirmValues100( )
      {
         nGXsfl_75_idx = 0 ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtExpedienteLinea_Internalname = "EXPEDIENTELINEA_"+sGXsfl_75_idx ;
         edtExpedienteArchivo_Internalname = "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx ;
         edtExpedienteDescripcion_Internalname = "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx ;
         edtExpedienteFechaL_Internalname = "EXPEDIENTEFECHAL_"+sGXsfl_75_idx ;
         edtExpedienteHoraL_Internalname = "EXPEDIENTEHORAL_"+sGXsfl_75_idx ;
         edtUsuarioCodigoL_Internalname = "USUARIOCODIGOL_"+sGXsfl_75_idx ;
         while ( nGXsfl_75_idx < nRC_Gridexpediente_expedientedet )
         {
            nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
            sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
            edtExpedienteLinea_Internalname = "EXPEDIENTELINEA_"+sGXsfl_75_idx ;
            edtExpedienteArchivo_Internalname = "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx ;
            edtExpedienteDescripcion_Internalname = "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx ;
            edtExpedienteFechaL_Internalname = "EXPEDIENTEFECHAL_"+sGXsfl_75_idx ;
            edtExpedienteHoraL_Internalname = "EXPEDIENTEHORAL_"+sGXsfl_75_idx ;
            edtUsuarioCodigoL_Internalname = "USUARIOCODIGOL_"+sGXsfl_75_idx ;
            ChangePostValue( "Z170ExpedienteLinea_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z170ExpedienteLinea_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z170ExpedienteLinea_"+sGXsfl_75_idx) ;
            ChangePostValue( "Z172ExpedienteDescripcion_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z172ExpedienteDescripcion_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z172ExpedienteDescripcion_"+sGXsfl_75_idx) ;
            ChangePostValue( "Z173ExpedienteFechaL_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z173ExpedienteFechaL_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z173ExpedienteFechaL_"+sGXsfl_75_idx) ;
            ChangePostValue( "Z174ExpedienteHoraL_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z174ExpedienteHoraL_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z174ExpedienteHoraL_"+sGXsfl_75_idx) ;
            ChangePostValue( "Z175UsuarioCodigoL_"+sGXsfl_75_idx, cgiGet( "ZT_"+"Z175UsuarioCodigoL_"+sGXsfl_75_idx)) ;
            DeletePostValue( "ZT_"+"Z175UsuarioCodigoL_"+sGXsfl_75_idx) ;
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("expediente.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z167ExpedienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z167ExpedienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z168ExpedienteFecha", context.localUtil.DToC( Z168ExpedienteFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z169ExpedienteHora", StringUtil.RTrim( Z169ExpedienteHora));
         GxWebStd.gx_hidden_field( context, "Z176ExpedienteObs", StringUtil.RTrim( Z176ExpedienteObs));
         GxWebStd.gx_hidden_field( context, "Z67PacienteId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z67PacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridexpediente_expedientedet", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_75_idx), 4, 0, ".", "")));
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
         return "Expediente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Expediente Médico Físico" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("expediente.aspx")  ;
      }

      protected void InitializeNonKey1046( )
      {
         A168ExpedienteFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168ExpedienteFecha", context.localUtil.Format(A168ExpedienteFecha, "99/99/99"));
         A169ExpedienteHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169ExpedienteHora", A169ExpedienteHora);
         A67PacienteId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A67PacienteId), 9, 0)));
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         A176ExpedienteObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176ExpedienteObs", A176ExpedienteObs);
      }

      protected void InitAll1046( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A167ExpedienteId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167ExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A167ExpedienteId), 9, 0)));
         InitializeNonKey1046( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1047( )
      {
         A171ExpedienteArchivo = "" ;
         A172ExpedienteDescripcion = "" ;
         A173ExpedienteFechaL = DateTime.MinValue ;
         A174ExpedienteHoraL = "" ;
         A175UsuarioCodigoL = "" ;
      }

      protected void InitAll1047( )
      {
         A170ExpedienteLinea = 0 ;
         InitializeNonKey1047( ) ;
      }

      protected void StandaloneModalInsert1047( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1555937");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("expediente.js", "?1555937");
         /* End function include_jscripts */
      }

      protected void init_level_properties47( )
      {
         edtExpedienteLinea_Enabled = defedtExpedienteLinea_Enabled ;
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
         lblTextblockexpedienteid_Internalname = "TEXTBLOCKEXPEDIENTEID" ;
         edtExpedienteId_Internalname = "EXPEDIENTEID" ;
         lblTextblockexpedientefecha_Internalname = "TEXTBLOCKEXPEDIENTEFECHA" ;
         edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA" ;
         lblTextblockexpedientehora_Internalname = "TEXTBLOCKEXPEDIENTEHORA" ;
         edtExpedienteHora_Internalname = "EXPEDIENTEHORA" ;
         lblTextblockpacienteid_Internalname = "TEXTBLOCKPACIENTEID" ;
         edtPacienteId_Internalname = "PACIENTEID" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         lblTextblockexpedienteobs_Internalname = "TEXTBLOCKEXPEDIENTEOBS" ;
         edtExpedienteObs_Internalname = "EXPEDIENTEOBS" ;
         lblTitleexpedientedet_Internalname = "TITLEEXPEDIENTEDET" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_67_Internalname = "PROMPT_41_67" ;
         imgprompt_4_Internalname = "PROMPT_4" ;
         subGridexpediente_expedientedet_Internalname = "GRIDEXPEDIENTE_EXPEDIENTEDET" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Expediente Médico Físico" ;
         edtExpedienteArchivo_Filename = "" ;
         edtUsuarioCodigoL_Jsonclick = "" ;
         edtExpedienteHoraL_Jsonclick = "" ;
         edtExpedienteFechaL_Jsonclick = "" ;
         edtExpedienteDescripcion_Jsonclick = "" ;
         edtExpedienteArchivo_Jsonclick = "" ;
         edtExpedienteArchivo_Parameters = "" ;
         edtExpedienteArchivo_Contenttype = "" ;
         edtExpedienteArchivo_Filetype = "" ;
         edtExpedienteLinea_Jsonclick = "" ;
         subGridexpediente_expedientedet_Class = "Grid" ;
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
         subGridexpediente_expedientedet_Allowcollapsing = 0 ;
         edtUsuarioCodigoL_Enabled = 1 ;
         edtExpedienteHoraL_Enabled = 1 ;
         edtExpedienteFechaL_Enabled = 1 ;
         edtExpedienteDescripcion_Enabled = 1 ;
         edtExpedienteArchivo_Enabled = 1 ;
         edtExpedienteLinea_Enabled = 1 ;
         subGridexpediente_expedientedet_Backcolorstyle = 2 ;
         edtExpedienteObs_Enabled = 1 ;
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         imgprompt_41_67_Visible = 1 ;
         imgprompt_41_67_Link = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtPacienteId_Enabled = 1 ;
         edtExpedienteHora_Jsonclick = "" ;
         edtExpedienteHora_Enabled = 1 ;
         edtExpedienteFecha_Jsonclick = "" ;
         edtExpedienteFecha_Enabled = 1 ;
         edtExpedienteId_Jsonclick = "" ;
         edtExpedienteId_Enabled = 1 ;
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

      protected void gxnrGridexpediente_expedientedet_newrow( short nRC_Gridexpediente_expedientedet ,
                                                              short nGXsfl_75_idx ,
                                                              String sGXsfl_75_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtExpedienteLinea_Internalname = "EXPEDIENTELINEA_"+sGXsfl_75_idx ;
         edtExpedienteArchivo_Internalname = "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx ;
         edtExpedienteDescripcion_Internalname = "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx ;
         edtExpedienteFechaL_Internalname = "EXPEDIENTEFECHAL_"+sGXsfl_75_idx ;
         edtExpedienteHoraL_Internalname = "EXPEDIENTEHORAL_"+sGXsfl_75_idx ;
         edtUsuarioCodigoL_Internalname = "USUARIOCODIGOL_"+sGXsfl_75_idx ;
         while ( nGXsfl_75_idx <= nRC_Gridexpediente_expedientedet )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1047( ) ;
            standaloneModal1047( ) ;
            dynload_actions( ) ;
            SendRow1047( ) ;
            nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
            sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
            edtExpedienteLinea_Internalname = "EXPEDIENTELINEA_"+sGXsfl_75_idx ;
            edtExpedienteArchivo_Internalname = "EXPEDIENTEARCHIVO_"+sGXsfl_75_idx ;
            edtExpedienteDescripcion_Internalname = "EXPEDIENTEDESCRIPCION_"+sGXsfl_75_idx ;
            edtExpedienteFechaL_Internalname = "EXPEDIENTEFECHAL_"+sGXsfl_75_idx ;
            edtExpedienteHoraL_Internalname = "EXPEDIENTEHORAL_"+sGXsfl_75_idx ;
            edtUsuarioCodigoL_Internalname = "USUARIOCODIGOL_"+sGXsfl_75_idx ;
         }
         context.GX_webresponse.AddString(Gridexpediente_expedientedetContainer.ToJavascriptSource());
         /* End function gxnrGridexpediente_expedientedet_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtExpedienteFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Expedienteid( String GX_Parm1 ,
                                      int GX_Parm2 ,
                                      DateTime GX_Parm3 ,
                                      String GX_Parm4 ,
                                      String GX_Parm5 ,
                                      int GX_Parm6 ,
                                      String GX_Parm7 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A167ExpedienteId = GX_Parm2 ;
         A168ExpedienteFecha = GX_Parm3 ;
         A169ExpedienteHora = GX_Parm4 ;
         A176ExpedienteObs = GX_Parm5 ;
         A67PacienteId = GX_Parm6 ;
         A4UsuarioCodigo = GX_Parm7 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A168ExpedienteFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A169ExpedienteHora)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A176ExpedienteObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z167ExpedienteId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z168ExpedienteFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z169ExpedienteHora)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z67PacienteId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z176ExpedienteObs)));
         isValidOutput.Add((Object)(Gridexpediente_expedientedetContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Pacienteid( String GX_Parm1 ,
                                    int GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A67PacienteId = GX_Parm2 ;
         /* Using cursor T001026 */
         pr_default.execute(24, new Object[] {A41ClinicaCodigo, A67PacienteId});
         if ( (pr_default.getStatus(24) == 101) )
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
         pr_default.close(24);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Usuariocodigo( String GX_Parm1 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         /* Using cursor T001027 */
         pr_default.execute(25, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(25) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(25);
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
         pr_default.close(23);
         pr_default.close(16);
         pr_default.close(11);
         pr_default.close(10);
         pr_default.close(24);
         pr_default.close(25);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A4UsuarioCodigo = "" ;
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
         lblTextblockexpedienteid_Jsonclick = "" ;
         lblTextblockexpedientefecha_Jsonclick = "" ;
         A168ExpedienteFecha = DateTime.MinValue ;
         lblTextblockexpedientehora_Jsonclick = "" ;
         A169ExpedienteHora = "" ;
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         lblTextblockexpedienteobs_Jsonclick = "" ;
         A176ExpedienteObs = "" ;
         Gridexpediente_expedientedetContainer = new GXWebGrid( context);
         Gridexpediente_expedientedetColumn = new GXWebColumn();
         A171ExpedienteArchivo = "" ;
         A172ExpedienteDescripcion = "" ;
         A173ExpedienteFechaL = DateTime.MinValue ;
         A174ExpedienteHoraL = "" ;
         A175UsuarioCodigoL = "" ;
         Gx_mode = "" ;
         sMode47 = "" ;
         edtExpedienteLinea_Internalname = "" ;
         lblTitleexpedientedet_Jsonclick = "" ;
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
         Z168ExpedienteFecha = DateTime.MinValue ;
         Z169ExpedienteHora = "" ;
         Z176ExpedienteObs = "" ;
         Z4UsuarioCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtExpedienteArchivo_Internalname = "" ;
         edtExpedienteDescripcion_Internalname = "" ;
         edtExpedienteFechaL_Internalname = "" ;
         edtExpedienteHoraL_Internalname = "" ;
         edtUsuarioCodigoL_Internalname = "" ;
         Z172ExpedienteDescripcion = "" ;
         Z173ExpedienteFechaL = DateTime.MinValue ;
         Z174ExpedienteHoraL = "" ;
         Z175UsuarioCodigoL = "" ;
         T00108_A167ExpedienteId = new int[1] ;
         T00108_A168ExpedienteFecha = new DateTime[] {DateTime.MinValue} ;
         T00108_A169ExpedienteHora = new String[] {""} ;
         T00108_A176ExpedienteObs = new String[] {""} ;
         T00108_A41ClinicaCodigo = new String[] {""} ;
         T00108_A67PacienteId = new int[1] ;
         T00108_A4UsuarioCodigo = new String[] {""} ;
         T00106_A41ClinicaCodigo = new String[] {""} ;
         T00107_A4UsuarioCodigo = new String[] {""} ;
         T00109_A41ClinicaCodigo = new String[] {""} ;
         T001010_A4UsuarioCodigo = new String[] {""} ;
         T001011_A41ClinicaCodigo = new String[] {""} ;
         T001011_A167ExpedienteId = new int[1] ;
         T00105_A167ExpedienteId = new int[1] ;
         T00105_A168ExpedienteFecha = new DateTime[] {DateTime.MinValue} ;
         T00105_A169ExpedienteHora = new String[] {""} ;
         T00105_A176ExpedienteObs = new String[] {""} ;
         T00105_A41ClinicaCodigo = new String[] {""} ;
         T00105_A67PacienteId = new int[1] ;
         T00105_A4UsuarioCodigo = new String[] {""} ;
         sMode46 = "" ;
         T001012_A41ClinicaCodigo = new String[] {""} ;
         T001012_A167ExpedienteId = new int[1] ;
         T001013_A41ClinicaCodigo = new String[] {""} ;
         T001013_A167ExpedienteId = new int[1] ;
         T001014_A167ExpedienteId = new int[1] ;
         T001014_A168ExpedienteFecha = new DateTime[] {DateTime.MinValue} ;
         T001014_A169ExpedienteHora = new String[] {""} ;
         T001014_A176ExpedienteObs = new String[] {""} ;
         T001014_A41ClinicaCodigo = new String[] {""} ;
         T001014_A67PacienteId = new int[1] ;
         T001014_A4UsuarioCodigo = new String[] {""} ;
         T001018_A41ClinicaCodigo = new String[] {""} ;
         T001018_A167ExpedienteId = new int[1] ;
         Z171ExpedienteArchivo = "" ;
         T001019_A167ExpedienteId = new int[1] ;
         T001019_A170ExpedienteLinea = new short[1] ;
         T001019_A172ExpedienteDescripcion = new String[] {""} ;
         T001019_A173ExpedienteFechaL = new DateTime[] {DateTime.MinValue} ;
         T001019_A174ExpedienteHoraL = new String[] {""} ;
         T001019_A175UsuarioCodigoL = new String[] {""} ;
         T001019_A41ClinicaCodigo = new String[] {""} ;
         T001019_A171ExpedienteArchivo = new String[] {""} ;
         T001020_A41ClinicaCodigo = new String[] {""} ;
         T001020_A167ExpedienteId = new int[1] ;
         T001020_A170ExpedienteLinea = new short[1] ;
         T00103_A167ExpedienteId = new int[1] ;
         T00103_A170ExpedienteLinea = new short[1] ;
         T00103_A172ExpedienteDescripcion = new String[] {""} ;
         T00103_A173ExpedienteFechaL = new DateTime[] {DateTime.MinValue} ;
         T00103_A174ExpedienteHoraL = new String[] {""} ;
         T00103_A175UsuarioCodigoL = new String[] {""} ;
         T00103_A41ClinicaCodigo = new String[] {""} ;
         T00103_A171ExpedienteArchivo = new String[] {""} ;
         T00102_A167ExpedienteId = new int[1] ;
         T00102_A170ExpedienteLinea = new short[1] ;
         T00102_A172ExpedienteDescripcion = new String[] {""} ;
         T00102_A173ExpedienteFechaL = new DateTime[] {DateTime.MinValue} ;
         T00102_A174ExpedienteHoraL = new String[] {""} ;
         T00102_A175UsuarioCodigoL = new String[] {""} ;
         T00102_A41ClinicaCodigo = new String[] {""} ;
         T00102_A171ExpedienteArchivo = new String[] {""} ;
         T001025_A41ClinicaCodigo = new String[] {""} ;
         T001025_A167ExpedienteId = new int[1] ;
         T001025_A170ExpedienteLinea = new short[1] ;
         Gridexpediente_expedientedetRow = new GXWebRow();
         subGridexpediente_expedientedet_Linesclass = "" ;
         ROClassString = "" ;
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         GXCCtl = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char15 = "" ;
         GXt_char14 = "" ;
         GXt_char16 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         T001026_A41ClinicaCodigo = new String[] {""} ;
         T001027_A4UsuarioCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.expediente__default(),
            new Object[][] {
                new Object[] {
               T00102_A167ExpedienteId, T00102_A170ExpedienteLinea, T00102_A172ExpedienteDescripcion, T00102_A173ExpedienteFechaL, T00102_A174ExpedienteHoraL, T00102_A175UsuarioCodigoL, T00102_A41ClinicaCodigo, T00102_A171ExpedienteArchivo
               }
               , new Object[] {
               T00103_A167ExpedienteId, T00103_A170ExpedienteLinea, T00103_A172ExpedienteDescripcion, T00103_A173ExpedienteFechaL, T00103_A174ExpedienteHoraL, T00103_A175UsuarioCodigoL, T00103_A41ClinicaCodigo, T00103_A171ExpedienteArchivo
               }
               , new Object[] {
               T00104_A167ExpedienteId, T00104_A168ExpedienteFecha, T00104_A169ExpedienteHora, T00104_A176ExpedienteObs, T00104_A41ClinicaCodigo, T00104_A67PacienteId, T00104_A4UsuarioCodigo
               }
               , new Object[] {
               T00105_A167ExpedienteId, T00105_A168ExpedienteFecha, T00105_A169ExpedienteHora, T00105_A176ExpedienteObs, T00105_A41ClinicaCodigo, T00105_A67PacienteId, T00105_A4UsuarioCodigo
               }
               , new Object[] {
               T00106_A41ClinicaCodigo
               }
               , new Object[] {
               T00107_A4UsuarioCodigo
               }
               , new Object[] {
               T00108_A167ExpedienteId, T00108_A168ExpedienteFecha, T00108_A169ExpedienteHora, T00108_A176ExpedienteObs, T00108_A41ClinicaCodigo, T00108_A67PacienteId, T00108_A4UsuarioCodigo
               }
               , new Object[] {
               T00109_A41ClinicaCodigo
               }
               , new Object[] {
               T001010_A4UsuarioCodigo
               }
               , new Object[] {
               T001011_A41ClinicaCodigo, T001011_A167ExpedienteId
               }
               , new Object[] {
               T001012_A41ClinicaCodigo, T001012_A167ExpedienteId
               }
               , new Object[] {
               T001013_A41ClinicaCodigo, T001013_A167ExpedienteId
               }
               , new Object[] {
               T001014_A167ExpedienteId, T001014_A168ExpedienteFecha, T001014_A169ExpedienteHora, T001014_A176ExpedienteObs, T001014_A41ClinicaCodigo, T001014_A67PacienteId, T001014_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001018_A41ClinicaCodigo, T001018_A167ExpedienteId
               }
               , new Object[] {
               T001019_A167ExpedienteId, T001019_A170ExpedienteLinea, T001019_A172ExpedienteDescripcion, T001019_A173ExpedienteFechaL, T001019_A174ExpedienteHoraL, T001019_A175UsuarioCodigoL, T001019_A41ClinicaCodigo, T001019_A171ExpedienteArchivo
               }
               , new Object[] {
               T001020_A41ClinicaCodigo, T001020_A167ExpedienteId, T001020_A170ExpedienteLinea
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001025_A41ClinicaCodigo, T001025_A167ExpedienteId, T001025_A170ExpedienteLinea
               }
               , new Object[] {
               T001026_A41ClinicaCodigo
               }
               , new Object[] {
               T001027_A4UsuarioCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridexpediente_expedientedet ;
      private short nGXsfl_75_idx=1 ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridexpediente_expedientedet_Backcolorstyle ;
      private short A170ExpedienteLinea ;
      private short subGridexpediente_expedientedet_Allowcollapsing ;
      private short subGridexpediente_expedientedet_Collapsed ;
      private short nBlankRcdCount47 ;
      private short nRcdExists_47 ;
      private short RcdFound47 ;
      private short nIsMod_47 ;
      private short nBlankRcdUsr47 ;
      private short nRcdDeleted_47 ;
      private short Z170ExpedienteLinea ;
      private short GX_JID ;
      private short RcdFound46 ;
      private short Gx_BScreen ;
      private short subGridexpediente_expedientedet_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A67PacienteId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int A167ExpedienteId ;
      private int edtExpedienteId_Enabled ;
      private int edtExpedienteFecha_Enabled ;
      private int edtExpedienteHora_Enabled ;
      private int edtPacienteId_Enabled ;
      private int imgprompt_41_67_Visible ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtExpedienteObs_Enabled ;
      private int edtExpedienteLinea_Enabled ;
      private int edtExpedienteArchivo_Enabled ;
      private int edtExpedienteDescripcion_Enabled ;
      private int edtExpedienteFechaL_Enabled ;
      private int edtExpedienteHoraL_Enabled ;
      private int edtUsuarioCodigoL_Enabled ;
      private int fRowAdded ;
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
      private int Z167ExpedienteId ;
      private int Z67PacienteId ;
      private int GRIDEXPEDIENTE_EXPEDIENTEDET_nFirstRecordOnPage ;
      private int AnyError41 ;
      private int AnyError67 ;
      private int AnyError4 ;
      private int subGridexpediente_expedientedet_Backcolor ;
      private int subGridexpediente_expedientedet_Allbackcolor ;
      private int defedtExpedienteLinea_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_75_idx="0001" ;
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
      private String lblTextblockexpedienteid_Internalname ;
      private String lblTextblockexpedienteid_Jsonclick ;
      private String edtExpedienteId_Internalname ;
      private String edtExpedienteId_Jsonclick ;
      private String lblTextblockexpedientefecha_Internalname ;
      private String lblTextblockexpedientefecha_Jsonclick ;
      private String edtExpedienteFecha_Internalname ;
      private String edtExpedienteFecha_Jsonclick ;
      private String lblTextblockexpedientehora_Internalname ;
      private String lblTextblockexpedientehora_Jsonclick ;
      private String A169ExpedienteHora ;
      private String edtExpedienteHora_Internalname ;
      private String edtExpedienteHora_Jsonclick ;
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtPacienteId_Internalname ;
      private String edtPacienteId_Jsonclick ;
      private String imgprompt_41_67_Internalname ;
      private String imgprompt_41_67_Link ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String lblTextblockexpedienteobs_Internalname ;
      private String lblTextblockexpedienteobs_Jsonclick ;
      private String edtExpedienteObs_Internalname ;
      private String A174ExpedienteHoraL ;
      private String Gx_mode ;
      private String sMode47 ;
      private String edtExpedienteLinea_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitleexpedientedet_Internalname ;
      private String lblTitleexpedientedet_Jsonclick ;
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
      private String Z169ExpedienteHora ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtExpedienteArchivo_Internalname ;
      private String edtExpedienteDescripcion_Internalname ;
      private String edtExpedienteFechaL_Internalname ;
      private String edtExpedienteHoraL_Internalname ;
      private String edtUsuarioCodigoL_Internalname ;
      private String Z174ExpedienteHoraL ;
      private String sMode46 ;
      private String subGridexpediente_expedientedet_Class ;
      private String subGridexpediente_expedientedet_Linesclass ;
      private String ROClassString ;
      private String edtExpedienteLinea_Jsonclick ;
      private String edtExpedienteArchivo_Filetype ;
      private String edtExpedienteArchivo_Contenttype ;
      private String edtExpedienteArchivo_Parameters ;
      private String edtExpedienteArchivo_Jsonclick ;
      private String edtExpedienteDescripcion_Jsonclick ;
      private String edtExpedienteFechaL_Jsonclick ;
      private String edtExpedienteHoraL_Jsonclick ;
      private String edtUsuarioCodigoL_Jsonclick ;
      private String GXCCtl ;
      private String edtExpedienteArchivo_Filename ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char15 ;
      private String GXt_char14 ;
      private String subGridexpediente_expedientedet_Internalname ;
      private String GXt_char16 ;
      private DateTime A168ExpedienteFecha ;
      private DateTime A173ExpedienteFechaL ;
      private DateTime Z168ExpedienteFecha ;
      private DateTime Z173ExpedienteFechaL ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A4UsuarioCodigo ;
      private String A176ExpedienteObs ;
      private String A172ExpedienteDescripcion ;
      private String A175UsuarioCodigoL ;
      private String Z41ClinicaCodigo ;
      private String Z176ExpedienteObs ;
      private String Z4UsuarioCodigo ;
      private String Z172ExpedienteDescripcion ;
      private String Z175UsuarioCodigoL ;
      private String A171ExpedienteArchivo ;
      private String Z171ExpedienteArchivo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GxFile gxblobfileaux ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridexpediente_expedientedetContainer ;
      private GXWebRow Gridexpediente_expedientedetRow ;
      private GXWebColumn Gridexpediente_expedientedetColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00108_A167ExpedienteId ;
      private DateTime[] T00108_A168ExpedienteFecha ;
      private String[] T00108_A169ExpedienteHora ;
      private String[] T00108_A176ExpedienteObs ;
      private String[] T00108_A41ClinicaCodigo ;
      private int[] T00108_A67PacienteId ;
      private String[] T00108_A4UsuarioCodigo ;
      private String[] T00106_A41ClinicaCodigo ;
      private String[] T00107_A4UsuarioCodigo ;
      private String[] T00109_A41ClinicaCodigo ;
      private String[] T001010_A4UsuarioCodigo ;
      private String[] T001011_A41ClinicaCodigo ;
      private int[] T001011_A167ExpedienteId ;
      private int[] T00105_A167ExpedienteId ;
      private DateTime[] T00105_A168ExpedienteFecha ;
      private String[] T00105_A169ExpedienteHora ;
      private String[] T00105_A176ExpedienteObs ;
      private String[] T00105_A41ClinicaCodigo ;
      private int[] T00105_A67PacienteId ;
      private String[] T00105_A4UsuarioCodigo ;
      private String[] T001012_A41ClinicaCodigo ;
      private int[] T001012_A167ExpedienteId ;
      private String[] T001013_A41ClinicaCodigo ;
      private int[] T001013_A167ExpedienteId ;
      private int[] T001014_A167ExpedienteId ;
      private DateTime[] T001014_A168ExpedienteFecha ;
      private String[] T001014_A169ExpedienteHora ;
      private String[] T001014_A176ExpedienteObs ;
      private String[] T001014_A41ClinicaCodigo ;
      private int[] T001014_A67PacienteId ;
      private String[] T001014_A4UsuarioCodigo ;
      private String[] T001018_A41ClinicaCodigo ;
      private int[] T001018_A167ExpedienteId ;
      private int[] T001019_A167ExpedienteId ;
      private short[] T001019_A170ExpedienteLinea ;
      private String[] T001019_A172ExpedienteDescripcion ;
      private DateTime[] T001019_A173ExpedienteFechaL ;
      private String[] T001019_A174ExpedienteHoraL ;
      private String[] T001019_A175UsuarioCodigoL ;
      private String[] T001019_A41ClinicaCodigo ;
      private String[] T001019_A171ExpedienteArchivo ;
      private String[] T001020_A41ClinicaCodigo ;
      private int[] T001020_A167ExpedienteId ;
      private short[] T001020_A170ExpedienteLinea ;
      private int[] T00103_A167ExpedienteId ;
      private short[] T00103_A170ExpedienteLinea ;
      private String[] T00103_A172ExpedienteDescripcion ;
      private DateTime[] T00103_A173ExpedienteFechaL ;
      private String[] T00103_A174ExpedienteHoraL ;
      private String[] T00103_A175UsuarioCodigoL ;
      private String[] T00103_A41ClinicaCodigo ;
      private String[] T00103_A171ExpedienteArchivo ;
      private int[] T00102_A167ExpedienteId ;
      private short[] T00102_A170ExpedienteLinea ;
      private String[] T00102_A172ExpedienteDescripcion ;
      private DateTime[] T00102_A173ExpedienteFechaL ;
      private String[] T00102_A174ExpedienteHoraL ;
      private String[] T00102_A175UsuarioCodigoL ;
      private String[] T00102_A41ClinicaCodigo ;
      private String[] T00102_A171ExpedienteArchivo ;
      private String[] T001025_A41ClinicaCodigo ;
      private int[] T001025_A167ExpedienteId ;
      private short[] T001025_A170ExpedienteLinea ;
      private String[] T001026_A41ClinicaCodigo ;
      private String[] T001027_A4UsuarioCodigo ;
      private int[] T00104_A167ExpedienteId ;
      private DateTime[] T00104_A168ExpedienteFecha ;
      private String[] T00104_A169ExpedienteHora ;
      private String[] T00104_A176ExpedienteObs ;
      private String[] T00104_A41ClinicaCodigo ;
      private int[] T00104_A67PacienteId ;
      private String[] T00104_A4UsuarioCodigo ;
      private GXWebForm Form ;
   }

   public class expediente__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new UpdateCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00104 ;
          prmT00104 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00108 ;
          prmT00108 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00106 ;
          prmT00106 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00107 ;
          prmT00107 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00109 ;
          prmT00109 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001010 ;
          prmT001010 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001011 ;
          prmT001011 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00105 ;
          prmT00105 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001012 ;
          prmT001012 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001013 ;
          prmT001013 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001014 ;
          prmT001014 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001015 ;
          prmT001015 = new Object[] {
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExpedienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@ExpedienteObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001016 ;
          prmT001016 = new Object[] {
          new Object[] {"@ExpedienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExpedienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@ExpedienteObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001017 ;
          prmT001017 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001018 ;
          prmT001018 = new Object[] {
          } ;
          Object[] prmT001019 ;
          prmT001019 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001020 ;
          prmT001020 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00103 ;
          prmT00103 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00102 ;
          prmT00102 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001021 ;
          prmT001021 = new Object[] {
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExpedienteArchivo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ExpedienteDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ExpedienteFechaL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExpedienteHoraL",SqlDbType.Char,8,0} ,
          new Object[] {"@UsuarioCodigoL",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001022 ;
          prmT001022 = new Object[] {
          new Object[] {"@ExpedienteDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ExpedienteFechaL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExpedienteHoraL",SqlDbType.Char,8,0} ,
          new Object[] {"@UsuarioCodigoL",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001023 ;
          prmT001023 = new Object[] {
          new Object[] {"@ExpedienteArchivo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001024 ;
          prmT001024 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001025 ;
          prmT001025 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001026 ;
          prmT001026 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001027 ;
          prmT001027 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00102", "SELECT [ExpedienteId], [ExpedienteLinea], [ExpedienteDescripcion], [ExpedienteFechaL], [ExpedienteHoraL], [UsuarioCodigoL], [ClinicaCodigo], [ExpedienteArchivo] FROM [ExpedienteDet] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId AND [ExpedienteLinea] = @ExpedienteLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00102,1,0,true,false )
             ,new CursorDef("T00103", "SELECT [ExpedienteId], [ExpedienteLinea], [ExpedienteDescripcion], [ExpedienteFechaL], [ExpedienteHoraL], [UsuarioCodigoL], [ClinicaCodigo], [ExpedienteArchivo] FROM [ExpedienteDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId AND [ExpedienteLinea] = @ExpedienteLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00103,1,0,true,false )
             ,new CursorDef("T00104", "SELECT [ExpedienteId], [ExpedienteFecha], [ExpedienteHora], [ExpedienteObs], [ClinicaCodigo], [PacienteId], [UsuarioCodigo] FROM [Expediente] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00104,1,0,true,false )
             ,new CursorDef("T00105", "SELECT [ExpedienteId], [ExpedienteFecha], [ExpedienteHora], [ExpedienteObs], [ClinicaCodigo], [PacienteId], [UsuarioCodigo] FROM [Expediente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00105,1,0,true,false )
             ,new CursorDef("T00106", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00106,1,0,true,false )
             ,new CursorDef("T00107", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00107,1,0,true,false )
             ,new CursorDef("T00108", "SELECT TM1.[ExpedienteId], TM1.[ExpedienteFecha], TM1.[ExpedienteHora], TM1.[ExpedienteObs], TM1.[ClinicaCodigo], TM1.[PacienteId], TM1.[UsuarioCodigo] FROM [Expediente] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[ExpedienteId] = @ExpedienteId ORDER BY TM1.[ClinicaCodigo], TM1.[ExpedienteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00108,100,0,true,false )
             ,new CursorDef("T00109", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00109,1,0,true,false )
             ,new CursorDef("T001010", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001010,1,0,true,false )
             ,new CursorDef("T001011", "SELECT [ClinicaCodigo], [ExpedienteId] FROM [Expediente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001011,1,0,true,false )
             ,new CursorDef("T001012", "SELECT TOP 1 [ClinicaCodigo], [ExpedienteId] FROM [Expediente] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ExpedienteId] > @ExpedienteId) ORDER BY [ClinicaCodigo], [ExpedienteId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001012,1,0,true,true )
             ,new CursorDef("T001013", "SELECT TOP 1 [ClinicaCodigo], [ExpedienteId] FROM [Expediente] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ExpedienteId] < @ExpedienteId) ORDER BY [ClinicaCodigo] DESC, [ExpedienteId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001013,1,0,true,true )
             ,new CursorDef("T001014", "SELECT [ExpedienteId], [ExpedienteFecha], [ExpedienteHora], [ExpedienteObs], [ClinicaCodigo], [PacienteId], [UsuarioCodigo] FROM [Expediente] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001014,1,0,true,false )
             ,new CursorDef("T001015", "INSERT INTO [Expediente] ([ExpedienteId], [ExpedienteFecha], [ExpedienteHora], [ExpedienteObs], [ClinicaCodigo], [PacienteId], [UsuarioCodigo]) VALUES (@ExpedienteId, @ExpedienteFecha, @ExpedienteHora, @ExpedienteObs, @ClinicaCodigo, @PacienteId, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001015)
             ,new CursorDef("T001016", "UPDATE [Expediente] SET [ExpedienteFecha]=@ExpedienteFecha, [ExpedienteHora]=@ExpedienteHora, [ExpedienteObs]=@ExpedienteObs, [PacienteId]=@PacienteId, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId", GxErrorMask.GX_NOMASK,prmT001016)
             ,new CursorDef("T001017", "DELETE FROM [Expediente]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId", GxErrorMask.GX_NOMASK,prmT001017)
             ,new CursorDef("T001018", "SELECT [ClinicaCodigo], [ExpedienteId] FROM [Expediente] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [ExpedienteId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001018,100,0,true,false )
             ,new CursorDef("T001019", "SELECT [ExpedienteId], [ExpedienteLinea], [ExpedienteDescripcion], [ExpedienteFechaL], [ExpedienteHoraL], [UsuarioCodigoL], [ClinicaCodigo], [ExpedienteArchivo] FROM [ExpedienteDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ExpedienteId] = @ExpedienteId and [ExpedienteLinea] = @ExpedienteLinea ORDER BY [ClinicaCodigo], [ExpedienteId], [ExpedienteLinea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001019,1,0,true,false )
             ,new CursorDef("T001020", "SELECT [ClinicaCodigo], [ExpedienteId], [ExpedienteLinea] FROM [ExpedienteDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId AND [ExpedienteLinea] = @ExpedienteLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001020,1,0,true,false )
             ,new CursorDef("T001021", "INSERT INTO [ExpedienteDet] ([ExpedienteId], [ExpedienteLinea], [ExpedienteArchivo], [ExpedienteDescripcion], [ExpedienteFechaL], [ExpedienteHoraL], [UsuarioCodigoL], [ClinicaCodigo]) VALUES (@ExpedienteId, @ExpedienteLinea, @ExpedienteArchivo, @ExpedienteDescripcion, @ExpedienteFechaL, @ExpedienteHoraL, @UsuarioCodigoL, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT001021)
             ,new CursorDef("T001022", "UPDATE [ExpedienteDet] SET [ExpedienteDescripcion]=@ExpedienteDescripcion, [ExpedienteFechaL]=@ExpedienteFechaL, [ExpedienteHoraL]=@ExpedienteHoraL, [UsuarioCodigoL]=@UsuarioCodigoL  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId AND [ExpedienteLinea] = @ExpedienteLinea", GxErrorMask.GX_NOMASK,prmT001022)
             ,new CursorDef("T001023", "UPDATE [ExpedienteDet] SET [ExpedienteArchivo]=@ExpedienteArchivo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId AND [ExpedienteLinea] = @ExpedienteLinea", GxErrorMask.GX_NOMASK,prmT001023)
             ,new CursorDef("T001024", "DELETE FROM [ExpedienteDet]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ExpedienteId] = @ExpedienteId AND [ExpedienteLinea] = @ExpedienteLinea", GxErrorMask.GX_NOMASK,prmT001024)
             ,new CursorDef("T001025", "SELECT [ClinicaCodigo], [ExpedienteId], [ExpedienteLinea] FROM [ExpedienteDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ExpedienteId] = @ExpedienteId ORDER BY [ClinicaCodigo], [ExpedienteId], [ExpedienteLinea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001025,11,0,true,false )
             ,new CursorDef("T001026", "SELECT [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [PacienteId] = @PacienteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001026,1,0,true,false )
             ,new CursorDef("T001027", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001027,1,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 8) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getBLOBFile(8, "JPG", "") ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 8) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getBLOBFile(8, "JPG", "") ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 8) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getBLOBFile(8, "JPG", "") ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 25 :
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 14 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 19 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
