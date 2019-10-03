/*
               File: MovimientoMayorizado
        Description: Movimiento mayorizado de partidas contables
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:26.79
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
   public class movimientomayorizado : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
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
            gxLoad_3( A41ClinicaCodigo, A193CtaContableCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
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
            gxLoad_4( A41ClinicaCodigo, A199TipoParCodigo) ;
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
         Form.Meta.addItem("Description", "Movimiento mayorizado de partidas contables", 0) ;
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

      public movimientomayorizado( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public movimientomayorizado( IGxContext context )
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
            wb_table1_2_1655( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1655e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1655( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1655( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1655e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Movimiento mayorizado de partidas contables"+"</legend>") ;
            wb_table3_27_1655( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1655e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1655e( true) ;
         }
         else
         {
            wb_table1_2_1655e( false) ;
         }
      }

      protected void wb_table3_27_1655( bool wbgen )
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
            wb_table4_33_1655( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1655e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoMayorizado.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoMayorizado.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1655e( true) ;
         }
         else
         {
            wb_table3_27_1655e( false) ;
         }
      }

      protected void wb_table4_33_1655( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparcodigo_Internalname, "Tipo_Partida", "", "", lblTextblocktipoparcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoParCodigo_Internalname, StringUtil.RTrim( A199TipoParCodigo), StringUtil.RTrim( context.localUtil.Format( A199TipoParCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtTipoParCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoParCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoMayorizado.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_199_Internalname, "prompt.gif", imgprompt_41_199_Link, "", "", "Fantastic", imgprompt_41_199_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadoid_Internalname, "Partida", "", "", lblTextblockmovmayorizadoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovMayorizadoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A217MovMayorizadoId), 9, 0, ".", "")), ((edtMovMayorizadoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A217MovMayorizadoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A217MovMayorizadoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtMovMayorizadoId_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovMayorizadoId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadolinea_Internalname, "Línea", "", "", lblTextblockmovmayorizadolinea_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovMayorizadoLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A218MovMayorizadoLinea), 4, 0, ".", "")), ((edtMovMayorizadoLinea_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A218MovMayorizadoLinea), "ZZZ9")) : context.localUtil.Format( (decimal)(A218MovMayorizadoLinea), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(53);\"", "", "", "", "", edtMovMayorizadoLinea_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovMayorizadoLinea_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadofecha_Internalname, "Fecha", "", "", lblTextblockmovmayorizadofecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219MovMayorizadoFecha", context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtMovMayorizadoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtMovMayorizadoFecha_Internalname, context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"), context.localUtil.Format( A219MovMayorizadoFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(58);\"", "", "", "", "", edtMovMayorizadoFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovMayorizadoFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoMayorizado.htm");
            GxWebStd.gx_bitmap( context, edtMovMayorizadoFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtMovMayorizadoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadohora_Internalname, "Hora", "", "", lblTextblockmovmayorizadohora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220MovMayorizadoHora", A220MovMayorizadoHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovMayorizadoHora_Internalname, StringUtil.RTrim( A220MovMayorizadoHora), StringUtil.RTrim( context.localUtil.Format( A220MovMayorizadoHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtMovMayorizadoHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovMayorizadoHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadoobs_Internalname, "Observaciones", "", "", lblTextblockmovmayorizadoobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221MovMayorizadoObs", A221MovMayorizadoObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtMovMayorizadoObs_Internalname, StringUtil.RTrim( A221MovMayorizadoObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, 1, edtMovMayorizadoObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadoreferencia_Internalname, "Referencia", "", "", lblTextblockmovmayorizadoreferencia_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222MovMayorizadoReferencia", A222MovMayorizadoReferencia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovMayorizadoReferencia_Internalname, StringUtil.RTrim( A222MovMayorizadoReferencia), StringUtil.RTrim( context.localUtil.Format( A222MovMayorizadoReferencia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", "", "", "", edtMovMayorizadoReferencia_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovMayorizadoReferencia_Enabled, 0, 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablecodigo_Internalname, "Cta_Contable", "", "", lblTextblockctacontablecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCtaContableCodigo_Internalname, StringUtil.RTrim( A193CtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( A193CtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", "", "", "", edtCtaContableCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCtaContableCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoMayorizado.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_193_Internalname, "prompt.gif", imgprompt_41_193_Link, "", "", "Fantastic", imgprompt_41_193_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadodebe_Internalname, "Debe", "", "", lblTextblockmovmayorizadodebe_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223MovMayorizadoDebe", StringUtil.LTrim( StringUtil.Str( A223MovMayorizadoDebe, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovMayorizadoDebe_Internalname, StringUtil.LTrim( StringUtil.NToC( A223MovMayorizadoDebe, 17, 2, ".", "")), ((edtMovMayorizadoDebe_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A223MovMayorizadoDebe, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A223MovMayorizadoDebe, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(83);\"", "", "", "", "", edtMovMayorizadoDebe_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovMayorizadoDebe_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadohaber_Internalname, "Haber", "", "", lblTextblockmovmayorizadohaber_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224MovMayorizadoHaber", StringUtil.LTrim( StringUtil.Str( A224MovMayorizadoHaber, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovMayorizadoHaber_Internalname, StringUtil.LTrim( StringUtil.NToC( A224MovMayorizadoHaber, 17, 2, ".", "")), ((edtMovMayorizadoHaber_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A224MovMayorizadoHaber, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A224MovMayorizadoHaber, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(88);\"", "", "", "", "", edtMovMayorizadoHaber_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovMayorizadoHaber_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(93);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoMayorizado.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoMayorizado.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1655e( true) ;
         }
         else
         {
            wb_table4_33_1655e( false) ;
         }
      }

      protected void wb_table2_5_1655( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01j0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVMAYORIZADOID"+"'), id:'"+"MOVMAYORIZADOID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVMAYORIZADOLINEA"+"'), id:'"+"MOVMAYORIZADOLINEA"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01j0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOPARCODIGO"+"'), id:'"+"TIPOPARCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVMAYORIZADOID"+"'), id:'"+"MOVMAYORIZADOID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVMAYORIZADOLINEA"+"'), id:'"+"MOVMAYORIZADOLINEA"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoMayorizado.htm");
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
            wb_table2_5_1655e( true) ;
         }
         else
         {
            wb_table2_5_1655e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovMayorizadoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovMayorizadoId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVMAYORIZADOID");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovMayorizadoId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A217MovMayorizadoId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
               }
               else
               {
                  A217MovMayorizadoId = (int)(context.localUtil.CToN( cgiGet( edtMovMayorizadoId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovMayorizadoLinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovMayorizadoLinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVMAYORIZADOLINEA");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovMayorizadoLinea_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A218MovMayorizadoLinea = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
               }
               else
               {
                  A218MovMayorizadoLinea = (short)(context.localUtil.CToN( cgiGet( edtMovMayorizadoLinea_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtMovMayorizadoFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "MOVMAYORIZADOFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovMayorizadoFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A219MovMayorizadoFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219MovMayorizadoFecha", context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"));
               }
               else
               {
                  A219MovMayorizadoFecha = context.localUtil.CToD( cgiGet( edtMovMayorizadoFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219MovMayorizadoFecha", context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"));
               }
               A220MovMayorizadoHora = cgiGet( edtMovMayorizadoHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220MovMayorizadoHora", A220MovMayorizadoHora);
               A221MovMayorizadoObs = cgiGet( edtMovMayorizadoObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221MovMayorizadoObs", A221MovMayorizadoObs);
               A222MovMayorizadoReferencia = cgiGet( edtMovMayorizadoReferencia_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222MovMayorizadoReferencia", A222MovMayorizadoReferencia);
               A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovMayorizadoDebe_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovMayorizadoDebe_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVMAYORIZADODEBE");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovMayorizadoDebe_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A223MovMayorizadoDebe = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223MovMayorizadoDebe", StringUtil.LTrim( StringUtil.Str( A223MovMayorizadoDebe, 17, 2)));
               }
               else
               {
                  A223MovMayorizadoDebe = context.localUtil.CToN( cgiGet( edtMovMayorizadoDebe_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223MovMayorizadoDebe", StringUtil.LTrim( StringUtil.Str( A223MovMayorizadoDebe, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovMayorizadoHaber_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovMayorizadoHaber_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVMAYORIZADOHABER");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovMayorizadoHaber_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A224MovMayorizadoHaber = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224MovMayorizadoHaber", StringUtil.LTrim( StringUtil.Str( A224MovMayorizadoHaber, 17, 2)));
               }
               else
               {
                  A224MovMayorizadoHaber = context.localUtil.CToN( cgiGet( edtMovMayorizadoHaber_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224MovMayorizadoHaber", StringUtil.LTrim( StringUtil.Str( A224MovMayorizadoHaber, 17, 2)));
               }
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z199TipoParCodigo = cgiGet( "Z199TipoParCodigo") ;
               Z217MovMayorizadoId = (int)(context.localUtil.CToN( cgiGet( "Z217MovMayorizadoId"), ".", ",")) ;
               Z218MovMayorizadoLinea = (short)(context.localUtil.CToN( cgiGet( "Z218MovMayorizadoLinea"), ".", ",")) ;
               Z219MovMayorizadoFecha = context.localUtil.CToD( cgiGet( "Z219MovMayorizadoFecha"), 0) ;
               Z220MovMayorizadoHora = cgiGet( "Z220MovMayorizadoHora") ;
               Z221MovMayorizadoObs = cgiGet( "Z221MovMayorizadoObs") ;
               Z222MovMayorizadoReferencia = cgiGet( "Z222MovMayorizadoReferencia") ;
               Z223MovMayorizadoDebe = context.localUtil.CToN( cgiGet( "Z223MovMayorizadoDebe"), ".", ",") ;
               Z224MovMayorizadoHaber = context.localUtil.CToN( cgiGet( "Z224MovMayorizadoHaber"), ".", ",") ;
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
                  A217MovMayorizadoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
                  A218MovMayorizadoLinea = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
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
               InitAll1655( ) ;
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
         DisableAttributes1655( ) ;
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

      protected void ResetCaption160( )
      {
      }

      protected void ZM1655( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z219MovMayorizadoFecha = T00163_A219MovMayorizadoFecha[0] ;
               Z220MovMayorizadoHora = T00163_A220MovMayorizadoHora[0] ;
               Z221MovMayorizadoObs = T00163_A221MovMayorizadoObs[0] ;
               Z222MovMayorizadoReferencia = T00163_A222MovMayorizadoReferencia[0] ;
               Z223MovMayorizadoDebe = T00163_A223MovMayorizadoDebe[0] ;
               Z224MovMayorizadoHaber = T00163_A224MovMayorizadoHaber[0] ;
               Z193CtaContableCodigo = T00163_A193CtaContableCodigo[0] ;
               Z4UsuarioCodigo = T00163_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z219MovMayorizadoFecha = A219MovMayorizadoFecha ;
               Z220MovMayorizadoHora = A220MovMayorizadoHora ;
               Z221MovMayorizadoObs = A221MovMayorizadoObs ;
               Z222MovMayorizadoReferencia = A222MovMayorizadoReferencia ;
               Z223MovMayorizadoDebe = A223MovMayorizadoDebe ;
               Z224MovMayorizadoHaber = A224MovMayorizadoHaber ;
               Z193CtaContableCodigo = A193CtaContableCodigo ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z217MovMayorizadoId = A217MovMayorizadoId ;
            Z218MovMayorizadoLinea = A218MovMayorizadoLinea ;
            Z219MovMayorizadoFecha = A219MovMayorizadoFecha ;
            Z220MovMayorizadoHora = A220MovMayorizadoHora ;
            Z221MovMayorizadoObs = A221MovMayorizadoObs ;
            Z222MovMayorizadoReferencia = A222MovMayorizadoReferencia ;
            Z223MovMayorizadoDebe = A223MovMayorizadoDebe ;
            Z224MovMayorizadoHaber = A224MovMayorizadoHaber ;
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

      protected void Load1655( )
      {
         /* Using cursor T00167 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound55 = 1 ;
            A219MovMayorizadoFecha = T00167_A219MovMayorizadoFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219MovMayorizadoFecha", context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"));
            A220MovMayorizadoHora = T00167_A220MovMayorizadoHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220MovMayorizadoHora", A220MovMayorizadoHora);
            A221MovMayorizadoObs = T00167_A221MovMayorizadoObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221MovMayorizadoObs", A221MovMayorizadoObs);
            A222MovMayorizadoReferencia = T00167_A222MovMayorizadoReferencia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222MovMayorizadoReferencia", A222MovMayorizadoReferencia);
            A223MovMayorizadoDebe = T00167_A223MovMayorizadoDebe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223MovMayorizadoDebe", StringUtil.LTrim( StringUtil.Str( A223MovMayorizadoDebe, 17, 2)));
            A224MovMayorizadoHaber = T00167_A224MovMayorizadoHaber[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224MovMayorizadoHaber", StringUtil.LTrim( StringUtil.Str( A224MovMayorizadoHaber, 17, 2)));
            A193CtaContableCodigo = T00167_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            A4UsuarioCodigo = T00167_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM1655( -2) ;
         }
         pr_default.close(5);
         OnLoadActions1655( ) ;
      }

      protected void OnLoadActions1655( )
      {
      }

      protected void CheckExtendedTable1655( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00164 */
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
         /* Using cursor T00165 */
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
         if ( ! ( (DateTime.MinValue==A219MovMayorizadoFecha) || ( A219MovMayorizadoFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T00166 */
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
      }

      protected void CloseExtendedTableCursors1655( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( String A41ClinicaCodigo ,
                               String A193CtaContableCodigo )
      {
         /* Using cursor T00168 */
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

      protected void gxLoad_4( String A41ClinicaCodigo ,
                               String A199TipoParCodigo )
      {
         /* Using cursor T00169 */
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

      protected void gxLoad_5( String A4UsuarioCodigo )
      {
         /* Using cursor T001610 */
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

      protected void GetKey1655( )
      {
         /* Using cursor T001611 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound55 = 1 ;
         }
         else
         {
            RcdFound55 = 0 ;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00163 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1655( 2) ;
            RcdFound55 = 1 ;
            A217MovMayorizadoId = T00163_A217MovMayorizadoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
            A218MovMayorizadoLinea = T00163_A218MovMayorizadoLinea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
            A219MovMayorizadoFecha = T00163_A219MovMayorizadoFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219MovMayorizadoFecha", context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"));
            A220MovMayorizadoHora = T00163_A220MovMayorizadoHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220MovMayorizadoHora", A220MovMayorizadoHora);
            A221MovMayorizadoObs = T00163_A221MovMayorizadoObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221MovMayorizadoObs", A221MovMayorizadoObs);
            A222MovMayorizadoReferencia = T00163_A222MovMayorizadoReferencia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222MovMayorizadoReferencia", A222MovMayorizadoReferencia);
            A223MovMayorizadoDebe = T00163_A223MovMayorizadoDebe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223MovMayorizadoDebe", StringUtil.LTrim( StringUtil.Str( A223MovMayorizadoDebe, 17, 2)));
            A224MovMayorizadoHaber = T00163_A224MovMayorizadoHaber[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224MovMayorizadoHaber", StringUtil.LTrim( StringUtil.Str( A224MovMayorizadoHaber, 17, 2)));
            A41ClinicaCodigo = T00163_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A193CtaContableCodigo = T00163_A193CtaContableCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
            A199TipoParCodigo = T00163_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A4UsuarioCodigo = T00163_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z199TipoParCodigo = A199TipoParCodigo ;
            Z217MovMayorizadoId = A217MovMayorizadoId ;
            Z218MovMayorizadoLinea = A218MovMayorizadoLinea ;
            sMode55 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1655( ) ;
            Gx_mode = sMode55 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound55 = 0 ;
            InitializeNonKey1655( ) ;
            sMode55 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode55 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1655( ) ;
         if ( RcdFound55 == 0 )
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
         RcdFound55 = 0 ;
         /* Using cursor T001612 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T001612_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001612_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001612_A199TipoParCodigo[0], A199TipoParCodigo) < 0 ) || ( StringUtil.StrCmp(T001612_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001612_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001612_A217MovMayorizadoId[0] < A217MovMayorizadoId ) || ( T001612_A217MovMayorizadoId[0] == A217MovMayorizadoId ) && ( StringUtil.StrCmp(T001612_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001612_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001612_A218MovMayorizadoLinea[0] < A218MovMayorizadoLinea ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( StringUtil.StrCmp(T001612_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001612_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001612_A199TipoParCodigo[0], A199TipoParCodigo) > 0 ) || ( StringUtil.StrCmp(T001612_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001612_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001612_A217MovMayorizadoId[0] > A217MovMayorizadoId ) || ( T001612_A217MovMayorizadoId[0] == A217MovMayorizadoId ) && ( StringUtil.StrCmp(T001612_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001612_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001612_A218MovMayorizadoLinea[0] > A218MovMayorizadoLinea ) ) )
            {
               A41ClinicaCodigo = T001612_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = T001612_A199TipoParCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A217MovMayorizadoId = T001612_A217MovMayorizadoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
               A218MovMayorizadoLinea = T001612_A218MovMayorizadoLinea[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
               RcdFound55 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound55 = 0 ;
         /* Using cursor T001613 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T001613_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001613_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001613_A199TipoParCodigo[0], A199TipoParCodigo) > 0 ) || ( StringUtil.StrCmp(T001613_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001613_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001613_A217MovMayorizadoId[0] > A217MovMayorizadoId ) || ( T001613_A217MovMayorizadoId[0] == A217MovMayorizadoId ) && ( StringUtil.StrCmp(T001613_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001613_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001613_A218MovMayorizadoLinea[0] > A218MovMayorizadoLinea ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( StringUtil.StrCmp(T001613_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001613_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001613_A199TipoParCodigo[0], A199TipoParCodigo) < 0 ) || ( StringUtil.StrCmp(T001613_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001613_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001613_A217MovMayorizadoId[0] < A217MovMayorizadoId ) || ( T001613_A217MovMayorizadoId[0] == A217MovMayorizadoId ) && ( StringUtil.StrCmp(T001613_A199TipoParCodigo[0], A199TipoParCodigo) == 0 ) && ( StringUtil.StrCmp(T001613_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001613_A218MovMayorizadoLinea[0] < A218MovMayorizadoLinea ) ) )
            {
               A41ClinicaCodigo = T001613_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = T001613_A199TipoParCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A217MovMayorizadoId = T001613_A217MovMayorizadoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
               A218MovMayorizadoLinea = T001613_A218MovMayorizadoLinea[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
               RcdFound55 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1655( ) ;
         if ( RcdFound55 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A217MovMayorizadoId != Z217MovMayorizadoId ) || ( A218MovMayorizadoLinea != Z218MovMayorizadoLinea ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A199TipoParCodigo = Z199TipoParCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
               A217MovMayorizadoId = Z217MovMayorizadoId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
               A218MovMayorizadoLinea = Z218MovMayorizadoLinea ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
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
               Update1655( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A217MovMayorizadoId != Z217MovMayorizadoId ) || ( A218MovMayorizadoLinea != Z218MovMayorizadoLinea ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1655( ) ;
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
                  Insert1655( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A199TipoParCodigo, Z199TipoParCodigo) != 0 ) || ( A217MovMayorizadoId != Z217MovMayorizadoId ) || ( A218MovMayorizadoLinea != Z218MovMayorizadoLinea ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = Z199TipoParCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A217MovMayorizadoId = Z217MovMayorizadoId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
            A218MovMayorizadoLinea = Z218MovMayorizadoLinea ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
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
         if ( RcdFound55 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtMovMayorizadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1655( ) ;
         if ( RcdFound55 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovMayorizadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1655( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound55 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovMayorizadoFecha_Internalname ;
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
         if ( RcdFound55 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovMayorizadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1655( ) ;
         if ( RcdFound55 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound55 != 0 )
            {
               ScanNext1655( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovMayorizadoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1655( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1655( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001614 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
            if ( (pr_default.getStatus(12) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MovimientoMayorizado"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(12) == 101) || ( Z219MovMayorizadoFecha != T001614_A219MovMayorizadoFecha[0] ) || ( StringUtil.StrCmp(Z220MovMayorizadoHora, T001614_A220MovMayorizadoHora[0]) != 0 ) || ( StringUtil.StrCmp(Z221MovMayorizadoObs, T001614_A221MovMayorizadoObs[0]) != 0 ) || ( StringUtil.StrCmp(Z222MovMayorizadoReferencia, T001614_A222MovMayorizadoReferencia[0]) != 0 ) || ( Z223MovMayorizadoDebe != T001614_A223MovMayorizadoDebe[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z224MovMayorizadoHaber != T001614_A224MovMayorizadoHaber[0] ) || ( StringUtil.StrCmp(Z193CtaContableCodigo, T001614_A193CtaContableCodigo[0]) != 0 ) || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001614_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MovimientoMayorizado"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1655( )
      {
         BeforeValidate1655( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1655( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1655( 0) ;
            CheckOptimisticConcurrency1655( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1655( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1655( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001615 */
                     pr_default.execute(13, new Object[] {A217MovMayorizadoId, A218MovMayorizadoLinea, A219MovMayorizadoFecha, A220MovMayorizadoHora, A221MovMayorizadoObs, A222MovMayorizadoReferencia, A223MovMayorizadoDebe, A224MovMayorizadoHaber, A41ClinicaCodigo, A193CtaContableCodigo, A199TipoParCodigo, A4UsuarioCodigo});
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
                           ResetCaption160( ) ;
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
               Load1655( ) ;
            }
            EndLevel1655( ) ;
         }
         CloseExtendedTableCursors1655( ) ;
      }

      protected void Update1655( )
      {
         BeforeValidate1655( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1655( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1655( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1655( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1655( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001616 */
                     pr_default.execute(14, new Object[] {A219MovMayorizadoFecha, A220MovMayorizadoHora, A221MovMayorizadoObs, A222MovMayorizadoReferencia, A223MovMayorizadoDebe, A224MovMayorizadoHaber, A193CtaContableCodigo, A4UsuarioCodigo, A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MovimientoMayorizado"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1655( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption160( ) ;
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
            EndLevel1655( ) ;
         }
         CloseExtendedTableCursors1655( ) ;
      }

      protected void DeferredUpdate1655( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1655( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1655( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1655( ) ;
            AfterConfirm1655( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1655( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001617 */
                  pr_default.execute(15, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
                  pr_default.close(15);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound55 == 0 )
                        {
                           InitAll1655( ) ;
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
                        ResetCaption160( ) ;
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
         sMode55 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1655( ) ;
         Gx_mode = sMode55 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1655( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1655( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1655( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(11);
            pr_default.close(10);
            context.CommitDataStores("MovimientoMayorizado");
            if ( AnyError == 0 )
            {
               ConfirmValues160( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(11);
            pr_default.close(10);
            context.RollbackDataStores("MovimientoMayorizado");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1655( )
      {
         /* Using cursor T001618 */
         pr_default.execute(16);
         RcdFound55 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound55 = 1 ;
            A41ClinicaCodigo = T001618_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T001618_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A217MovMayorizadoId = T001618_A217MovMayorizadoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
            A218MovMayorizadoLinea = T001618_A218MovMayorizadoLinea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1655( )
      {
         pr_default.readNext(16);
         RcdFound55 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound55 = 1 ;
            A41ClinicaCodigo = T001618_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A199TipoParCodigo = T001618_A199TipoParCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
            A217MovMayorizadoId = T001618_A217MovMayorizadoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
            A218MovMayorizadoLinea = T001618_A218MovMayorizadoLinea[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
         }
      }

      protected void ScanEnd1655( )
      {
      }

      protected void AfterConfirm1655( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1655( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1655( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1655( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1655( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1655( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1655( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtTipoParCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoParCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoParCodigo_Enabled), 5, 0)));
         edtMovMayorizadoId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovMayorizadoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovMayorizadoId_Enabled), 5, 0)));
         edtMovMayorizadoLinea_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovMayorizadoLinea_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovMayorizadoLinea_Enabled), 5, 0)));
         edtMovMayorizadoFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovMayorizadoFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovMayorizadoFecha_Enabled), 5, 0)));
         edtMovMayorizadoHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovMayorizadoHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovMayorizadoHora_Enabled), 5, 0)));
         edtMovMayorizadoObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovMayorizadoObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovMayorizadoObs_Enabled), 5, 0)));
         edtMovMayorizadoReferencia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovMayorizadoReferencia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovMayorizadoReferencia_Enabled), 5, 0)));
         edtCtaContableCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCtaContableCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCtaContableCodigo_Enabled), 5, 0)));
         edtMovMayorizadoDebe_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovMayorizadoDebe_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovMayorizadoDebe_Enabled), 5, 0)));
         edtMovMayorizadoHaber_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovMayorizadoHaber_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovMayorizadoHaber_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues160( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("movimientomayorizado.aspx") +"\" class=\""+"Form"+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z217MovMayorizadoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z217MovMayorizadoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z218MovMayorizadoLinea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z219MovMayorizadoFecha", context.localUtil.DToC( Z219MovMayorizadoFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z220MovMayorizadoHora", StringUtil.RTrim( Z220MovMayorizadoHora));
         GxWebStd.gx_hidden_field( context, "Z221MovMayorizadoObs", StringUtil.RTrim( Z221MovMayorizadoObs));
         GxWebStd.gx_hidden_field( context, "Z222MovMayorizadoReferencia", StringUtil.RTrim( Z222MovMayorizadoReferencia));
         GxWebStd.gx_hidden_field( context, "Z223MovMayorizadoDebe", StringUtil.LTrim( StringUtil.NToC( Z223MovMayorizadoDebe, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z224MovMayorizadoHaber", StringUtil.LTrim( StringUtil.NToC( Z224MovMayorizadoHaber, 17, 2, ".", "")));
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
         return "MovimientoMayorizado" ;
      }

      public override String GetPgmdesc( )
      {
         return "Movimiento mayorizado de partidas contables" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("movimientomayorizado.aspx")  ;
      }

      protected void InitializeNonKey1655( )
      {
         A219MovMayorizadoFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219MovMayorizadoFecha", context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"));
         A220MovMayorizadoHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220MovMayorizadoHora", A220MovMayorizadoHora);
         A221MovMayorizadoObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221MovMayorizadoObs", A221MovMayorizadoObs);
         A222MovMayorizadoReferencia = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222MovMayorizadoReferencia", A222MovMayorizadoReferencia);
         A193CtaContableCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193CtaContableCodigo", A193CtaContableCodigo);
         A223MovMayorizadoDebe = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223MovMayorizadoDebe", StringUtil.LTrim( StringUtil.Str( A223MovMayorizadoDebe, 17, 2)));
         A224MovMayorizadoHaber = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224MovMayorizadoHaber", StringUtil.LTrim( StringUtil.Str( A224MovMayorizadoHaber, 17, 2)));
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
      }

      protected void InitAll1655( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A199TipoParCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199TipoParCodigo", A199TipoParCodigo);
         A217MovMayorizadoId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217MovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A217MovMayorizadoId), 9, 0)));
         A218MovMayorizadoLinea = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218MovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(A218MovMayorizadoLinea), 4, 0)));
         InitializeNonKey1655( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1562916");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("movimientomayorizado.js", "?1562916");
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
         lblTextblockmovmayorizadoid_Internalname = "TEXTBLOCKMOVMAYORIZADOID" ;
         edtMovMayorizadoId_Internalname = "MOVMAYORIZADOID" ;
         lblTextblockmovmayorizadolinea_Internalname = "TEXTBLOCKMOVMAYORIZADOLINEA" ;
         edtMovMayorizadoLinea_Internalname = "MOVMAYORIZADOLINEA" ;
         lblTextblockmovmayorizadofecha_Internalname = "TEXTBLOCKMOVMAYORIZADOFECHA" ;
         edtMovMayorizadoFecha_Internalname = "MOVMAYORIZADOFECHA" ;
         lblTextblockmovmayorizadohora_Internalname = "TEXTBLOCKMOVMAYORIZADOHORA" ;
         edtMovMayorizadoHora_Internalname = "MOVMAYORIZADOHORA" ;
         lblTextblockmovmayorizadoobs_Internalname = "TEXTBLOCKMOVMAYORIZADOOBS" ;
         edtMovMayorizadoObs_Internalname = "MOVMAYORIZADOOBS" ;
         lblTextblockmovmayorizadoreferencia_Internalname = "TEXTBLOCKMOVMAYORIZADOREFERENCIA" ;
         edtMovMayorizadoReferencia_Internalname = "MOVMAYORIZADOREFERENCIA" ;
         lblTextblockctacontablecodigo_Internalname = "TEXTBLOCKCTACONTABLECODIGO" ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO" ;
         lblTextblockmovmayorizadodebe_Internalname = "TEXTBLOCKMOVMAYORIZADODEBE" ;
         edtMovMayorizadoDebe_Internalname = "MOVMAYORIZADODEBE" ;
         lblTextblockmovmayorizadohaber_Internalname = "TEXTBLOCKMOVMAYORIZADOHABER" ;
         edtMovMayorizadoHaber_Internalname = "MOVMAYORIZADOHABER" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
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
         Form.Caption = "Movimiento mayorizado de partidas contables" ;
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
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         edtMovMayorizadoHaber_Jsonclick = "" ;
         edtMovMayorizadoHaber_Enabled = 1 ;
         edtMovMayorizadoDebe_Jsonclick = "" ;
         edtMovMayorizadoDebe_Enabled = 1 ;
         imgprompt_41_193_Visible = 1 ;
         imgprompt_41_193_Link = "" ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtCtaContableCodigo_Enabled = 1 ;
         edtMovMayorizadoReferencia_Jsonclick = "" ;
         edtMovMayorizadoReferencia_Enabled = 1 ;
         edtMovMayorizadoObs_Enabled = 1 ;
         edtMovMayorizadoHora_Jsonclick = "" ;
         edtMovMayorizadoHora_Enabled = 1 ;
         edtMovMayorizadoFecha_Jsonclick = "" ;
         edtMovMayorizadoFecha_Enabled = 1 ;
         edtMovMayorizadoLinea_Jsonclick = "" ;
         edtMovMayorizadoLinea_Enabled = 1 ;
         edtMovMayorizadoId_Jsonclick = "" ;
         edtMovMayorizadoId_Enabled = 1 ;
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
         /* Using cursor T001619 */
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
         GX_FocusControl = edtMovMayorizadoFecha_Internalname ;
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
         /* Using cursor T001619 */
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

      public void Valid_Movmayorizadolinea( String GX_Parm1 ,
                                            String GX_Parm2 ,
                                            int GX_Parm3 ,
                                            short GX_Parm4 ,
                                            DateTime GX_Parm5 ,
                                            String GX_Parm6 ,
                                            String GX_Parm7 ,
                                            String GX_Parm8 ,
                                            decimal GX_Parm9 ,
                                            decimal GX_Parm10 ,
                                            String GX_Parm11 ,
                                            String GX_Parm12 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A199TipoParCodigo = GX_Parm2 ;
         A217MovMayorizadoId = GX_Parm3 ;
         A218MovMayorizadoLinea = GX_Parm4 ;
         A219MovMayorizadoFecha = GX_Parm5 ;
         A220MovMayorizadoHora = GX_Parm6 ;
         A221MovMayorizadoObs = GX_Parm7 ;
         A222MovMayorizadoReferencia = GX_Parm8 ;
         A223MovMayorizadoDebe = GX_Parm9 ;
         A224MovMayorizadoHaber = GX_Parm10 ;
         A193CtaContableCodigo = GX_Parm11 ;
         A4UsuarioCodigo = GX_Parm12 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A220MovMayorizadoHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A221MovMayorizadoObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A222MovMayorizadoReferencia)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A193CtaContableCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A223MovMayorizadoDebe, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A224MovMayorizadoHaber, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z199TipoParCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z217MovMayorizadoId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z218MovMayorizadoLinea), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z219MovMayorizadoFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z220MovMayorizadoHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z221MovMayorizadoObs)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z222MovMayorizadoReferencia)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z193CtaContableCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z223MovMayorizadoDebe, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z224MovMayorizadoHaber, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
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
         /* Using cursor T001620 */
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
         /* Using cursor T001621 */
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
         lblTextblockmovmayorizadoid_Jsonclick = "" ;
         lblTextblockmovmayorizadolinea_Jsonclick = "" ;
         lblTextblockmovmayorizadofecha_Jsonclick = "" ;
         A219MovMayorizadoFecha = DateTime.MinValue ;
         lblTextblockmovmayorizadohora_Jsonclick = "" ;
         A220MovMayorizadoHora = "" ;
         lblTextblockmovmayorizadoobs_Jsonclick = "" ;
         A221MovMayorizadoObs = "" ;
         lblTextblockmovmayorizadoreferencia_Jsonclick = "" ;
         A222MovMayorizadoReferencia = "" ;
         lblTextblockctacontablecodigo_Jsonclick = "" ;
         lblTextblockmovmayorizadodebe_Jsonclick = "" ;
         lblTextblockmovmayorizadohaber_Jsonclick = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
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
         Z219MovMayorizadoFecha = DateTime.MinValue ;
         Z220MovMayorizadoHora = "" ;
         Z221MovMayorizadoObs = "" ;
         Z222MovMayorizadoReferencia = "" ;
         Z193CtaContableCodigo = "" ;
         Z4UsuarioCodigo = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00167_A217MovMayorizadoId = new int[1] ;
         T00167_A218MovMayorizadoLinea = new short[1] ;
         T00167_A219MovMayorizadoFecha = new DateTime[] {DateTime.MinValue} ;
         T00167_A220MovMayorizadoHora = new String[] {""} ;
         T00167_A221MovMayorizadoObs = new String[] {""} ;
         T00167_A222MovMayorizadoReferencia = new String[] {""} ;
         T00167_A223MovMayorizadoDebe = new decimal[1] ;
         T00167_A224MovMayorizadoHaber = new decimal[1] ;
         T00167_A41ClinicaCodigo = new String[] {""} ;
         T00167_A193CtaContableCodigo = new String[] {""} ;
         T00167_A199TipoParCodigo = new String[] {""} ;
         T00167_A4UsuarioCodigo = new String[] {""} ;
         T00164_A41ClinicaCodigo = new String[] {""} ;
         T00165_A41ClinicaCodigo = new String[] {""} ;
         T00166_A4UsuarioCodigo = new String[] {""} ;
         T00168_A41ClinicaCodigo = new String[] {""} ;
         T00169_A41ClinicaCodigo = new String[] {""} ;
         T001610_A4UsuarioCodigo = new String[] {""} ;
         T001611_A41ClinicaCodigo = new String[] {""} ;
         T001611_A199TipoParCodigo = new String[] {""} ;
         T001611_A217MovMayorizadoId = new int[1] ;
         T001611_A218MovMayorizadoLinea = new short[1] ;
         T00163_A217MovMayorizadoId = new int[1] ;
         T00163_A218MovMayorizadoLinea = new short[1] ;
         T00163_A219MovMayorizadoFecha = new DateTime[] {DateTime.MinValue} ;
         T00163_A220MovMayorizadoHora = new String[] {""} ;
         T00163_A221MovMayorizadoObs = new String[] {""} ;
         T00163_A222MovMayorizadoReferencia = new String[] {""} ;
         T00163_A223MovMayorizadoDebe = new decimal[1] ;
         T00163_A224MovMayorizadoHaber = new decimal[1] ;
         T00163_A41ClinicaCodigo = new String[] {""} ;
         T00163_A193CtaContableCodigo = new String[] {""} ;
         T00163_A199TipoParCodigo = new String[] {""} ;
         T00163_A4UsuarioCodigo = new String[] {""} ;
         sMode55 = "" ;
         T001612_A41ClinicaCodigo = new String[] {""} ;
         T001612_A199TipoParCodigo = new String[] {""} ;
         T001612_A217MovMayorizadoId = new int[1] ;
         T001612_A218MovMayorizadoLinea = new short[1] ;
         T001613_A41ClinicaCodigo = new String[] {""} ;
         T001613_A199TipoParCodigo = new String[] {""} ;
         T001613_A217MovMayorizadoId = new int[1] ;
         T001613_A218MovMayorizadoLinea = new short[1] ;
         T001614_A217MovMayorizadoId = new int[1] ;
         T001614_A218MovMayorizadoLinea = new short[1] ;
         T001614_A219MovMayorizadoFecha = new DateTime[] {DateTime.MinValue} ;
         T001614_A220MovMayorizadoHora = new String[] {""} ;
         T001614_A221MovMayorizadoObs = new String[] {""} ;
         T001614_A222MovMayorizadoReferencia = new String[] {""} ;
         T001614_A223MovMayorizadoDebe = new decimal[1] ;
         T001614_A224MovMayorizadoHaber = new decimal[1] ;
         T001614_A41ClinicaCodigo = new String[] {""} ;
         T001614_A193CtaContableCodigo = new String[] {""} ;
         T001614_A199TipoParCodigo = new String[] {""} ;
         T001614_A4UsuarioCodigo = new String[] {""} ;
         T001618_A41ClinicaCodigo = new String[] {""} ;
         T001618_A199TipoParCodigo = new String[] {""} ;
         T001618_A217MovMayorizadoId = new int[1] ;
         T001618_A218MovMayorizadoLinea = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         T001619_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T001620_A41ClinicaCodigo = new String[] {""} ;
         T001621_A4UsuarioCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.movimientomayorizado__default(),
            new Object[][] {
                new Object[] {
               T00162_A217MovMayorizadoId, T00162_A218MovMayorizadoLinea, T00162_A219MovMayorizadoFecha, T00162_A220MovMayorizadoHora, T00162_A221MovMayorizadoObs, T00162_A222MovMayorizadoReferencia, T00162_A223MovMayorizadoDebe, T00162_A224MovMayorizadoHaber, T00162_A41ClinicaCodigo, T00162_A193CtaContableCodigo,
               T00162_A199TipoParCodigo, T00162_A4UsuarioCodigo
               }
               , new Object[] {
               T00163_A217MovMayorizadoId, T00163_A218MovMayorizadoLinea, T00163_A219MovMayorizadoFecha, T00163_A220MovMayorizadoHora, T00163_A221MovMayorizadoObs, T00163_A222MovMayorizadoReferencia, T00163_A223MovMayorizadoDebe, T00163_A224MovMayorizadoHaber, T00163_A41ClinicaCodigo, T00163_A193CtaContableCodigo,
               T00163_A199TipoParCodigo, T00163_A4UsuarioCodigo
               }
               , new Object[] {
               T00164_A41ClinicaCodigo
               }
               , new Object[] {
               T00165_A41ClinicaCodigo
               }
               , new Object[] {
               T00166_A4UsuarioCodigo
               }
               , new Object[] {
               T00167_A217MovMayorizadoId, T00167_A218MovMayorizadoLinea, T00167_A219MovMayorizadoFecha, T00167_A220MovMayorizadoHora, T00167_A221MovMayorizadoObs, T00167_A222MovMayorizadoReferencia, T00167_A223MovMayorizadoDebe, T00167_A224MovMayorizadoHaber, T00167_A41ClinicaCodigo, T00167_A193CtaContableCodigo,
               T00167_A199TipoParCodigo, T00167_A4UsuarioCodigo
               }
               , new Object[] {
               T00168_A41ClinicaCodigo
               }
               , new Object[] {
               T00169_A41ClinicaCodigo
               }
               , new Object[] {
               T001610_A4UsuarioCodigo
               }
               , new Object[] {
               T001611_A41ClinicaCodigo, T001611_A199TipoParCodigo, T001611_A217MovMayorizadoId, T001611_A218MovMayorizadoLinea
               }
               , new Object[] {
               T001612_A41ClinicaCodigo, T001612_A199TipoParCodigo, T001612_A217MovMayorizadoId, T001612_A218MovMayorizadoLinea
               }
               , new Object[] {
               T001613_A41ClinicaCodigo, T001613_A199TipoParCodigo, T001613_A217MovMayorizadoId, T001613_A218MovMayorizadoLinea
               }
               , new Object[] {
               T001614_A217MovMayorizadoId, T001614_A218MovMayorizadoLinea, T001614_A219MovMayorizadoFecha, T001614_A220MovMayorizadoHora, T001614_A221MovMayorizadoObs, T001614_A222MovMayorizadoReferencia, T001614_A223MovMayorizadoDebe, T001614_A224MovMayorizadoHaber, T001614_A41ClinicaCodigo, T001614_A193CtaContableCodigo,
               T001614_A199TipoParCodigo, T001614_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001618_A41ClinicaCodigo, T001618_A199TipoParCodigo, T001618_A217MovMayorizadoId, T001618_A218MovMayorizadoLinea
               }
               , new Object[] {
               T001619_A41ClinicaCodigo
               }
               , new Object[] {
               T001620_A41ClinicaCodigo
               }
               , new Object[] {
               T001621_A4UsuarioCodigo
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
      private short A218MovMayorizadoLinea ;
      private short Z218MovMayorizadoLinea ;
      private short GX_JID ;
      private short RcdFound55 ;
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
      private int A217MovMayorizadoId ;
      private int edtMovMayorizadoId_Enabled ;
      private int edtMovMayorizadoLinea_Enabled ;
      private int edtMovMayorizadoFecha_Enabled ;
      private int edtMovMayorizadoHora_Enabled ;
      private int edtMovMayorizadoObs_Enabled ;
      private int edtMovMayorizadoReferencia_Enabled ;
      private int edtCtaContableCodigo_Enabled ;
      private int imgprompt_41_193_Visible ;
      private int edtMovMayorizadoDebe_Enabled ;
      private int edtMovMayorizadoHaber_Enabled ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
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
      private int Z217MovMayorizadoId ;
      private int AnyError41 ;
      private int AnyError193 ;
      private int AnyError199 ;
      private int AnyError4 ;
      private int idxLst ;
      private decimal A223MovMayorizadoDebe ;
      private decimal A224MovMayorizadoHaber ;
      private decimal Z223MovMayorizadoDebe ;
      private decimal Z224MovMayorizadoHaber ;
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
      private String lblTextblockmovmayorizadoid_Internalname ;
      private String lblTextblockmovmayorizadoid_Jsonclick ;
      private String edtMovMayorizadoId_Internalname ;
      private String edtMovMayorizadoId_Jsonclick ;
      private String lblTextblockmovmayorizadolinea_Internalname ;
      private String lblTextblockmovmayorizadolinea_Jsonclick ;
      private String edtMovMayorizadoLinea_Internalname ;
      private String edtMovMayorizadoLinea_Jsonclick ;
      private String lblTextblockmovmayorizadofecha_Internalname ;
      private String lblTextblockmovmayorizadofecha_Jsonclick ;
      private String edtMovMayorizadoFecha_Internalname ;
      private String edtMovMayorizadoFecha_Jsonclick ;
      private String lblTextblockmovmayorizadohora_Internalname ;
      private String lblTextblockmovmayorizadohora_Jsonclick ;
      private String A220MovMayorizadoHora ;
      private String edtMovMayorizadoHora_Internalname ;
      private String edtMovMayorizadoHora_Jsonclick ;
      private String lblTextblockmovmayorizadoobs_Internalname ;
      private String lblTextblockmovmayorizadoobs_Jsonclick ;
      private String edtMovMayorizadoObs_Internalname ;
      private String lblTextblockmovmayorizadoreferencia_Internalname ;
      private String lblTextblockmovmayorizadoreferencia_Jsonclick ;
      private String edtMovMayorizadoReferencia_Internalname ;
      private String edtMovMayorizadoReferencia_Jsonclick ;
      private String lblTextblockctacontablecodigo_Internalname ;
      private String lblTextblockctacontablecodigo_Jsonclick ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String imgprompt_41_193_Internalname ;
      private String imgprompt_41_193_Link ;
      private String lblTextblockmovmayorizadodebe_Internalname ;
      private String lblTextblockmovmayorizadodebe_Jsonclick ;
      private String edtMovMayorizadoDebe_Internalname ;
      private String edtMovMayorizadoDebe_Jsonclick ;
      private String lblTextblockmovmayorizadohaber_Internalname ;
      private String lblTextblockmovmayorizadohaber_Jsonclick ;
      private String edtMovMayorizadoHaber_Internalname ;
      private String edtMovMayorizadoHaber_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
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
      private String Z220MovMayorizadoHora ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode55 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A219MovMayorizadoFecha ;
      private DateTime Z219MovMayorizadoFecha ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A193CtaContableCodigo ;
      private String A199TipoParCodigo ;
      private String A4UsuarioCodigo ;
      private String A221MovMayorizadoObs ;
      private String A222MovMayorizadoReferencia ;
      private String Z41ClinicaCodigo ;
      private String Z199TipoParCodigo ;
      private String Z221MovMayorizadoObs ;
      private String Z222MovMayorizadoReferencia ;
      private String Z193CtaContableCodigo ;
      private String Z4UsuarioCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T00167_A217MovMayorizadoId ;
      private short[] T00167_A218MovMayorizadoLinea ;
      private DateTime[] T00167_A219MovMayorizadoFecha ;
      private String[] T00167_A220MovMayorizadoHora ;
      private String[] T00167_A221MovMayorizadoObs ;
      private String[] T00167_A222MovMayorizadoReferencia ;
      private decimal[] T00167_A223MovMayorizadoDebe ;
      private decimal[] T00167_A224MovMayorizadoHaber ;
      private String[] T00167_A41ClinicaCodigo ;
      private String[] T00167_A193CtaContableCodigo ;
      private String[] T00167_A199TipoParCodigo ;
      private String[] T00167_A4UsuarioCodigo ;
      private String[] T00164_A41ClinicaCodigo ;
      private String[] T00165_A41ClinicaCodigo ;
      private String[] T00166_A4UsuarioCodigo ;
      private String[] T00168_A41ClinicaCodigo ;
      private String[] T00169_A41ClinicaCodigo ;
      private String[] T001610_A4UsuarioCodigo ;
      private String[] T001611_A41ClinicaCodigo ;
      private String[] T001611_A199TipoParCodigo ;
      private int[] T001611_A217MovMayorizadoId ;
      private short[] T001611_A218MovMayorizadoLinea ;
      private int[] T00163_A217MovMayorizadoId ;
      private short[] T00163_A218MovMayorizadoLinea ;
      private DateTime[] T00163_A219MovMayorizadoFecha ;
      private String[] T00163_A220MovMayorizadoHora ;
      private String[] T00163_A221MovMayorizadoObs ;
      private String[] T00163_A222MovMayorizadoReferencia ;
      private decimal[] T00163_A223MovMayorizadoDebe ;
      private decimal[] T00163_A224MovMayorizadoHaber ;
      private String[] T00163_A41ClinicaCodigo ;
      private String[] T00163_A193CtaContableCodigo ;
      private String[] T00163_A199TipoParCodigo ;
      private String[] T00163_A4UsuarioCodigo ;
      private String[] T001612_A41ClinicaCodigo ;
      private String[] T001612_A199TipoParCodigo ;
      private int[] T001612_A217MovMayorizadoId ;
      private short[] T001612_A218MovMayorizadoLinea ;
      private String[] T001613_A41ClinicaCodigo ;
      private String[] T001613_A199TipoParCodigo ;
      private int[] T001613_A217MovMayorizadoId ;
      private short[] T001613_A218MovMayorizadoLinea ;
      private int[] T001614_A217MovMayorizadoId ;
      private short[] T001614_A218MovMayorizadoLinea ;
      private DateTime[] T001614_A219MovMayorizadoFecha ;
      private String[] T001614_A220MovMayorizadoHora ;
      private String[] T001614_A221MovMayorizadoObs ;
      private String[] T001614_A222MovMayorizadoReferencia ;
      private decimal[] T001614_A223MovMayorizadoDebe ;
      private decimal[] T001614_A224MovMayorizadoHaber ;
      private String[] T001614_A41ClinicaCodigo ;
      private String[] T001614_A193CtaContableCodigo ;
      private String[] T001614_A199TipoParCodigo ;
      private String[] T001614_A4UsuarioCodigo ;
      private String[] T001618_A41ClinicaCodigo ;
      private String[] T001618_A199TipoParCodigo ;
      private int[] T001618_A217MovMayorizadoId ;
      private short[] T001618_A218MovMayorizadoLinea ;
      private String[] T001619_A41ClinicaCodigo ;
      private String[] T001620_A41ClinicaCodigo ;
      private String[] T001621_A4UsuarioCodigo ;
      private int[] T00162_A217MovMayorizadoId ;
      private short[] T00162_A218MovMayorizadoLinea ;
      private DateTime[] T00162_A219MovMayorizadoFecha ;
      private String[] T00162_A220MovMayorizadoHora ;
      private String[] T00162_A221MovMayorizadoObs ;
      private String[] T00162_A222MovMayorizadoReferencia ;
      private decimal[] T00162_A223MovMayorizadoDebe ;
      private decimal[] T00162_A224MovMayorizadoHaber ;
      private String[] T00162_A41ClinicaCodigo ;
      private String[] T00162_A193CtaContableCodigo ;
      private String[] T00162_A199TipoParCodigo ;
      private String[] T00162_A4UsuarioCodigo ;
      private GXWebForm Form ;
   }

   public class movimientomayorizado__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00162 ;
          prmT00162 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00167 ;
          prmT00167 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00164 ;
          prmT00164 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00165 ;
          prmT00165 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00166 ;
          prmT00166 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00168 ;
          prmT00168 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00169 ;
          prmT00169 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001610 ;
          prmT001610 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001611 ;
          prmT001611 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00163 ;
          prmT00163 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001612 ;
          prmT001612 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001613 ;
          prmT001613 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001614 ;
          prmT001614 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001615 ;
          prmT001615 = new Object[] {
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovMayorizadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovMayorizadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@MovMayorizadoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovMayorizadoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@MovMayorizadoDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovMayorizadoHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001616 ;
          prmT001616 = new Object[] {
          new Object[] {"@MovMayorizadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovMayorizadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@MovMayorizadoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovMayorizadoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@MovMayorizadoDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovMayorizadoHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001617 ;
          prmT001617 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001618 ;
          prmT001618 = new Object[] {
          } ;
          Object[] prmT001619 ;
          prmT001619 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001620 ;
          prmT001620 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001621 ;
          prmT001621 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00162", "SELECT [MovMayorizadoId], [MovMayorizadoLinea], [MovMayorizadoFecha], [MovMayorizadoHora], [MovMayorizadoObs], [MovMayorizadoReferencia], [MovMayorizadoDebe], [MovMayorizadoHaber], [ClinicaCodigo], [CtaContableCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [MovimientoMayorizado] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovMayorizadoId] = @MovMayorizadoId AND [MovMayorizadoLinea] = @MovMayorizadoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00162,1,0,true,false )
             ,new CursorDef("T00163", "SELECT [MovMayorizadoId], [MovMayorizadoLinea], [MovMayorizadoFecha], [MovMayorizadoHora], [MovMayorizadoObs], [MovMayorizadoReferencia], [MovMayorizadoDebe], [MovMayorizadoHaber], [ClinicaCodigo], [CtaContableCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovMayorizadoId] = @MovMayorizadoId AND [MovMayorizadoLinea] = @MovMayorizadoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT00163,1,0,true,false )
             ,new CursorDef("T00164", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00164,1,0,true,false )
             ,new CursorDef("T00165", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00165,1,0,true,false )
             ,new CursorDef("T00166", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00166,1,0,true,false )
             ,new CursorDef("T00167", "SELECT TM1.[MovMayorizadoId], TM1.[MovMayorizadoLinea], TM1.[MovMayorizadoFecha], TM1.[MovMayorizadoHora], TM1.[MovMayorizadoObs], TM1.[MovMayorizadoReferencia], TM1.[MovMayorizadoDebe], TM1.[MovMayorizadoHaber], TM1.[ClinicaCodigo], TM1.[CtaContableCodigo], TM1.[TipoParCodigo], TM1.[UsuarioCodigo] FROM [MovimientoMayorizado] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[TipoParCodigo] = @TipoParCodigo and TM1.[MovMayorizadoId] = @MovMayorizadoId and TM1.[MovMayorizadoLinea] = @MovMayorizadoLinea ORDER BY TM1.[ClinicaCodigo], TM1.[TipoParCodigo], TM1.[MovMayorizadoId], TM1.[MovMayorizadoLinea]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00167,100,0,true,false )
             ,new CursorDef("T00168", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00168,1,0,true,false )
             ,new CursorDef("T00169", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00169,1,0,true,false )
             ,new CursorDef("T001610", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001610,1,0,true,false )
             ,new CursorDef("T001611", "SELECT [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea] FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovMayorizadoId] = @MovMayorizadoId AND [MovMayorizadoLinea] = @MovMayorizadoLinea  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001611,1,0,true,false )
             ,new CursorDef("T001612", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea] FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] > @TipoParCodigo or [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovMayorizadoId] > @MovMayorizadoId or [MovMayorizadoId] = @MovMayorizadoId and [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovMayorizadoLinea] > @MovMayorizadoLinea) ORDER BY [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001612,1,0,true,true )
             ,new CursorDef("T001613", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea] FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] < @TipoParCodigo or [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovMayorizadoId] < @MovMayorizadoId or [MovMayorizadoId] = @MovMayorizadoId and [TipoParCodigo] = @TipoParCodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovMayorizadoLinea] < @MovMayorizadoLinea) ORDER BY [ClinicaCodigo] DESC, [TipoParCodigo] DESC, [MovMayorizadoId] DESC, [MovMayorizadoLinea] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001613,1,0,true,true )
             ,new CursorDef("T001614", "SELECT [MovMayorizadoId], [MovMayorizadoLinea], [MovMayorizadoFecha], [MovMayorizadoHora], [MovMayorizadoObs], [MovMayorizadoReferencia], [MovMayorizadoDebe], [MovMayorizadoHaber], [ClinicaCodigo], [CtaContableCodigo], [TipoParCodigo], [UsuarioCodigo] FROM [MovimientoMayorizado] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovMayorizadoId] = @MovMayorizadoId AND [MovMayorizadoLinea] = @MovMayorizadoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001614,1,0,true,false )
             ,new CursorDef("T001615", "INSERT INTO [MovimientoMayorizado] ([MovMayorizadoId], [MovMayorizadoLinea], [MovMayorizadoFecha], [MovMayorizadoHora], [MovMayorizadoObs], [MovMayorizadoReferencia], [MovMayorizadoDebe], [MovMayorizadoHaber], [ClinicaCodigo], [CtaContableCodigo], [TipoParCodigo], [UsuarioCodigo]) VALUES (@MovMayorizadoId, @MovMayorizadoLinea, @MovMayorizadoFecha, @MovMayorizadoHora, @MovMayorizadoObs, @MovMayorizadoReferencia, @MovMayorizadoDebe, @MovMayorizadoHaber, @ClinicaCodigo, @CtaContableCodigo, @TipoParCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001615)
             ,new CursorDef("T001616", "UPDATE [MovimientoMayorizado] SET [MovMayorizadoFecha]=@MovMayorizadoFecha, [MovMayorizadoHora]=@MovMayorizadoHora, [MovMayorizadoObs]=@MovMayorizadoObs, [MovMayorizadoReferencia]=@MovMayorizadoReferencia, [MovMayorizadoDebe]=@MovMayorizadoDebe, [MovMayorizadoHaber]=@MovMayorizadoHaber, [CtaContableCodigo]=@CtaContableCodigo, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovMayorizadoId] = @MovMayorizadoId AND [MovMayorizadoLinea] = @MovMayorizadoLinea", GxErrorMask.GX_NOMASK,prmT001616)
             ,new CursorDef("T001617", "DELETE FROM [MovimientoMayorizado]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovMayorizadoId] = @MovMayorizadoId AND [MovMayorizadoLinea] = @MovMayorizadoLinea", GxErrorMask.GX_NOMASK,prmT001617)
             ,new CursorDef("T001618", "SELECT [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea] FROM [MovimientoMayorizado] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001618,100,0,true,false )
             ,new CursorDef("T001619", "SELECT [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001619,1,0,true,false )
             ,new CursorDef("T001620", "SELECT [ClinicaCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CtaContableCodigo] = @CtaContableCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001620,1,0,true,false )
             ,new CursorDef("T001621", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001621,1,0,true,false )
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
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
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
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
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
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
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
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
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
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                break;
             case 14 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (int)parms[10]);
                stmt.SetParameter(12, (short)parms[11]);
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
