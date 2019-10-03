/*
               File: MovimientoReversado
        Description: Movimiento Contable Reversado
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:59.8
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
   public class movimientoreversado : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A193CtaContableCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_4( A41ClinicaCodigo, A193CtaContableCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo, A199TipoParCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A4UsuarioCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_6( A4UsuarioCodigo) ;
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
         Form.Meta.addItem("Description", "Movimiento Contable Reversado", 0) ;
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

      public movimientoreversado( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public movimientoreversado( IGxContext context )
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
            wb_table1_2_1I70( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1I70e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1I70( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1I70( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1I70e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Movimiento Contable Reversado"+"</legend>") ;
            wb_table3_27_1I70( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1I70e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1I70e( true) ;
         }
         else
         {
            wb_table1_2_1I70e( false) ;
         }
      }

      protected void wb_table3_27_1I70( bool wbgen )
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
            wb_table4_33_1I70( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1I70e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoReversado.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoReversado.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1I70e( true) ;
         }
         else
         {
            wb_table3_27_1I70e( false) ;
         }
      }

      protected void wb_table4_33_1I70( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparcodigo_Internalname, "Tipo_Partida", "", "", lblTextblocktipoparcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoParCodigo_Internalname, StringUtil.RTrim( A199TipoParCodigo), StringUtil.RTrim( context.localUtil.Format( A199TipoParCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtTipoParCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoParCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoReversado.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_199_Internalname, "prompt.gif", imgprompt_41_199_Link, "", "", "Fantastic", imgprompt_41_199_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadoid_Internalname, "Id", "", "", lblTextblockmovreversadoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A290MovReversadoId), 9, 0, ".", "")), ((edtMovReversadoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A290MovReversadoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A290MovReversadoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtMovReversadoId_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadolinea_Internalname, "Linea", "", "", lblTextblockmovreversadolinea_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A291MovReversadoLinea), 4, 0, ".", "")), ((edtMovReversadoLinea_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A291MovReversadoLinea), "ZZZ9")) : context.localUtil.Format( (decimal)(A291MovReversadoLinea), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(53);\"", "", "", "", "", edtMovReversadoLinea_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoLinea_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadofecha_Internalname, "Fecha", "", "", lblTextblockmovreversadofecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292MovReversadoFecha", context.localUtil.Format(A292MovReversadoFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtMovReversadoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoFecha_Internalname, context.localUtil.Format(A292MovReversadoFecha, "99/99/99"), context.localUtil.Format( A292MovReversadoFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(58);\"", "", "", "", "", edtMovReversadoFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoReversado.htm");
            GxWebStd.gx_bitmap( context, edtMovReversadoFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtMovReversadoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_MovimientoReversado.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadohora_Internalname, "Hora", "", "", lblTextblockmovreversadohora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293MovReversadoHora", A293MovReversadoHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoHora_Internalname, StringUtil.RTrim( A293MovReversadoHora), StringUtil.RTrim( context.localUtil.Format( A293MovReversadoHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtMovReversadoHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadoobs_Internalname, "Observaciones", "", "", lblTextblockmovreversadoobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294MovReversadoObs", A294MovReversadoObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtMovReversadoObs_Internalname, StringUtil.RTrim( A294MovReversadoObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, 1, edtMovReversadoObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadoreferencia_Internalname, "Referencia", "", "", lblTextblockmovreversadoreferencia_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295MovReversadoReferencia", A295MovReversadoReferencia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoReferencia_Internalname, StringUtil.RTrim( A295MovReversadoReferencia), StringUtil.RTrim( context.localUtil.Format( A295MovReversadoReferencia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", "", "", "", edtMovReversadoReferencia_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoReferencia_Enabled, 0, 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablecodigo_Internalname, "Cta_Contable", "", "", lblTextblockctacontablecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCtaContableCodigo_Internalname, StringUtil.RTrim( A193CtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( A193CtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", "", "", "", edtCtaContableCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCtaContableCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoReversado.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_193_Internalname, "prompt.gif", imgprompt_41_193_Link, "", "", "Fantastic", imgprompt_41_193_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadodebe_Internalname, "Debe", "", "", lblTextblockmovreversadodebe_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296MovReversadoDebe", StringUtil.LTrim( StringUtil.Str( A296MovReversadoDebe, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoDebe_Internalname, StringUtil.LTrim( StringUtil.NToC( A296MovReversadoDebe, 17, 2, ".", "")), ((edtMovReversadoDebe_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A296MovReversadoDebe, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A296MovReversadoDebe, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(83);\"", "", "", "", "", edtMovReversadoDebe_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoDebe_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadohaber_Internalname, "Haber", "", "", lblTextblockmovreversadohaber_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297MovReversadoHaber", StringUtil.LTrim( StringUtil.Str( A297MovReversadoHaber, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoHaber_Internalname, StringUtil.LTrim( StringUtil.NToC( A297MovReversadoHaber, 17, 2, ".", "")), ((edtMovReversadoHaber_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A297MovReversadoHaber, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A297MovReversadoHaber, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(88);\"", "", "", "", "", edtMovReversadoHaber_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoHaber_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(93);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoReversado.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadofechar_Internalname, "Reversa", "", "", lblTextblockmovreversadofechar_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298MovReversadoFechaR", context.localUtil.Format(A298MovReversadoFechaR, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtMovReversadoFechaR_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoFechaR_Internalname, context.localUtil.Format(A298MovReversadoFechaR, "99/99/99"), context.localUtil.Format( A298MovReversadoFechaR, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(98);\"", "", "", "", "", edtMovReversadoFechaR_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoFechaR_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoReversado.htm");
            GxWebStd.gx_bitmap( context, edtMovReversadoFechaR_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtMovReversadoFechaR_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_MovimientoReversado.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovreversadohorar_Internalname, "Reversa", "", "", lblTextblockmovreversadohorar_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299MovReversadoHoraR", A299MovReversadoHoraR);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovReversadoHoraR_Internalname, StringUtil.RTrim( A299MovReversadoHoraR), StringUtil.RTrim( context.localUtil.Format( A299MovReversadoHoraR, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(103);\"", "", "", "", "", edtMovReversadoHoraR_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovReversadoHoraR_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoReversado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1I70e( true) ;
         }
         else
         {
            wb_table4_33_1I70e( false) ;
         }
      }

      protected void wb_table2_5_1I70( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01y0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVREVERSADOID"+"'), id:'"+"MOVREVERSADOID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVREVERSADOLINEA"+"'), id:'"+"MOVREVERSADOLINEA"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01y0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVREVERSADOID"+"'), id:'"+"MOVREVERSADOID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVREVERSADOLINEA"+"'), id:'"+"MOVREVERSADOLINEA"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoReversado.htm");
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
            wb_table2_5_1I70e( true) ;
         }
         else
         {
            wb_table2_5_1I70e( false) ;
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
               A199TipoParCodigo = cgiGet( edtTipoParCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovReversadoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovReversadoId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVREVERSADOID");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovReversadoId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A290MovReversadoId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
               }
               else
               {
                  A290MovReversadoId = (int)(context.localUtil.CToN( cgiGet( edtMovReversadoId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovReversadoLinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovReversadoLinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVREVERSADOLINEA");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovReversadoLinea_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A291MovReversadoLinea = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
               }
               else
               {
                  A291MovReversadoLinea = (short)(context.localUtil.CToN( cgiGet( edtMovReversadoLinea_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtMovReversadoFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "MOVREVERSADOFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovReversadoFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A292MovReversadoFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292MovReversadoFecha", context.localUtil.Format(A292MovReversadoFecha, "99/99/99"));
               }
               else
               {
                  A292MovReversadoFecha = context.localUtil.CToD( cgiGet( edtMovReversadoFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292MovReversadoFecha", context.localUtil.Format(A292MovReversadoFecha, "99/99/99"));
               }
               A293MovReversadoHora = cgiGet( edtMovReversadoHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293MovReversadoHora", A293MovReversadoHora);
               A294MovReversadoObs = cgiGet( edtMovReversadoObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294MovReversadoObs", A294MovReversadoObs);
               A295MovReversadoReferencia = cgiGet( edtMovReversadoReferencia_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295MovReversadoReferencia", A295MovReversadoReferencia);
               A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovReversadoDebe_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovReversadoDebe_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVREVERSADODEBE");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovReversadoDebe_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A296MovReversadoDebe = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296MovReversadoDebe", StringUtil.LTrim( StringUtil.Str( A296MovReversadoDebe, 17, 2)));
               }
               else
               {
                  A296MovReversadoDebe = context.localUtil.CToN( cgiGet( edtMovReversadoDebe_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296MovReversadoDebe", StringUtil.LTrim( StringUtil.Str( A296MovReversadoDebe, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovReversadoHaber_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovReversadoHaber_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVREVERSADOHABER");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovReversadoHaber_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A297MovReversadoHaber = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297MovReversadoHaber", StringUtil.LTrim( StringUtil.Str( A297MovReversadoHaber, 17, 2)));
               }
               else
               {
                  A297MovReversadoHaber = context.localUtil.CToN( cgiGet( edtMovReversadoHaber_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297MovReversadoHaber", StringUtil.LTrim( StringUtil.Str( A297MovReversadoHaber, 17, 2)));
               }
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               if ( context.localUtil.VCDate( cgiGet( edtMovReversadoFechaR_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha_Reversa"}), 1, "MOVREVERSADOFECHAR");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovReversadoFechaR_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A298MovReversadoFechaR = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298MovReversadoFechaR", context.localUtil.Format(A298MovReversadoFechaR, "99/99/99"));
               }
               else
               {
                  A298MovReversadoFechaR = context.localUtil.CToD( cgiGet( edtMovReversadoFechaR_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298MovReversadoFechaR", context.localUtil.Format(A298MovReversadoFechaR, "99/99/99"));
               }
               A299MovReversadoHoraR = cgiGet( edtMovReversadoHoraR_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299MovReversadoHoraR", A299MovReversadoHoraR);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z199TipoParCodigo = cgiGet( "Z199TipoParCodigo") ;
               Z290MovReversadoId = (int)(context.localUtil.CToN( cgiGet( "Z290MovReversadoId"), ".", ",")) ;
               Z291MovReversadoLinea = (short)(context.localUtil.CToN( cgiGet( "Z291MovReversadoLinea"), ".", ",")) ;
               Z292MovReversadoFecha = context.localUtil.CToD( cgiGet( "Z292MovReversadoFecha"), 0) ;
               Z293MovReversadoHora = cgiGet( "Z293MovReversadoHora") ;
               Z294MovReversadoObs = cgiGet( "Z294MovReversadoObs") ;
               Z295MovReversadoReferencia = cgiGet( "Z295MovReversadoReferencia") ;
               Z296MovReversadoDebe = context.localUtil.CToN( cgiGet( "Z296MovReversadoDebe"), ".", ",") ;
               Z297MovReversadoHaber = context.localUtil.CToN( cgiGet( "Z297MovReversadoHaber"), ".", ",") ;
               Z298MovReversadoFechaR = context.localUtil.CToD( cgiGet( "Z298MovReversadoFechaR"), 0) ;
               Z299MovReversadoHoraR = cgiGet( "Z299MovReversadoHoraR") ;
               Z193CtaContableCodigo = cgiGet( "Z193CtaContableCodigo") ;
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
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
                  A199TipoParCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
                  A290MovReversadoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
                  A291MovReversadoLinea = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
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
               InitAll1I70( ) ;
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
         DisableAttributes1I70( ) ;
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

      protected void ResetCaption1I0( )
      {
      }

      protected void ZM1I70( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z292MovReversadoFecha = T001I3_A292MovReversadoFecha[0] ;
               Z293MovReversadoHora = T001I3_A293MovReversadoHora[0] ;
               Z294MovReversadoObs = T001I3_A294MovReversadoObs[0] ;
               Z295MovReversadoReferencia = T001I3_A295MovReversadoReferencia[0] ;
               Z296MovReversadoDebe = T001I3_A296MovReversadoDebe[0] ;
               Z297MovReversadoHaber = T001I3_A297MovReversadoHaber[0] ;
               Z298MovReversadoFechaR = T001I3_A298MovReversadoFechaR[0] ;
               Z299MovReversadoHoraR = T001I3_A299MovReversadoHoraR[0] ;
               Z193CtaContableCodigo = T001I3_A193CtaContableCodigo[0] ;
               Z4UsuarioCodigo = T001I3_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z292MovReversadoFecha = A292MovReversadoFecha ;
               Z293MovReversadoHora = A293MovReversadoHora ;
               Z294MovReversadoObs = A294MovReversadoObs ;
               Z295MovReversadoReferencia = A295MovReversadoReferencia ;
               Z296MovReversadoDebe = A296MovReversadoDebe ;
               Z297MovReversadoHaber = A297MovReversadoHaber ;
               Z298MovReversadoFechaR = A298MovReversadoFechaR ;
               Z299MovReversadoHoraR = A299MovReversadoHoraR ;
               Z193CtaContableCodigo = A193CtaContableCodigo ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z290MovReversadoId = A290MovReversadoId ;
            Z291MovReversadoLinea = A291MovReversadoLinea ;
            Z292MovReversadoFecha = A292MovReversadoFecha ;
            Z293MovReversadoHora = A293MovReversadoHora ;
            Z294MovReversadoObs = A294MovReversadoObs ;
            Z295MovReversadoReferencia = A295MovReversadoReferencia ;
            Z296MovReversadoDebe = A296MovReversadoDebe ;
            Z297MovReversadoHaber = A297MovReversadoHaber ;
            Z298MovReversadoFechaR = A298MovReversadoFechaR ;
            Z299MovReversadoHoraR = A299MovReversadoHoraR ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z193CtaContableCodigo = A193CtaContableCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_199_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx01f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
         imgprompt_41_193_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx01e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CTACONTABLECODIGO"+"'), id:'"+"CTACONTABLECODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load1I70( )
      {
         /* Using cursor T001I7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound70 = 1 ;
            A292MovReversadoFecha = T001I7_A292MovReversadoFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292MovReversadoFecha", context.localUtil.Format(A292MovReversadoFecha, "99/99/99"));
            A293MovReversadoHora = T001I7_A293MovReversadoHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293MovReversadoHora", A293MovReversadoHora);
            A294MovReversadoObs = T001I7_A294MovReversadoObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294MovReversadoObs", A294MovReversadoObs);
            A295MovReversadoReferencia = T001I7_A295MovReversadoReferencia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295MovReversadoReferencia", A295MovReversadoReferencia);
            A296MovReversadoDebe = T001I7_A296MovReversadoDebe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296MovReversadoDebe", StringUtil.LTrim( StringUtil.Str( A296MovReversadoDebe, 17, 2)));
            A297MovReversadoHaber = T001I7_A297MovReversadoHaber[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297MovReversadoHaber", StringUtil.LTrim( StringUtil.Str( A297MovReversadoHaber, 17, 2)));
            A298MovReversadoFechaR = T001I7_A298MovReversadoFechaR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298MovReversadoFechaR", context.localUtil.Format(A298MovReversadoFechaR, "99/99/99"));
            A299MovReversadoHoraR = T001I7_A299MovReversadoHoraR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299MovReversadoHoraR", A299MovReversadoHoraR);
            A193CtaContableCodigo = T001I7_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            A4UsuarioCodigo = T001I7_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM1I70( -3) ;
         }
         pr_default.close(5);
         OnLoadActions1I70( ) ;
      }

      protected void OnLoadActions1I70( )
      {
      }

      protected void CheckExtendedTable1I70( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001I4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
         {
         }
         pr_default.close(2);
         /* Using cursor T001I5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(3) == 101) )
         {
            AnyError41 = 1 ;
            AnyError199 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Partidas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError199 == 0 ) )
         {
         }
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A292MovReversadoFecha) || ( A292MovReversadoFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T001I6 */
         pr_default.execute(4, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(4) == 101) )
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
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A298MovReversadoFechaR) || ( A298MovReversadoFechaR >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha_Reversa fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1I70( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( String A41ClinicaCodigo ,
                               String A193CtaContableCodigo )
      {
         /* Using cursor T001I8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void gxLoad_5( String A41ClinicaCodigo ,
                               String A199TipoParCodigo )
      {
         /* Using cursor T001I9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(7) == 101) )
         {
            AnyError41 = 1 ;
            AnyError199 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Partidas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError199 == 0 ) )
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

      protected void gxLoad_6( String A4UsuarioCodigo )
      {
         /* Using cursor T001I10 */
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

      protected void GetKey1I70( )
      {
         /* Using cursor T001I11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound70 = 1 ;
         }
         else
         {
            RcdFound70 = 0 ;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001I3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1I70( 3) ;
            RcdFound70 = 1 ;
            A290MovReversadoId = T001I3_A290MovReversadoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
            A291MovReversadoLinea = T001I3_A291MovReversadoLinea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
            A292MovReversadoFecha = T001I3_A292MovReversadoFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292MovReversadoFecha", context.localUtil.Format(A292MovReversadoFecha, "99/99/99"));
            A293MovReversadoHora = T001I3_A293MovReversadoHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293MovReversadoHora", A293MovReversadoHora);
            A294MovReversadoObs = T001I3_A294MovReversadoObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294MovReversadoObs", A294MovReversadoObs);
            A295MovReversadoReferencia = T001I3_A295MovReversadoReferencia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295MovReversadoReferencia", A295MovReversadoReferencia);
            A296MovReversadoDebe = T001I3_A296MovReversadoDebe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296MovReversadoDebe", StringUtil.LTrim( StringUtil.Str( A296MovReversadoDebe, 17, 2)));
            A297MovReversadoHaber = T001I3_A297MovReversadoHaber[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297MovReversadoHaber", StringUtil.LTrim( StringUtil.Str( A297MovReversadoHaber, 17, 2)));
            A298MovReversadoFechaR = T001I3_A298MovReversadoFechaR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298MovReversadoFechaR", context.localUtil.Format(A298MovReversadoFechaR, "99/99/99"));
            A299MovReversadoHoraR = T001I3_A299MovReversadoHoraR[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299MovReversadoHoraR", A299MovReversadoHoraR);
            A41ClinicaCodigo = T001I3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A193CtaContableCodigo = T001I3_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            A199TipoParCodigo = T001I3_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A4UsuarioCodigo = T001I3_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z290MovReversadoId = A290MovReversadoId ;
            Z291MovReversadoLinea = A291MovReversadoLinea ;
            sMode70 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1I70( ) ;
            Gx_mode = sMode70 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound70 = 0 ;
            InitializeNonKey1I70( ) ;
            sMode70 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode70 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1I70( ) ;
         if ( RcdFound70 == 0 )
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
         RcdFound70 = 0 ;
         /* Using cursor T001I12 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T001I12_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001I12_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001I12_A199TipoParCodigo[0], A199TipoParCodigo) < 0 ) || ( StringUtil.StrCmp(T001I12_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001I12_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001I12_A290MovReversadoId[0] < A290MovReversadoId ) || ( T001I12_A290MovReversadoId[0] == A290MovReversadoId ) && ( StringUtil.StrCmp(T001I12_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001I12_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001I12_A291MovReversadoLinea[0] < A291MovReversadoLinea ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T001I12_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001I12_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001I12_A199TipoParCodigo[0], A199TipoParCodigo) > 0 ) || ( StringUtil.StrCmp(T001I12_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001I12_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001I12_A290MovReversadoId[0] > A290MovReversadoId ) || ( T001I12_A290MovReversadoId[0] == A290MovReversadoId ) && ( StringUtil.StrCmp(T001I12_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001I12_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001I12_A291MovReversadoLinea[0] > A291MovReversadoLinea ) ) )
            {
               A41ClinicaCodigo = T001I12_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = T001I12_A199TipoParCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A290MovReversadoId = T001I12_A290MovReversadoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
               A291MovReversadoLinea = T001I12_A291MovReversadoLinea[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
               RcdFound70 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound70 = 0 ;
         /* Using cursor T001I13 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T001I13_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001I13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001I13_A199TipoParCodigo[0], A199TipoParCodigo) > 0 ) || ( StringUtil.StrCmp(T001I13_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001I13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001I13_A290MovReversadoId[0] > A290MovReversadoId ) || ( T001I13_A290MovReversadoId[0] == A290MovReversadoId ) && ( StringUtil.StrCmp(T001I13_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001I13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001I13_A291MovReversadoLinea[0] > A291MovReversadoLinea ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T001I13_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001I13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001I13_A199TipoParCodigo[0], A199TipoParCodigo) < 0 ) || ( StringUtil.StrCmp(T001I13_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001I13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001I13_A290MovReversadoId[0] < A290MovReversadoId ) || ( T001I13_A290MovReversadoId[0] == A290MovReversadoId ) && ( StringUtil.StrCmp(T001I13_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001I13_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001I13_A291MovReversadoLinea[0] < A291MovReversadoLinea ) ) )
            {
               A41ClinicaCodigo = T001I13_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = T001I13_A199TipoParCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A290MovReversadoId = T001I13_A290MovReversadoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
               A291MovReversadoLinea = T001I13_A291MovReversadoLinea[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
               RcdFound70 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1I70( ) ;
         if ( RcdFound70 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A290MovReversadoId != Z290MovReversadoId ) || ( A291MovReversadoLinea != Z291MovReversadoLinea ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = Z199TipoParCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A290MovReversadoId = Z290MovReversadoId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
               A291MovReversadoLinea = Z291MovReversadoLinea ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
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
               Update1I70( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A290MovReversadoId != Z290MovReversadoId ) || ( A291MovReversadoLinea != Z291MovReversadoLinea ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1I70( ) ;
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
                  Insert1I70( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A290MovReversadoId != Z290MovReversadoId ) || ( A291MovReversadoLinea != Z291MovReversadoLinea ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = Z199TipoParCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A290MovReversadoId = Z290MovReversadoId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
            A291MovReversadoLinea = Z291MovReversadoLinea ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
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
         if ( RcdFound70 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtMovReversadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1I70( ) ;
         if ( RcdFound70 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovReversadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1I70( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound70 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovReversadoFecha_Internalname ;
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
         if ( RcdFound70 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovReversadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1I70( ) ;
         if ( RcdFound70 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound70 != 0 )
            {
               ScanNext1I70( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovReversadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1I70( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1I70( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001I14 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea});
            if ( (pr_default.getStatus(12) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MovimientoReversado"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(12) == 101) || ( Z292MovReversadoFecha != T001I14_A292MovReversadoFecha[0] ) || ( StringUtil.StrCmp(Z293MovReversadoHora, T001I14_A293MovReversadoHora[0]) != 0 ) || ( StringUtil.StrCmp(Z294MovReversadoObs, T001I14_A294MovReversadoObs[0]) != 0 ) || ( StringUtil.StrCmp(Z295MovReversadoReferencia, T001I14_A295MovReversadoReferencia[0]) != 0 ) || ( Z296MovReversadoDebe != T001I14_A296MovReversadoDebe[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z297MovReversadoHaber != T001I14_A297MovReversadoHaber[0] ) || ( Z298MovReversadoFechaR != T001I14_A298MovReversadoFechaR[0] ) || ( StringUtil.StrCmp(Z299MovReversadoHoraR, T001I14_A299MovReversadoHoraR[0]) != 0 ) || ( StringUtil.StrCmp(Z193CtaContableCodigo, T001I14_A193CtaContableCodigo[0]) != 0 ) || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001I14_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MovimientoReversado"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1I70( )
      {
         BeforeValidate1I70( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1I70( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1I70( 0) ;
            CheckOptimisticConcurrency1I70( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1I70( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1I70( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001I15 */
                     pr_default.execute(13, new Object[] {A290MovReversadoId, A291MovReversadoLinea, A292MovReversadoFecha, A293MovReversadoHora, A294MovReversadoObs, A295MovReversadoReferencia, A296MovReversadoDebe, A297MovReversadoHaber, A298MovReversadoFechaR, A299MovReversadoHoraR, A41ClinicaCodigo, A193CtaContableCodigo, A199TipoParCodigo, A4UsuarioCodigo});
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
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                           ResetCaption1I0( ) ;
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
               Load1I70( ) ;
            }
            EndLevel1I70( ) ;
         }
         CloseExtendedTableCursors1I70( ) ;
      }

      protected void Update1I70( )
      {
         BeforeValidate1I70( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1I70( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1I70( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1I70( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1I70( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001I16 */
                     pr_default.execute(14, new Object[] {A292MovReversadoFecha, A293MovReversadoHora, A294MovReversadoObs, A295MovReversadoReferencia, A296MovReversadoDebe, A297MovReversadoHaber, A298MovReversadoFechaR, A299MovReversadoHoraR, A193CtaContableCodigo, A4UsuarioCodigo, A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MovimientoReversado"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1I70( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption1I0( ) ;
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
            EndLevel1I70( ) ;
         }
         CloseExtendedTableCursors1I70( ) ;
      }

      protected void DeferredUpdate1I70( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1I70( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1I70( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1I70( ) ;
            AfterConfirm1I70( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1I70( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001I17 */
                  pr_default.execute(15, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea});
                  pr_default.close(15);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound70 == 0 )
                        {
                           InitAll1I70( ) ;
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
                        ResetCaption1I0( ) ;
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
         sMode70 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1I70( ) ;
         Gx_mode = sMode70 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1I70( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1I70( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1I70( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(11);
            pr_default.close(10);
            context.CommitDataStores("MovimientoReversado");
            if ( AnyError == 0 )
            {
               ConfirmValues1I0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(11);
            pr_default.close(10);
            context.RollbackDataStores("MovimientoReversado");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1I70( )
      {
         /* Using cursor T001I18 */
         pr_default.execute(16);
         RcdFound70 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound70 = 1 ;
            A41ClinicaCodigo = T001I18_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T001I18_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A290MovReversadoId = T001I18_A290MovReversadoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
            A291MovReversadoLinea = T001I18_A291MovReversadoLinea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1I70( )
      {
         pr_default.readNext(16);
         RcdFound70 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound70 = 1 ;
            A41ClinicaCodigo = T001I18_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T001I18_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A290MovReversadoId = T001I18_A290MovReversadoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
            A291MovReversadoLinea = T001I18_A291MovReversadoLinea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
         }
      }

      protected void ScanEnd1I70( )
      {
      }

      protected void AfterConfirm1I70( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1I70( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1I70( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1I70( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1I70( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1I70( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1I70( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtTipoParCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoParCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoParCodigo_Enabled), 5, 0)));
         edtMovReversadoId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoId_Enabled), 5, 0)));
         edtMovReversadoLinea_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoLinea_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoLinea_Enabled), 5, 0)));
         edtMovReversadoFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoFecha_Enabled), 5, 0)));
         edtMovReversadoHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoHora_Enabled), 5, 0)));
         edtMovReversadoObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoObs_Enabled), 5, 0)));
         edtMovReversadoReferencia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoReferencia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoReferencia_Enabled), 5, 0)));
         edtCtaContableCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCtaContableCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCtaContableCodigo_Enabled), 5, 0)));
         edtMovReversadoDebe_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoDebe_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoDebe_Enabled), 5, 0)));
         edtMovReversadoHaber_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoHaber_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoHaber_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
         edtMovReversadoFechaR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoFechaR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoFechaR_Enabled), 5, 0)));
         edtMovReversadoHoraR_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovReversadoHoraR_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovReversadoHoraR_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1I0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("movimientoreversado.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z199TipoParCodigo", StringUtil.RTrim( Z199TipoParCodigo));
         GxWebStd.gx_hidden_field( context, "Z290MovReversadoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z290MovReversadoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z291MovReversadoLinea", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z291MovReversadoLinea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z292MovReversadoFecha", context.localUtil.DToC( Z292MovReversadoFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z293MovReversadoHora", StringUtil.RTrim( Z293MovReversadoHora));
         GxWebStd.gx_hidden_field( context, "Z294MovReversadoObs", StringUtil.RTrim( Z294MovReversadoObs));
         GxWebStd.gx_hidden_field( context, "Z295MovReversadoReferencia", StringUtil.RTrim( Z295MovReversadoReferencia));
         GxWebStd.gx_hidden_field( context, "Z296MovReversadoDebe", StringUtil.LTrim( StringUtil.NToC( Z296MovReversadoDebe, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z297MovReversadoHaber", StringUtil.LTrim( StringUtil.NToC( Z297MovReversadoHaber, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z298MovReversadoFechaR", context.localUtil.DToC( Z298MovReversadoFechaR, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z299MovReversadoHoraR", StringUtil.RTrim( Z299MovReversadoHoraR));
         GxWebStd.gx_hidden_field( context, "Z193CtaContableCodigo", StringUtil.RTrim( Z193CtaContableCodigo));
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
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
         return "MovimientoReversado" ;
      }

      public override String GetPgmdesc( )
      {
         return "Movimiento Contable Reversado" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("movimientoreversado.aspx")  ;
      }

      protected void InitializeNonKey1I70( )
      {
         A292MovReversadoFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292MovReversadoFecha", context.localUtil.Format(A292MovReversadoFecha, "99/99/99"));
         A293MovReversadoHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293MovReversadoHora", A293MovReversadoHora);
         A294MovReversadoObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294MovReversadoObs", A294MovReversadoObs);
         A295MovReversadoReferencia = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295MovReversadoReferencia", A295MovReversadoReferencia);
         A193CtaContableCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
         A296MovReversadoDebe = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296MovReversadoDebe", StringUtil.LTrim( StringUtil.Str( A296MovReversadoDebe, 17, 2)));
         A297MovReversadoHaber = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297MovReversadoHaber", StringUtil.LTrim( StringUtil.Str( A297MovReversadoHaber, 17, 2)));
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         A298MovReversadoFechaR = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298MovReversadoFechaR", context.localUtil.Format(A298MovReversadoFechaR, "99/99/99"));
         A299MovReversadoHoraR = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A299MovReversadoHoraR", A299MovReversadoHoraR);
      }

      protected void InitAll1I70( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A199TipoParCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
         A290MovReversadoId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290MovReversadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A290MovReversadoId), 9, 0)));
         A291MovReversadoLinea = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291MovReversadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A291MovReversadoLinea), 4, 0)));
         InitializeNonKey1I70( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?157159");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("movimientoreversado.js", "?157159");
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
         lblTextblocktipoparcodigo_Internalname = "TEXTBLOCKTIPOPARCODIGO" ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO" ;
         lblTextblockmovreversadoid_Internalname = "TEXTBLOCKMOVREVERSADOID" ;
         edtMovReversadoId_Internalname = "MOVREVERSADOID" ;
         lblTextblockmovreversadolinea_Internalname = "TEXTBLOCKMOVREVERSADOLINEA" ;
         edtMovReversadoLinea_Internalname = "MOVREVERSADOLINEA" ;
         lblTextblockmovreversadofecha_Internalname = "TEXTBLOCKMOVREVERSADOFECHA" ;
         edtMovReversadoFecha_Internalname = "MOVREVERSADOFECHA" ;
         lblTextblockmovreversadohora_Internalname = "TEXTBLOCKMOVREVERSADOHORA" ;
         edtMovReversadoHora_Internalname = "MOVREVERSADOHORA" ;
         lblTextblockmovreversadoobs_Internalname = "TEXTBLOCKMOVREVERSADOOBS" ;
         edtMovReversadoObs_Internalname = "MOVREVERSADOOBS" ;
         lblTextblockmovreversadoreferencia_Internalname = "TEXTBLOCKMOVREVERSADOREFERENCIA" ;
         edtMovReversadoReferencia_Internalname = "MOVREVERSADOREFERENCIA" ;
         lblTextblockctacontablecodigo_Internalname = "TEXTBLOCKCTACONTABLECODIGO" ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO" ;
         lblTextblockmovreversadodebe_Internalname = "TEXTBLOCKMOVREVERSADODEBE" ;
         edtMovReversadoDebe_Internalname = "MOVREVERSADODEBE" ;
         lblTextblockmovreversadohaber_Internalname = "TEXTBLOCKMOVREVERSADOHABER" ;
         edtMovReversadoHaber_Internalname = "MOVREVERSADOHABER" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         lblTextblockmovreversadofechar_Internalname = "TEXTBLOCKMOVREVERSADOFECHAR" ;
         edtMovReversadoFechaR_Internalname = "MOVREVERSADOFECHAR" ;
         lblTextblockmovreversadohorar_Internalname = "TEXTBLOCKMOVREVERSADOHORAR" ;
         edtMovReversadoHoraR_Internalname = "MOVREVERSADOHORAR" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_199_Internalname = "PROMPT_41_199" ;
         imgprompt_41_193_Internalname = "PROMPT_41_193" ;
         imgprompt_4_Internalname = "PROMPT_4" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Movimiento Contable Reversado" ;
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
         edtMovReversadoHoraR_Jsonclick = "" ;
         edtMovReversadoHoraR_Enabled = 1 ;
         edtMovReversadoFechaR_Jsonclick = "" ;
         edtMovReversadoFechaR_Enabled = 1 ;
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         edtMovReversadoHaber_Jsonclick = "" ;
         edtMovReversadoHaber_Enabled = 1 ;
         edtMovReversadoDebe_Jsonclick = "" ;
         edtMovReversadoDebe_Enabled = 1 ;
         imgprompt_41_193_Visible = 1 ;
         imgprompt_41_193_Link = "" ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtCtaContableCodigo_Enabled = 1 ;
         edtMovReversadoReferencia_Jsonclick = "" ;
         edtMovReversadoReferencia_Enabled = 1 ;
         edtMovReversadoObs_Enabled = 1 ;
         edtMovReversadoHora_Jsonclick = "" ;
         edtMovReversadoHora_Enabled = 1 ;
         edtMovReversadoFecha_Jsonclick = "" ;
         edtMovReversadoFecha_Enabled = 1 ;
         edtMovReversadoLinea_Jsonclick = "" ;
         edtMovReversadoLinea_Enabled = 1 ;
         edtMovReversadoId_Jsonclick = "" ;
         edtMovReversadoId_Enabled = 1 ;
         imgprompt_41_199_Visible = 1 ;
         imgprompt_41_199_Link = "" ;
         edtTipoParCodigo_Jsonclick = "" ;
         edtTipoParCodigo_Enabled = 1 ;
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
         /* Using cursor T001I19 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(17) == 101) )
         {
            AnyError41 = 1 ;
            AnyError199 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Partidas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError199 == 0 ) )
         {
         }
         pr_default.close(17);
         GX_FocusControl = edtMovReversadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Tipoparcodigo( String GX_Parm1 ,
                                       String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A199TipoParCodigo = GX_Parm2 ;
         /* Using cursor T001I19 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo, A199TipoParCodigo});
         if ( (pr_default.getStatus(17) == 101) )
         {
            AnyError41 = 1 ;
            AnyError199 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Partidas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError199 == 0 ) )
         {
         }
         pr_default.close(17);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Movreversadolinea( String GX_Parm1 ,
                                           String GX_Parm2 ,
                                           int GX_Parm3 ,
                                           short GX_Parm4 ,
                                           DateTime GX_Parm5 ,
                                           String GX_Parm6 ,
                                           String GX_Parm7 ,
                                           String GX_Parm8 ,
                                           decimal GX_Parm9 ,
                                           decimal GX_Parm10 ,
                                           DateTime GX_Parm11 ,
                                           String GX_Parm12 ,
                                           String GX_Parm13 ,
                                           String GX_Parm14 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A199TipoParCodigo = GX_Parm2 ;
         A290MovReversadoId = GX_Parm3 ;
         A291MovReversadoLinea = GX_Parm4 ;
         A292MovReversadoFecha = GX_Parm5 ;
         A293MovReversadoHora = GX_Parm6 ;
         A294MovReversadoObs = GX_Parm7 ;
         A295MovReversadoReferencia = GX_Parm8 ;
         A296MovReversadoDebe = GX_Parm9 ;
         A297MovReversadoHaber = GX_Parm10 ;
         A298MovReversadoFechaR = GX_Parm11 ;
         A299MovReversadoHoraR = GX_Parm12 ;
         A193CtaContableCodigo = GX_Parm13 ;
         A4UsuarioCodigo = GX_Parm14 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A292MovReversadoFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A293MovReversadoHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A294MovReversadoObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A295MovReversadoReferencia)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A193CtaContableCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A296MovReversadoDebe, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A297MovReversadoHaber, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(context.localUtil.Format(A298MovReversadoFechaR, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A299MovReversadoHoraR)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z199TipoParCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z290MovReversadoId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z291MovReversadoLinea), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z292MovReversadoFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z293MovReversadoHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z294MovReversadoObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z295MovReversadoReferencia)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z193CtaContableCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z296MovReversadoDebe, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z297MovReversadoHaber, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z298MovReversadoFechaR, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z299MovReversadoHoraR)));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Ctacontablecodigo( String GX_Parm1 ,
                                           String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A193CtaContableCodigo = GX_Parm2 ;
         /* Using cursor T001I20 */
         pr_default.execute(18, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         if ( (pr_default.getStatus(18) == 101) )
         {
            AnyError41 = 1 ;
            AnyError193 = 1 ;
            GX_msglist.addItem("No existe 'Catálogo de Cuentas Contables'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError193 == 0 ) )
         {
         }
         pr_default.close(18);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Usuariocodigo( String GX_Parm1 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         /* Using cursor T001I21 */
         pr_default.execute(19, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(19) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(19);
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
         pr_default.close(16);
         pr_default.close(11);
         pr_default.close(10);
         pr_default.close(18);
         pr_default.close(17);
         pr_default.close(19);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A193CtaContableCodigo = "" ;
         A199TipoParCodigo = "" ;
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
         lblTextblocktipoparcodigo_Jsonclick = "" ;
         lblTextblockmovreversadoid_Jsonclick = "" ;
         lblTextblockmovreversadolinea_Jsonclick = "" ;
         lblTextblockmovreversadofecha_Jsonclick = "" ;
         A292MovReversadoFecha = DateTime.MinValue ;
         lblTextblockmovreversadohora_Jsonclick = "" ;
         A293MovReversadoHora = "" ;
         lblTextblockmovreversadoobs_Jsonclick = "" ;
         A294MovReversadoObs = "" ;
         lblTextblockmovreversadoreferencia_Jsonclick = "" ;
         A295MovReversadoReferencia = "" ;
         lblTextblockctacontablecodigo_Jsonclick = "" ;
         lblTextblockmovreversadodebe_Jsonclick = "" ;
         lblTextblockmovreversadohaber_Jsonclick = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         lblTextblockmovreversadofechar_Jsonclick = "" ;
         A298MovReversadoFechaR = DateTime.MinValue ;
         lblTextblockmovreversadohorar_Jsonclick = "" ;
         A299MovReversadoHoraR = "" ;
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
         Z199TipoParCodigo = "" ;
         Z292MovReversadoFecha = DateTime.MinValue ;
         Z293MovReversadoHora = "" ;
         Z294MovReversadoObs = "" ;
         Z295MovReversadoReferencia = "" ;
         Z298MovReversadoFechaR = DateTime.MinValue ;
         Z299MovReversadoHoraR = "" ;
         Z193CtaContableCodigo = "" ;
         Z4UsuarioCodigo = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T001I7_A290MovReversadoId = new int[1] ;
         T001I7_A291MovReversadoLinea = new short[1] ;
         T001I7_A292MovReversadoFecha = new DateTime[] {DateTime.MinValue} ;
         T001I7_A293MovReversadoHora = new String[] {""} ;
         T001I7_A294MovReversadoObs = new String[] {""} ;
         T001I7_A295MovReversadoReferencia = new String[] {""} ;
         T001I7_A296MovReversadoDebe = new decimal[1] ;
         T001I7_A297MovReversadoHaber = new decimal[1] ;
         T001I7_A298MovReversadoFechaR = new DateTime[] {DateTime.MinValue} ;
         T001I7_A299MovReversadoHoraR = new String[] {""} ;
         T001I7_A41ClinicaCodigo = new String[] {""} ;
         T001I7_A193CtaContableCodigo = new String[] {""} ;
         T001I7_A199TipoParCodigo = new String[] {""} ;
         T001I7_A4UsuarioCodigo = new String[] {""} ;
         T001I4_A41ClinicaCodigo = new String[] {""} ;
         T001I5_A41ClinicaCodigo = new String[] {""} ;
         T001I6_A4UsuarioCodigo = new String[] {""} ;
         T001I8_A41ClinicaCodigo = new String[] {""} ;
         T001I9_A41ClinicaCodigo = new String[] {""} ;
         T001I10_A4UsuarioCodigo = new String[] {""} ;
         T001I11_A41ClinicaCodigo = new String[] {""} ;
         T001I11_A199TipoParCodigo = new String[] {""} ;
         T001I11_A290MovReversadoId = new int[1] ;
         T001I11_A291MovReversadoLinea = new short[1] ;
         T001I3_A290MovReversadoId = new int[1] ;
         T001I3_A291MovReversadoLinea = new short[1] ;
         T001I3_A292MovReversadoFecha = new DateTime[] {DateTime.MinValue} ;
         T001I3_A293MovReversadoHora = new String[] {""} ;
         T001I3_A294MovReversadoObs = new String[] {""} ;
         T001I3_A295MovReversadoReferencia = new String[] {""} ;
         T001I3_A296MovReversadoDebe = new decimal[1] ;
         T001I3_A297MovReversadoHaber = new decimal[1] ;
         T001I3_A298MovReversadoFechaR = new DateTime[] {DateTime.MinValue} ;
         T001I3_A299MovReversadoHoraR = new String[] {""} ;
         T001I3_A41ClinicaCodigo = new String[] {""} ;
         T001I3_A193CtaContableCodigo = new String[] {""} ;
         T001I3_A199TipoParCodigo = new String[] {""} ;
         T001I3_A4UsuarioCodigo = new String[] {""} ;
         sMode70 = "" ;
         T001I12_A41ClinicaCodigo = new String[] {""} ;
         T001I12_A199TipoParCodigo = new String[] {""} ;
         T001I12_A290MovReversadoId = new int[1] ;
         T001I12_A291MovReversadoLinea = new short[1] ;
         T001I13_A41ClinicaCodigo = new String[] {""} ;
         T001I13_A199TipoParCodigo = new String[] {""} ;
         T001I13_A290MovReversadoId = new int[1] ;
         T001I13_A291MovReversadoLinea = new short[1] ;
         T001I14_A290MovReversadoId = new int[1] ;
         T001I14_A291MovReversadoLinea = new short[1] ;
         T001I14_A292MovReversadoFecha = new DateTime[] {DateTime.MinValue} ;
         T001I14_A293MovReversadoHora = new String[] {""} ;
         T001I14_A294MovReversadoObs = new String[] {""} ;
         T001I14_A295MovReversadoReferencia = new String[] {""} ;
         T001I14_A296MovReversadoDebe = new decimal[1] ;
         T001I14_A297MovReversadoHaber = new decimal[1] ;
         T001I14_A298MovReversadoFechaR = new DateTime[] {DateTime.MinValue} ;
         T001I14_A299MovReversadoHoraR = new String[] {""} ;
         T001I14_A41ClinicaCodigo = new String[] {""} ;
         T001I14_A193CtaContableCodigo = new String[] {""} ;
         T001I14_A199TipoParCodigo = new String[] {""} ;
         T001I14_A4UsuarioCodigo = new String[] {""} ;
         T001I18_A41ClinicaCodigo = new String[] {""} ;
         T001I18_A199TipoParCodigo = new String[] {""} ;
         T001I18_A290MovReversadoId = new int[1] ;
         T001I18_A291MovReversadoLinea = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         T001I19_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T001I20_A41ClinicaCodigo = new String[] {""} ;
         T001I21_A4UsuarioCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.movimientoreversado__default(),
            new Object[][] {
                new Object[] {
               T001I2_A290MovReversadoId, T001I2_A291MovReversadoLinea, T001I2_A292MovReversadoFecha, T001I2_A293MovReversadoHora, T001I2_A294MovReversadoObs, T001I2_A295MovReversadoReferencia, T001I2_A296MovReversadoDebe, T001I2_A297MovReversadoHaber, T001I2_A298MovReversadoFechaR, T001I2_A299MovReversadoHoraR,
               T001I2_A41ClinicaCodigo, T001I2_A193CtaContableCodigo, T001I2_A199TipoParCodigo, T001I2_A4UsuarioCodigo
               }
               , new Object[] {
               T001I3_A290MovReversadoId, T001I3_A291MovReversadoLinea, T001I3_A292MovReversadoFecha, T001I3_A293MovReversadoHora, T001I3_A294MovReversadoObs, T001I3_A295MovReversadoReferencia, T001I3_A296MovReversadoDebe, T001I3_A297MovReversadoHaber, T001I3_A298MovReversadoFechaR, T001I3_A299MovReversadoHoraR,
               T001I3_A41ClinicaCodigo, T001I3_A193CtaContableCodigo, T001I3_A199TipoParCodigo, T001I3_A4UsuarioCodigo
               }
               , new Object[] {
               T001I4_A41ClinicaCodigo
               }
               , new Object[] {
               T001I5_A41ClinicaCodigo
               }
               , new Object[] {
               T001I6_A4UsuarioCodigo
               }
               , new Object[] {
               T001I7_A290MovReversadoId, T001I7_A291MovReversadoLinea, T001I7_A292MovReversadoFecha, T001I7_A293MovReversadoHora, T001I7_A294MovReversadoObs, T001I7_A295MovReversadoReferencia, T001I7_A296MovReversadoDebe, T001I7_A297MovReversadoHaber, T001I7_A298MovReversadoFechaR, T001I7_A299MovReversadoHoraR,
               T001I7_A41ClinicaCodigo, T001I7_A193CtaContableCodigo, T001I7_A199TipoParCodigo, T001I7_A4UsuarioCodigo
               }
               , new Object[] {
               T001I8_A41ClinicaCodigo
               }
               , new Object[] {
               T001I9_A41ClinicaCodigo
               }
               , new Object[] {
               T001I10_A4UsuarioCodigo
               }
               , new Object[] {
               T001I11_A41ClinicaCodigo, T001I11_A199TipoParCodigo, T001I11_A290MovReversadoId, T001I11_A291MovReversadoLinea
               }
               , new Object[] {
               T001I12_A41ClinicaCodigo, T001I12_A199TipoParCodigo, T001I12_A290MovReversadoId, T001I12_A291MovReversadoLinea
               }
               , new Object[] {
               T001I13_A41ClinicaCodigo, T001I13_A199TipoParCodigo, T001I13_A290MovReversadoId, T001I13_A291MovReversadoLinea
               }
               , new Object[] {
               T001I14_A290MovReversadoId, T001I14_A291MovReversadoLinea, T001I14_A292MovReversadoFecha, T001I14_A293MovReversadoHora, T001I14_A294MovReversadoObs, T001I14_A295MovReversadoReferencia, T001I14_A296MovReversadoDebe, T001I14_A297MovReversadoHaber, T001I14_A298MovReversadoFechaR, T001I14_A299MovReversadoHoraR,
               T001I14_A41ClinicaCodigo, T001I14_A193CtaContableCodigo, T001I14_A199TipoParCodigo, T001I14_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001I18_A41ClinicaCodigo, T001I18_A199TipoParCodigo, T001I18_A290MovReversadoId, T001I18_A291MovReversadoLinea
               }
               , new Object[] {
               T001I19_A41ClinicaCodigo
               }
               , new Object[] {
               T001I20_A41ClinicaCodigo
               }
               , new Object[] {
               T001I21_A4UsuarioCodigo
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
      private short A291MovReversadoLinea ;
      private short Z291MovReversadoLinea ;
      private short GX_JID ;
      private short RcdFound70 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtTipoParCodigo_Enabled ;
      private int imgprompt_41_199_Visible ;
      private int A290MovReversadoId ;
      private int edtMovReversadoId_Enabled ;
      private int edtMovReversadoLinea_Enabled ;
      private int edtMovReversadoFecha_Enabled ;
      private int edtMovReversadoHora_Enabled ;
      private int edtMovReversadoObs_Enabled ;
      private int edtMovReversadoReferencia_Enabled ;
      private int edtCtaContableCodigo_Enabled ;
      private int imgprompt_41_193_Visible ;
      private int edtMovReversadoDebe_Enabled ;
      private int edtMovReversadoHaber_Enabled ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtMovReversadoFechaR_Enabled ;
      private int edtMovReversadoHoraR_Enabled ;
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
      private int Z290MovReversadoId ;
      private int AnyError41 ;
      private int AnyError193 ;
      private int AnyError199 ;
      private int AnyError4 ;
      private int idxLst ;
      private decimal A296MovReversadoDebe ;
      private decimal A297MovReversadoHaber ;
      private decimal Z296MovReversadoDebe ;
      private decimal Z297MovReversadoHaber ;
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
      private String lblTextblocktipoparcodigo_Internalname ;
      private String lblTextblocktipoparcodigo_Jsonclick ;
      private String edtTipoParCodigo_Internalname ;
      private String edtTipoParCodigo_Jsonclick ;
      private String imgprompt_41_199_Internalname ;
      private String imgprompt_41_199_Link ;
      private String lblTextblockmovreversadoid_Internalname ;
      private String lblTextblockmovreversadoid_Jsonclick ;
      private String edtMovReversadoId_Internalname ;
      private String edtMovReversadoId_Jsonclick ;
      private String lblTextblockmovreversadolinea_Internalname ;
      private String lblTextblockmovreversadolinea_Jsonclick ;
      private String edtMovReversadoLinea_Internalname ;
      private String edtMovReversadoLinea_Jsonclick ;
      private String lblTextblockmovreversadofecha_Internalname ;
      private String lblTextblockmovreversadofecha_Jsonclick ;
      private String edtMovReversadoFecha_Internalname ;
      private String edtMovReversadoFecha_Jsonclick ;
      private String lblTextblockmovreversadohora_Internalname ;
      private String lblTextblockmovreversadohora_Jsonclick ;
      private String A293MovReversadoHora ;
      private String edtMovReversadoHora_Internalname ;
      private String edtMovReversadoHora_Jsonclick ;
      private String lblTextblockmovreversadoobs_Internalname ;
      private String lblTextblockmovreversadoobs_Jsonclick ;
      private String edtMovReversadoObs_Internalname ;
      private String lblTextblockmovreversadoreferencia_Internalname ;
      private String lblTextblockmovreversadoreferencia_Jsonclick ;
      private String edtMovReversadoReferencia_Internalname ;
      private String edtMovReversadoReferencia_Jsonclick ;
      private String lblTextblockctacontablecodigo_Internalname ;
      private String lblTextblockctacontablecodigo_Jsonclick ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String imgprompt_41_193_Internalname ;
      private String imgprompt_41_193_Link ;
      private String lblTextblockmovreversadodebe_Internalname ;
      private String lblTextblockmovreversadodebe_Jsonclick ;
      private String edtMovReversadoDebe_Internalname ;
      private String edtMovReversadoDebe_Jsonclick ;
      private String lblTextblockmovreversadohaber_Internalname ;
      private String lblTextblockmovreversadohaber_Jsonclick ;
      private String edtMovReversadoHaber_Internalname ;
      private String edtMovReversadoHaber_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String lblTextblockmovreversadofechar_Internalname ;
      private String lblTextblockmovreversadofechar_Jsonclick ;
      private String edtMovReversadoFechaR_Internalname ;
      private String edtMovReversadoFechaR_Jsonclick ;
      private String lblTextblockmovreversadohorar_Internalname ;
      private String lblTextblockmovreversadohorar_Jsonclick ;
      private String A299MovReversadoHoraR ;
      private String edtMovReversadoHoraR_Internalname ;
      private String edtMovReversadoHoraR_Jsonclick ;
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
      private String Z293MovReversadoHora ;
      private String Z299MovReversadoHoraR ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode70 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A292MovReversadoFecha ;
      private DateTime A298MovReversadoFechaR ;
      private DateTime Z292MovReversadoFecha ;
      private DateTime Z298MovReversadoFechaR ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A193CtaContableCodigo ;
      private String A199TipoParCodigo ;
      private String A4UsuarioCodigo ;
      private String A294MovReversadoObs ;
      private String A295MovReversadoReferencia ;
      private String Z41ClinicaCodigo ;
      private String Z199TipoParCodigo ;
      private String Z294MovReversadoObs ;
      private String Z295MovReversadoReferencia ;
      private String Z193CtaContableCodigo ;
      private String Z4UsuarioCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T001I7_A290MovReversadoId ;
      private short[] T001I7_A291MovReversadoLinea ;
      private DateTime[] T001I7_A292MovReversadoFecha ;
      private String[] T001I7_A293MovReversadoHora ;
      private String[] T001I7_A294MovReversadoObs ;
      private String[] T001I7_A295MovReversadoReferencia ;
      private decimal[] T001I7_A296MovReversadoDebe ;
      private decimal[] T001I7_A297MovReversadoHaber ;
      private DateTime[] T001I7_A298MovReversadoFechaR ;
      private String[] T001I7_A299MovReversadoHoraR ;
      private String[] T001I7_A41ClinicaCodigo ;
      private String[] T001I7_A193CtaContableCodigo ;
      private String[] T001I7_A199TipoParCodigo ;
      private String[] T001I7_A4UsuarioCodigo ;
      private String[] T001I4_A41ClinicaCodigo ;
      private String[] T001I5_A41ClinicaCodigo ;
      private String[] T001I6_A4UsuarioCodigo ;
      private String[] T001I8_A41ClinicaCodigo ;
      private String[] T001I9_A41ClinicaCodigo ;
      private String[] T001I10_A4UsuarioCodigo ;
      private String[] T001I11_A41ClinicaCodigo ;
      private String[] T001I11_A199TipoParCodigo ;
      private int[] T001I11_A290MovReversadoId ;
      private short[] T001I11_A291MovReversadoLinea ;
      private int[] T001I3_A290MovReversadoId ;
      private short[] T001I3_A291MovReversadoLinea ;
      private DateTime[] T001I3_A292MovReversadoFecha ;
      private String[] T001I3_A293MovReversadoHora ;
      private String[] T001I3_A294MovReversadoObs ;
      private String[] T001I3_A295MovReversadoReferencia ;
      private decimal[] T001I3_A296MovReversadoDebe ;
      private decimal[] T001I3_A297MovReversadoHaber ;
      private DateTime[] T001I3_A298MovReversadoFechaR ;
      private String[] T001I3_A299MovReversadoHoraR ;
      private String[] T001I3_A41ClinicaCodigo ;
      private String[] T001I3_A193CtaContableCodigo ;
      private String[] T001I3_A199TipoParCodigo ;
      private String[] T001I3_A4UsuarioCodigo ;
      private String[] T001I12_A41ClinicaCodigo ;
      private String[] T001I12_A199TipoParCodigo ;
      private int[] T001I12_A290MovReversadoId ;
      private short[] T001I12_A291MovReversadoLinea ;
      private String[] T001I13_A41ClinicaCodigo ;
      private String[] T001I13_A199TipoParCodigo ;
      private int[] T001I13_A290MovReversadoId ;
      private short[] T001I13_A291MovReversadoLinea ;
      private int[] T001I14_A290MovReversadoId ;
      private short[] T001I14_A291MovReversadoLinea ;
      private DateTime[] T001I14_A292MovReversadoFecha ;
      private String[] T001I14_A293MovReversadoHora ;
      private String[] T001I14_A294MovReversadoObs ;
      private String[] T001I14_A295MovReversadoReferencia ;
      private decimal[] T001I14_A296MovReversadoDebe ;
      private decimal[] T001I14_A297MovReversadoHaber ;
      private DateTime[] T001I14_A298MovReversadoFechaR ;
      private String[] T001I14_A299MovReversadoHoraR ;
      private String[] T001I14_A41ClinicaCodigo ;
      private String[] T001I14_A193CtaContableCodigo ;
      private String[] T001I14_A199TipoParCodigo ;
      private String[] T001I14_A4UsuarioCodigo ;
      private String[] T001I18_A41ClinicaCodigo ;
      private String[] T001I18_A199TipoParCodigo ;
      private int[] T001I18_A290MovReversadoId ;
      private short[] T001I18_A291MovReversadoLinea ;
      private String[] T001I19_A41ClinicaCodigo ;
      private String[] T001I20_A41ClinicaCodigo ;
      private String[] T001I21_A4UsuarioCodigo ;
      private int[] T001I2_A290MovReversadoId ;
      private short[] T001I2_A291MovReversadoLinea ;
      private DateTime[] T001I2_A292MovReversadoFecha ;
      private String[] T001I2_A293MovReversadoHora ;
      private String[] T001I2_A294MovReversadoObs ;
      private String[] T001I2_A295MovReversadoReferencia ;
      private decimal[] T001I2_A296MovReversadoDebe ;
      private decimal[] T001I2_A297MovReversadoHaber ;
      private DateTime[] T001I2_A298MovReversadoFechaR ;
      private String[] T001I2_A299MovReversadoHoraR ;
      private String[] T001I2_A41ClinicaCodigo ;
      private String[] T001I2_A193CtaContableCodigo ;
      private String[] T001I2_A199TipoParCodigo ;
      private String[] T001I2_A4UsuarioCodigo ;
      private GXWebForm Form ;
   }

   public class movimientoreversado__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[19])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001I2 ;
          prmT001I2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I7 ;
          prmT001I7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I4 ;
          prmT001I4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I5 ;
          prmT001I5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I6 ;
          prmT001I6 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I8 ;
          prmT001I8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I9 ;
          prmT001I9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I10 ;
          prmT001I10 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I11 ;
          prmT001I11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I3 ;
          prmT001I3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I12 ;
          prmT001I12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I13 ;
          prmT001I13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I14 ;
          prmT001I14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I15 ;
          prmT001I15 = new Object[] {
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovReversadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovReversadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@MovReversadoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovReversadoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@MovReversadoDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovReversadoHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovReversadoFechaR",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovReversadoHoraR",SqlDbType.Char,8,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I16 ;
          prmT001I16 = new Object[] {
          new Object[] {"@MovReversadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovReversadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@MovReversadoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovReversadoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@MovReversadoDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovReversadoHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovReversadoFechaR",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovReversadoHoraR",SqlDbType.Char,8,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I17 ;
          prmT001I17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001I18 ;
          prmT001I18 = new Object[] {
          } ;
          Object[] prmT001I19 ;
          prmT001I19 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I20 ;
          prmT001I20 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001I21 ;
          prmT001I21 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001I2", "SELECT [MovReversadoId], [MovReversadoLinea], [MovReversadoFecha], [MovReversadoHora], [MovReversadoObs], [MovReversadoReferencia], [MovReversadoDebe], [MovReversadoHaber], [MovReversadoFechaR], [MovReversadoHoraR], [ClinicaCodigo], [CtaContableCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [MovimientoReversado] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovReversadoId] = @MovReversadoId AND [MovReversadoLinea] = @MovReversadoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I2,1,0,true,false )
             ,new CursorDef("T001I3", "SELECT [MovReversadoId], [MovReversadoLinea], [MovReversadoFecha], [MovReversadoHora], [MovReversadoObs], [MovReversadoReferencia], [MovReversadoDebe], [MovReversadoHaber], [MovReversadoFechaR], [MovReversadoHoraR], [ClinicaCodigo], [CtaContableCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [MovimientoReversado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovReversadoId] = @MovReversadoId AND [MovReversadoLinea] = @MovReversadoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I3,1,0,true,false )
             ,new CursorDef("T001I4", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I4,1,0,true,false )
             ,new CursorDef("T001I5", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I5,1,0,true,false )
             ,new CursorDef("T001I6", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I6,1,0,true,false )
             ,new CursorDef("T001I7", "SELECT TM1.[MovReversadoId], TM1.[MovReversadoLinea], TM1.[MovReversadoFecha], TM1.[MovReversadoHora], TM1.[MovReversadoObs], TM1.[MovReversadoReferencia], TM1.[MovReversadoDebe], TM1.[MovReversadoHaber], TM1.[MovReversadoFechaR], TM1.[MovReversadoHoraR], TM1.[ClinicaCodigo], TM1.[CtaContableCodigo], TM1.[TipoParCodigo], TM1.[UsuarioCodigo] FROM [MovimientoReversado] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[TipoParCodigo] = @TipoParCodigo and TM1.[MovReversadoId] = @MovReversadoId and TM1.[MovReversadoLinea] = @MovReversadoLinea ORDER BY TM1.[ClinicaCodigo], TM1.[TipoParCodigo], TM1.[MovReversadoId], TM1.[MovReversadoLinea]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001I7,100,0,true,false )
             ,new CursorDef("T001I8", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I8,1,0,true,false )
             ,new CursorDef("T001I9", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I9,1,0,true,false )
             ,new CursorDef("T001I10", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I10,1,0,true,false )
             ,new CursorDef("T001I11", "SELECT [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea] FROM [MovimientoReversado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovReversadoId] = @MovReversadoId AND [MovReversadoLinea] = @MovReversadoLinea  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001I11,1,0,true,false )
             ,new CursorDef("T001I12", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea] FROM [MovimientoReversado] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] > @TipoParCodigo or [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovReversadoId] > @MovReversadoId or [MovReversadoId] = @MovReversadoId and [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovReversadoLinea] > @MovReversadoLinea) ORDER BY [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001I12,1,0,true,true )
             ,new CursorDef("T001I13", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea] FROM [MovimientoReversado] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] < @TipoParCodigo or [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovReversadoId] < @MovReversadoId or [MovReversadoId] = @MovReversadoId and [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovReversadoLinea] < @MovReversadoLinea) ORDER BY [ClinicaCodigo] DESC, [TipoParCodigo] DESC, [MovReversadoId] DESC, [MovReversadoLinea] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001I13,1,0,true,true )
             ,new CursorDef("T001I14", "SELECT [MovReversadoId], [MovReversadoLinea], [MovReversadoFecha], [MovReversadoHora], [MovReversadoObs], [MovReversadoReferencia], [MovReversadoDebe], [MovReversadoHaber], [MovReversadoFechaR], [MovReversadoHoraR], [ClinicaCodigo], [CtaContableCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [MovimientoReversado] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovReversadoId] = @MovReversadoId AND [MovReversadoLinea] = @MovReversadoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I14,1,0,true,false )
             ,new CursorDef("T001I15", "INSERT INTO [MovimientoReversado] ([MovReversadoId], [MovReversadoLinea], [MovReversadoFecha], [MovReversadoHora], [MovReversadoObs], [MovReversadoReferencia], [MovReversadoDebe], [MovReversadoHaber], [MovReversadoFechaR], [MovReversadoHoraR], [ClinicaCodigo], [CtaContableCodigo], [TipoParCodigo], [UsuarioCodigo]) VALUES (@MovReversadoId, @MovReversadoLinea, @MovReversadoFecha, @MovReversadoHora, @MovReversadoObs, @MovReversadoReferencia, @MovReversadoDebe, @MovReversadoHaber, @MovReversadoFechaR, @MovReversadoHoraR, @ClinicaCodigo, @CtaContableCodigo, @TipoParCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001I15)
             ,new CursorDef("T001I16", "UPDATE [MovimientoReversado] SET [MovReversadoFecha]=@MovReversadoFecha, [MovReversadoHora]=@MovReversadoHora, [MovReversadoObs]=@MovReversadoObs, [MovReversadoReferencia]=@MovReversadoReferencia, [MovReversadoDebe]=@MovReversadoDebe, [MovReversadoHaber]=@MovReversadoHaber, [MovReversadoFechaR]=@MovReversadoFechaR, [MovReversadoHoraR]=@MovReversadoHoraR, [CtaContableCodigo]=@CtaContableCodigo, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovReversadoId] = @MovReversadoId AND [MovReversadoLinea] = @MovReversadoLinea", GxErrorMask.GX_NOMASK,prmT001I16)
             ,new CursorDef("T001I17", "DELETE FROM [MovimientoReversado]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovReversadoId] = @MovReversadoId AND [MovReversadoLinea] = @MovReversadoLinea", GxErrorMask.GX_NOMASK,prmT001I17)
             ,new CursorDef("T001I18", "SELECT [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea] FROM [MovimientoReversado] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001I18,100,0,true,false )
             ,new CursorDef("T001I19", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I19,1,0,true,false )
             ,new CursorDef("T001I20", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I20,1,0,true,false )
             ,new CursorDef("T001I21", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001I21,1,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 8) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 8) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 8) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 8) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getString(10, 8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 19 :
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
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
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
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                stmt.SetParameter(8, (decimal)parms[7]);
                stmt.SetParameter(9, (DateTime)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                break;
             case 14 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (int)parms[12]);
                stmt.SetParameter(14, (short)parms[13]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
