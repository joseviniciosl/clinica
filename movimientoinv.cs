/*
               File: MovimientoInv
        Description: Encabezado de movimiento de inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:46.61
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
   public class movimientoinv : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A121BodegaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo, A121BodegaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A114TipoMICodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_4( A41ClinicaCodigo, A114TipoMICodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A30ArticuloCodigo = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A41ClinicaCodigo, A30ArticuloCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridmovimientoinv_movimientoinvdetalle") == 0 )
         {
            nRC_Gridmovimientoinv_movimientoinvdetalle = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_90_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_90_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridmovimientoinv_movimientoinvdetalle_newrow( nRC_Gridmovimientoinv_movimientoinvdetalle, nGXsfl_90_idx, sGXsfl_90_idx) ;
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
         cmbMovimientoEstado.Name = "MOVIMIENTOESTADO" ;
         cmbMovimientoEstado.WebTags = "" ;
         cmbMovimientoEstado.addItem("0", "Creado", 0);
         cmbMovimientoEstado.addItem("1", "Emitido", 0);
         cmbMovimientoEstado.addItem("2", "Anulado", 0);
         cmbMovimientoEstado.addItem("3", "Cancelado", 0);
         if ( ( cmbMovimientoEstado.ItemCount > 0 ) && (0==A271MovimientoEstado) )
         {
            A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271MovimientoEstado", StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Encabezado de movimiento de inventario", 0) ;
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

      public movimientoinv( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public movimientoinv( IGxContext context )
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
         cmbMovimientoEstado = new GXCombobox();
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
            wb_table1_2_1F65( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1F65e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1F65( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1F65( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1F65e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Encabezado de movimiento de inventario"+"</legend>") ;
            wb_table3_27_1F65( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1F65e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1F65e( true) ;
         }
         else
         {
            wb_table1_2_1F65e( false) ;
         }
      }

      protected void wb_table3_27_1F65( bool wbgen )
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
            wb_table4_33_1F65( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1F65e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoInv.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoInv.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1F65e( true) ;
         }
         else
         {
            wb_table3_27_1F65e( false) ;
         }
      }

      protected void wb_table4_33_1F65( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipomicodigo_Internalname, "Tipo_Movimiento", "", "", lblTextblocktipomicodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoMICodigo_Internalname, StringUtil.RTrim( A114TipoMICodigo), StringUtil.RTrim( context.localUtil.Format( A114TipoMICodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtTipoMICodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoMICodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoInv.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_114_Internalname, "prompt.gif", imgprompt_41_114_Link, "", "", "Fantastic", imgprompt_41_114_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientoid_Internalname, "Id", "", "", lblTextblockmovimientoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovimientoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")), ((edtMovimientoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A267MovimientoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A267MovimientoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtMovimientoId_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovimientoId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientofecha_Internalname, "Fecha", "", "", lblTextblockmovimientofecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268MovimientoFecha", context.localUtil.Format(A268MovimientoFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtMovimientoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtMovimientoFecha_Internalname, context.localUtil.Format(A268MovimientoFecha, "99/99/99"), context.localUtil.Format( A268MovimientoFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(53);\"", "", "", "", "", edtMovimientoFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovimientoFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_MovimientoInv.htm");
            GxWebStd.gx_bitmap( context, edtMovimientoFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtMovimientoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_MovimientoInv.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientohora_Internalname, "Hora", "", "", lblTextblockmovimientohora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288MovimientoHora", A288MovimientoHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovimientoHora_Internalname, StringUtil.RTrim( A288MovimientoHora), StringUtil.RTrim( context.localUtil.Format( A288MovimientoHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtMovimientoHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovimientoHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbodegacodigo_Internalname, "Bodega", "", "", lblTextblockbodegacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBodegaCodigo_Internalname, StringUtil.RTrim( A121BodegaCodigo), StringUtil.RTrim( context.localUtil.Format( A121BodegaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtBodegaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtBodegaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoInv.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_121_Internalname, "prompt.gif", imgprompt_41_121_Link, "", "", "Fantastic", imgprompt_41_121_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientoreferencia_Internalname, "Referencia", "", "", lblTextblockmovimientoreferencia_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269MovimientoReferencia", A269MovimientoReferencia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMovimientoReferencia_Internalname, StringUtil.RTrim( A269MovimientoReferencia), StringUtil.RTrim( context.localUtil.Format( A269MovimientoReferencia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", "", "", "", edtMovimientoReferencia_Jsonclick, 0, ClassString, StyleString, "", 1, edtMovimientoReferencia_Enabled, 0, 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientoobs_Internalname, "Obs", "", "", lblTextblockmovimientoobs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270MovimientoObs", A270MovimientoObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtMovimientoObs_Internalname, StringUtil.RTrim( A270MovimientoObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", 0, 1, edtMovimientoObs_Enabled, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientoestado_Internalname, "Estado", "", "", lblTextblockmovimientoestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271MovimientoEstado", StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbMovimientoEstado, cmbMovimientoEstado_Internalname, StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0), 1, cmbMovimientoEstado_Jsonclick, 0, "", "int", "", 1, cmbMovimientoEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", true, "HLP_MovimientoInv.htm");
            cmbMovimientoEstado.CurrentValue = StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMovimientoEstado_Internalname, "Values", (String)(cmbMovimientoEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(83);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_MovimientoInv.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_86_1F65( true) ;
         }
         return  ;
      }

      protected void wb_table5_86_1F65e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("GridName", "Gridmovimientoinv_movimientoinvdetalle");
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("Class", "Grid");
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmovimientoinv_movimientoinvdetalle_Backcolorstyle), 1, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("CmpContext", "");
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("InMasterPage", "false");
            Gridmovimientoinv_movimientoinvdetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A272MovimientoLinea), 4, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoLinea_Enabled), 5, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddColumnProperties(Gridmovimientoinv_movimientoinvdetalleColumn);
            Gridmovimientoinv_movimientoinvdetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Value", StringUtil.RTrim( A30ArticuloCodigo));
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddColumnProperties(Gridmovimientoinv_movimientoinvdetalleColumn);
            Gridmovimientoinv_movimientoinvdetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmovimientoinv_movimientoinvdetalleContainer.AddColumnProperties(Gridmovimientoinv_movimientoinvdetalleColumn);
            Gridmovimientoinv_movimientoinvdetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A273MovimientoCantidad, 17, 2, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCantidad_Enabled), 5, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddColumnProperties(Gridmovimientoinv_movimientoinvdetalleColumn);
            Gridmovimientoinv_movimientoinvdetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A274MovimientoCosto, 17, 2, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCosto_Enabled), 5, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddColumnProperties(Gridmovimientoinv_movimientoinvdetalleColumn);
            Gridmovimientoinv_movimientoinvdetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A275MovimientoCostoTotal, 17, 2, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCostoTotal_Enabled), 5, 0, ".", "")));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddColumnProperties(Gridmovimientoinv_movimientoinvdetalleColumn);
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("Allowselection", "false");
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("Allowcollapsing", ((subGridmovimientoinv_movimientoinvdetalle_Allowcollapsing==1) ? "true" : "false"));
            Gridmovimientoinv_movimientoinvdetalleContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmovimientoinv_movimientoinvdetalle_Collapsed), 9, 0, ".", "")));
            nGXsfl_90_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount66 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_66 = 1 ;
                  ScanStart1F66( ) ;
                  while ( RcdFound66 != 0 )
                  {
                     init_level_properties66( ) ;
                     getByPrimaryKey1F66( ) ;
                     AddRow1F66( ) ;
                     ScanNext1F66( ) ;
                  }
                  ScanEnd1F66( ) ;
                  nBlankRcdCount66 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal1F66( ) ;
               standaloneModal1F66( ) ;
               sMode66 = Gx_mode ;
               while ( nGXsfl_90_idx < nRC_Gridmovimientoinv_movimientoinvdetalle )
               {
                  ReadRow1F66( ) ;
                  edtMovimientoLinea_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOLINEA_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  edtArticuloCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOCODIGO_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  edtMovimientoCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  edtMovimientoCosto_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOCOSTO_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  edtMovimientoCostoTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
                  imgprompt_41_114_Link = cgiGet( "PROMPT_30_"+sGXsfl_90_idx+"Link") ;
                  if ( ( nRcdExists_66 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal1F66( ) ;
                  }
                  SendRow1F66( ) ;
               }
               Gx_mode = sMode66 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount66 = 5 ;
               nRcdExists_66 = 1 ;
               ScanStart1F66( ) ;
               while ( RcdFound66 != 0 )
               {
                  init_level_properties66( ) ;
                  getByPrimaryKey1F66( ) ;
                  standaloneNotModal1F66( ) ;
                  standaloneModal1F66( ) ;
                  AddRow1F66( ) ;
                  ScanNext1F66( ) ;
               }
               ScanEnd1F66( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode66 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll1F66( ) ;
            init_level_properties66( ) ;
            standaloneNotModal1F66( ) ;
            standaloneModal1F66( ) ;
            nRcdExists_66 = 0 ;
            nIsMod_66 = 0 ;
            nBlankRcdCount66 = (short)(nBlankRcdUsr66+nBlankRcdCount66) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount66 > 0 )
            {
               AddRow1F66( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtMovimientoLinea_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount66 = (short)(nBlankRcdCount66-1) ;
            }
            Gx_mode = sMode66 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridmovimientoinv_movimientoinvdetalleContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridmovimientoinv_movimientoinvdetalle", (Object)(Gridmovimientoinv_movimientoinvdetalleContainer));
            GxWebStd.gx_hidden_field( context, "Gridmovimientoinv_movimientoinvdetalleContainerData", Gridmovimientoinv_movimientoinvdetalleContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridmovimientoinv_movimientoinvdetalleContainerData"+"V", Gridmovimientoinv_movimientoinvdetalleContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridmovimientoinv_movimientoinvdetalleContainerData"+"V"+"\" value='"+Gridmovimientoinv_movimientoinvdetalleContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1F65e( true) ;
         }
         else
         {
            wb_table4_33_1F65e( false) ;
         }
      }

      protected void wb_table5_86_1F65( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlemovimientoinvdetalle_Internalname, "Detalle de movimiento de inventario", "", "", lblTitlemovimientoinvdetalle_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_MovimientoInv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_86_1F65e( true) ;
         }
         else
         {
            wb_table5_86_1F65e( false) ;
         }
      }

      protected void wb_table2_5_1F65( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01t0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOMICODIGO"+"'), id:'"+"TIPOMICODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVIMIENTOID"+"'), id:'"+"MOVIMIENTOID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01t0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOMICODIGO"+"'), id:'"+"TIPOMICODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MOVIMIENTOID"+"'), id:'"+"MOVIMIENTOID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_MovimientoInv.htm");
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
            wb_table2_5_1F65e( true) ;
         }
         else
         {
            wb_table2_5_1F65e( false) ;
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
               A114TipoMICodigo = cgiGet( edtTipoMICodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtMovimientoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovimientoId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVIMIENTOID");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovimientoId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A267MovimientoId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
               }
               else
               {
                  A267MovimientoId = (int)(context.localUtil.CToN( cgiGet( edtMovimientoId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtMovimientoFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "MOVIMIENTOFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtMovimientoFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A268MovimientoFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268MovimientoFecha", context.localUtil.Format(A268MovimientoFecha, "99/99/99"));
               }
               else
               {
                  A268MovimientoFecha = context.localUtil.CToD( cgiGet( edtMovimientoFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268MovimientoFecha", context.localUtil.Format(A268MovimientoFecha, "99/99/99"));
               }
               A288MovimientoHora = cgiGet( edtMovimientoHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288MovimientoHora", A288MovimientoHora);
               A121BodegaCodigo = cgiGet( edtBodegaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
               A269MovimientoReferencia = cgiGet( edtMovimientoReferencia_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269MovimientoReferencia", A269MovimientoReferencia);
               A270MovimientoObs = cgiGet( edtMovimientoObs_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270MovimientoObs", A270MovimientoObs);
               cmbMovimientoEstado.Name = cmbMovimientoEstado_Internalname ;
               cmbMovimientoEstado.CurrentValue = cgiGet( cmbMovimientoEstado_Internalname) ;
               A271MovimientoEstado = (short)(NumberUtil.Val( cgiGet( cmbMovimientoEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271MovimientoEstado", StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0));
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z114TipoMICodigo = cgiGet( "Z114TipoMICodigo") ;
               Z267MovimientoId = (int)(context.localUtil.CToN( cgiGet( "Z267MovimientoId"), ".", ",")) ;
               Z268MovimientoFecha = context.localUtil.CToD( cgiGet( "Z268MovimientoFecha"), 0) ;
               Z288MovimientoHora = cgiGet( "Z288MovimientoHora") ;
               Z269MovimientoReferencia = cgiGet( "Z269MovimientoReferencia") ;
               Z270MovimientoObs = cgiGet( "Z270MovimientoObs") ;
               Z271MovimientoEstado = (short)(context.localUtil.CToN( cgiGet( "Z271MovimientoEstado"), ".", ",")) ;
               Z121BodegaCodigo = cgiGet( "Z121BodegaCodigo") ;
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridmovimientoinv_movimientoinvdetalle = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridmovimientoinv_movimientoinvdetalle"), ".", ",")) ;
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
                  A114TipoMICodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
                  A267MovimientoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
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
               InitAll1F65( ) ;
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
         DisableAttributes1F65( ) ;
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

      protected void CONFIRM_1F66( )
      {
         nGXsfl_90_idx = 0 ;
         while ( nGXsfl_90_idx < nRC_Gridmovimientoinv_movimientoinvdetalle )
         {
            ReadRow1F66( ) ;
            if ( ( nRcdExists_66 != 0 ) || ( nIsMod_66 != 0 ) )
            {
               GetKey1F66( ) ;
               if ( ( nRcdExists_66 == 0 ) && ( nRcdDeleted_66 == 0 ) )
               {
                  if ( RcdFound66 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate1F66( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1F66( ) ;
                        CloseExtendedTableCursors1F66( ) ;
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
                     GX_FocusControl = edtMovimientoLinea_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound66 != 0 )
                  {
                     if ( nRcdDeleted_66 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey1F66( ) ;
                        Load1F66( ) ;
                        BeforeValidate1F66( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1F66( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_66 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate1F66( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1F66( ) ;
                              CloseExtendedTableCursors1F66( ) ;
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
                     if ( nRcdDeleted_66 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtMovimientoLinea_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtMovimientoLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A272MovimientoLinea), 4, 0, ".", ""))) ;
            ChangePostValue( edtArticuloCodigo_Internalname, StringUtil.RTrim( A30ArticuloCodigo)) ;
            ChangePostValue( edtMovimientoCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A273MovimientoCantidad, 17, 2, ".", ""))) ;
            ChangePostValue( edtMovimientoCosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A274MovimientoCosto, 17, 2, ".", ""))) ;
            ChangePostValue( edtMovimientoCostoTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A275MovimientoCostoTotal, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z272MovimientoLinea_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z272MovimientoLinea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z273MovimientoCantidad_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z273MovimientoCantidad, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z274MovimientoCosto_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z274MovimientoCosto, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z30ArticuloCodigo_"+sGXsfl_90_idx, StringUtil.RTrim( Z30ArticuloCodigo)) ;
            ChangePostValue( "nRcdDeleted_66_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_66), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_66_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_66), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_66_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_66), 4, 0, ".", ""))) ;
            if ( nIsMod_66 != 0 )
            {
               ChangePostValue( "MOVIMIENTOLINEA_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoLinea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOCODIGO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOCOSTO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCosto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCostoTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption1F0( )
      {
      }

      protected void ZM1F65( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z268MovimientoFecha = T001F6_A268MovimientoFecha[0] ;
               Z288MovimientoHora = T001F6_A288MovimientoHora[0] ;
               Z269MovimientoReferencia = T001F6_A269MovimientoReferencia[0] ;
               Z270MovimientoObs = T001F6_A270MovimientoObs[0] ;
               Z271MovimientoEstado = T001F6_A271MovimientoEstado[0] ;
               Z121BodegaCodigo = T001F6_A121BodegaCodigo[0] ;
               Z4UsuarioCodigo = T001F6_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z268MovimientoFecha = A268MovimientoFecha ;
               Z288MovimientoHora = A288MovimientoHora ;
               Z269MovimientoReferencia = A269MovimientoReferencia ;
               Z270MovimientoObs = A270MovimientoObs ;
               Z271MovimientoEstado = A271MovimientoEstado ;
               Z121BodegaCodigo = A121BodegaCodigo ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z267MovimientoId = A267MovimientoId ;
            Z268MovimientoFecha = A268MovimientoFecha ;
            Z288MovimientoHora = A288MovimientoHora ;
            Z269MovimientoReferencia = A269MovimientoReferencia ;
            Z270MovimientoObs = A270MovimientoObs ;
            Z271MovimientoEstado = A271MovimientoEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z114TipoMICodigo = A114TipoMICodigo ;
            Z121BodegaCodigo = A121BodegaCodigo ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_114_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00s0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOMICODIGO"+"'), id:'"+"TIPOMICODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
         imgprompt_41_121_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00u0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"BODEGACODIGO"+"'), id:'"+"BODEGACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load1F65( )
      {
         /* Using cursor T001F10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound65 = 1 ;
            A268MovimientoFecha = T001F10_A268MovimientoFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268MovimientoFecha", context.localUtil.Format(A268MovimientoFecha, "99/99/99"));
            A288MovimientoHora = T001F10_A288MovimientoHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288MovimientoHora", A288MovimientoHora);
            A269MovimientoReferencia = T001F10_A269MovimientoReferencia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269MovimientoReferencia", A269MovimientoReferencia);
            A270MovimientoObs = T001F10_A270MovimientoObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270MovimientoObs", A270MovimientoObs);
            A271MovimientoEstado = T001F10_A271MovimientoEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271MovimientoEstado", StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0));
            A121BodegaCodigo = T001F10_A121BodegaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
            A4UsuarioCodigo = T001F10_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            ZM1F65( -3) ;
         }
         pr_default.close(8);
         OnLoadActions1F65( ) ;
      }

      protected void OnLoadActions1F65( )
      {
      }

      protected void CheckExtendedTable1F65( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001F8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            AnyError121 = 1 ;
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError121 == 0 ) )
         {
         }
         pr_default.close(6);
         /* Using cursor T001F7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError41 = 1 ;
            AnyError114 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Movimientos de Inventario'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError114 == 0 ) )
         {
         }
         pr_default.close(5);
         if ( ! ( (DateTime.MinValue==A268MovimientoFecha) || ( A268MovimientoFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T001F9 */
         pr_default.execute(7, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(7) == 101) )
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
         pr_default.close(7);
      }

      protected void CloseExtendedTableCursors1F65( )
      {
         pr_default.close(6);
         pr_default.close(5);
         pr_default.close(7);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo ,
                               String A121BodegaCodigo )
      {
         /* Using cursor T001F11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
         if ( (pr_default.getStatus(9) == 101) )
         {
            AnyError41 = 1 ;
            AnyError121 = 1 ;
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError121 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(9);
      }

      protected void gxLoad_4( String A41ClinicaCodigo ,
                               String A114TipoMICodigo )
      {
         /* Using cursor T001F12 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(10) == 101) )
         {
            AnyError41 = 1 ;
            AnyError114 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Movimientos de Inventario'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError114 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(10);
      }

      protected void gxLoad_6( String A4UsuarioCodigo )
      {
         /* Using cursor T001F13 */
         pr_default.execute(11, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(11) == 101) )
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
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(11);
      }

      protected void GetKey1F65( )
      {
         /* Using cursor T001F14 */
         pr_default.execute(12, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound65 = 1 ;
         }
         else
         {
            RcdFound65 = 0 ;
         }
         pr_default.close(12);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001F6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM1F65( 3) ;
            RcdFound65 = 1 ;
            A267MovimientoId = T001F6_A267MovimientoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
            A268MovimientoFecha = T001F6_A268MovimientoFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268MovimientoFecha", context.localUtil.Format(A268MovimientoFecha, "99/99/99"));
            A288MovimientoHora = T001F6_A288MovimientoHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288MovimientoHora", A288MovimientoHora);
            A269MovimientoReferencia = T001F6_A269MovimientoReferencia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269MovimientoReferencia", A269MovimientoReferencia);
            A270MovimientoObs = T001F6_A270MovimientoObs[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270MovimientoObs", A270MovimientoObs);
            A271MovimientoEstado = T001F6_A271MovimientoEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271MovimientoEstado", StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0));
            A41ClinicaCodigo = T001F6_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A114TipoMICodigo = T001F6_A114TipoMICodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
            A121BodegaCodigo = T001F6_A121BodegaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
            A4UsuarioCodigo = T001F6_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z114TipoMICodigo = A114TipoMICodigo ;
            Z267MovimientoId = A267MovimientoId ;
            sMode65 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1F65( ) ;
            Gx_mode = sMode65 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound65 = 0 ;
            InitializeNonKey1F65( ) ;
            sMode65 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode65 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey1F65( ) ;
         if ( RcdFound65 == 0 )
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
         RcdFound65 = 0 ;
         /* Using cursor T001F15 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( StringUtil.StrCmp(T001F15_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001F15_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001F15_A114TipoMICodigo[0], A114TipoMICodigo) < 0 ) || ( StringUtil.StrCmp(T001F15_A114TipoMICodigo[0], A114TipoMICodigo) == 0 ) && ( StringUtil.StrCmp(T001F15_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001F15_A267MovimientoId[0] < A267MovimientoId ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( StringUtil.StrCmp(T001F15_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001F15_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001F15_A114TipoMICodigo[0], A114TipoMICodigo) > 0 ) || ( StringUtil.StrCmp(T001F15_A114TipoMICodigo[0], A114TipoMICodigo) == 0 ) && ( StringUtil.StrCmp(T001F15_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001F15_A267MovimientoId[0] > A267MovimientoId ) ) )
            {
               A41ClinicaCodigo = T001F15_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A114TipoMICodigo = T001F15_A114TipoMICodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
               A267MovimientoId = T001F15_A267MovimientoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
               RcdFound65 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound65 = 0 ;
         /* Using cursor T001F16 */
         pr_default.execute(14, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( StringUtil.StrCmp(T001F16_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001F16_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001F16_A114TipoMICodigo[0], A114TipoMICodigo) > 0 ) || ( StringUtil.StrCmp(T001F16_A114TipoMICodigo[0], A114TipoMICodigo) == 0 ) && ( StringUtil.StrCmp(T001F16_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001F16_A267MovimientoId[0] > A267MovimientoId ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( StringUtil.StrCmp(T001F16_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001F16_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T001F16_A114TipoMICodigo[0], A114TipoMICodigo) < 0 ) || ( StringUtil.StrCmp(T001F16_A114TipoMICodigo[0], A114TipoMICodigo) == 0 ) && ( StringUtil.StrCmp(T001F16_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001F16_A267MovimientoId[0] < A267MovimientoId ) ) )
            {
               A41ClinicaCodigo = T001F16_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A114TipoMICodigo = T001F16_A114TipoMICodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
               A267MovimientoId = T001F16_A267MovimientoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
               RcdFound65 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1F65( ) ;
         if ( RcdFound65 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A114TipoMICodigo, Z114TipoMICodigo) != 0 ) || ( A267MovimientoId != Z267MovimientoId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A114TipoMICodigo = Z114TipoMICodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
               A267MovimientoId = Z267MovimientoId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
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
               Update1F65( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A114TipoMICodigo, Z114TipoMICodigo) != 0 ) || ( A267MovimientoId != Z267MovimientoId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1F65( ) ;
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
                  Insert1F65( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A114TipoMICodigo, Z114TipoMICodigo) != 0 ) || ( A267MovimientoId != Z267MovimientoId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A114TipoMICodigo = Z114TipoMICodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
            A267MovimientoId = Z267MovimientoId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
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
         if ( RcdFound65 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtMovimientoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1F65( ) ;
         if ( RcdFound65 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovimientoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1F65( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound65 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovimientoFecha_Internalname ;
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
         if ( RcdFound65 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovimientoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1F65( ) ;
         if ( RcdFound65 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound65 != 0 )
            {
               ScanNext1F65( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMovimientoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1F65( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1F65( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001F17 */
            pr_default.execute(15, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
            if ( (pr_default.getStatus(15) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MovimientoInv"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(15) == 101) || ( Z268MovimientoFecha != T001F17_A268MovimientoFecha[0] ) || ( StringUtil.StrCmp(Z288MovimientoHora, T001F17_A288MovimientoHora[0]) != 0 ) || ( StringUtil.StrCmp(Z269MovimientoReferencia, T001F17_A269MovimientoReferencia[0]) != 0 ) || ( StringUtil.StrCmp(Z270MovimientoObs, T001F17_A270MovimientoObs[0]) != 0 ) || ( Z271MovimientoEstado != T001F17_A271MovimientoEstado[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z121BodegaCodigo, T001F17_A121BodegaCodigo[0]) != 0 ) || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001F17_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MovimientoInv"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1F65( )
      {
         BeforeValidate1F65( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1F65( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1F65( 0) ;
            CheckOptimisticConcurrency1F65( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1F65( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1F65( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001F18 */
                     pr_default.execute(16, new Object[] {A267MovimientoId, A268MovimientoFecha, A288MovimientoHora, A269MovimientoReferencia, A270MovimientoObs, A271MovimientoEstado, A41ClinicaCodigo, A114TipoMICodigo, A121BodegaCodigo, A4UsuarioCodigo});
                     pr_default.close(16);
                     if ( (pr_default.getStatus(16) == 1) )
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
                           ProcessLevel1F65( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption1F0( ) ;
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
               Load1F65( ) ;
            }
            EndLevel1F65( ) ;
         }
         CloseExtendedTableCursors1F65( ) ;
      }

      protected void Update1F65( )
      {
         BeforeValidate1F65( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1F65( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1F65( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1F65( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1F65( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001F19 */
                     pr_default.execute(17, new Object[] {A268MovimientoFecha, A288MovimientoHora, A269MovimientoReferencia, A270MovimientoObs, A271MovimientoEstado, A121BodegaCodigo, A4UsuarioCodigo, A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
                     pr_default.close(17);
                     if ( (pr_default.getStatus(17) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MovimientoInv"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1F65( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1F65( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption1F0( ) ;
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
            EndLevel1F65( ) ;
         }
         CloseExtendedTableCursors1F65( ) ;
      }

      protected void DeferredUpdate1F65( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1F65( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1F65( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1F65( ) ;
            AfterConfirm1F65( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1F65( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart1F66( ) ;
                  while ( RcdFound66 != 0 )
                  {
                     getByPrimaryKey1F66( ) ;
                     Delete1F66( ) ;
                     ScanNext1F66( ) ;
                  }
                  ScanEnd1F66( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001F20 */
                     pr_default.execute(18, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
                     pr_default.close(18);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound65 == 0 )
                           {
                              InitAll1F65( ) ;
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
                           ResetCaption1F0( ) ;
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
         sMode65 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1F65( ) ;
         Gx_mode = sMode65 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1F65( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel1F66( )
      {
         nGXsfl_90_idx = 0 ;
         while ( nGXsfl_90_idx < nRC_Gridmovimientoinv_movimientoinvdetalle )
         {
            ReadRow1F66( ) ;
            if ( ( nRcdExists_66 != 0 ) || ( nIsMod_66 != 0 ) )
            {
               standaloneNotModal1F66( ) ;
               GetKey1F66( ) ;
               if ( ( nRcdExists_66 == 0 ) && ( nRcdDeleted_66 == 0 ) )
               {
                  if ( RcdFound66 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert1F66( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtMovimientoLinea_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound66 != 0 )
                  {
                     if ( ( nRcdDeleted_66 != 0 ) && ( nRcdExists_66 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete1F66( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_66 != 0 ) && ( nRcdExists_66 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update1F66( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_66 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtMovimientoLinea_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtMovimientoLinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A272MovimientoLinea), 4, 0, ".", ""))) ;
            ChangePostValue( edtArticuloCodigo_Internalname, StringUtil.RTrim( A30ArticuloCodigo)) ;
            ChangePostValue( edtMovimientoCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A273MovimientoCantidad, 17, 2, ".", ""))) ;
            ChangePostValue( edtMovimientoCosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A274MovimientoCosto, 17, 2, ".", ""))) ;
            ChangePostValue( edtMovimientoCostoTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A275MovimientoCostoTotal, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z272MovimientoLinea_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z272MovimientoLinea), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z273MovimientoCantidad_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z273MovimientoCantidad, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z274MovimientoCosto_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( Z274MovimientoCosto, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z30ArticuloCodigo_"+sGXsfl_90_idx, StringUtil.RTrim( Z30ArticuloCodigo)) ;
            ChangePostValue( "nRcdDeleted_66_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_66), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_66_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_66), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_66_"+sGXsfl_90_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_66), 4, 0, ".", ""))) ;
            if ( nIsMod_66 != 0 )
            {
               ChangePostValue( "MOVIMIENTOLINEA_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoLinea_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOCODIGO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOCOSTO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCosto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCostoTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1F66( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_66 = 0 ;
         nIsMod_66 = 0 ;
         nRcdDeleted_66 = 0 ;
      }

      protected void ProcessLevel1F65( )
      {
         /* Save parent mode. */
         sMode65 = Gx_mode ;
         ProcessNestedLevel1F66( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode65 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel1F65( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(15);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1F65( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(14);
            pr_default.close(13);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.CommitDataStores("MovimientoInv");
            if ( AnyError == 0 )
            {
               ConfirmValues1F0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(14);
            pr_default.close(13);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            context.RollbackDataStores("MovimientoInv");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1F65( )
      {
         /* Using cursor T001F21 */
         pr_default.execute(19);
         RcdFound65 = 0 ;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound65 = 1 ;
            A41ClinicaCodigo = T001F21_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A114TipoMICodigo = T001F21_A114TipoMICodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
            A267MovimientoId = T001F21_A267MovimientoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1F65( )
      {
         pr_default.readNext(19);
         RcdFound65 = 0 ;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound65 = 1 ;
            A41ClinicaCodigo = T001F21_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A114TipoMICodigo = T001F21_A114TipoMICodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
            A267MovimientoId = T001F21_A267MovimientoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
         }
      }

      protected void ScanEnd1F65( )
      {
      }

      protected void AfterConfirm1F65( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1F65( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1F65( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1F65( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1F65( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1F65( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1F65( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtTipoMICodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoMICodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoMICodigo_Enabled), 5, 0)));
         edtMovimientoId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientoId_Enabled), 5, 0)));
         edtMovimientoFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientoFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientoFecha_Enabled), 5, 0)));
         edtMovimientoHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientoHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientoHora_Enabled), 5, 0)));
         edtBodegaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodegaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodegaCodigo_Enabled), 5, 0)));
         edtMovimientoReferencia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientoReferencia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientoReferencia_Enabled), 5, 0)));
         edtMovimientoObs_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMovimientoObs_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMovimientoObs_Enabled), 5, 0)));
         cmbMovimientoEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMovimientoEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbMovimientoEstado.Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
      }

      protected void ZM1F66( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z273MovimientoCantidad = T001F3_A273MovimientoCantidad[0] ;
               Z274MovimientoCosto = T001F3_A274MovimientoCosto[0] ;
               Z30ArticuloCodigo = T001F3_A30ArticuloCodigo[0] ;
            }
            else
            {
               Z273MovimientoCantidad = A273MovimientoCantidad ;
               Z274MovimientoCosto = A274MovimientoCosto ;
               Z30ArticuloCodigo = A30ArticuloCodigo ;
            }
         }
         if ( GX_JID == -7 )
         {
            Z114TipoMICodigo = A114TipoMICodigo ;
            Z267MovimientoId = A267MovimientoId ;
            Z272MovimientoLinea = A272MovimientoLinea ;
            Z273MovimientoCantidad = A273MovimientoCantidad ;
            Z274MovimientoCosto = A274MovimientoCosto ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z30ArticuloCodigo = A30ArticuloCodigo ;
         }
      }

      protected void standaloneNotModal1F66( )
      {
      }

      protected void standaloneModal1F66( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtMovimientoLinea_Enabled = 0 ;
         }
         else
         {
            edtMovimientoLinea_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode66, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode66, "DLT") == 0 ) )
         {
            DisableAttributes1F66( ) ;
         }
      }

      protected void Load1F66( )
      {
         /* Using cursor T001F22 */
         pr_default.execute(20, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound66 = 1 ;
            A273MovimientoCantidad = T001F22_A273MovimientoCantidad[0] ;
            A274MovimientoCosto = T001F22_A274MovimientoCosto[0] ;
            A30ArticuloCodigo = T001F22_A30ArticuloCodigo[0] ;
            ZM1F66( -7) ;
         }
         pr_default.close(20);
         OnLoadActions1F66( ) ;
      }

      protected void OnLoadActions1F66( )
      {
         A275MovimientoCostoTotal = (decimal)((A273MovimientoCantidad*A274MovimientoCosto)) ;
      }

      protected void CheckExtendedTable1F66( )
      {
         Gx_BScreen = 1 ;
         standaloneModal1F66( ) ;
         /* Using cursor T001F4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError30 = 1 ;
            GX_msglist.addItem("No existe 'Maestro de productos y servicios'.", "ForeignKeyNotFound", 1, "ARTICULOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtArticuloCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError30 == 0 ) )
         {
         }
         pr_default.close(2);
         A275MovimientoCostoTotal = (decimal)((A273MovimientoCantidad*A274MovimientoCosto)) ;
      }

      protected void CloseExtendedTableCursors1F66( )
      {
         pr_default.close(2);
      }

      protected void enableDisable1F66( )
      {
      }

      protected void gxLoad_8( String A41ClinicaCodigo ,
                               String A30ArticuloCodigo )
      {
         /* Using cursor T001F23 */
         pr_default.execute(21, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(21) == 101) )
         {
            AnyError41 = 1 ;
            AnyError30 = 1 ;
            GX_msglist.addItem("No existe 'Maestro de productos y servicios'.", "ForeignKeyNotFound", 1, "ARTICULOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtArticuloCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError30 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(21) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(21);
      }

      protected void GetKey1F66( )
      {
         /* Using cursor T001F24 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea});
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound66 = 1 ;
         }
         else
         {
            RcdFound66 = 0 ;
         }
         pr_default.close(22);
      }

      protected void getByPrimaryKey1F66( )
      {
         /* Using cursor T001F3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1F66( 7) ;
            RcdFound66 = 1 ;
            InitializeNonKey1F66( ) ;
            A272MovimientoLinea = T001F3_A272MovimientoLinea[0] ;
            A273MovimientoCantidad = T001F3_A273MovimientoCantidad[0] ;
            A274MovimientoCosto = T001F3_A274MovimientoCosto[0] ;
            A30ArticuloCodigo = T001F3_A30ArticuloCodigo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z114TipoMICodigo = A114TipoMICodigo ;
            Z267MovimientoId = A267MovimientoId ;
            Z272MovimientoLinea = A272MovimientoLinea ;
            sMode66 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1F66( ) ;
            Load1F66( ) ;
            Gx_mode = sMode66 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound66 = 0 ;
            InitializeNonKey1F66( ) ;
            sMode66 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1F66( ) ;
            Gx_mode = sMode66 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1F66( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001F2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MovimientoInvDetalle"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z273MovimientoCantidad != T001F2_A273MovimientoCantidad[0] ) || ( Z274MovimientoCosto != T001F2_A274MovimientoCosto[0] ) || ( StringUtil.StrCmp(Z30ArticuloCodigo, T001F2_A30ArticuloCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"MovimientoInvDetalle"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1F66( )
      {
         BeforeValidate1F66( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1F66( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1F66( 0) ;
            CheckOptimisticConcurrency1F66( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1F66( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1F66( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001F25 */
                     pr_default.execute(23, new Object[] {A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea, A273MovimientoCantidad, A274MovimientoCosto, A41ClinicaCodigo, A30ArticuloCodigo});
                     pr_default.close(23);
                     if ( (pr_default.getStatus(23) == 1) )
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
               Load1F66( ) ;
            }
            EndLevel1F66( ) ;
         }
         CloseExtendedTableCursors1F66( ) ;
      }

      protected void Update1F66( )
      {
         BeforeValidate1F66( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1F66( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1F66( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1F66( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1F66( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001F26 */
                     pr_default.execute(24, new Object[] {A273MovimientoCantidad, A274MovimientoCosto, A30ArticuloCodigo, A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea});
                     pr_default.close(24);
                     if ( (pr_default.getStatus(24) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"MovimientoInvDetalle"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1F66( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1F66( ) ;
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
            EndLevel1F66( ) ;
         }
         CloseExtendedTableCursors1F66( ) ;
      }

      protected void DeferredUpdate1F66( )
      {
      }

      protected void Delete1F66( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1F66( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1F66( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1F66( ) ;
            AfterConfirm1F66( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1F66( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001F27 */
                  pr_default.execute(25, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea});
                  pr_default.close(25);
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
         sMode66 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1F66( ) ;
         Gx_mode = sMode66 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1F66( )
      {
         standaloneModal1F66( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            A275MovimientoCostoTotal = (decimal)((A273MovimientoCantidad*A274MovimientoCosto)) ;
         }
      }

      protected void EndLevel1F66( )
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

      protected void ScanStart1F66( )
      {
         /* Using cursor T001F28 */
         pr_default.execute(26, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
         RcdFound66 = 0 ;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound66 = 1 ;
            A272MovimientoLinea = T001F28_A272MovimientoLinea[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1F66( )
      {
         pr_default.readNext(26);
         RcdFound66 = 0 ;
         if ( (pr_default.getStatus(26) != 101) )
         {
            RcdFound66 = 1 ;
            A272MovimientoLinea = T001F28_A272MovimientoLinea[0] ;
         }
      }

      protected void ScanEnd1F66( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm1F66( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1F66( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1F66( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1F66( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1F66( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1F66( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1F66( )
      {
         edtMovimientoLinea_Enabled = 0 ;
         edtArticuloCodigo_Enabled = 0 ;
         edtMovimientoCantidad_Enabled = 0 ;
         edtMovimientoCosto_Enabled = 0 ;
         edtMovimientoCostoTotal_Enabled = 0 ;
      }

      protected void AddRow1F66( )
      {
         nGXsfl_90_idx = (short)(nGXsfl_90_idx+1) ;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
         edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_90_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_90_idx ;
         imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_90_idx ;
         edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx ;
         edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_90_idx ;
         edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx ;
         SendRow1F66( ) ;
      }

      protected void SendRow1F66( )
      {
         Gridmovimientoinv_movimientoinvdetalleRow = GXWebRow.GetNew(context) ;
         if ( subGridmovimientoinv_movimientoinvdetalle_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridmovimientoinv_movimientoinvdetalle_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridmovimientoinv_movimientoinvdetalle_Class, "") != 0 )
            {
               subGridmovimientoinv_movimientoinvdetalle_Linesclass = subGridmovimientoinv_movimientoinvdetalle_Class+"Odd" ;
            }
         }
         else if ( subGridmovimientoinv_movimientoinvdetalle_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridmovimientoinv_movimientoinvdetalle_Backstyle = 0 ;
            subGridmovimientoinv_movimientoinvdetalle_Backcolor = subGridmovimientoinv_movimientoinvdetalle_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmovimientoinv_movimientoinvdetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmovimientoinv_movimientoinvdetalle_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridmovimientoinv_movimientoinvdetalle_Class, "") != 0 )
            {
               subGridmovimientoinv_movimientoinvdetalle_Linesclass = subGridmovimientoinv_movimientoinvdetalle_Class+"Uniform" ;
            }
         }
         else if ( subGridmovimientoinv_movimientoinvdetalle_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridmovimientoinv_movimientoinvdetalle_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridmovimientoinv_movimientoinvdetalle_Class, "") != 0 )
            {
               subGridmovimientoinv_movimientoinvdetalle_Linesclass = subGridmovimientoinv_movimientoinvdetalle_Class+"Odd" ;
            }
            subGridmovimientoinv_movimientoinvdetalle_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmovimientoinv_movimientoinvdetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmovimientoinv_movimientoinvdetalle_Backcolor), 9, 0)));
         }
         else if ( subGridmovimientoinv_movimientoinvdetalle_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridmovimientoinv_movimientoinvdetalle_Backstyle = 1 ;
            if ( ((int)(nGXsfl_90_idx) % (2)) == 0 )
            {
               subGridmovimientoinv_movimientoinvdetalle_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmovimientoinv_movimientoinvdetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmovimientoinv_movimientoinvdetalle_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridmovimientoinv_movimientoinvdetalle_Class, "") != 0 )
               {
                  subGridmovimientoinv_movimientoinvdetalle_Linesclass = subGridmovimientoinv_movimientoinvdetalle_Class+"Even" ;
               }
            }
            else
            {
               subGridmovimientoinv_movimientoinvdetalle_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmovimientoinv_movimientoinvdetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmovimientoinv_movimientoinvdetalle_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridmovimientoinv_movimientoinvdetalle_Class, "") != 0 )
               {
                  subGridmovimientoinv_movimientoinvdetalle_Linesclass = subGridmovimientoinv_movimientoinvdetalle_Class+"Odd" ;
               }
            }
         }
         imgprompt_30_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00c1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+"}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOCODIGO_"+sGXsfl_90_idx+"'), id:'"+"ARTICULOCODIGO_"+sGXsfl_90_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_66_"+sGXsfl_90_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_66_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 91,'',false,'" + sGXsfl_90_idx + "',90)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmovimientoinv_movimientoinvdetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A272MovimientoLinea), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A272MovimientoLinea), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(91);\"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoLinea_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtMovimientoLinea_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_66_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_90_idx + "',90)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmovimientoinv_movimientoinvdetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCodigo_Internalname,StringUtil.RTrim( A30ArticuloCodigo),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(92);\"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtArticuloCodigo_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridmovimientoinv_movimientoinvdetalleRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_30_Internalname,"prompt.gif",(String)imgprompt_30_Link,(String)"",(String)"",(String)"Fantastic",(int)imgprompt_30_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_66_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_90_idx + "',90)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmovimientoinv_movimientoinvdetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A273MovimientoCantidad, 17, 2, ".", "")),((edtMovimientoCantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A273MovimientoCantidad, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A273MovimientoCantidad, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(93);\"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoCantidad_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtMovimientoCantidad_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_66_" + sGXsfl_90_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 94,'',false,'" + sGXsfl_90_idx + "',90)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmovimientoinv_movimientoinvdetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoCosto_Internalname,StringUtil.LTrim( StringUtil.NToC( A274MovimientoCosto, 17, 2, ".", "")),((edtMovimientoCosto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A274MovimientoCosto, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A274MovimientoCosto, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(94);\"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoCosto_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtMovimientoCosto_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmovimientoinv_movimientoinvdetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoCostoTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A275MovimientoCostoTotal, 17, 2, ".", "")),((edtMovimientoCostoTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A275MovimientoCostoTotal, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A275MovimientoCostoTotal, "ZZZZZZZZZZZZZ9.99")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoCostoTotal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtMovimientoCostoTotal_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)90,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridmovimientoinv_movimientoinvdetalleRow);
         GXCCtl = "Z272MovimientoLinea_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z272MovimientoLinea), 4, 0, ".", "")));
         GXCCtl = "Z273MovimientoCantidad_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z273MovimientoCantidad, 17, 2, ".", "")));
         GXCCtl = "Z274MovimientoCosto_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z274MovimientoCosto, 17, 2, ".", "")));
         GXCCtl = "Z30ArticuloCodigo_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z30ArticuloCodigo));
         GXCCtl = "nRcdDeleted_66_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_66), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_66_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_66), 4, 0, ".", "")));
         GXCCtl = "nIsMod_66_" + sGXsfl_90_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_66), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOLINEA_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoLinea_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ARTICULOCODIGO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCantidad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOCOSTO_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCosto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMovimientoCostoTotal_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_30_"+sGXsfl_90_idx+"Link", StringUtil.RTrim( imgprompt_30_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridmovimientoinv_movimientoinvdetalleContainer.AddRow(Gridmovimientoinv_movimientoinvdetalleRow);
      }

      protected void ReadRow1F66( )
      {
         nGXsfl_90_idx = (short)(nGXsfl_90_idx+1) ;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
         edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_90_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_90_idx ;
         imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_90_idx ;
         edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx ;
         edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_90_idx ;
         edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx ;
         edtMovimientoLinea_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOLINEA_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         edtArticuloCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOCODIGO_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         edtMovimientoCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         edtMovimientoCosto_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOCOSTO_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         edtMovimientoCostoTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx+"Enabled"), ".", ",")) ;
         imgprompt_41_114_Link = cgiGet( "PROMPT_30_"+sGXsfl_90_idx+"Link") ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtMovimientoLinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovimientoLinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVIMIENTOLINEA");
            AnyError = 1 ;
            GX_FocusControl = edtMovimientoLinea_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A272MovimientoLinea = 0 ;
         }
         else
         {
            A272MovimientoLinea = (short)(context.localUtil.CToN( cgiGet( edtMovimientoLinea_Internalname), ".", ",")) ;
         }
         A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtMovimientoCantidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovimientoCantidad_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVIMIENTOCANTIDAD");
            AnyError = 1 ;
            GX_FocusControl = edtMovimientoCantidad_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A273MovimientoCantidad = 0 ;
         }
         else
         {
            A273MovimientoCantidad = context.localUtil.CToN( cgiGet( edtMovimientoCantidad_Internalname), ".", ",") ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtMovimientoCosto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMovimientoCosto_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MOVIMIENTOCOSTO");
            AnyError = 1 ;
            GX_FocusControl = edtMovimientoCosto_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A274MovimientoCosto = 0 ;
         }
         else
         {
            A274MovimientoCosto = context.localUtil.CToN( cgiGet( edtMovimientoCosto_Internalname), ".", ",") ;
         }
         A275MovimientoCostoTotal = context.localUtil.CToN( cgiGet( edtMovimientoCostoTotal_Internalname), ".", ",") ;
         GXCCtl = "Z272MovimientoLinea_" + sGXsfl_90_idx ;
         Z272MovimientoLinea = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z273MovimientoCantidad_" + sGXsfl_90_idx ;
         Z273MovimientoCantidad = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z274MovimientoCosto_" + sGXsfl_90_idx ;
         Z274MovimientoCosto = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z30ArticuloCodigo_" + sGXsfl_90_idx ;
         Z30ArticuloCodigo = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_66_" + sGXsfl_90_idx ;
         nRcdDeleted_66 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_66_" + sGXsfl_90_idx ;
         nRcdExists_66 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_66_" + sGXsfl_90_idx ;
         nIsMod_66 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtMovimientoLinea_Enabled = edtMovimientoLinea_Enabled ;
      }

      protected void ConfirmValues1F0( )
      {
         nGXsfl_90_idx = 0 ;
         sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
         edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_90_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_90_idx ;
         imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_90_idx ;
         edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx ;
         edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_90_idx ;
         edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx ;
         while ( nGXsfl_90_idx < nRC_Gridmovimientoinv_movimientoinvdetalle )
         {
            nGXsfl_90_idx = (short)(nGXsfl_90_idx+1) ;
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
            edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_90_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_90_idx ;
            imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_90_idx ;
            edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx ;
            edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_90_idx ;
            edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx ;
            ChangePostValue( "Z272MovimientoLinea_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z272MovimientoLinea_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z272MovimientoLinea_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z273MovimientoCantidad_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z273MovimientoCantidad_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z273MovimientoCantidad_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z274MovimientoCosto_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z274MovimientoCosto_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z274MovimientoCosto_"+sGXsfl_90_idx) ;
            ChangePostValue( "Z30ArticuloCodigo_"+sGXsfl_90_idx, cgiGet( "ZT_"+"Z30ArticuloCodigo_"+sGXsfl_90_idx)) ;
            DeletePostValue( "ZT_"+"Z30ArticuloCodigo_"+sGXsfl_90_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("movimientoinv.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z114TipoMICodigo", StringUtil.RTrim( Z114TipoMICodigo));
         GxWebStd.gx_hidden_field( context, "Z267MovimientoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z267MovimientoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z268MovimientoFecha", context.localUtil.DToC( Z268MovimientoFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z288MovimientoHora", StringUtil.RTrim( Z288MovimientoHora));
         GxWebStd.gx_hidden_field( context, "Z269MovimientoReferencia", StringUtil.RTrim( Z269MovimientoReferencia));
         GxWebStd.gx_hidden_field( context, "Z270MovimientoObs", StringUtil.RTrim( Z270MovimientoObs));
         GxWebStd.gx_hidden_field( context, "Z271MovimientoEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z271MovimientoEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z121BodegaCodigo", StringUtil.RTrim( Z121BodegaCodigo));
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridmovimientoinv_movimientoinvdetalle", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_90_idx), 4, 0, ".", "")));
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
         return "MovimientoInv" ;
      }

      public override String GetPgmdesc( )
      {
         return "Encabezado de movimiento de inventario" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("movimientoinv.aspx")  ;
      }

      protected void InitializeNonKey1F65( )
      {
         A268MovimientoFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268MovimientoFecha", context.localUtil.Format(A268MovimientoFecha, "99/99/99"));
         A288MovimientoHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288MovimientoHora", A288MovimientoHora);
         A121BodegaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
         A269MovimientoReferencia = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269MovimientoReferencia", A269MovimientoReferencia);
         A270MovimientoObs = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A270MovimientoObs", A270MovimientoObs);
         A271MovimientoEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271MovimientoEstado", StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0));
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
      }

      protected void InitAll1F65( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A114TipoMICodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114TipoMICodigo", A114TipoMICodigo);
         A267MovimientoId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A267MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A267MovimientoId), 9, 0)));
         InitializeNonKey1F65( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1F66( )
      {
         A275MovimientoCostoTotal = 0 ;
         A30ArticuloCodigo = "" ;
         A273MovimientoCantidad = 0 ;
         A274MovimientoCosto = 0 ;
      }

      protected void InitAll1F66( )
      {
         A272MovimientoLinea = 0 ;
         InitializeNonKey1F66( ) ;
      }

      protected void StandaloneModalInsert1F66( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1565016");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("movimientoinv.js", "?1565016");
         /* End function include_jscripts */
      }

      protected void init_level_properties66( )
      {
         edtMovimientoLinea_Enabled = defedtMovimientoLinea_Enabled ;
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
         lblTextblocktipomicodigo_Internalname = "TEXTBLOCKTIPOMICODIGO" ;
         edtTipoMICodigo_Internalname = "TIPOMICODIGO" ;
         lblTextblockmovimientoid_Internalname = "TEXTBLOCKMOVIMIENTOID" ;
         edtMovimientoId_Internalname = "MOVIMIENTOID" ;
         lblTextblockmovimientofecha_Internalname = "TEXTBLOCKMOVIMIENTOFECHA" ;
         edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA" ;
         lblTextblockmovimientohora_Internalname = "TEXTBLOCKMOVIMIENTOHORA" ;
         edtMovimientoHora_Internalname = "MOVIMIENTOHORA" ;
         lblTextblockbodegacodigo_Internalname = "TEXTBLOCKBODEGACODIGO" ;
         edtBodegaCodigo_Internalname = "BODEGACODIGO" ;
         lblTextblockmovimientoreferencia_Internalname = "TEXTBLOCKMOVIMIENTOREFERENCIA" ;
         edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA" ;
         lblTextblockmovimientoobs_Internalname = "TEXTBLOCKMOVIMIENTOOBS" ;
         edtMovimientoObs_Internalname = "MOVIMIENTOOBS" ;
         lblTextblockmovimientoestado_Internalname = "TEXTBLOCKMOVIMIENTOESTADO" ;
         cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         lblTitlemovimientoinvdetalle_Internalname = "TITLEMOVIMIENTOINVDETALLE" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_114_Internalname = "PROMPT_41_114" ;
         imgprompt_41_121_Internalname = "PROMPT_41_121" ;
         imgprompt_4_Internalname = "PROMPT_4" ;
         subGridmovimientoinv_movimientoinvdetalle_Internalname = "GRIDMOVIMIENTOINV_MOVIMIENTOINVDETALLE" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Encabezado de movimiento de inventario" ;
         edtMovimientoCostoTotal_Jsonclick = "" ;
         edtMovimientoCosto_Jsonclick = "" ;
         edtMovimientoCantidad_Jsonclick = "" ;
         imgprompt_30_Visible = 1 ;
         imgprompt_30_Link = "" ;
         imgprompt_41_114_Visible = 1 ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtMovimientoLinea_Jsonclick = "" ;
         subGridmovimientoinv_movimientoinvdetalle_Class = "Grid" ;
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
         subGridmovimientoinv_movimientoinvdetalle_Allowcollapsing = 0 ;
         edtMovimientoCostoTotal_Enabled = 0 ;
         edtMovimientoCosto_Enabled = 1 ;
         edtMovimientoCantidad_Enabled = 1 ;
         edtArticuloCodigo_Enabled = 1 ;
         edtMovimientoLinea_Enabled = 1 ;
         subGridmovimientoinv_movimientoinvdetalle_Backcolorstyle = 2 ;
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         cmbMovimientoEstado_Jsonclick = "" ;
         cmbMovimientoEstado.Enabled = 1 ;
         edtMovimientoObs_Enabled = 1 ;
         edtMovimientoReferencia_Jsonclick = "" ;
         edtMovimientoReferencia_Enabled = 1 ;
         imgprompt_41_121_Visible = 1 ;
         imgprompt_41_121_Link = "" ;
         edtBodegaCodigo_Jsonclick = "" ;
         edtBodegaCodigo_Enabled = 1 ;
         edtMovimientoHora_Jsonclick = "" ;
         edtMovimientoHora_Enabled = 1 ;
         edtMovimientoFecha_Jsonclick = "" ;
         edtMovimientoFecha_Enabled = 1 ;
         edtMovimientoId_Jsonclick = "" ;
         edtMovimientoId_Enabled = 1 ;
         imgprompt_41_114_Visible = 1 ;
         imgprompt_41_114_Link = "" ;
         edtTipoMICodigo_Jsonclick = "" ;
         edtTipoMICodigo_Enabled = 1 ;
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

      protected void gxnrGridmovimientoinv_movimientoinvdetalle_newrow( short nRC_Gridmovimientoinv_movimientoinvdetalle ,
                                                                        short nGXsfl_90_idx ,
                                                                        String sGXsfl_90_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_90_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_90_idx ;
         imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_90_idx ;
         edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx ;
         edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_90_idx ;
         edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx ;
         while ( nGXsfl_90_idx <= nRC_Gridmovimientoinv_movimientoinvdetalle )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1F66( ) ;
            standaloneModal1F66( ) ;
            cmbMovimientoEstado.Name = "MOVIMIENTOESTADO" ;
            cmbMovimientoEstado.WebTags = "" ;
            cmbMovimientoEstado.addItem("0", "Creado", 0);
            cmbMovimientoEstado.addItem("1", "Emitido", 0);
            cmbMovimientoEstado.addItem("2", "Anulado", 0);
            cmbMovimientoEstado.addItem("3", "Cancelado", 0);
            if ( ( cmbMovimientoEstado.ItemCount > 0 ) && (0==A271MovimientoEstado) )
            {
               A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A271MovimientoEstado", StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0));
            }
            dynload_actions( ) ;
            SendRow1F66( ) ;
            nGXsfl_90_idx = (short)(nGXsfl_90_idx+1) ;
            sGXsfl_90_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_90_idx), 4, 0)), 4, "0") ;
            edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_90_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_90_idx ;
            imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_90_idx ;
            edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_90_idx ;
            edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_90_idx ;
            edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_90_idx ;
         }
         context.GX_webresponse.AddString(Gridmovimientoinv_movimientoinvdetalleContainer.ToJavascriptSource());
         /* End function gxnrGridmovimientoinv_movimientoinvdetalle_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T001F29 */
         pr_default.execute(27, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(27) == 101) )
         {
            AnyError41 = 1 ;
            AnyError114 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Movimientos de Inventario'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError114 == 0 ) )
         {
         }
         pr_default.close(27);
         GX_FocusControl = edtMovimientoFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Tipomicodigo( String GX_Parm1 ,
                                      String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A114TipoMICodigo = GX_Parm2 ;
         /* Using cursor T001F29 */
         pr_default.execute(27, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         if ( (pr_default.getStatus(27) == 101) )
         {
            AnyError41 = 1 ;
            AnyError114 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Movimientos de Inventario'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError114 == 0 ) )
         {
         }
         pr_default.close(27);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Movimientoid( String GX_Parm1 ,
                                      String GX_Parm2 ,
                                      int GX_Parm3 ,
                                      DateTime GX_Parm4 ,
                                      String GX_Parm5 ,
                                      String GX_Parm6 ,
                                      String GX_Parm7 ,
                                      GXCombobox cmbGX_Parm8 ,
                                      String GX_Parm9 ,
                                      String GX_Parm10 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A114TipoMICodigo = GX_Parm2 ;
         A267MovimientoId = GX_Parm3 ;
         A268MovimientoFecha = GX_Parm4 ;
         A288MovimientoHora = GX_Parm5 ;
         A269MovimientoReferencia = GX_Parm6 ;
         A270MovimientoObs = GX_Parm7 ;
         cmbMovimientoEstado = cmbGX_Parm8 ;
         A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.CurrentValue, ".")) ;
         cmbMovimientoEstado.CurrentValue = StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0) ;
         A121BodegaCodigo = GX_Parm9 ;
         A4UsuarioCodigo = GX_Parm10 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A268MovimientoFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A288MovimientoHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A121BodegaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A269MovimientoReferencia)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A270MovimientoObs)));
         cmbMovimientoEstado.CurrentValue = StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbMovimientoEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z114TipoMICodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z267MovimientoId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z268MovimientoFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z288MovimientoHora)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z121BodegaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z269MovimientoReferencia)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z270MovimientoObs)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z271MovimientoEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(Gridmovimientoinv_movimientoinvdetalleContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Bodegacodigo( String GX_Parm1 ,
                                      String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A121BodegaCodigo = GX_Parm2 ;
         /* Using cursor T001F30 */
         pr_default.execute(28, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
         if ( (pr_default.getStatus(28) == 101) )
         {
            AnyError41 = 1 ;
            AnyError121 = 1 ;
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError121 == 0 ) )
         {
         }
         pr_default.close(28);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Usuariocodigo( String GX_Parm1 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         /* Using cursor T001F31 */
         pr_default.execute(29, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(29) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(29);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Articulocodigo( String GX_Parm1 ,
                                        String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A30ArticuloCodigo = GX_Parm2 ;
         /* Using cursor T001F32 */
         pr_default.execute(30, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(30) == 101) )
         {
            AnyError41 = 1 ;
            AnyError30 = 1 ;
            GX_msglist.addItem("No existe 'Maestro de productos y servicios'.", "ForeignKeyNotFound", 1, "ARTICULOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtArticuloCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError30 == 0 ) )
         {
         }
         pr_default.close(30);
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
         pr_default.close(26);
         pr_default.close(30);
         pr_default.close(19);
         pr_default.close(14);
         pr_default.close(13);
         pr_default.close(27);
         pr_default.close(28);
         pr_default.close(29);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A121BodegaCodigo = "" ;
         A114TipoMICodigo = "" ;
         A4UsuarioCodigo = "" ;
         A30ArticuloCodigo = "" ;
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
         lblTextblocktipomicodigo_Jsonclick = "" ;
         lblTextblockmovimientoid_Jsonclick = "" ;
         lblTextblockmovimientofecha_Jsonclick = "" ;
         A268MovimientoFecha = DateTime.MinValue ;
         lblTextblockmovimientohora_Jsonclick = "" ;
         A288MovimientoHora = "" ;
         lblTextblockbodegacodigo_Jsonclick = "" ;
         lblTextblockmovimientoreferencia_Jsonclick = "" ;
         A269MovimientoReferencia = "" ;
         lblTextblockmovimientoobs_Jsonclick = "" ;
         A270MovimientoObs = "" ;
         lblTextblockmovimientoestado_Jsonclick = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         Gridmovimientoinv_movimientoinvdetalleContainer = new GXWebGrid( context);
         Gridmovimientoinv_movimientoinvdetalleColumn = new GXWebColumn();
         Gx_mode = "" ;
         sMode66 = "" ;
         edtMovimientoLinea_Internalname = "" ;
         lblTitlemovimientoinvdetalle_Jsonclick = "" ;
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
         Z114TipoMICodigo = "" ;
         Z268MovimientoFecha = DateTime.MinValue ;
         Z288MovimientoHora = "" ;
         Z269MovimientoReferencia = "" ;
         Z270MovimientoObs = "" ;
         Z121BodegaCodigo = "" ;
         Z4UsuarioCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtArticuloCodigo_Internalname = "" ;
         edtMovimientoCantidad_Internalname = "" ;
         edtMovimientoCosto_Internalname = "" ;
         edtMovimientoCostoTotal_Internalname = "" ;
         Z30ArticuloCodigo = "" ;
         T001F10_A267MovimientoId = new int[1] ;
         T001F10_A268MovimientoFecha = new DateTime[] {DateTime.MinValue} ;
         T001F10_A288MovimientoHora = new String[] {""} ;
         T001F10_A269MovimientoReferencia = new String[] {""} ;
         T001F10_A270MovimientoObs = new String[] {""} ;
         T001F10_A271MovimientoEstado = new short[1] ;
         T001F10_A41ClinicaCodigo = new String[] {""} ;
         T001F10_A114TipoMICodigo = new String[] {""} ;
         T001F10_A121BodegaCodigo = new String[] {""} ;
         T001F10_A4UsuarioCodigo = new String[] {""} ;
         T001F8_A41ClinicaCodigo = new String[] {""} ;
         T001F7_A41ClinicaCodigo = new String[] {""} ;
         T001F9_A4UsuarioCodigo = new String[] {""} ;
         T001F11_A41ClinicaCodigo = new String[] {""} ;
         T001F12_A41ClinicaCodigo = new String[] {""} ;
         T001F13_A4UsuarioCodigo = new String[] {""} ;
         T001F14_A41ClinicaCodigo = new String[] {""} ;
         T001F14_A114TipoMICodigo = new String[] {""} ;
         T001F14_A267MovimientoId = new int[1] ;
         T001F6_A267MovimientoId = new int[1] ;
         T001F6_A268MovimientoFecha = new DateTime[] {DateTime.MinValue} ;
         T001F6_A288MovimientoHora = new String[] {""} ;
         T001F6_A269MovimientoReferencia = new String[] {""} ;
         T001F6_A270MovimientoObs = new String[] {""} ;
         T001F6_A271MovimientoEstado = new short[1] ;
         T001F6_A41ClinicaCodigo = new String[] {""} ;
         T001F6_A114TipoMICodigo = new String[] {""} ;
         T001F6_A121BodegaCodigo = new String[] {""} ;
         T001F6_A4UsuarioCodigo = new String[] {""} ;
         sMode65 = "" ;
         T001F15_A41ClinicaCodigo = new String[] {""} ;
         T001F15_A114TipoMICodigo = new String[] {""} ;
         T001F15_A267MovimientoId = new int[1] ;
         T001F16_A41ClinicaCodigo = new String[] {""} ;
         T001F16_A114TipoMICodigo = new String[] {""} ;
         T001F16_A267MovimientoId = new int[1] ;
         T001F17_A267MovimientoId = new int[1] ;
         T001F17_A268MovimientoFecha = new DateTime[] {DateTime.MinValue} ;
         T001F17_A288MovimientoHora = new String[] {""} ;
         T001F17_A269MovimientoReferencia = new String[] {""} ;
         T001F17_A270MovimientoObs = new String[] {""} ;
         T001F17_A271MovimientoEstado = new short[1] ;
         T001F17_A41ClinicaCodigo = new String[] {""} ;
         T001F17_A114TipoMICodigo = new String[] {""} ;
         T001F17_A121BodegaCodigo = new String[] {""} ;
         T001F17_A4UsuarioCodigo = new String[] {""} ;
         T001F21_A41ClinicaCodigo = new String[] {""} ;
         T001F21_A114TipoMICodigo = new String[] {""} ;
         T001F21_A267MovimientoId = new int[1] ;
         T001F22_A114TipoMICodigo = new String[] {""} ;
         T001F22_A267MovimientoId = new int[1] ;
         T001F22_A272MovimientoLinea = new short[1] ;
         T001F22_A273MovimientoCantidad = new decimal[1] ;
         T001F22_A274MovimientoCosto = new decimal[1] ;
         T001F22_A41ClinicaCodigo = new String[] {""} ;
         T001F22_A30ArticuloCodigo = new String[] {""} ;
         T001F4_A41ClinicaCodigo = new String[] {""} ;
         T001F23_A41ClinicaCodigo = new String[] {""} ;
         T001F24_A41ClinicaCodigo = new String[] {""} ;
         T001F24_A114TipoMICodigo = new String[] {""} ;
         T001F24_A267MovimientoId = new int[1] ;
         T001F24_A272MovimientoLinea = new short[1] ;
         T001F3_A114TipoMICodigo = new String[] {""} ;
         T001F3_A267MovimientoId = new int[1] ;
         T001F3_A272MovimientoLinea = new short[1] ;
         T001F3_A273MovimientoCantidad = new decimal[1] ;
         T001F3_A274MovimientoCosto = new decimal[1] ;
         T001F3_A41ClinicaCodigo = new String[] {""} ;
         T001F3_A30ArticuloCodigo = new String[] {""} ;
         T001F2_A114TipoMICodigo = new String[] {""} ;
         T001F2_A267MovimientoId = new int[1] ;
         T001F2_A272MovimientoLinea = new short[1] ;
         T001F2_A273MovimientoCantidad = new decimal[1] ;
         T001F2_A274MovimientoCosto = new decimal[1] ;
         T001F2_A41ClinicaCodigo = new String[] {""} ;
         T001F2_A30ArticuloCodigo = new String[] {""} ;
         T001F28_A41ClinicaCodigo = new String[] {""} ;
         T001F28_A114TipoMICodigo = new String[] {""} ;
         T001F28_A267MovimientoId = new int[1] ;
         T001F28_A272MovimientoLinea = new short[1] ;
         imgprompt_30_Internalname = "" ;
         Gridmovimientoinv_movimientoinvdetalleRow = new GXWebRow();
         subGridmovimientoinv_movimientoinvdetalle_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char12 = "" ;
         GXt_char11 = "" ;
         GXt_char13 = "" ;
         T001F29_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T001F30_A41ClinicaCodigo = new String[] {""} ;
         T001F31_A4UsuarioCodigo = new String[] {""} ;
         T001F32_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.movimientoinv__default(),
            new Object[][] {
                new Object[] {
               T001F2_A114TipoMICodigo, T001F2_A267MovimientoId, T001F2_A272MovimientoLinea, T001F2_A273MovimientoCantidad, T001F2_A274MovimientoCosto, T001F2_A41ClinicaCodigo, T001F2_A30ArticuloCodigo
               }
               , new Object[] {
               T001F3_A114TipoMICodigo, T001F3_A267MovimientoId, T001F3_A272MovimientoLinea, T001F3_A273MovimientoCantidad, T001F3_A274MovimientoCosto, T001F3_A41ClinicaCodigo, T001F3_A30ArticuloCodigo
               }
               , new Object[] {
               T001F4_A41ClinicaCodigo
               }
               , new Object[] {
               T001F5_A267MovimientoId, T001F5_A268MovimientoFecha, T001F5_A288MovimientoHora, T001F5_A269MovimientoReferencia, T001F5_A270MovimientoObs, T001F5_A271MovimientoEstado, T001F5_A41ClinicaCodigo, T001F5_A114TipoMICodigo, T001F5_A121BodegaCodigo, T001F5_A4UsuarioCodigo
               }
               , new Object[] {
               T001F6_A267MovimientoId, T001F6_A268MovimientoFecha, T001F6_A288MovimientoHora, T001F6_A269MovimientoReferencia, T001F6_A270MovimientoObs, T001F6_A271MovimientoEstado, T001F6_A41ClinicaCodigo, T001F6_A114TipoMICodigo, T001F6_A121BodegaCodigo, T001F6_A4UsuarioCodigo
               }
               , new Object[] {
               T001F7_A41ClinicaCodigo
               }
               , new Object[] {
               T001F8_A41ClinicaCodigo
               }
               , new Object[] {
               T001F9_A4UsuarioCodigo
               }
               , new Object[] {
               T001F10_A267MovimientoId, T001F10_A268MovimientoFecha, T001F10_A288MovimientoHora, T001F10_A269MovimientoReferencia, T001F10_A270MovimientoObs, T001F10_A271MovimientoEstado, T001F10_A41ClinicaCodigo, T001F10_A114TipoMICodigo, T001F10_A121BodegaCodigo, T001F10_A4UsuarioCodigo
               }
               , new Object[] {
               T001F11_A41ClinicaCodigo
               }
               , new Object[] {
               T001F12_A41ClinicaCodigo
               }
               , new Object[] {
               T001F13_A4UsuarioCodigo
               }
               , new Object[] {
               T001F14_A41ClinicaCodigo, T001F14_A114TipoMICodigo, T001F14_A267MovimientoId
               }
               , new Object[] {
               T001F15_A41ClinicaCodigo, T001F15_A114TipoMICodigo, T001F15_A267MovimientoId
               }
               , new Object[] {
               T001F16_A41ClinicaCodigo, T001F16_A114TipoMICodigo, T001F16_A267MovimientoId
               }
               , new Object[] {
               T001F17_A267MovimientoId, T001F17_A268MovimientoFecha, T001F17_A288MovimientoHora, T001F17_A269MovimientoReferencia, T001F17_A270MovimientoObs, T001F17_A271MovimientoEstado, T001F17_A41ClinicaCodigo, T001F17_A114TipoMICodigo, T001F17_A121BodegaCodigo, T001F17_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001F21_A41ClinicaCodigo, T001F21_A114TipoMICodigo, T001F21_A267MovimientoId
               }
               , new Object[] {
               T001F22_A114TipoMICodigo, T001F22_A267MovimientoId, T001F22_A272MovimientoLinea, T001F22_A273MovimientoCantidad, T001F22_A274MovimientoCosto, T001F22_A41ClinicaCodigo, T001F22_A30ArticuloCodigo
               }
               , new Object[] {
               T001F23_A41ClinicaCodigo
               }
               , new Object[] {
               T001F24_A41ClinicaCodigo, T001F24_A114TipoMICodigo, T001F24_A267MovimientoId, T001F24_A272MovimientoLinea
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001F28_A41ClinicaCodigo, T001F28_A114TipoMICodigo, T001F28_A267MovimientoId, T001F28_A272MovimientoLinea
               }
               , new Object[] {
               T001F29_A41ClinicaCodigo
               }
               , new Object[] {
               T001F30_A41ClinicaCodigo
               }
               , new Object[] {
               T001F31_A4UsuarioCodigo
               }
               , new Object[] {
               T001F32_A41ClinicaCodigo
               }
            }
         );
      }

      private short nIsMod_66 ;
      private short GxWebError ;
      private short nRC_Gridmovimientoinv_movimientoinvdetalle ;
      private short nGXsfl_90_idx=1 ;
      private short gxcookieaux ;
      private short A271MovimientoEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridmovimientoinv_movimientoinvdetalle_Backcolorstyle ;
      private short A272MovimientoLinea ;
      private short subGridmovimientoinv_movimientoinvdetalle_Allowcollapsing ;
      private short subGridmovimientoinv_movimientoinvdetalle_Collapsed ;
      private short nBlankRcdCount66 ;
      private short nRcdExists_66 ;
      private short RcdFound66 ;
      private short nBlankRcdUsr66 ;
      private short Z271MovimientoEstado ;
      private short nRcdDeleted_66 ;
      private short Z272MovimientoLinea ;
      private short GX_JID ;
      private short RcdFound65 ;
      private short Gx_BScreen ;
      private short subGridmovimientoinv_movimientoinvdetalle_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtTipoMICodigo_Enabled ;
      private int imgprompt_41_114_Visible ;
      private int A267MovimientoId ;
      private int edtMovimientoId_Enabled ;
      private int edtMovimientoFecha_Enabled ;
      private int edtMovimientoHora_Enabled ;
      private int edtBodegaCodigo_Enabled ;
      private int imgprompt_41_121_Visible ;
      private int edtMovimientoReferencia_Enabled ;
      private int edtMovimientoObs_Enabled ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtMovimientoLinea_Enabled ;
      private int edtArticuloCodigo_Enabled ;
      private int edtMovimientoCantidad_Enabled ;
      private int edtMovimientoCosto_Enabled ;
      private int edtMovimientoCostoTotal_Enabled ;
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
      private int Z267MovimientoId ;
      private int GRIDMOVIMIENTOINV_MOVIMIENTOINVDETALLE_nFirstRecordOnPage ;
      private int AnyError41 ;
      private int AnyError121 ;
      private int AnyError114 ;
      private int AnyError4 ;
      private int AnyError30 ;
      private int subGridmovimientoinv_movimientoinvdetalle_Backcolor ;
      private int subGridmovimientoinv_movimientoinvdetalle_Allbackcolor ;
      private int imgprompt_30_Visible ;
      private int defedtMovimientoLinea_Enabled ;
      private int idxLst ;
      private decimal A273MovimientoCantidad ;
      private decimal A274MovimientoCosto ;
      private decimal A275MovimientoCostoTotal ;
      private decimal Z273MovimientoCantidad ;
      private decimal Z274MovimientoCosto ;
      private String sPrefix ;
      private String sGXsfl_90_idx="0001" ;
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
      private String lblTextblocktipomicodigo_Internalname ;
      private String lblTextblocktipomicodigo_Jsonclick ;
      private String edtTipoMICodigo_Internalname ;
      private String edtTipoMICodigo_Jsonclick ;
      private String imgprompt_41_114_Internalname ;
      private String imgprompt_41_114_Link ;
      private String lblTextblockmovimientoid_Internalname ;
      private String lblTextblockmovimientoid_Jsonclick ;
      private String edtMovimientoId_Internalname ;
      private String edtMovimientoId_Jsonclick ;
      private String lblTextblockmovimientofecha_Internalname ;
      private String lblTextblockmovimientofecha_Jsonclick ;
      private String edtMovimientoFecha_Internalname ;
      private String edtMovimientoFecha_Jsonclick ;
      private String lblTextblockmovimientohora_Internalname ;
      private String lblTextblockmovimientohora_Jsonclick ;
      private String A288MovimientoHora ;
      private String edtMovimientoHora_Internalname ;
      private String edtMovimientoHora_Jsonclick ;
      private String lblTextblockbodegacodigo_Internalname ;
      private String lblTextblockbodegacodigo_Jsonclick ;
      private String edtBodegaCodigo_Internalname ;
      private String edtBodegaCodigo_Jsonclick ;
      private String imgprompt_41_121_Internalname ;
      private String imgprompt_41_121_Link ;
      private String lblTextblockmovimientoreferencia_Internalname ;
      private String lblTextblockmovimientoreferencia_Jsonclick ;
      private String edtMovimientoReferencia_Internalname ;
      private String edtMovimientoReferencia_Jsonclick ;
      private String lblTextblockmovimientoobs_Internalname ;
      private String lblTextblockmovimientoobs_Jsonclick ;
      private String edtMovimientoObs_Internalname ;
      private String lblTextblockmovimientoestado_Internalname ;
      private String lblTextblockmovimientoestado_Jsonclick ;
      private String cmbMovimientoEstado_Internalname ;
      private String cmbMovimientoEstado_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String Gx_mode ;
      private String sMode66 ;
      private String edtMovimientoLinea_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlemovimientoinvdetalle_Internalname ;
      private String lblTitlemovimientoinvdetalle_Jsonclick ;
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
      private String Z288MovimientoHora ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtArticuloCodigo_Internalname ;
      private String edtMovimientoCantidad_Internalname ;
      private String edtMovimientoCosto_Internalname ;
      private String edtMovimientoCostoTotal_Internalname ;
      private String sMode65 ;
      private String imgprompt_30_Internalname ;
      private String subGridmovimientoinv_movimientoinvdetalle_Class ;
      private String subGridmovimientoinv_movimientoinvdetalle_Linesclass ;
      private String imgprompt_30_Link ;
      private String ROClassString ;
      private String edtMovimientoLinea_Jsonclick ;
      private String edtArticuloCodigo_Jsonclick ;
      private String edtMovimientoCantidad_Jsonclick ;
      private String edtMovimientoCosto_Jsonclick ;
      private String edtMovimientoCostoTotal_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char12 ;
      private String GXt_char11 ;
      private String subGridmovimientoinv_movimientoinvdetalle_Internalname ;
      private String GXt_char13 ;
      private DateTime A268MovimientoFecha ;
      private DateTime Z268MovimientoFecha ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A121BodegaCodigo ;
      private String A114TipoMICodigo ;
      private String A4UsuarioCodigo ;
      private String A30ArticuloCodigo ;
      private String A269MovimientoReferencia ;
      private String A270MovimientoObs ;
      private String Z41ClinicaCodigo ;
      private String Z114TipoMICodigo ;
      private String Z269MovimientoReferencia ;
      private String Z270MovimientoObs ;
      private String Z121BodegaCodigo ;
      private String Z4UsuarioCodigo ;
      private String Z30ArticuloCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridmovimientoinv_movimientoinvdetalleContainer ;
      private GXWebRow Gridmovimientoinv_movimientoinvdetalleRow ;
      private GXWebColumn Gridmovimientoinv_movimientoinvdetalleColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbMovimientoEstado ;
      private IDataStoreProvider pr_default ;
      private int[] T001F10_A267MovimientoId ;
      private DateTime[] T001F10_A268MovimientoFecha ;
      private String[] T001F10_A288MovimientoHora ;
      private String[] T001F10_A269MovimientoReferencia ;
      private String[] T001F10_A270MovimientoObs ;
      private short[] T001F10_A271MovimientoEstado ;
      private String[] T001F10_A41ClinicaCodigo ;
      private String[] T001F10_A114TipoMICodigo ;
      private String[] T001F10_A121BodegaCodigo ;
      private String[] T001F10_A4UsuarioCodigo ;
      private String[] T001F8_A41ClinicaCodigo ;
      private String[] T001F7_A41ClinicaCodigo ;
      private String[] T001F9_A4UsuarioCodigo ;
      private String[] T001F11_A41ClinicaCodigo ;
      private String[] T001F12_A41ClinicaCodigo ;
      private String[] T001F13_A4UsuarioCodigo ;
      private String[] T001F14_A41ClinicaCodigo ;
      private String[] T001F14_A114TipoMICodigo ;
      private int[] T001F14_A267MovimientoId ;
      private int[] T001F6_A267MovimientoId ;
      private DateTime[] T001F6_A268MovimientoFecha ;
      private String[] T001F6_A288MovimientoHora ;
      private String[] T001F6_A269MovimientoReferencia ;
      private String[] T001F6_A270MovimientoObs ;
      private short[] T001F6_A271MovimientoEstado ;
      private String[] T001F6_A41ClinicaCodigo ;
      private String[] T001F6_A114TipoMICodigo ;
      private String[] T001F6_A121BodegaCodigo ;
      private String[] T001F6_A4UsuarioCodigo ;
      private String[] T001F15_A41ClinicaCodigo ;
      private String[] T001F15_A114TipoMICodigo ;
      private int[] T001F15_A267MovimientoId ;
      private String[] T001F16_A41ClinicaCodigo ;
      private String[] T001F16_A114TipoMICodigo ;
      private int[] T001F16_A267MovimientoId ;
      private int[] T001F17_A267MovimientoId ;
      private DateTime[] T001F17_A268MovimientoFecha ;
      private String[] T001F17_A288MovimientoHora ;
      private String[] T001F17_A269MovimientoReferencia ;
      private String[] T001F17_A270MovimientoObs ;
      private short[] T001F17_A271MovimientoEstado ;
      private String[] T001F17_A41ClinicaCodigo ;
      private String[] T001F17_A114TipoMICodigo ;
      private String[] T001F17_A121BodegaCodigo ;
      private String[] T001F17_A4UsuarioCodigo ;
      private String[] T001F21_A41ClinicaCodigo ;
      private String[] T001F21_A114TipoMICodigo ;
      private int[] T001F21_A267MovimientoId ;
      private String[] T001F22_A114TipoMICodigo ;
      private int[] T001F22_A267MovimientoId ;
      private short[] T001F22_A272MovimientoLinea ;
      private decimal[] T001F22_A273MovimientoCantidad ;
      private decimal[] T001F22_A274MovimientoCosto ;
      private String[] T001F22_A41ClinicaCodigo ;
      private String[] T001F22_A30ArticuloCodigo ;
      private String[] T001F4_A41ClinicaCodigo ;
      private String[] T001F23_A41ClinicaCodigo ;
      private String[] T001F24_A41ClinicaCodigo ;
      private String[] T001F24_A114TipoMICodigo ;
      private int[] T001F24_A267MovimientoId ;
      private short[] T001F24_A272MovimientoLinea ;
      private String[] T001F3_A114TipoMICodigo ;
      private int[] T001F3_A267MovimientoId ;
      private short[] T001F3_A272MovimientoLinea ;
      private decimal[] T001F3_A273MovimientoCantidad ;
      private decimal[] T001F3_A274MovimientoCosto ;
      private String[] T001F3_A41ClinicaCodigo ;
      private String[] T001F3_A30ArticuloCodigo ;
      private String[] T001F2_A114TipoMICodigo ;
      private int[] T001F2_A267MovimientoId ;
      private short[] T001F2_A272MovimientoLinea ;
      private decimal[] T001F2_A273MovimientoCantidad ;
      private decimal[] T001F2_A274MovimientoCosto ;
      private String[] T001F2_A41ClinicaCodigo ;
      private String[] T001F2_A30ArticuloCodigo ;
      private String[] T001F28_A41ClinicaCodigo ;
      private String[] T001F28_A114TipoMICodigo ;
      private int[] T001F28_A267MovimientoId ;
      private short[] T001F28_A272MovimientoLinea ;
      private String[] T001F29_A41ClinicaCodigo ;
      private String[] T001F30_A41ClinicaCodigo ;
      private String[] T001F31_A4UsuarioCodigo ;
      private String[] T001F32_A41ClinicaCodigo ;
      private int[] T001F5_A267MovimientoId ;
      private DateTime[] T001F5_A268MovimientoFecha ;
      private String[] T001F5_A288MovimientoHora ;
      private String[] T001F5_A269MovimientoReferencia ;
      private String[] T001F5_A270MovimientoObs ;
      private short[] T001F5_A271MovimientoEstado ;
      private String[] T001F5_A41ClinicaCodigo ;
      private String[] T001F5_A114TipoMICodigo ;
      private String[] T001F5_A121BodegaCodigo ;
      private String[] T001F5_A4UsuarioCodigo ;
      private GXWebForm Form ;
   }

   public class movimientoinv__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001F5 ;
          prmT001F5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F10 ;
          prmT001F10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F8 ;
          prmT001F8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F7 ;
          prmT001F7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F9 ;
          prmT001F9 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F11 ;
          prmT001F11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F12 ;
          prmT001F12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F13 ;
          prmT001F13 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F14 ;
          prmT001F14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F6 ;
          prmT001F6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F15 ;
          prmT001F15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F16 ;
          prmT001F16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F17 ;
          prmT001F17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F18 ;
          prmT001F18 = new Object[] {
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovimientoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@MovimientoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@MovimientoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovimientoEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F19 ;
          prmT001F19 = new Object[] {
          new Object[] {"@MovimientoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovimientoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@MovimientoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@MovimientoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovimientoEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F20 ;
          prmT001F20 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F21 ;
          prmT001F21 = new Object[] {
          } ;
          Object[] prmT001F22 ;
          prmT001F22 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001F4 ;
          prmT001F4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F23 ;
          prmT001F23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F24 ;
          prmT001F24 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001F3 ;
          prmT001F3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001F2 ;
          prmT001F2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001F25 ;
          prmT001F25 = new Object[] {
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovimientoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovimientoCosto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F26 ;
          prmT001F26 = new Object[] {
          new Object[] {"@MovimientoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovimientoCosto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001F27 ;
          prmT001F27 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001F28 ;
          prmT001F28 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F29 ;
          prmT001F29 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F30 ;
          prmT001F30 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F31 ;
          prmT001F31 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001F32 ;
          prmT001F32 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001F2", "SELECT [TipoMICodigo], [MovimientoId], [MovimientoLinea], [MovimientoCantidad], [MovimientoCosto], [ClinicaCodigo], [ArticuloCodigo] FROM [MovimientoInvDetalle] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId AND [MovimientoLinea] = @MovimientoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F2,1,0,true,false )
             ,new CursorDef("T001F3", "SELECT [TipoMICodigo], [MovimientoId], [MovimientoLinea], [MovimientoCantidad], [MovimientoCosto], [ClinicaCodigo], [ArticuloCodigo] FROM [MovimientoInvDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId AND [MovimientoLinea] = @MovimientoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F3,1,0,true,false )
             ,new CursorDef("T001F4", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F4,1,0,true,false )
             ,new CursorDef("T001F5", "SELECT [MovimientoId], [MovimientoFecha], [MovimientoHora], [MovimientoReferencia], [MovimientoObs], [MovimientoEstado], [ClinicaCodigo], [TipoMICodigo], [BodegaCodigo], [UsuarioCodigo] FROM [MovimientoInv] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F5,1,0,true,false )
             ,new CursorDef("T001F6", "SELECT [MovimientoId], [MovimientoFecha], [MovimientoHora], [MovimientoReferencia], [MovimientoObs], [MovimientoEstado], [ClinicaCodigo], [TipoMICodigo], [BodegaCodigo], [UsuarioCodigo] FROM [MovimientoInv] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F6,1,0,true,false )
             ,new CursorDef("T001F7", "SELECT [ClinicaCodigo] FROM [TipoMovInventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F7,1,0,true,false )
             ,new CursorDef("T001F8", "SELECT [ClinicaCodigo] FROM [Bodega] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F8,1,0,true,false )
             ,new CursorDef("T001F9", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F9,1,0,true,false )
             ,new CursorDef("T001F10", "SELECT TM1.[MovimientoId], TM1.[MovimientoFecha], TM1.[MovimientoHora], TM1.[MovimientoReferencia], TM1.[MovimientoObs], TM1.[MovimientoEstado], TM1.[ClinicaCodigo], TM1.[TipoMICodigo], TM1.[BodegaCodigo], TM1.[UsuarioCodigo] FROM [MovimientoInv] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[TipoMICodigo] = @TipoMICodigo and TM1.[MovimientoId] = @MovimientoId ORDER BY TM1.[ClinicaCodigo], TM1.[TipoMICodigo], TM1.[MovimientoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F10,100,0,true,false )
             ,new CursorDef("T001F11", "SELECT [ClinicaCodigo] FROM [Bodega] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F11,1,0,true,false )
             ,new CursorDef("T001F12", "SELECT [ClinicaCodigo] FROM [TipoMovInventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F12,1,0,true,false )
             ,new CursorDef("T001F13", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F13,1,0,true,false )
             ,new CursorDef("T001F14", "SELECT [ClinicaCodigo], [TipoMICodigo], [MovimientoId] FROM [MovimientoInv] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F14,1,0,true,false )
             ,new CursorDef("T001F15", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo], [MovimientoId] FROM [MovimientoInv] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] > @TipoMICodigo or [TipoMICodigo] = @TipoMICodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovimientoId] > @MovimientoId) ORDER BY [ClinicaCodigo], [TipoMICodigo], [MovimientoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F15,1,0,true,true )
             ,new CursorDef("T001F16", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo], [MovimientoId] FROM [MovimientoInv] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] < @TipoMICodigo or [TipoMICodigo] = @TipoMICodigo and [ClinicaCodigo] = @ClinicaCodigo and [MovimientoId] < @MovimientoId) ORDER BY [ClinicaCodigo] DESC, [TipoMICodigo] DESC, [MovimientoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F16,1,0,true,true )
             ,new CursorDef("T001F17", "SELECT [MovimientoId], [MovimientoFecha], [MovimientoHora], [MovimientoReferencia], [MovimientoObs], [MovimientoEstado], [ClinicaCodigo], [TipoMICodigo], [BodegaCodigo], [UsuarioCodigo] FROM [MovimientoInv] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F17,1,0,true,false )
             ,new CursorDef("T001F18", "INSERT INTO [MovimientoInv] ([MovimientoId], [MovimientoFecha], [MovimientoHora], [MovimientoReferencia], [MovimientoObs], [MovimientoEstado], [ClinicaCodigo], [TipoMICodigo], [BodegaCodigo], [UsuarioCodigo]) VALUES (@MovimientoId, @MovimientoFecha, @MovimientoHora, @MovimientoReferencia, @MovimientoObs, @MovimientoEstado, @ClinicaCodigo, @TipoMICodigo, @BodegaCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001F18)
             ,new CursorDef("T001F19", "UPDATE [MovimientoInv] SET [MovimientoFecha]=@MovimientoFecha, [MovimientoHora]=@MovimientoHora, [MovimientoReferencia]=@MovimientoReferencia, [MovimientoObs]=@MovimientoObs, [MovimientoEstado]=@MovimientoEstado, [BodegaCodigo]=@BodegaCodigo, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId", GxErrorMask.GX_NOMASK,prmT001F19)
             ,new CursorDef("T001F20", "DELETE FROM [MovimientoInv]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId", GxErrorMask.GX_NOMASK,prmT001F20)
             ,new CursorDef("T001F21", "SELECT [ClinicaCodigo], [TipoMICodigo], [MovimientoId] FROM [MovimientoInv] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [TipoMICodigo], [MovimientoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F21,100,0,true,false )
             ,new CursorDef("T001F22", "SELECT [TipoMICodigo], [MovimientoId], [MovimientoLinea], [MovimientoCantidad], [MovimientoCosto], [ClinicaCodigo], [ArticuloCodigo] FROM [MovimientoInvDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] = @TipoMICodigo and [MovimientoId] = @MovimientoId and [MovimientoLinea] = @MovimientoLinea ORDER BY [ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoLinea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F22,11,0,true,false )
             ,new CursorDef("T001F23", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F23,1,0,true,false )
             ,new CursorDef("T001F24", "SELECT [ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoLinea] FROM [MovimientoInvDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId AND [MovimientoLinea] = @MovimientoLinea ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F24,1,0,true,false )
             ,new CursorDef("T001F25", "INSERT INTO [MovimientoInvDetalle] ([TipoMICodigo], [MovimientoId], [MovimientoLinea], [MovimientoCantidad], [MovimientoCosto], [ClinicaCodigo], [ArticuloCodigo]) VALUES (@TipoMICodigo, @MovimientoId, @MovimientoLinea, @MovimientoCantidad, @MovimientoCosto, @ClinicaCodigo, @ArticuloCodigo)", GxErrorMask.GX_NOMASK,prmT001F25)
             ,new CursorDef("T001F26", "UPDATE [MovimientoInvDetalle] SET [MovimientoCantidad]=@MovimientoCantidad, [MovimientoCosto]=@MovimientoCosto, [ArticuloCodigo]=@ArticuloCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId AND [MovimientoLinea] = @MovimientoLinea", GxErrorMask.GX_NOMASK,prmT001F26)
             ,new CursorDef("T001F27", "DELETE FROM [MovimientoInvDetalle]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId AND [MovimientoLinea] = @MovimientoLinea", GxErrorMask.GX_NOMASK,prmT001F27)
             ,new CursorDef("T001F28", "SELECT [ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoLinea] FROM [MovimientoInvDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] = @TipoMICodigo and [MovimientoId] = @MovimientoId ORDER BY [ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoLinea] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F28,11,0,true,false )
             ,new CursorDef("T001F29", "SELECT [ClinicaCodigo] FROM [TipoMovInventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F29,1,0,true,false )
             ,new CursorDef("T001F30", "SELECT [ClinicaCodigo] FROM [Bodega] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F30,1,0,true,false )
             ,new CursorDef("T001F31", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F31,1,0,true,false )
             ,new CursorDef("T001F32", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F32,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 29 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 30 :
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
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
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
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                break;
             case 17 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (int)parms[9]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 24 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 26 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 27 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 28 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 29 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 30 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
