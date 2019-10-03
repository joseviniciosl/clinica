/*
               File: Factura
        Description: Factura a Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:5.13
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
   public class factura : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_6( A41ClinicaCodigo, A91ConsultaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A132CajaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A41ClinicaCodigo, A132CajaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A178ClienteCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A41ClinicaCodigo, A178ClienteCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_10( A41ClinicaCodigo, A185FacturaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_11( A41ClinicaCodigo, A185FacturaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A4UsuarioCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_9( A4UsuarioCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_13") == 0 )
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
            gxLoad_13( A41ClinicaCodigo, A30ArticuloCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridfactura_facturadetalle") == 0 )
         {
            nRC_Gridfactura_facturadetalle = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_130_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_130_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridfactura_facturadetalle_newrow( nRC_Gridfactura_facturadetalle, nGXsfl_130_idx, sGXsfl_130_idx) ;
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
         cmbFacturaEstado.Name = "FACTURAESTADO" ;
         cmbFacturaEstado.WebTags = "" ;
         cmbFacturaEstado.addItem("0", "Creado", 0);
         cmbFacturaEstado.addItem("1", "Facturado", 0);
         cmbFacturaEstado.addItem("2", "Anulado", 0);
         cmbFacturaEstado.addItem("3", "Cancelado", 0);
         if ( ( cmbFacturaEstado.ItemCount > 0 ) && (0==A188FacturaEstado) )
         {
            A188FacturaEstado = (short)(NumberUtil.Val( cmbFacturaEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188FacturaEstado", StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Factura a Pacientes", 0) ;
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

      public factura( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public factura( IGxContext context )
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
         cmbFacturaEstado = new GXCombobox();
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
            wb_table1_2_1249( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1249e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1249( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1249( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1249e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Factura a Pacientes"+"</legend>") ;
            wb_table3_27_1249( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1249e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1249e( true) ;
         }
         else
         {
            wb_table1_2_1249e( false) ;
         }
      }

      protected void wb_table3_27_1249( bool wbgen )
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
            wb_table4_33_1249( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1249e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1249e( true) ;
         }
         else
         {
            wb_table3_27_1249e( false) ;
         }
      }

      protected void wb_table4_33_1249( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturaid_Internalname, "Factura", "", "", lblTextblockfacturaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A185FacturaId), 9, 0, ".", "")), ((edtFacturaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A185FacturaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A185FacturaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtFacturaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturafecha_Internalname, "Fecha", "", "", lblTextblockfacturafecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186FacturaFecha", context.localUtil.Format(A186FacturaFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtFacturaFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtFacturaFecha_Internalname, context.localUtil.Format(A186FacturaFecha, "99/99/99"), context.localUtil.Format( A186FacturaFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(48);\"", "", "", "", "", edtFacturaFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            GxWebStd.gx_bitmap( context, edtFacturaFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtFacturaFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Factura.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturahora_Internalname, "Hora", "", "", lblTextblockfacturahora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187FacturaHora", A187FacturaHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaHora_Internalname, StringUtil.RTrim( A187FacturaHora), StringUtil.RTrim( context.localUtil.Format( A187FacturaHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtFacturaHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaHora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturaestado_Internalname, "Estado", "", "", lblTextblockfacturaestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188FacturaEstado", StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbFacturaEstado, cmbFacturaEstado_Internalname, StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0), 1, cmbFacturaEstado_Jsonclick, 0, "", "int", "", 1, cmbFacturaEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", true, "HLP_Factura.htm");
            cmbFacturaEstado.CurrentValue = StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbFacturaEstado_Internalname, "Values", (String)(cmbFacturaEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclientecodigo_Internalname, "Cliente", "", "", lblTextblockclientecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClienteCodigo_Internalname, StringUtil.RTrim( A178ClienteCodigo), StringUtil.RTrim( context.localUtil.Format( A178ClienteCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtClienteCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClienteCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Factura.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_178_Internalname, "prompt.gif", imgprompt_41_178_Link, "", "", "Fantastic", imgprompt_41_178_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturadocto_Internalname, "Documento", "", "", lblTextblockfacturadocto_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189FacturaDocto", StringUtil.LTrim( StringUtil.Str( (decimal)(A189FacturaDocto), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaDocto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A189FacturaDocto), 9, 0, ".", "")), ((edtFacturaDocto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A189FacturaDocto), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A189FacturaDocto), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(68);\"", "", "", "", "", edtFacturaDocto_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaDocto_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturaserie_Internalname, "Serie", "", "", lblTextblockfacturaserie_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190FacturaSerie", A190FacturaSerie);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaSerie_Internalname, StringUtil.RTrim( A190FacturaSerie), StringUtil.RTrim( context.localUtil.Format( A190FacturaSerie, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", "", "", "", edtFacturaSerie_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaSerie_Enabled, 0, 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, true, "left", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturaiva_Internalname, "IVA", "", "", lblTextblockfacturaiva_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A191FacturaIva", StringUtil.LTrim( StringUtil.Str( A191FacturaIva, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaIva_Internalname, StringUtil.LTrim( StringUtil.NToC( A191FacturaIva, 17, 2, ".", "")), ((edtFacturaIva_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A191FacturaIva, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A191FacturaIva, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(78);\"", "", "", "", "", edtFacturaIva_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaIva_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturatotal_Internalname, "Total", "", "", lblTextblockfacturatotal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A247FacturaTotal, 17, 2, ".", "")), ((edtFacturaTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A247FacturaTotal, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A247FacturaTotal, "ZZZZZZZZZZZZZ9.99")), "", "", "", "", "", edtFacturaTotal_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaTotal_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturapago_Internalname, "Pago", "", "", lblTextblockfacturapago_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtFacturaPago_Internalname, StringUtil.LTrim( StringUtil.NToC( A263FacturaPago, 17, 2, ".", "")), ((edtFacturaPago_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A263FacturaPago, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A263FacturaPago, "ZZZZZZZZZZZZZ9.99")), "", "", "", "", "", edtFacturaPago_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaPago_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturacae1_Internalname, "Firma_1", "", "", lblTextblockfacturacae1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192FacturaCae1", A192FacturaCae1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtFacturaCae1_Internalname, StringUtil.RTrim( A192FacturaCae1), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(93);\"", 0, 1, edtFacturaCae1_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "1000", -1, "", true, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturacae2_Internalname, "Firma_2", "", "", lblTextblockfacturacae2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229FacturaCae2", A229FacturaCae2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtFacturaCae2_Internalname, StringUtil.RTrim( A229FacturaCae2), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(98);\"", 0, 1, edtFacturaCae2_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "1000", -1, "", true, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultaid_Internalname, "Consulta", "", "", lblTextblockconsultaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtConsultaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")), ((edtConsultaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(103);\"", "", "", "", "", edtConsultaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_91_Internalname, "prompt.gif", imgprompt_41_91_Link, "", "", "Fantastic", imgprompt_41_91_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcajacodigo_Internalname, "Caja", "", "", lblTextblockcajacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCajaCodigo_Internalname, StringUtil.RTrim( A132CajaCodigo), StringUtil.RTrim( context.localUtil.Format( A132CajaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(108);\"", "", "", "", "", edtCajaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCajaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Factura.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_132_Internalname, "prompt.gif", imgprompt_41_132_Link, "", "", "Fantastic", imgprompt_41_132_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(113);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Factura.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_4_Internalname, "prompt.gif", imgprompt_4_Link, "", "", "Fantastic", imgprompt_4_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfacturafechahora_Internalname, "Hora", "", "", lblTextblockfacturafechahora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280FacturaFechaHora", context.localUtil.TToC( A280FacturaFechaHora, 8, 5, 0, 3, "/", ":", " "));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtFacturaFechaHora_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtFacturaFechaHora_Internalname, context.localUtil.Format(A280FacturaFechaHora, "99/99/99 99:99"), context.localUtil.Format( A280FacturaFechaHora, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(118);\"", "", "", "", "", edtFacturaFechaHora_Jsonclick, 0, ClassString, StyleString, "", 1, edtFacturaFechaHora_Enabled, 0, 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            GxWebStd.gx_bitmap( context, edtFacturaFechaHora_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtFacturaFechaHora_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Factura.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcortecajaidf_Internalname, "Caja", "", "", lblTextblockcortecajaidf_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281CorteCajaIdF", StringUtil.LTrim( StringUtil.Str( (decimal)(A281CorteCajaIdF), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCorteCajaIdF_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A281CorteCajaIdF), 9, 0, ".", "")), ((edtCorteCajaIdF_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A281CorteCajaIdF), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A281CorteCajaIdF), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(123);\"", "", "", "", "", edtCorteCajaIdF_Jsonclick, 0, ClassString, StyleString, "", 1, edtCorteCajaIdF_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_126_1249( true) ;
         }
         return  ;
      }

      protected void wb_table5_126_1249e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridfactura_facturadetalleContainer.AddObjectProperty("GridName", "Gridfactura_facturadetalle");
            Gridfactura_facturadetalleContainer.AddObjectProperty("Class", "Grid");
            Gridfactura_facturadetalleContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridfactura_facturadetalleContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridfactura_facturadetalleContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_facturadetalle_Backcolorstyle), 1, 0, ".", "")));
            Gridfactura_facturadetalleContainer.AddObjectProperty("CmpContext", "");
            Gridfactura_facturadetalleContainer.AddObjectProperty("InMasterPage", "false");
            Gridfactura_facturadetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridfactura_facturadetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", "")));
            Gridfactura_facturadetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDId_Enabled), 5, 0, ".", "")));
            Gridfactura_facturadetalleContainer.AddColumnProperties(Gridfactura_facturadetalleColumn);
            Gridfactura_facturadetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridfactura_facturadetalleColumn.AddObjectProperty("Value", StringUtil.RTrim( A30ArticuloCodigo));
            Gridfactura_facturadetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", "")));
            Gridfactura_facturadetalleContainer.AddColumnProperties(Gridfactura_facturadetalleColumn);
            Gridfactura_facturadetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridfactura_facturadetalleContainer.AddColumnProperties(Gridfactura_facturadetalleColumn);
            Gridfactura_facturadetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridfactura_facturadetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A249FacturaDPrecio, 17, 2, ".", "")));
            Gridfactura_facturadetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDPrecio_Enabled), 5, 0, ".", "")));
            Gridfactura_facturadetalleContainer.AddColumnProperties(Gridfactura_facturadetalleColumn);
            Gridfactura_facturadetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridfactura_facturadetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A250FacturaDCantidad, 17, 2, ".", "")));
            Gridfactura_facturadetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDCantidad_Enabled), 5, 0, ".", "")));
            Gridfactura_facturadetalleContainer.AddColumnProperties(Gridfactura_facturadetalleColumn);
            Gridfactura_facturadetalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridfactura_facturadetalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A251FacturaDTotal, 17, 2, ".", "")));
            Gridfactura_facturadetalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDTotal_Enabled), 5, 0, ".", "")));
            Gridfactura_facturadetalleContainer.AddColumnProperties(Gridfactura_facturadetalleColumn);
            Gridfactura_facturadetalleContainer.AddObjectProperty("Allowselection", "false");
            Gridfactura_facturadetalleContainer.AddObjectProperty("Allowcollapsing", ((subGridfactura_facturadetalle_Allowcollapsing==1) ? "true" : "false"));
            Gridfactura_facturadetalleContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridfactura_facturadetalle_Collapsed), 9, 0, ".", "")));
            nGXsfl_130_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount60 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_60 = 1 ;
                  ScanStart1260( ) ;
                  while ( RcdFound60 != 0 )
                  {
                     init_level_properties60( ) ;
                     getByPrimaryKey1260( ) ;
                     AddRow1260( ) ;
                     ScanNext1260( ) ;
                  }
                  ScanEnd1260( ) ;
                  nBlankRcdCount60 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               B247FacturaTotal = A247FacturaTotal ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
               standaloneNotModal1260( ) ;
               standaloneModal1260( ) ;
               sMode60 = Gx_mode ;
               while ( nGXsfl_130_idx < nRC_Gridfactura_facturadetalle )
               {
                  ReadRow1260( ) ;
                  edtFacturaDId_Enabled = (int)(context.localUtil.CToN( cgiGet( "FACTURADID_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
                  edtArticuloCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOCODIGO_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
                  edtFacturaDPrecio_Enabled = (int)(context.localUtil.CToN( cgiGet( "FACTURADPRECIO_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
                  edtFacturaDCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "FACTURADCANTIDAD_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
                  edtFacturaDTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "FACTURADTOTAL_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
                  imgprompt_41_178_Link = cgiGet( "PROMPT_30_"+sGXsfl_130_idx+"Link") ;
                  if ( ( nRcdExists_60 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal1260( ) ;
                  }
                  SendRow1260( ) ;
               }
               Gx_mode = sMode60 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               A247FacturaTotal = B247FacturaTotal ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount60 = 5 ;
               nRcdExists_60 = 1 ;
               ScanStart1260( ) ;
               while ( RcdFound60 != 0 )
               {
                  init_level_properties60( ) ;
                  getByPrimaryKey1260( ) ;
                  standaloneNotModal1260( ) ;
                  standaloneModal1260( ) ;
                  AddRow1260( ) ;
                  ScanNext1260( ) ;
               }
               ScanEnd1260( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode60 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll1260( ) ;
            init_level_properties60( ) ;
            B247FacturaTotal = A247FacturaTotal ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            standaloneNotModal1260( ) ;
            standaloneModal1260( ) ;
            nRcdExists_60 = 0 ;
            nIsMod_60 = 0 ;
            nBlankRcdCount60 = (short)(nBlankRcdUsr60+nBlankRcdCount60) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount60 > 0 )
            {
               AddRow1260( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtFacturaDId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount60 = (short)(nBlankRcdCount60-1) ;
            }
            Gx_mode = sMode60 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            A247FacturaTotal = B247FacturaTotal ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridfactura_facturadetalleContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridfactura_facturadetalle", (Object)(Gridfactura_facturadetalleContainer));
            GxWebStd.gx_hidden_field( context, "Gridfactura_facturadetalleContainerData", Gridfactura_facturadetalleContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridfactura_facturadetalleContainerData"+"V", Gridfactura_facturadetalleContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridfactura_facturadetalleContainerData"+"V"+"\" value='"+Gridfactura_facturadetalleContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1249e( true) ;
         }
         else
         {
            wb_table4_33_1249e( false) ;
         }
      }

      protected void wb_table5_126_1249( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlefacturadetalle_Internalname, "Detalle de Factura a Pacientes", "", "", lblTitlefacturadetalle_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_126_1249e( true) ;
         }
         else
         {
            wb_table5_126_1249e( false) ;
         }
      }

      protected void wb_table2_5_1249( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"FACTURAID"+"'), id:'"+"FACTURAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"FACTURAID"+"'), id:'"+"FACTURAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Factura.htm");
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
            wb_table2_5_1249e( true) ;
         }
         else
         {
            wb_table2_5_1249e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtFacturaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A185FacturaId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               }
               else
               {
                  A185FacturaId = (int)(context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtFacturaFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "FACTURAFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtFacturaFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A186FacturaFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186FacturaFecha", context.localUtil.Format(A186FacturaFecha, "99/99/99"));
               }
               else
               {
                  A186FacturaFecha = context.localUtil.CToD( cgiGet( edtFacturaFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186FacturaFecha", context.localUtil.Format(A186FacturaFecha, "99/99/99"));
               }
               A187FacturaHora = cgiGet( edtFacturaHora_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187FacturaHora", A187FacturaHora);
               cmbFacturaEstado.Name = cmbFacturaEstado_Internalname ;
               cmbFacturaEstado.CurrentValue = cgiGet( cmbFacturaEstado_Internalname) ;
               A188FacturaEstado = (short)(NumberUtil.Val( cgiGet( cmbFacturaEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188FacturaEstado", StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0));
               A178ClienteCodigo = cgiGet( edtClienteCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaDocto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaDocto_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURADOCTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtFacturaDocto_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A189FacturaDocto = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189FacturaDocto", StringUtil.LTrim( StringUtil.Str( (decimal)(A189FacturaDocto), 9, 0)));
               }
               else
               {
                  A189FacturaDocto = (int)(context.localUtil.CToN( cgiGet( edtFacturaDocto_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189FacturaDocto", StringUtil.LTrim( StringUtil.Str( (decimal)(A189FacturaDocto), 9, 0)));
               }
               A190FacturaSerie = cgiGet( edtFacturaSerie_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190FacturaSerie", A190FacturaSerie);
               if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaIva_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaIva_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURAIVA");
                  AnyError = 1 ;
                  GX_FocusControl = edtFacturaIva_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A191FacturaIva = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A191FacturaIva", StringUtil.LTrim( StringUtil.Str( A191FacturaIva, 17, 2)));
               }
               else
               {
                  A191FacturaIva = context.localUtil.CToN( cgiGet( edtFacturaIva_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A191FacturaIva", StringUtil.LTrim( StringUtil.Str( A191FacturaIva, 17, 2)));
               }
               A247FacturaTotal = context.localUtil.CToN( cgiGet( edtFacturaTotal_Internalname), ".", ",") ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
               A263FacturaPago = context.localUtil.CToN( cgiGet( edtFacturaPago_Internalname), ".", ",") ;
               n263FacturaPago = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
               A192FacturaCae1 = cgiGet( edtFacturaCae1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192FacturaCae1", A192FacturaCae1);
               A229FacturaCae2 = cgiGet( edtFacturaCae2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229FacturaCae2", A229FacturaCae2);
               if ( ( ( context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CONSULTAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtConsultaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A91ConsultaId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               }
               else
               {
                  A91ConsultaId = (int)(context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               }
               A132CajaCodigo = cgiGet( edtCajaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               if ( context.localUtil.VCDateTime( cgiGet( edtFacturaFechaHora_Internalname), 2, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"FechaHora"}), 1, "FACTURAFECHAHORA");
                  AnyError = 1 ;
                  GX_FocusControl = edtFacturaFechaHora_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A280FacturaFechaHora = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280FacturaFechaHora", context.localUtil.TToC( A280FacturaFechaHora, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A280FacturaFechaHora = context.localUtil.CToT( cgiGet( edtFacturaFechaHora_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280FacturaFechaHora", context.localUtil.TToC( A280FacturaFechaHora, 8, 5, 0, 3, "/", ":", " "));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCorteCajaIdF_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCorteCajaIdF_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CORTECAJAIDF");
                  AnyError = 1 ;
                  GX_FocusControl = edtCorteCajaIdF_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A281CorteCajaIdF = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281CorteCajaIdF", StringUtil.LTrim( StringUtil.Str( (decimal)(A281CorteCajaIdF), 9, 0)));
               }
               else
               {
                  A281CorteCajaIdF = (int)(context.localUtil.CToN( cgiGet( edtCorteCajaIdF_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281CorteCajaIdF", StringUtil.LTrim( StringUtil.Str( (decimal)(A281CorteCajaIdF), 9, 0)));
               }
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z185FacturaId = (int)(context.localUtil.CToN( cgiGet( "Z185FacturaId"), ".", ",")) ;
               Z186FacturaFecha = context.localUtil.CToD( cgiGet( "Z186FacturaFecha"), 0) ;
               Z187FacturaHora = cgiGet( "Z187FacturaHora") ;
               Z188FacturaEstado = (short)(context.localUtil.CToN( cgiGet( "Z188FacturaEstado"), ".", ",")) ;
               Z189FacturaDocto = (int)(context.localUtil.CToN( cgiGet( "Z189FacturaDocto"), ".", ",")) ;
               Z190FacturaSerie = cgiGet( "Z190FacturaSerie") ;
               Z191FacturaIva = context.localUtil.CToN( cgiGet( "Z191FacturaIva"), ".", ",") ;
               Z192FacturaCae1 = cgiGet( "Z192FacturaCae1") ;
               Z229FacturaCae2 = cgiGet( "Z229FacturaCae2") ;
               Z280FacturaFechaHora = context.localUtil.CToT( cgiGet( "Z280FacturaFechaHora"), 0) ;
               Z281CorteCajaIdF = (int)(context.localUtil.CToN( cgiGet( "Z281CorteCajaIdF"), ".", ",")) ;
               Z91ConsultaId = (int)(context.localUtil.CToN( cgiGet( "Z91ConsultaId"), ".", ",")) ;
               Z132CajaCodigo = cgiGet( "Z132CajaCodigo") ;
               Z178ClienteCodigo = cgiGet( "Z178ClienteCodigo") ;
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
               O247FacturaTotal = context.localUtil.CToN( cgiGet( "O247FacturaTotal"), ".", ",") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridfactura_facturadetalle = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridfactura_facturadetalle"), ".", ",")) ;
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
                  A185FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
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
               InitAll1249( ) ;
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
         DisableAttributes1249( ) ;
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

      protected void CONFIRM_1260( )
      {
         s247FacturaTotal = O247FacturaTotal ;
         n247FacturaTotal = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         nGXsfl_130_idx = 0 ;
         while ( nGXsfl_130_idx < nRC_Gridfactura_facturadetalle )
         {
            ReadRow1260( ) ;
            if ( ( nRcdExists_60 != 0 ) || ( nIsMod_60 != 0 ) )
            {
               GetKey1260( ) ;
               if ( ( nRcdExists_60 == 0 ) && ( nRcdDeleted_60 == 0 ) )
               {
                  if ( RcdFound60 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate1260( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1260( ) ;
                        CloseExtendedTableCursors1260( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1 ;
                        }
                        O247FacturaTotal = A247FacturaTotal ;
                        n247FacturaTotal = false ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtFacturaDId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound60 != 0 )
                  {
                     if ( nRcdDeleted_60 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey1260( ) ;
                        Load1260( ) ;
                        BeforeValidate1260( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1260( ) ;
                           O247FacturaTotal = A247FacturaTotal ;
                           n247FacturaTotal = false ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_60 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate1260( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1260( ) ;
                              CloseExtendedTableCursors1260( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1 ;
                              }
                              O247FacturaTotal = A247FacturaTotal ;
                              n247FacturaTotal = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_60 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtFacturaDId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtFacturaDId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", ""))) ;
            ChangePostValue( edtArticuloCodigo_Internalname, StringUtil.RTrim( A30ArticuloCodigo)) ;
            ChangePostValue( edtFacturaDPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A249FacturaDPrecio, 17, 2, ".", ""))) ;
            ChangePostValue( edtFacturaDCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A250FacturaDCantidad, 17, 2, ".", ""))) ;
            ChangePostValue( edtFacturaDTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A251FacturaDTotal, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z248FacturaDId_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z248FacturaDId), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z249FacturaDPrecio_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( Z249FacturaDPrecio, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z250FacturaDCantidad_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( Z250FacturaDCantidad, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z30ArticuloCodigo_"+sGXsfl_130_idx, StringUtil.RTrim( Z30ArticuloCodigo)) ;
            ChangePostValue( "T251FacturaDTotal_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( O251FacturaDTotal, 17, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_60_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_60), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_60_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_60), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_60_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_60), 4, 0, ".", ""))) ;
            if ( nIsMod_60 != 0 )
            {
               ChangePostValue( "FACTURADID_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOCODIGO_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FACTURADPRECIO_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDPrecio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FACTURADCANTIDAD_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FACTURADTOTAL_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O247FacturaTotal = s247FacturaTotal ;
         n247FacturaTotal = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption120( )
      {
      }

      protected void ZM1249( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z186FacturaFecha = T00126_A186FacturaFecha[0] ;
               Z187FacturaHora = T00126_A187FacturaHora[0] ;
               Z188FacturaEstado = T00126_A188FacturaEstado[0] ;
               Z189FacturaDocto = T00126_A189FacturaDocto[0] ;
               Z190FacturaSerie = T00126_A190FacturaSerie[0] ;
               Z191FacturaIva = T00126_A191FacturaIva[0] ;
               Z192FacturaCae1 = T00126_A192FacturaCae1[0] ;
               Z229FacturaCae2 = T00126_A229FacturaCae2[0] ;
               Z280FacturaFechaHora = T00126_A280FacturaFechaHora[0] ;
               Z281CorteCajaIdF = T00126_A281CorteCajaIdF[0] ;
               Z91ConsultaId = T00126_A91ConsultaId[0] ;
               Z132CajaCodigo = T00126_A132CajaCodigo[0] ;
               Z178ClienteCodigo = T00126_A178ClienteCodigo[0] ;
               Z4UsuarioCodigo = T00126_A4UsuarioCodigo[0] ;
            }
            else
            {
               Z186FacturaFecha = A186FacturaFecha ;
               Z187FacturaHora = A187FacturaHora ;
               Z188FacturaEstado = A188FacturaEstado ;
               Z189FacturaDocto = A189FacturaDocto ;
               Z190FacturaSerie = A190FacturaSerie ;
               Z191FacturaIva = A191FacturaIva ;
               Z192FacturaCae1 = A192FacturaCae1 ;
               Z229FacturaCae2 = A229FacturaCae2 ;
               Z280FacturaFechaHora = A280FacturaFechaHora ;
               Z281CorteCajaIdF = A281CorteCajaIdF ;
               Z91ConsultaId = A91ConsultaId ;
               Z132CajaCodigo = A132CajaCodigo ;
               Z178ClienteCodigo = A178ClienteCodigo ;
               Z4UsuarioCodigo = A4UsuarioCodigo ;
            }
         }
         if ( GX_JID == -5 )
         {
            Z185FacturaId = A185FacturaId ;
            Z186FacturaFecha = A186FacturaFecha ;
            Z187FacturaHora = A187FacturaHora ;
            Z188FacturaEstado = A188FacturaEstado ;
            Z189FacturaDocto = A189FacturaDocto ;
            Z190FacturaSerie = A190FacturaSerie ;
            Z191FacturaIva = A191FacturaIva ;
            Z192FacturaCae1 = A192FacturaCae1 ;
            Z229FacturaCae2 = A229FacturaCae2 ;
            Z280FacturaFechaHora = A280FacturaFechaHora ;
            Z281CorteCajaIdF = A281CorteCajaIdF ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z91ConsultaId = A91ConsultaId ;
            Z132CajaCodigo = A132CajaCodigo ;
            Z178ClienteCodigo = A178ClienteCodigo ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
            Z247FacturaTotal = A247FacturaTotal ;
            Z263FacturaPago = A263FacturaPago ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_178_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx01c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CLIENTECODIGO"+"'), id:'"+"CLIENTECODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_91_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_41_132_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0100.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CAJACODIGO"+"'), id:'"+"CAJACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load1249( )
      {
         /* Using cursor T001217 */
         pr_default.execute(11, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound49 = 1 ;
            A186FacturaFecha = T001217_A186FacturaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186FacturaFecha", context.localUtil.Format(A186FacturaFecha, "99/99/99"));
            A187FacturaHora = T001217_A187FacturaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187FacturaHora", A187FacturaHora);
            A188FacturaEstado = T001217_A188FacturaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188FacturaEstado", StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0));
            A189FacturaDocto = T001217_A189FacturaDocto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189FacturaDocto", StringUtil.LTrim( StringUtil.Str( (decimal)(A189FacturaDocto), 9, 0)));
            A190FacturaSerie = T001217_A190FacturaSerie[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190FacturaSerie", A190FacturaSerie);
            A191FacturaIva = T001217_A191FacturaIva[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A191FacturaIva", StringUtil.LTrim( StringUtil.Str( A191FacturaIva, 17, 2)));
            A192FacturaCae1 = T001217_A192FacturaCae1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192FacturaCae1", A192FacturaCae1);
            A229FacturaCae2 = T001217_A229FacturaCae2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229FacturaCae2", A229FacturaCae2);
            A280FacturaFechaHora = T001217_A280FacturaFechaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280FacturaFechaHora", context.localUtil.TToC( A280FacturaFechaHora, 8, 5, 0, 3, "/", ":", " "));
            A281CorteCajaIdF = T001217_A281CorteCajaIdF[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281CorteCajaIdF", StringUtil.LTrim( StringUtil.Str( (decimal)(A281CorteCajaIdF), 9, 0)));
            A91ConsultaId = T001217_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A132CajaCodigo = T001217_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            A178ClienteCodigo = T001217_A178ClienteCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
            A4UsuarioCodigo = T001217_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            A247FacturaTotal = T001217_A247FacturaTotal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            n247FacturaTotal = T001217_n247FacturaTotal[0] ;
            A263FacturaPago = T001217_A263FacturaPago[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
            n263FacturaPago = T001217_n263FacturaPago[0] ;
            ZM1249( -5) ;
         }
         pr_default.close(11);
         OnLoadActions1249( ) ;
      }

      protected void OnLoadActions1249( )
      {
         O247FacturaTotal = A247FacturaTotal ;
         n247FacturaTotal = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
      }

      protected void CheckExtendedTable1249( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00127 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError41 = 1 ;
            AnyError91 = 1 ;
            GX_msglist.addItem("No existe 'Consulta de pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError91 == 0 ) )
         {
         }
         pr_default.close(5);
         /* Using cursor T00128 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            AnyError132 = 1 ;
            GX_msglist.addItem("No existe 'Cajas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError132 == 0 ) )
         {
         }
         pr_default.close(6);
         /* Using cursor T00129 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         if ( (pr_default.getStatus(7) == 101) )
         {
            AnyError41 = 1 ;
            AnyError178 = 1 ;
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError178 == 0 ) )
         {
         }
         pr_default.close(7);
         /* Using cursor T001212 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            A247FacturaTotal = T001212_A247FacturaTotal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            n247FacturaTotal = T001212_n247FacturaTotal[0] ;
         }
         else
         {
            A247FacturaTotal = 0 ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         }
         pr_default.close(9);
         /* Using cursor T001214 */
         pr_default.execute(10, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            A263FacturaPago = T001214_A263FacturaPago[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
            n263FacturaPago = T001214_n263FacturaPago[0] ;
         }
         else
         {
            A263FacturaPago = 0 ;
            n263FacturaPago = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
         }
         pr_default.close(10);
         if ( ! ( (DateTime.MinValue==A186FacturaFecha) || ( A186FacturaFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T001210 */
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
         pr_default.close(8);
         if ( ! ( (DateTime.MinValue==A280FacturaFechaHora) || ( A280FacturaFechaHora >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo FechaHora fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1249( )
      {
         pr_default.close(5);
         pr_default.close(6);
         pr_default.close(7);
         pr_default.close(9);
         pr_default.close(10);
         pr_default.close(8);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_6( String A41ClinicaCodigo ,
                               int A91ConsultaId )
      {
         /* Using cursor T001218 */
         pr_default.execute(12, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            AnyError41 = 1 ;
            AnyError91 = 1 ;
            GX_msglist.addItem("No existe 'Consulta de pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError91 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(12);
      }

      protected void gxLoad_7( String A41ClinicaCodigo ,
                               String A132CajaCodigo )
      {
         /* Using cursor T001219 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(13) == 101) )
         {
            AnyError41 = 1 ;
            AnyError132 = 1 ;
            GX_msglist.addItem("No existe 'Cajas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError132 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(13) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(13);
      }

      protected void gxLoad_8( String A41ClinicaCodigo ,
                               String A178ClienteCodigo )
      {
         /* Using cursor T001220 */
         pr_default.execute(14, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         if ( (pr_default.getStatus(14) == 101) )
         {
            AnyError41 = 1 ;
            AnyError178 = 1 ;
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError178 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(14) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(14);
      }

      protected void gxLoad_10( String A41ClinicaCodigo ,
                                int A185FacturaId )
      {
         /* Using cursor T001222 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            A247FacturaTotal = T001222_A247FacturaTotal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            n247FacturaTotal = T001222_n247FacturaTotal[0] ;
         }
         else
         {
            A247FacturaTotal = 0 ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A247FacturaTotal, 17, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(15) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(15);
      }

      protected void gxLoad_11( String A41ClinicaCodigo ,
                                int A185FacturaId )
      {
         /* Using cursor T001224 */
         pr_default.execute(16, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            A263FacturaPago = T001224_A263FacturaPago[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
            n263FacturaPago = T001224_n263FacturaPago[0] ;
         }
         else
         {
            A263FacturaPago = 0 ;
            n263FacturaPago = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A263FacturaPago, 17, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(16) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(16);
      }

      protected void gxLoad_9( String A4UsuarioCodigo )
      {
         /* Using cursor T001225 */
         pr_default.execute(17, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(17) == 101) )
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
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(17);
      }

      protected void GetKey1249( )
      {
         /* Using cursor T001226 */
         pr_default.execute(18, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound49 = 1 ;
         }
         else
         {
            RcdFound49 = 0 ;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00126 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM1249( 5) ;
            RcdFound49 = 1 ;
            A185FacturaId = T00126_A185FacturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            A186FacturaFecha = T00126_A186FacturaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186FacturaFecha", context.localUtil.Format(A186FacturaFecha, "99/99/99"));
            A187FacturaHora = T00126_A187FacturaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187FacturaHora", A187FacturaHora);
            A188FacturaEstado = T00126_A188FacturaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188FacturaEstado", StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0));
            A189FacturaDocto = T00126_A189FacturaDocto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189FacturaDocto", StringUtil.LTrim( StringUtil.Str( (decimal)(A189FacturaDocto), 9, 0)));
            A190FacturaSerie = T00126_A190FacturaSerie[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190FacturaSerie", A190FacturaSerie);
            A191FacturaIva = T00126_A191FacturaIva[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A191FacturaIva", StringUtil.LTrim( StringUtil.Str( A191FacturaIva, 17, 2)));
            A192FacturaCae1 = T00126_A192FacturaCae1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192FacturaCae1", A192FacturaCae1);
            A229FacturaCae2 = T00126_A229FacturaCae2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229FacturaCae2", A229FacturaCae2);
            A280FacturaFechaHora = T00126_A280FacturaFechaHora[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280FacturaFechaHora", context.localUtil.TToC( A280FacturaFechaHora, 8, 5, 0, 3, "/", ":", " "));
            A281CorteCajaIdF = T00126_A281CorteCajaIdF[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281CorteCajaIdF", StringUtil.LTrim( StringUtil.Str( (decimal)(A281CorteCajaIdF), 9, 0)));
            A41ClinicaCodigo = T00126_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = T00126_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A132CajaCodigo = T00126_A132CajaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
            A178ClienteCodigo = T00126_A178ClienteCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
            A4UsuarioCodigo = T00126_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z185FacturaId = A185FacturaId ;
            sMode49 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1249( ) ;
            Gx_mode = sMode49 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound49 = 0 ;
            InitializeNonKey1249( ) ;
            sMode49 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode49 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey1249( ) ;
         if ( RcdFound49 == 0 )
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
         RcdFound49 = 0 ;
         /* Using cursor T001227 */
         pr_default.execute(19, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(19) != 101) )
         {
            while ( (pr_default.getStatus(19) != 101) && ( ( StringUtil.StrCmp(T001227_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001227_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001227_A185FacturaId[0] < A185FacturaId ) ) )
            {
               pr_default.readNext(19);
            }
            if ( (pr_default.getStatus(19) != 101) && ( ( StringUtil.StrCmp(T001227_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001227_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001227_A185FacturaId[0] > A185FacturaId ) ) )
            {
               A41ClinicaCodigo = T001227_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A185FacturaId = T001227_A185FacturaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               RcdFound49 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound49 = 0 ;
         /* Using cursor T001228 */
         pr_default.execute(20, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(20) != 101) )
         {
            while ( (pr_default.getStatus(20) != 101) && ( ( StringUtil.StrCmp(T001228_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001228_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001228_A185FacturaId[0] > A185FacturaId ) ) )
            {
               pr_default.readNext(20);
            }
            if ( (pr_default.getStatus(20) != 101) && ( ( StringUtil.StrCmp(T001228_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001228_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001228_A185FacturaId[0] < A185FacturaId ) ) )
            {
               A41ClinicaCodigo = T001228_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A185FacturaId = T001228_A185FacturaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               RcdFound49 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1249( ) ;
         if ( RcdFound49 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A185FacturaId != Z185FacturaId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A185FacturaId = Z185FacturaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               A247FacturaTotal = O247FacturaTotal ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
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
               A247FacturaTotal = O247FacturaTotal ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
               Update1249( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A185FacturaId != Z185FacturaId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               A247FacturaTotal = O247FacturaTotal ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1249( ) ;
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
                  A247FacturaTotal = O247FacturaTotal ;
                  n247FacturaTotal = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
                  GX_FocusControl = edtClinicaCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1249( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A185FacturaId != Z185FacturaId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = Z185FacturaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A247FacturaTotal = O247FacturaTotal ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
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
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtFacturaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1249( ) ;
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFacturaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1249( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFacturaFecha_Internalname ;
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
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFacturaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1249( ) ;
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound49 != 0 )
            {
               ScanNext1249( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtFacturaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1249( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1249( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001229 */
            pr_default.execute(21, new Object[] {A41ClinicaCodigo, A185FacturaId});
            if ( (pr_default.getStatus(21) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Factura"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(21) == 101) || ( Z186FacturaFecha != T001229_A186FacturaFecha[0] ) || ( StringUtil.StrCmp(Z187FacturaHora, T001229_A187FacturaHora[0]) != 0 ) || ( Z188FacturaEstado != T001229_A188FacturaEstado[0] ) || ( Z189FacturaDocto != T001229_A189FacturaDocto[0] ) || ( StringUtil.StrCmp(Z190FacturaSerie, T001229_A190FacturaSerie[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z191FacturaIva != T001229_A191FacturaIva[0] ) || ( StringUtil.StrCmp(Z192FacturaCae1, T001229_A192FacturaCae1[0]) != 0 ) || ( StringUtil.StrCmp(Z229FacturaCae2, T001229_A229FacturaCae2[0]) != 0 ) || ( Z280FacturaFechaHora != T001229_A280FacturaFechaHora[0] ) || ( Z281CorteCajaIdF != T001229_A281CorteCajaIdF[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z91ConsultaId != T001229_A91ConsultaId[0] ) || ( StringUtil.StrCmp(Z132CajaCodigo, T001229_A132CajaCodigo[0]) != 0 ) || ( StringUtil.StrCmp(Z178ClienteCodigo, T001229_A178ClienteCodigo[0]) != 0 ) || ( StringUtil.StrCmp(Z4UsuarioCodigo, T001229_A4UsuarioCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Factura"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1249( )
      {
         BeforeValidate1249( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1249( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1249( 0) ;
            CheckOptimisticConcurrency1249( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1249( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1249( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001230 */
                     pr_default.execute(22, new Object[] {A185FacturaId, A186FacturaFecha, A187FacturaHora, A188FacturaEstado, A189FacturaDocto, A190FacturaSerie, A191FacturaIva, A192FacturaCae1, A229FacturaCae2, A280FacturaFechaHora, A281CorteCajaIdF, A41ClinicaCodigo, A91ConsultaId, A132CajaCodigo, A178ClienteCodigo, A4UsuarioCodigo});
                     pr_default.close(22);
                     if ( (pr_default.getStatus(22) == 1) )
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
                           ProcessLevel1249( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption120( ) ;
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
               Load1249( ) ;
            }
            EndLevel1249( ) ;
         }
         CloseExtendedTableCursors1249( ) ;
      }

      protected void Update1249( )
      {
         BeforeValidate1249( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1249( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1249( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1249( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1249( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001231 */
                     pr_default.execute(23, new Object[] {A186FacturaFecha, A187FacturaHora, A188FacturaEstado, A189FacturaDocto, A190FacturaSerie, A191FacturaIva, A192FacturaCae1, A229FacturaCae2, A280FacturaFechaHora, A281CorteCajaIdF, A91ConsultaId, A132CajaCodigo, A178ClienteCodigo, A4UsuarioCodigo, A41ClinicaCodigo, A185FacturaId});
                     pr_default.close(23);
                     if ( (pr_default.getStatus(23) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Factura"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1249( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1249( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption120( ) ;
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
            EndLevel1249( ) ;
         }
         CloseExtendedTableCursors1249( ) ;
      }

      protected void DeferredUpdate1249( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1249( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1249( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1249( ) ;
            AfterConfirm1249( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1249( ) ;
               if ( AnyError == 0 )
               {
                  A247FacturaTotal = O247FacturaTotal ;
                  n247FacturaTotal = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
                  ScanStart1260( ) ;
                  while ( RcdFound60 != 0 )
                  {
                     getByPrimaryKey1260( ) ;
                     Delete1260( ) ;
                     ScanNext1260( ) ;
                     O247FacturaTotal = A247FacturaTotal ;
                     n247FacturaTotal = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
                  }
                  ScanEnd1260( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001232 */
                     pr_default.execute(24, new Object[] {A41ClinicaCodigo, A185FacturaId});
                     pr_default.close(24);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound49 == 0 )
                           {
                              InitAll1249( ) ;
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
                           ResetCaption120( ) ;
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
         sMode49 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1249( ) ;
         Gx_mode = sMode49 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1249( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T001234 */
            pr_default.execute(25, new Object[] {A41ClinicaCodigo, A185FacturaId});
            if ( (pr_default.getStatus(25) != 101) )
            {
               A247FacturaTotal = T001234_A247FacturaTotal[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
               n247FacturaTotal = T001234_n247FacturaTotal[0] ;
            }
            else
            {
               A247FacturaTotal = 0 ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            }
            pr_default.close(25);
            /* Using cursor T001236 */
            pr_default.execute(26, new Object[] {A41ClinicaCodigo, A185FacturaId});
            if ( (pr_default.getStatus(26) != 101) )
            {
               A263FacturaPago = T001236_A263FacturaPago[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
               n263FacturaPago = T001236_n263FacturaPago[0] ;
            }
            else
            {
               A263FacturaPago = 0 ;
               n263FacturaPago = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
            }
            pr_default.close(26);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T001237 */
            pr_default.execute(27, new Object[] {A41ClinicaCodigo, A185FacturaId});
            if ( (pr_default.getStatus(27) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Detalle de Pago de Facturas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(27);
         }
      }

      protected void ProcessNestedLevel1260( )
      {
         s247FacturaTotal = O247FacturaTotal ;
         n247FacturaTotal = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         nGXsfl_130_idx = 0 ;
         while ( nGXsfl_130_idx < nRC_Gridfactura_facturadetalle )
         {
            ReadRow1260( ) ;
            if ( ( nRcdExists_60 != 0 ) || ( nIsMod_60 != 0 ) )
            {
               standaloneNotModal1260( ) ;
               GetKey1260( ) ;
               if ( ( nRcdExists_60 == 0 ) && ( nRcdDeleted_60 == 0 ) )
               {
                  if ( RcdFound60 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert1260( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtFacturaDId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound60 != 0 )
                  {
                     if ( ( nRcdDeleted_60 != 0 ) && ( nRcdExists_60 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete1260( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_60 != 0 ) && ( nRcdExists_60 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update1260( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_60 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtFacturaDId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O247FacturaTotal = A247FacturaTotal ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            }
            ChangePostValue( edtFacturaDId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", ""))) ;
            ChangePostValue( edtArticuloCodigo_Internalname, StringUtil.RTrim( A30ArticuloCodigo)) ;
            ChangePostValue( edtFacturaDPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A249FacturaDPrecio, 17, 2, ".", ""))) ;
            ChangePostValue( edtFacturaDCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A250FacturaDCantidad, 17, 2, ".", ""))) ;
            ChangePostValue( edtFacturaDTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A251FacturaDTotal, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z248FacturaDId_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z248FacturaDId), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z249FacturaDPrecio_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( Z249FacturaDPrecio, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z250FacturaDCantidad_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( Z250FacturaDCantidad, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z30ArticuloCodigo_"+sGXsfl_130_idx, StringUtil.RTrim( Z30ArticuloCodigo)) ;
            ChangePostValue( "T251FacturaDTotal_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( O251FacturaDTotal, 17, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_60_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_60), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_60_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_60), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_60_"+sGXsfl_130_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_60), 4, 0, ".", ""))) ;
            if ( nIsMod_60 != 0 )
            {
               ChangePostValue( "FACTURADID_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ARTICULOCODIGO_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FACTURADPRECIO_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDPrecio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FACTURADCANTIDAD_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDCantidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "FACTURADTOTAL_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDTotal_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1260( ) ;
         if ( AnyError != 0 )
         {
            O247FacturaTotal = s247FacturaTotal ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         }
         nRcdExists_60 = 0 ;
         nIsMod_60 = 0 ;
         nRcdDeleted_60 = 0 ;
      }

      protected void ProcessLevel1249( )
      {
         /* Save parent mode. */
         sMode49 = Gx_mode ;
         ProcessNestedLevel1260( ) ;
         if ( AnyError != 0 )
         {
            O247FacturaTotal = s247FacturaTotal ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode49 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel1249( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(21);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1249( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(20);
            pr_default.close(19);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(25);
            pr_default.close(26);
            pr_default.close(2);
            context.CommitDataStores("Factura");
            if ( AnyError == 0 )
            {
               ConfirmValues120( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(20);
            pr_default.close(19);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(25);
            pr_default.close(26);
            pr_default.close(2);
            context.RollbackDataStores("Factura");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1249( )
      {
         /* Using cursor T001238 */
         pr_default.execute(28);
         RcdFound49 = 0 ;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound49 = 1 ;
            A41ClinicaCodigo = T001238_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = T001238_A185FacturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1249( )
      {
         pr_default.readNext(28);
         RcdFound49 = 0 ;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound49 = 1 ;
            A41ClinicaCodigo = T001238_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A185FacturaId = T001238_A185FacturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
         }
      }

      protected void ScanEnd1249( )
      {
      }

      protected void AfterConfirm1249( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1249( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1249( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1249( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1249( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1249( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1249( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtFacturaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaId_Enabled), 5, 0)));
         edtFacturaFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaFecha_Enabled), 5, 0)));
         edtFacturaHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaHora_Enabled), 5, 0)));
         cmbFacturaEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbFacturaEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbFacturaEstado.Enabled), 5, 0)));
         edtClienteCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteCodigo_Enabled), 5, 0)));
         edtFacturaDocto_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaDocto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaDocto_Enabled), 5, 0)));
         edtFacturaSerie_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaSerie_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaSerie_Enabled), 5, 0)));
         edtFacturaIva_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaIva_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaIva_Enabled), 5, 0)));
         edtFacturaTotal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaTotal_Enabled), 5, 0)));
         edtFacturaPago_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaPago_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaPago_Enabled), 5, 0)));
         edtFacturaCae1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaCae1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaCae1_Enabled), 5, 0)));
         edtFacturaCae2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaCae2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaCae2_Enabled), 5, 0)));
         edtConsultaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaId_Enabled), 5, 0)));
         edtCajaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCajaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCajaCodigo_Enabled), 5, 0)));
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
         edtFacturaFechaHora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtFacturaFechaHora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtFacturaFechaHora_Enabled), 5, 0)));
         edtCorteCajaIdF_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCorteCajaIdF_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCorteCajaIdF_Enabled), 5, 0)));
      }

      protected void ZM1260( short GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z249FacturaDPrecio = T00123_A249FacturaDPrecio[0] ;
               Z250FacturaDCantidad = T00123_A250FacturaDCantidad[0] ;
               Z30ArticuloCodigo = T00123_A30ArticuloCodigo[0] ;
            }
            else
            {
               Z249FacturaDPrecio = A249FacturaDPrecio ;
               Z250FacturaDCantidad = A250FacturaDCantidad ;
               Z30ArticuloCodigo = A30ArticuloCodigo ;
            }
         }
         if ( GX_JID == -12 )
         {
            Z185FacturaId = A185FacturaId ;
            Z248FacturaDId = A248FacturaDId ;
            Z249FacturaDPrecio = A249FacturaDPrecio ;
            Z250FacturaDCantidad = A250FacturaDCantidad ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z30ArticuloCodigo = A30ArticuloCodigo ;
         }
      }

      protected void standaloneNotModal1260( )
      {
      }

      protected void standaloneModal1260( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtFacturaDId_Enabled = 0 ;
         }
         else
         {
            edtFacturaDId_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode60, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode60, "DLT") == 0 ) )
         {
            DisableAttributes1260( ) ;
         }
      }

      protected void Load1260( )
      {
         /* Using cursor T001239 */
         pr_default.execute(29, new Object[] {A41ClinicaCodigo, A185FacturaId, A248FacturaDId});
         if ( (pr_default.getStatus(29) != 101) )
         {
            RcdFound60 = 1 ;
            A249FacturaDPrecio = T001239_A249FacturaDPrecio[0] ;
            A250FacturaDCantidad = T001239_A250FacturaDCantidad[0] ;
            A30ArticuloCodigo = T001239_A30ArticuloCodigo[0] ;
            ZM1260( -12) ;
         }
         pr_default.close(29);
         OnLoadActions1260( ) ;
      }

      protected void OnLoadActions1260( )
      {
         A251FacturaDTotal = (decimal)(A249FacturaDPrecio*A250FacturaDCantidad) ;
         O251FacturaDTotal = A251FacturaDTotal ;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A247FacturaTotal = (decimal)(O247FacturaTotal+A251FacturaDTotal) ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A247FacturaTotal = (decimal)(O247FacturaTotal+A251FacturaDTotal-O251FacturaDTotal) ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A247FacturaTotal = (decimal)(O247FacturaTotal-O251FacturaDTotal) ;
                  n247FacturaTotal = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
               }
            }
         }
      }

      protected void CheckExtendedTable1260( )
      {
         Gx_BScreen = 1 ;
         standaloneModal1260( ) ;
         /* Using cursor T00124 */
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
         A251FacturaDTotal = (decimal)(A249FacturaDPrecio*A250FacturaDCantidad) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A247FacturaTotal = (decimal)(O247FacturaTotal+A251FacturaDTotal) ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A247FacturaTotal = (decimal)(O247FacturaTotal+A251FacturaDTotal-O251FacturaDTotal) ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A247FacturaTotal = (decimal)(O247FacturaTotal-O251FacturaDTotal) ;
                  n247FacturaTotal = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
               }
            }
         }
      }

      protected void CloseExtendedTableCursors1260( )
      {
         pr_default.close(2);
      }

      protected void enableDisable1260( )
      {
      }

      protected void gxLoad_13( String A41ClinicaCodigo ,
                                String A30ArticuloCodigo )
      {
         /* Using cursor T001240 */
         pr_default.execute(30, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(30) == 101) )
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
         if ( (pr_default.getStatus(30) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(30);
      }

      protected void GetKey1260( )
      {
         /* Using cursor T001241 */
         pr_default.execute(31, new Object[] {A41ClinicaCodigo, A185FacturaId, A248FacturaDId});
         if ( (pr_default.getStatus(31) != 101) )
         {
            RcdFound60 = 1 ;
         }
         else
         {
            RcdFound60 = 0 ;
         }
         pr_default.close(31);
      }

      protected void getByPrimaryKey1260( )
      {
         /* Using cursor T00123 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A185FacturaId, A248FacturaDId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1260( 12) ;
            RcdFound60 = 1 ;
            InitializeNonKey1260( ) ;
            A248FacturaDId = T00123_A248FacturaDId[0] ;
            A249FacturaDPrecio = T00123_A249FacturaDPrecio[0] ;
            A250FacturaDCantidad = T00123_A250FacturaDCantidad[0] ;
            A30ArticuloCodigo = T00123_A30ArticuloCodigo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z185FacturaId = A185FacturaId ;
            Z248FacturaDId = A248FacturaDId ;
            sMode60 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1260( ) ;
            Load1260( ) ;
            Gx_mode = sMode60 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound60 = 0 ;
            InitializeNonKey1260( ) ;
            sMode60 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1260( ) ;
            Gx_mode = sMode60 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1260( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00122 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A185FacturaId, A248FacturaDId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"FacturaDetalle"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z249FacturaDPrecio != T00122_A249FacturaDPrecio[0] ) || ( Z250FacturaDCantidad != T00122_A250FacturaDCantidad[0] ) || ( StringUtil.StrCmp(Z30ArticuloCodigo, T00122_A30ArticuloCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"FacturaDetalle"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1260( )
      {
         BeforeValidate1260( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1260( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1260( 0) ;
            CheckOptimisticConcurrency1260( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1260( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1260( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001242 */
                     pr_default.execute(32, new Object[] {A185FacturaId, A248FacturaDId, A249FacturaDPrecio, A250FacturaDCantidad, A41ClinicaCodigo, A30ArticuloCodigo});
                     pr_default.close(32);
                     if ( (pr_default.getStatus(32) == 1) )
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
               Load1260( ) ;
            }
            EndLevel1260( ) ;
         }
         CloseExtendedTableCursors1260( ) ;
      }

      protected void Update1260( )
      {
         BeforeValidate1260( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1260( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1260( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1260( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1260( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001243 */
                     pr_default.execute(33, new Object[] {A249FacturaDPrecio, A250FacturaDCantidad, A30ArticuloCodigo, A41ClinicaCodigo, A185FacturaId, A248FacturaDId});
                     pr_default.close(33);
                     if ( (pr_default.getStatus(33) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"FacturaDetalle"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1260( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1260( ) ;
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
            EndLevel1260( ) ;
         }
         CloseExtendedTableCursors1260( ) ;
      }

      protected void DeferredUpdate1260( )
      {
      }

      protected void Delete1260( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1260( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1260( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1260( ) ;
            AfterConfirm1260( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1260( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001244 */
                  pr_default.execute(34, new Object[] {A41ClinicaCodigo, A185FacturaId, A248FacturaDId});
                  pr_default.close(34);
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
         sMode60 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1260( ) ;
         Gx_mode = sMode60 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1260( )
      {
         standaloneModal1260( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            A251FacturaDTotal = (decimal)(A249FacturaDPrecio*A250FacturaDCantidad) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A247FacturaTotal = (decimal)(O247FacturaTotal+A251FacturaDTotal) ;
               n247FacturaTotal = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A247FacturaTotal = (decimal)(O247FacturaTotal+A251FacturaDTotal-O251FacturaDTotal) ;
                  n247FacturaTotal = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A247FacturaTotal = (decimal)(O247FacturaTotal-O251FacturaDTotal) ;
                     n247FacturaTotal = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
                  }
               }
            }
         }
      }

      protected void EndLevel1260( )
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

      protected void ScanStart1260( )
      {
         /* Using cursor T001245 */
         pr_default.execute(35, new Object[] {A41ClinicaCodigo, A185FacturaId});
         RcdFound60 = 0 ;
         if ( (pr_default.getStatus(35) != 101) )
         {
            RcdFound60 = 1 ;
            A248FacturaDId = T001245_A248FacturaDId[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1260( )
      {
         pr_default.readNext(35);
         RcdFound60 = 0 ;
         if ( (pr_default.getStatus(35) != 101) )
         {
            RcdFound60 = 1 ;
            A248FacturaDId = T001245_A248FacturaDId[0] ;
         }
      }

      protected void ScanEnd1260( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm1260( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1260( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1260( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1260( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1260( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1260( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1260( )
      {
         edtFacturaDId_Enabled = 0 ;
         edtArticuloCodigo_Enabled = 0 ;
         edtFacturaDPrecio_Enabled = 0 ;
         edtFacturaDCantidad_Enabled = 0 ;
         edtFacturaDTotal_Enabled = 0 ;
      }

      protected void AddRow1260( )
      {
         nGXsfl_130_idx = (short)(nGXsfl_130_idx+1) ;
         sGXsfl_130_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_130_idx), 4, 0)), 4, "0") ;
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_130_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_130_idx ;
         imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_130_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_130_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_130_idx ;
         edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_130_idx ;
         SendRow1260( ) ;
      }

      protected void SendRow1260( )
      {
         Gridfactura_facturadetalleRow = GXWebRow.GetNew(context) ;
         if ( subGridfactura_facturadetalle_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridfactura_facturadetalle_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridfactura_facturadetalle_Class, "") != 0 )
            {
               subGridfactura_facturadetalle_Linesclass = subGridfactura_facturadetalle_Class+"Odd" ;
            }
         }
         else if ( subGridfactura_facturadetalle_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridfactura_facturadetalle_Backstyle = 0 ;
            subGridfactura_facturadetalle_Backcolor = subGridfactura_facturadetalle_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridfactura_facturadetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridfactura_facturadetalle_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridfactura_facturadetalle_Class, "") != 0 )
            {
               subGridfactura_facturadetalle_Linesclass = subGridfactura_facturadetalle_Class+"Uniform" ;
            }
         }
         else if ( subGridfactura_facturadetalle_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridfactura_facturadetalle_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridfactura_facturadetalle_Class, "") != 0 )
            {
               subGridfactura_facturadetalle_Linesclass = subGridfactura_facturadetalle_Class+"Odd" ;
            }
            subGridfactura_facturadetalle_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridfactura_facturadetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridfactura_facturadetalle_Backcolor), 9, 0)));
         }
         else if ( subGridfactura_facturadetalle_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridfactura_facturadetalle_Backstyle = 1 ;
            if ( ((int)(nGXsfl_130_idx) % (2)) == 0 )
            {
               subGridfactura_facturadetalle_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridfactura_facturadetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridfactura_facturadetalle_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridfactura_facturadetalle_Class, "") != 0 )
               {
                  subGridfactura_facturadetalle_Linesclass = subGridfactura_facturadetalle_Class+"Even" ;
               }
            }
            else
            {
               subGridfactura_facturadetalle_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridfactura_facturadetalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridfactura_facturadetalle_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridfactura_facturadetalle_Class, "") != 0 )
               {
                  subGridfactura_facturadetalle_Linesclass = subGridfactura_facturadetalle_Class+"Odd" ;
               }
            }
         }
         imgprompt_30_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00c1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+"}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOCODIGO_"+sGXsfl_130_idx+"'), id:'"+"ARTICULOCODIGO_"+sGXsfl_130_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_60_"+sGXsfl_130_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_60_" + sGXsfl_130_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 131,'',false,'" + sGXsfl_130_idx + "',130)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridfactura_facturadetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A248FacturaDId), "ZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(131);\"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtFacturaDId_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)130,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_60_" + sGXsfl_130_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 132,'',false,'" + sGXsfl_130_idx + "',130)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridfactura_facturadetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCodigo_Internalname,StringUtil.RTrim( A30ArticuloCodigo),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(132);\"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtArticuloCodigo_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)130,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridfactura_facturadetalleRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_30_Internalname,"prompt.gif",(String)imgprompt_30_Link,(String)"",(String)"",(String)"Fantastic",(int)imgprompt_30_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_60_" + sGXsfl_130_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 133,'',false,'" + sGXsfl_130_idx + "',130)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridfactura_facturadetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDPrecio_Internalname,StringUtil.LTrim( StringUtil.NToC( A249FacturaDPrecio, 17, 2, ".", "")),((edtFacturaDPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A249FacturaDPrecio, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A249FacturaDPrecio, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(133);\"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDPrecio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtFacturaDPrecio_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)130,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_60_" + sGXsfl_130_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 134,'',false,'" + sGXsfl_130_idx + "',130)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridfactura_facturadetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A250FacturaDCantidad, 17, 2, ".", "")),((edtFacturaDCantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A250FacturaDCantidad, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A250FacturaDCantidad, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(134);\"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDCantidad_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtFacturaDCantidad_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)130,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridfactura_facturadetalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A251FacturaDTotal, 17, 2, ".", "")),((edtFacturaDTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A251FacturaDTotal, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A251FacturaDTotal, "ZZZZZZZZZZZZZ9.99")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDTotal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtFacturaDTotal_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)130,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridfactura_facturadetalleRow);
         GXCCtl = "Z248FacturaDId_" + sGXsfl_130_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z248FacturaDId), 9, 0, ".", "")));
         GXCCtl = "Z249FacturaDPrecio_" + sGXsfl_130_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z249FacturaDPrecio, 17, 2, ".", "")));
         GXCCtl = "Z250FacturaDCantidad_" + sGXsfl_130_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z250FacturaDCantidad, 17, 2, ".", "")));
         GXCCtl = "Z30ArticuloCodigo_" + sGXsfl_130_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z30ArticuloCodigo));
         GXCCtl = "O251FacturaDTotal_" + sGXsfl_130_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O251FacturaDTotal, 17, 2, ".", "")));
         GXCCtl = "nRcdDeleted_60_" + sGXsfl_130_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_60), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_60_" + sGXsfl_130_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_60), 4, 0, ".", "")));
         GXCCtl = "nIsMod_60_" + sGXsfl_130_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_60), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FACTURADID_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ARTICULOCODIGO_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtArticuloCodigo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FACTURADPRECIO_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDPrecio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FACTURADCANTIDAD_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDCantidad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "FACTURADTOTAL_"+sGXsfl_130_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtFacturaDTotal_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_30_"+sGXsfl_130_idx+"Link", StringUtil.RTrim( imgprompt_30_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridfactura_facturadetalleContainer.AddRow(Gridfactura_facturadetalleRow);
      }

      protected void ReadRow1260( )
      {
         nGXsfl_130_idx = (short)(nGXsfl_130_idx+1) ;
         sGXsfl_130_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_130_idx), 4, 0)), 4, "0") ;
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_130_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_130_idx ;
         imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_130_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_130_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_130_idx ;
         edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_130_idx ;
         edtFacturaDId_Enabled = (int)(context.localUtil.CToN( cgiGet( "FACTURADID_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
         edtArticuloCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "ARTICULOCODIGO_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
         edtFacturaDPrecio_Enabled = (int)(context.localUtil.CToN( cgiGet( "FACTURADPRECIO_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
         edtFacturaDCantidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "FACTURADCANTIDAD_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
         edtFacturaDTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "FACTURADTOTAL_"+sGXsfl_130_idx+"Enabled"), ".", ",")) ;
         imgprompt_41_178_Link = cgiGet( "PROMPT_30_"+sGXsfl_130_idx+"Link") ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaDId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaDId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURADID");
            AnyError = 1 ;
            GX_FocusControl = edtFacturaDId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A248FacturaDId = 0 ;
         }
         else
         {
            A248FacturaDId = (int)(context.localUtil.CToN( cgiGet( edtFacturaDId_Internalname), ".", ",")) ;
         }
         A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaDPrecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaDPrecio_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURADPRECIO");
            AnyError = 1 ;
            GX_FocusControl = edtFacturaDPrecio_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A249FacturaDPrecio = 0 ;
         }
         else
         {
            A249FacturaDPrecio = context.localUtil.CToN( cgiGet( edtFacturaDPrecio_Internalname), ".", ",") ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtFacturaDCantidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtFacturaDCantidad_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURADCANTIDAD");
            AnyError = 1 ;
            GX_FocusControl = edtFacturaDCantidad_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A250FacturaDCantidad = 0 ;
         }
         else
         {
            A250FacturaDCantidad = context.localUtil.CToN( cgiGet( edtFacturaDCantidad_Internalname), ".", ",") ;
         }
         A251FacturaDTotal = context.localUtil.CToN( cgiGet( edtFacturaDTotal_Internalname), ".", ",") ;
         GXCCtl = "Z248FacturaDId_" + sGXsfl_130_idx ;
         Z248FacturaDId = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z249FacturaDPrecio_" + sGXsfl_130_idx ;
         Z249FacturaDPrecio = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z250FacturaDCantidad_" + sGXsfl_130_idx ;
         Z250FacturaDCantidad = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z30ArticuloCodigo_" + sGXsfl_130_idx ;
         Z30ArticuloCodigo = cgiGet( GXCCtl) ;
         GXCCtl = "O251FacturaDTotal_" + sGXsfl_130_idx ;
         O251FacturaDTotal = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "nRcdDeleted_60_" + sGXsfl_130_idx ;
         nRcdDeleted_60 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_60_" + sGXsfl_130_idx ;
         nRcdExists_60 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_60_" + sGXsfl_130_idx ;
         nIsMod_60 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtFacturaDId_Enabled = edtFacturaDId_Enabled ;
      }

      protected void ConfirmValues120( )
      {
         nGXsfl_130_idx = 0 ;
         sGXsfl_130_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_130_idx), 4, 0)), 4, "0") ;
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_130_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_130_idx ;
         imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_130_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_130_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_130_idx ;
         edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_130_idx ;
         while ( nGXsfl_130_idx < nRC_Gridfactura_facturadetalle )
         {
            nGXsfl_130_idx = (short)(nGXsfl_130_idx+1) ;
            sGXsfl_130_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_130_idx), 4, 0)), 4, "0") ;
            edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_130_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_130_idx ;
            imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_130_idx ;
            edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_130_idx ;
            edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_130_idx ;
            edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_130_idx ;
            ChangePostValue( "Z248FacturaDId_"+sGXsfl_130_idx, cgiGet( "ZT_"+"Z248FacturaDId_"+sGXsfl_130_idx)) ;
            DeletePostValue( "ZT_"+"Z248FacturaDId_"+sGXsfl_130_idx) ;
            ChangePostValue( "Z249FacturaDPrecio_"+sGXsfl_130_idx, cgiGet( "ZT_"+"Z249FacturaDPrecio_"+sGXsfl_130_idx)) ;
            DeletePostValue( "ZT_"+"Z249FacturaDPrecio_"+sGXsfl_130_idx) ;
            ChangePostValue( "Z250FacturaDCantidad_"+sGXsfl_130_idx, cgiGet( "ZT_"+"Z250FacturaDCantidad_"+sGXsfl_130_idx)) ;
            DeletePostValue( "ZT_"+"Z250FacturaDCantidad_"+sGXsfl_130_idx) ;
            ChangePostValue( "Z30ArticuloCodigo_"+sGXsfl_130_idx, cgiGet( "ZT_"+"Z30ArticuloCodigo_"+sGXsfl_130_idx)) ;
            DeletePostValue( "ZT_"+"Z30ArticuloCodigo_"+sGXsfl_130_idx) ;
         }
         ChangePostValue( "O251FacturaDTotal", cgiGet( "T251FacturaDTotal")) ;
         DeletePostValue( "T251FacturaDTotal") ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("factura.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z185FacturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z185FacturaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z186FacturaFecha", context.localUtil.DToC( Z186FacturaFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z187FacturaHora", StringUtil.RTrim( Z187FacturaHora));
         GxWebStd.gx_hidden_field( context, "Z188FacturaEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z188FacturaEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z189FacturaDocto", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z189FacturaDocto), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z190FacturaSerie", StringUtil.RTrim( Z190FacturaSerie));
         GxWebStd.gx_hidden_field( context, "Z191FacturaIva", StringUtil.LTrim( StringUtil.NToC( Z191FacturaIva, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z192FacturaCae1", StringUtil.RTrim( Z192FacturaCae1));
         GxWebStd.gx_hidden_field( context, "Z229FacturaCae2", StringUtil.RTrim( Z229FacturaCae2));
         GxWebStd.gx_hidden_field( context, "Z280FacturaFechaHora", context.localUtil.TToC( Z280FacturaFechaHora, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z281CorteCajaIdF", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z281CorteCajaIdF), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z91ConsultaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91ConsultaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z132CajaCodigo", StringUtil.RTrim( Z132CajaCodigo));
         GxWebStd.gx_hidden_field( context, "Z178ClienteCodigo", StringUtil.RTrim( Z178ClienteCodigo));
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
         GxWebStd.gx_hidden_field( context, "O247FacturaTotal", StringUtil.LTrim( StringUtil.NToC( O247FacturaTotal, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridfactura_facturadetalle", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_130_idx), 4, 0, ".", "")));
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
         return "Factura" ;
      }

      public override String GetPgmdesc( )
      {
         return "Factura a Pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("factura.aspx")  ;
      }

      protected void InitializeNonKey1249( )
      {
         A186FacturaFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186FacturaFecha", context.localUtil.Format(A186FacturaFecha, "99/99/99"));
         A187FacturaHora = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187FacturaHora", A187FacturaHora);
         A188FacturaEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188FacturaEstado", StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0));
         A178ClienteCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
         A189FacturaDocto = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189FacturaDocto", StringUtil.LTrim( StringUtil.Str( (decimal)(A189FacturaDocto), 9, 0)));
         A190FacturaSerie = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190FacturaSerie", A190FacturaSerie);
         A191FacturaIva = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A191FacturaIva", StringUtil.LTrim( StringUtil.Str( A191FacturaIva, 17, 2)));
         A247FacturaTotal = 0 ;
         n247FacturaTotal = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         A263FacturaPago = 0 ;
         n263FacturaPago = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
         A192FacturaCae1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192FacturaCae1", A192FacturaCae1);
         A229FacturaCae2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229FacturaCae2", A229FacturaCae2);
         A91ConsultaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         A132CajaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132CajaCodigo", A132CajaCodigo);
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         A280FacturaFechaHora = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A280FacturaFechaHora", context.localUtil.TToC( A280FacturaFechaHora, 8, 5, 0, 3, "/", ":", " "));
         A281CorteCajaIdF = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281CorteCajaIdF", StringUtil.LTrim( StringUtil.Str( (decimal)(A281CorteCajaIdF), 9, 0)));
         O247FacturaTotal = A247FacturaTotal ;
         n247FacturaTotal = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
      }

      protected void InitAll1249( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A185FacturaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A185FacturaId), 9, 0)));
         InitializeNonKey1249( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1260( )
      {
         A251FacturaDTotal = 0 ;
         A30ArticuloCodigo = "" ;
         A249FacturaDPrecio = 0 ;
         A250FacturaDCantidad = 0 ;
         O251FacturaDTotal = A251FacturaDTotal ;
      }

      protected void InitAll1260( )
      {
         A248FacturaDId = 0 ;
         InitializeNonKey1260( ) ;
      }

      protected void StandaloneModalInsert1260( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1561034");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("factura.js", "?1561034");
         /* End function include_jscripts */
      }

      protected void init_level_properties60( )
      {
         edtFacturaDId_Enabled = defedtFacturaDId_Enabled ;
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
         lblTextblockfacturaid_Internalname = "TEXTBLOCKFACTURAID" ;
         edtFacturaId_Internalname = "FACTURAID" ;
         lblTextblockfacturafecha_Internalname = "TEXTBLOCKFACTURAFECHA" ;
         edtFacturaFecha_Internalname = "FACTURAFECHA" ;
         lblTextblockfacturahora_Internalname = "TEXTBLOCKFACTURAHORA" ;
         edtFacturaHora_Internalname = "FACTURAHORA" ;
         lblTextblockfacturaestado_Internalname = "TEXTBLOCKFACTURAESTADO" ;
         cmbFacturaEstado_Internalname = "FACTURAESTADO" ;
         lblTextblockclientecodigo_Internalname = "TEXTBLOCKCLIENTECODIGO" ;
         edtClienteCodigo_Internalname = "CLIENTECODIGO" ;
         lblTextblockfacturadocto_Internalname = "TEXTBLOCKFACTURADOCTO" ;
         edtFacturaDocto_Internalname = "FACTURADOCTO" ;
         lblTextblockfacturaserie_Internalname = "TEXTBLOCKFACTURASERIE" ;
         edtFacturaSerie_Internalname = "FACTURASERIE" ;
         lblTextblockfacturaiva_Internalname = "TEXTBLOCKFACTURAIVA" ;
         edtFacturaIva_Internalname = "FACTURAIVA" ;
         lblTextblockfacturatotal_Internalname = "TEXTBLOCKFACTURATOTAL" ;
         edtFacturaTotal_Internalname = "FACTURATOTAL" ;
         lblTextblockfacturapago_Internalname = "TEXTBLOCKFACTURAPAGO" ;
         edtFacturaPago_Internalname = "FACTURAPAGO" ;
         lblTextblockfacturacae1_Internalname = "TEXTBLOCKFACTURACAE1" ;
         edtFacturaCae1_Internalname = "FACTURACAE1" ;
         lblTextblockfacturacae2_Internalname = "TEXTBLOCKFACTURACAE2" ;
         edtFacturaCae2_Internalname = "FACTURACAE2" ;
         lblTextblockconsultaid_Internalname = "TEXTBLOCKCONSULTAID" ;
         edtConsultaId_Internalname = "CONSULTAID" ;
         lblTextblockcajacodigo_Internalname = "TEXTBLOCKCAJACODIGO" ;
         edtCajaCodigo_Internalname = "CAJACODIGO" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         lblTextblockfacturafechahora_Internalname = "TEXTBLOCKFACTURAFECHAHORA" ;
         edtFacturaFechaHora_Internalname = "FACTURAFECHAHORA" ;
         lblTextblockcortecajaidf_Internalname = "TEXTBLOCKCORTECAJAIDF" ;
         edtCorteCajaIdF_Internalname = "CORTECAJAIDF" ;
         lblTitlefacturadetalle_Internalname = "TITLEFACTURADETALLE" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_178_Internalname = "PROMPT_41_178" ;
         imgprompt_41_91_Internalname = "PROMPT_41_91" ;
         imgprompt_41_132_Internalname = "PROMPT_41_132" ;
         imgprompt_4_Internalname = "PROMPT_4" ;
         subGridfactura_facturadetalle_Internalname = "GRIDFACTURA_FACTURADETALLE" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Factura a Pacientes" ;
         edtFacturaDTotal_Jsonclick = "" ;
         edtFacturaDCantidad_Jsonclick = "" ;
         edtFacturaDPrecio_Jsonclick = "" ;
         imgprompt_30_Visible = 1 ;
         imgprompt_30_Link = "" ;
         imgprompt_41_178_Visible = 1 ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtFacturaDId_Jsonclick = "" ;
         subGridfactura_facturadetalle_Class = "Grid" ;
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
         subGridfactura_facturadetalle_Allowcollapsing = 0 ;
         edtFacturaDTotal_Enabled = 0 ;
         edtFacturaDCantidad_Enabled = 1 ;
         edtFacturaDPrecio_Enabled = 1 ;
         edtArticuloCodigo_Enabled = 1 ;
         edtFacturaDId_Enabled = 1 ;
         subGridfactura_facturadetalle_Backcolorstyle = 2 ;
         edtCorteCajaIdF_Jsonclick = "" ;
         edtCorteCajaIdF_Enabled = 1 ;
         edtFacturaFechaHora_Jsonclick = "" ;
         edtFacturaFechaHora_Enabled = 1 ;
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         imgprompt_41_132_Visible = 1 ;
         imgprompt_41_132_Link = "" ;
         edtCajaCodigo_Jsonclick = "" ;
         edtCajaCodigo_Enabled = 1 ;
         imgprompt_41_91_Visible = 1 ;
         imgprompt_41_91_Link = "" ;
         edtConsultaId_Jsonclick = "" ;
         edtConsultaId_Enabled = 1 ;
         edtFacturaCae2_Enabled = 1 ;
         edtFacturaCae1_Enabled = 1 ;
         edtFacturaPago_Jsonclick = "" ;
         edtFacturaPago_Enabled = 0 ;
         edtFacturaTotal_Jsonclick = "" ;
         edtFacturaTotal_Enabled = 0 ;
         edtFacturaIva_Jsonclick = "" ;
         edtFacturaIva_Enabled = 1 ;
         edtFacturaSerie_Jsonclick = "" ;
         edtFacturaSerie_Enabled = 1 ;
         edtFacturaDocto_Jsonclick = "" ;
         edtFacturaDocto_Enabled = 1 ;
         imgprompt_41_178_Visible = 1 ;
         imgprompt_41_178_Link = "" ;
         edtClienteCodigo_Jsonclick = "" ;
         edtClienteCodigo_Enabled = 1 ;
         cmbFacturaEstado_Jsonclick = "" ;
         cmbFacturaEstado.Enabled = 1 ;
         edtFacturaHora_Jsonclick = "" ;
         edtFacturaHora_Enabled = 1 ;
         edtFacturaFecha_Jsonclick = "" ;
         edtFacturaFecha_Enabled = 1 ;
         edtFacturaId_Jsonclick = "" ;
         edtFacturaId_Enabled = 1 ;
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

      protected void gxnrGridfactura_facturadetalle_newrow( short nRC_Gridfactura_facturadetalle ,
                                                            short nGXsfl_130_idx ,
                                                            String sGXsfl_130_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_130_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_130_idx ;
         imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_130_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_130_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_130_idx ;
         edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_130_idx ;
         while ( nGXsfl_130_idx <= nRC_Gridfactura_facturadetalle )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1260( ) ;
            standaloneModal1260( ) ;
            cmbFacturaEstado.Name = "FACTURAESTADO" ;
            cmbFacturaEstado.WebTags = "" ;
            cmbFacturaEstado.addItem("0", "Creado", 0);
            cmbFacturaEstado.addItem("1", "Facturado", 0);
            cmbFacturaEstado.addItem("2", "Anulado", 0);
            cmbFacturaEstado.addItem("3", "Cancelado", 0);
            if ( ( cmbFacturaEstado.ItemCount > 0 ) && (0==A188FacturaEstado) )
            {
               A188FacturaEstado = (short)(NumberUtil.Val( cmbFacturaEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188FacturaEstado", StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0));
            }
            dynload_actions( ) ;
            SendRow1260( ) ;
            nGXsfl_130_idx = (short)(nGXsfl_130_idx+1) ;
            sGXsfl_130_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_130_idx), 4, 0)), 4, "0") ;
            edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_130_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_130_idx ;
            imgprompt_30_Internalname = "PROMPT_30_"+sGXsfl_130_idx ;
            edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_130_idx ;
            edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_130_idx ;
            edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_130_idx ;
         }
         context.GX_webresponse.AddString(Gridfactura_facturadetalleContainer.ToJavascriptSource());
         /* End function gxnrGridfactura_facturadetalle_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T001234 */
         pr_default.execute(25, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(25) != 101) )
         {
            A247FacturaTotal = T001234_A247FacturaTotal[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
            n247FacturaTotal = T001234_n247FacturaTotal[0] ;
         }
         else
         {
            A247FacturaTotal = 0 ;
            n247FacturaTotal = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A247FacturaTotal", StringUtil.LTrim( StringUtil.Str( A247FacturaTotal, 17, 2)));
         }
         pr_default.close(25);
         /* Using cursor T001236 */
         pr_default.execute(26, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(26) != 101) )
         {
            A263FacturaPago = T001236_A263FacturaPago[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
            n263FacturaPago = T001236_n263FacturaPago[0] ;
         }
         else
         {
            A263FacturaPago = 0 ;
            n263FacturaPago = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263FacturaPago", StringUtil.LTrim( StringUtil.Str( A263FacturaPago, 17, 2)));
         }
         pr_default.close(26);
         GX_FocusControl = edtFacturaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Facturaid( String GX_Parm1 ,
                                   int GX_Parm2 ,
                                   DateTime GX_Parm3 ,
                                   String GX_Parm4 ,
                                   GXCombobox cmbGX_Parm5 ,
                                   int GX_Parm6 ,
                                   String GX_Parm7 ,
                                   decimal GX_Parm8 ,
                                   String GX_Parm9 ,
                                   String GX_Parm10 ,
                                   DateTime GX_Parm11 ,
                                   int GX_Parm12 ,
                                   int GX_Parm13 ,
                                   String GX_Parm14 ,
                                   String GX_Parm15 ,
                                   String GX_Parm16 ,
                                   decimal GX_Parm17 ,
                                   decimal GX_Parm18 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A185FacturaId = GX_Parm2 ;
         A186FacturaFecha = GX_Parm3 ;
         A187FacturaHora = GX_Parm4 ;
         cmbFacturaEstado = cmbGX_Parm5 ;
         A188FacturaEstado = (short)(NumberUtil.Val( cmbFacturaEstado.CurrentValue, ".")) ;
         cmbFacturaEstado.CurrentValue = StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0) ;
         A189FacturaDocto = GX_Parm6 ;
         A190FacturaSerie = GX_Parm7 ;
         A191FacturaIva = GX_Parm8 ;
         A192FacturaCae1 = GX_Parm9 ;
         A229FacturaCae2 = GX_Parm10 ;
         A280FacturaFechaHora = GX_Parm11 ;
         A281CorteCajaIdF = GX_Parm12 ;
         A91ConsultaId = GX_Parm13 ;
         A132CajaCodigo = GX_Parm14 ;
         A178ClienteCodigo = GX_Parm15 ;
         A4UsuarioCodigo = GX_Parm16 ;
         A247FacturaTotal = GX_Parm17 ;
         n247FacturaTotal = false ;
         A263FacturaPago = GX_Parm18 ;
         n263FacturaPago = false ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         /* Using cursor T001234 */
         pr_default.execute(25, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(25) != 101) )
         {
            A247FacturaTotal = T001234_A247FacturaTotal[0] ;
            n247FacturaTotal = T001234_n247FacturaTotal[0] ;
         }
         else
         {
            A247FacturaTotal = 0 ;
            n247FacturaTotal = false ;
         }
         pr_default.close(25);
         /* Using cursor T001236 */
         pr_default.execute(26, new Object[] {A41ClinicaCodigo, A185FacturaId});
         if ( (pr_default.getStatus(26) != 101) )
         {
            A263FacturaPago = T001236_A263FacturaPago[0] ;
            n263FacturaPago = T001236_n263FacturaPago[0] ;
         }
         else
         {
            A263FacturaPago = 0 ;
            n263FacturaPago = false ;
         }
         pr_default.close(26);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A247FacturaTotal = 0 ;
            n247FacturaTotal = false ;
            A263FacturaPago = 0 ;
            n263FacturaPago = false ;
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A186FacturaFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A187FacturaHora)));
         cmbFacturaEstado.CurrentValue = StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbFacturaEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( A178ClienteCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A189FacturaDocto), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A190FacturaSerie)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A191FacturaIva, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A192FacturaCae1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A229FacturaCae2)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A132CajaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4UsuarioCodigo)));
         isValidOutput.Add((Object)(context.localUtil.Format(A280FacturaFechaHora, "99/99/99 99:99")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A281CorteCajaIdF), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A247FacturaTotal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A263FacturaPago, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z185FacturaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z186FacturaFecha, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z187FacturaHora)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z188FacturaEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z178ClienteCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z189FacturaDocto), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z190FacturaSerie)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z191FacturaIva, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z192FacturaCae1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z229FacturaCae2)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91ConsultaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z132CajaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z280FacturaFechaHora, 10, 8, 0, 0, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z281CorteCajaIdF), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z247FacturaTotal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z263FacturaPago, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( O247FacturaTotal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(Gridfactura_facturadetalleContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Clientecodigo( String GX_Parm1 ,
                                       String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A178ClienteCodigo = GX_Parm2 ;
         /* Using cursor T001246 */
         pr_default.execute(36, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         if ( (pr_default.getStatus(36) == 101) )
         {
            AnyError41 = 1 ;
            AnyError178 = 1 ;
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError178 == 0 ) )
         {
         }
         pr_default.close(36);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Consultaid( String GX_Parm1 ,
                                    int GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A91ConsultaId = GX_Parm2 ;
         /* Using cursor T001247 */
         pr_default.execute(37, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(37) == 101) )
         {
            AnyError41 = 1 ;
            AnyError91 = 1 ;
            GX_msglist.addItem("No existe 'Consulta de pacientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError91 == 0 ) )
         {
         }
         pr_default.close(37);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Cajacodigo( String GX_Parm1 ,
                                    String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A132CajaCodigo = GX_Parm2 ;
         /* Using cursor T001248 */
         pr_default.execute(38, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         if ( (pr_default.getStatus(38) == 101) )
         {
            AnyError41 = 1 ;
            AnyError132 = 1 ;
            GX_msglist.addItem("No existe 'Cajas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError132 == 0 ) )
         {
         }
         pr_default.close(38);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Usuariocodigo( String GX_Parm1 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         /* Using cursor T001249 */
         pr_default.execute(39, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(39) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Usuarios'.", "ForeignKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
         }
         if ( AnyError4 == 0 )
         {
         }
         pr_default.close(39);
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
         /* Using cursor T001250 */
         pr_default.execute(40, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(40) == 101) )
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
         pr_default.close(40);
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
         pr_default.close(35);
         pr_default.close(40);
         pr_default.close(28);
         pr_default.close(20);
         pr_default.close(19);
         pr_default.close(37);
         pr_default.close(38);
         pr_default.close(36);
         pr_default.close(39);
         pr_default.close(25);
         pr_default.close(26);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A132CajaCodigo = "" ;
         A178ClienteCodigo = "" ;
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
         lblTextblockfacturaid_Jsonclick = "" ;
         lblTextblockfacturafecha_Jsonclick = "" ;
         A186FacturaFecha = DateTime.MinValue ;
         lblTextblockfacturahora_Jsonclick = "" ;
         A187FacturaHora = "" ;
         lblTextblockfacturaestado_Jsonclick = "" ;
         lblTextblockclientecodigo_Jsonclick = "" ;
         lblTextblockfacturadocto_Jsonclick = "" ;
         lblTextblockfacturaserie_Jsonclick = "" ;
         A190FacturaSerie = "" ;
         lblTextblockfacturaiva_Jsonclick = "" ;
         lblTextblockfacturatotal_Jsonclick = "" ;
         lblTextblockfacturapago_Jsonclick = "" ;
         lblTextblockfacturacae1_Jsonclick = "" ;
         A192FacturaCae1 = "" ;
         lblTextblockfacturacae2_Jsonclick = "" ;
         A229FacturaCae2 = "" ;
         lblTextblockconsultaid_Jsonclick = "" ;
         lblTextblockcajacodigo_Jsonclick = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         lblTextblockfacturafechahora_Jsonclick = "" ;
         A280FacturaFechaHora = (DateTime)(DateTime.MinValue) ;
         lblTextblockcortecajaidf_Jsonclick = "" ;
         Gridfactura_facturadetalleContainer = new GXWebGrid( context);
         Gridfactura_facturadetalleColumn = new GXWebColumn();
         Gx_mode = "" ;
         sMode60 = "" ;
         edtFacturaDId_Internalname = "" ;
         lblTitlefacturadetalle_Jsonclick = "" ;
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
         Z186FacturaFecha = DateTime.MinValue ;
         Z187FacturaHora = "" ;
         Z190FacturaSerie = "" ;
         Z192FacturaCae1 = "" ;
         Z229FacturaCae2 = "" ;
         Z280FacturaFechaHora = (DateTime)(DateTime.MinValue) ;
         Z132CajaCodigo = "" ;
         Z178ClienteCodigo = "" ;
         Z4UsuarioCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtArticuloCodigo_Internalname = "" ;
         edtFacturaDPrecio_Internalname = "" ;
         edtFacturaDCantidad_Internalname = "" ;
         edtFacturaDTotal_Internalname = "" ;
         Z30ArticuloCodigo = "" ;
         T001217_A185FacturaId = new int[1] ;
         T001217_A186FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         T001217_A187FacturaHora = new String[] {""} ;
         T001217_A188FacturaEstado = new short[1] ;
         T001217_A189FacturaDocto = new int[1] ;
         T001217_A190FacturaSerie = new String[] {""} ;
         T001217_A191FacturaIva = new decimal[1] ;
         T001217_A192FacturaCae1 = new String[] {""} ;
         T001217_A229FacturaCae2 = new String[] {""} ;
         T001217_A280FacturaFechaHora = new DateTime[] {DateTime.MinValue} ;
         T001217_A281CorteCajaIdF = new int[1] ;
         T001217_A41ClinicaCodigo = new String[] {""} ;
         T001217_A91ConsultaId = new int[1] ;
         T001217_A132CajaCodigo = new String[] {""} ;
         T001217_A178ClienteCodigo = new String[] {""} ;
         T001217_A4UsuarioCodigo = new String[] {""} ;
         T001217_A247FacturaTotal = new decimal[1] ;
         T001217_n247FacturaTotal = new bool[] {false} ;
         T001217_A263FacturaPago = new decimal[1] ;
         T001217_n263FacturaPago = new bool[] {false} ;
         T00127_A41ClinicaCodigo = new String[] {""} ;
         T00128_A41ClinicaCodigo = new String[] {""} ;
         T00129_A41ClinicaCodigo = new String[] {""} ;
         T001212_A247FacturaTotal = new decimal[1] ;
         T001212_n247FacturaTotal = new bool[] {false} ;
         T001214_A263FacturaPago = new decimal[1] ;
         T001214_n263FacturaPago = new bool[] {false} ;
         T001210_A4UsuarioCodigo = new String[] {""} ;
         T001218_A41ClinicaCodigo = new String[] {""} ;
         T001219_A41ClinicaCodigo = new String[] {""} ;
         T001220_A41ClinicaCodigo = new String[] {""} ;
         T001222_A247FacturaTotal = new decimal[1] ;
         T001222_n247FacturaTotal = new bool[] {false} ;
         T001224_A263FacturaPago = new decimal[1] ;
         T001224_n263FacturaPago = new bool[] {false} ;
         T001225_A4UsuarioCodigo = new String[] {""} ;
         T001226_A41ClinicaCodigo = new String[] {""} ;
         T001226_A185FacturaId = new int[1] ;
         T00126_A185FacturaId = new int[1] ;
         T00126_A186FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         T00126_A187FacturaHora = new String[] {""} ;
         T00126_A188FacturaEstado = new short[1] ;
         T00126_A189FacturaDocto = new int[1] ;
         T00126_A190FacturaSerie = new String[] {""} ;
         T00126_A191FacturaIva = new decimal[1] ;
         T00126_A192FacturaCae1 = new String[] {""} ;
         T00126_A229FacturaCae2 = new String[] {""} ;
         T00126_A280FacturaFechaHora = new DateTime[] {DateTime.MinValue} ;
         T00126_A281CorteCajaIdF = new int[1] ;
         T00126_A41ClinicaCodigo = new String[] {""} ;
         T00126_A91ConsultaId = new int[1] ;
         T00126_A132CajaCodigo = new String[] {""} ;
         T00126_A178ClienteCodigo = new String[] {""} ;
         T00126_A4UsuarioCodigo = new String[] {""} ;
         sMode49 = "" ;
         T001227_A41ClinicaCodigo = new String[] {""} ;
         T001227_A185FacturaId = new int[1] ;
         T001228_A41ClinicaCodigo = new String[] {""} ;
         T001228_A185FacturaId = new int[1] ;
         T001229_A185FacturaId = new int[1] ;
         T001229_A186FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         T001229_A187FacturaHora = new String[] {""} ;
         T001229_A188FacturaEstado = new short[1] ;
         T001229_A189FacturaDocto = new int[1] ;
         T001229_A190FacturaSerie = new String[] {""} ;
         T001229_A191FacturaIva = new decimal[1] ;
         T001229_A192FacturaCae1 = new String[] {""} ;
         T001229_A229FacturaCae2 = new String[] {""} ;
         T001229_A280FacturaFechaHora = new DateTime[] {DateTime.MinValue} ;
         T001229_A281CorteCajaIdF = new int[1] ;
         T001229_A41ClinicaCodigo = new String[] {""} ;
         T001229_A91ConsultaId = new int[1] ;
         T001229_A132CajaCodigo = new String[] {""} ;
         T001229_A178ClienteCodigo = new String[] {""} ;
         T001229_A4UsuarioCodigo = new String[] {""} ;
         T001234_A247FacturaTotal = new decimal[1] ;
         T001234_n247FacturaTotal = new bool[] {false} ;
         T001236_A263FacturaPago = new decimal[1] ;
         T001236_n263FacturaPago = new bool[] {false} ;
         T001237_A41ClinicaCodigo = new String[] {""} ;
         T001237_A185FacturaId = new int[1] ;
         T001237_A260FacturaPId = new int[1] ;
         T001238_A41ClinicaCodigo = new String[] {""} ;
         T001238_A185FacturaId = new int[1] ;
         T001239_A185FacturaId = new int[1] ;
         T001239_A248FacturaDId = new int[1] ;
         T001239_A249FacturaDPrecio = new decimal[1] ;
         T001239_A250FacturaDCantidad = new decimal[1] ;
         T001239_A41ClinicaCodigo = new String[] {""} ;
         T001239_A30ArticuloCodigo = new String[] {""} ;
         T00124_A41ClinicaCodigo = new String[] {""} ;
         T001240_A41ClinicaCodigo = new String[] {""} ;
         T001241_A41ClinicaCodigo = new String[] {""} ;
         T001241_A185FacturaId = new int[1] ;
         T001241_A248FacturaDId = new int[1] ;
         T00123_A185FacturaId = new int[1] ;
         T00123_A248FacturaDId = new int[1] ;
         T00123_A249FacturaDPrecio = new decimal[1] ;
         T00123_A250FacturaDCantidad = new decimal[1] ;
         T00123_A41ClinicaCodigo = new String[] {""} ;
         T00123_A30ArticuloCodigo = new String[] {""} ;
         T00122_A185FacturaId = new int[1] ;
         T00122_A248FacturaDId = new int[1] ;
         T00122_A249FacturaDPrecio = new decimal[1] ;
         T00122_A250FacturaDCantidad = new decimal[1] ;
         T00122_A41ClinicaCodigo = new String[] {""} ;
         T00122_A30ArticuloCodigo = new String[] {""} ;
         T001245_A41ClinicaCodigo = new String[] {""} ;
         T001245_A185FacturaId = new int[1] ;
         T001245_A248FacturaDId = new int[1] ;
         imgprompt_30_Internalname = "" ;
         Gridfactura_facturadetalleRow = new GXWebRow();
         subGridfactura_facturadetalle_Linesclass = "" ;
         ROClassString = "" ;
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
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char12 = "" ;
         GXt_char11 = "" ;
         GXt_char13 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         T001246_A41ClinicaCodigo = new String[] {""} ;
         T001247_A41ClinicaCodigo = new String[] {""} ;
         T001248_A41ClinicaCodigo = new String[] {""} ;
         T001249_A4UsuarioCodigo = new String[] {""} ;
         T001250_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.factura__default(),
            new Object[][] {
                new Object[] {
               T00122_A185FacturaId, T00122_A248FacturaDId, T00122_A249FacturaDPrecio, T00122_A250FacturaDCantidad, T00122_A41ClinicaCodigo, T00122_A30ArticuloCodigo
               }
               , new Object[] {
               T00123_A185FacturaId, T00123_A248FacturaDId, T00123_A249FacturaDPrecio, T00123_A250FacturaDCantidad, T00123_A41ClinicaCodigo, T00123_A30ArticuloCodigo
               }
               , new Object[] {
               T00124_A41ClinicaCodigo
               }
               , new Object[] {
               T00125_A185FacturaId, T00125_A186FacturaFecha, T00125_A187FacturaHora, T00125_A188FacturaEstado, T00125_A189FacturaDocto, T00125_A190FacturaSerie, T00125_A191FacturaIva, T00125_A192FacturaCae1, T00125_A229FacturaCae2, T00125_A280FacturaFechaHora,
               T00125_A281CorteCajaIdF, T00125_A41ClinicaCodigo, T00125_A91ConsultaId, T00125_A132CajaCodigo, T00125_A178ClienteCodigo, T00125_A4UsuarioCodigo
               }
               , new Object[] {
               T00126_A185FacturaId, T00126_A186FacturaFecha, T00126_A187FacturaHora, T00126_A188FacturaEstado, T00126_A189FacturaDocto, T00126_A190FacturaSerie, T00126_A191FacturaIva, T00126_A192FacturaCae1, T00126_A229FacturaCae2, T00126_A280FacturaFechaHora,
               T00126_A281CorteCajaIdF, T00126_A41ClinicaCodigo, T00126_A91ConsultaId, T00126_A132CajaCodigo, T00126_A178ClienteCodigo, T00126_A4UsuarioCodigo
               }
               , new Object[] {
               T00127_A41ClinicaCodigo
               }
               , new Object[] {
               T00128_A41ClinicaCodigo
               }
               , new Object[] {
               T00129_A41ClinicaCodigo
               }
               , new Object[] {
               T001210_A4UsuarioCodigo
               }
               , new Object[] {
               T001212_A247FacturaTotal, T001212_n247FacturaTotal
               }
               , new Object[] {
               T001214_A263FacturaPago, T001214_n263FacturaPago
               }
               , new Object[] {
               T001217_A185FacturaId, T001217_A186FacturaFecha, T001217_A187FacturaHora, T001217_A188FacturaEstado, T001217_A189FacturaDocto, T001217_A190FacturaSerie, T001217_A191FacturaIva, T001217_A192FacturaCae1, T001217_A229FacturaCae2, T001217_A280FacturaFechaHora,
               T001217_A281CorteCajaIdF, T001217_A41ClinicaCodigo, T001217_A91ConsultaId, T001217_A132CajaCodigo, T001217_A178ClienteCodigo, T001217_A4UsuarioCodigo, T001217_A247FacturaTotal, T001217_n247FacturaTotal, T001217_A263FacturaPago, T001217_n263FacturaPago
               }
               , new Object[] {
               T001218_A41ClinicaCodigo
               }
               , new Object[] {
               T001219_A41ClinicaCodigo
               }
               , new Object[] {
               T001220_A41ClinicaCodigo
               }
               , new Object[] {
               T001222_A247FacturaTotal, T001222_n247FacturaTotal
               }
               , new Object[] {
               T001224_A263FacturaPago, T001224_n263FacturaPago
               }
               , new Object[] {
               T001225_A4UsuarioCodigo
               }
               , new Object[] {
               T001226_A41ClinicaCodigo, T001226_A185FacturaId
               }
               , new Object[] {
               T001227_A41ClinicaCodigo, T001227_A185FacturaId
               }
               , new Object[] {
               T001228_A41ClinicaCodigo, T001228_A185FacturaId
               }
               , new Object[] {
               T001229_A185FacturaId, T001229_A186FacturaFecha, T001229_A187FacturaHora, T001229_A188FacturaEstado, T001229_A189FacturaDocto, T001229_A190FacturaSerie, T001229_A191FacturaIva, T001229_A192FacturaCae1, T001229_A229FacturaCae2, T001229_A280FacturaFechaHora,
               T001229_A281CorteCajaIdF, T001229_A41ClinicaCodigo, T001229_A91ConsultaId, T001229_A132CajaCodigo, T001229_A178ClienteCodigo, T001229_A4UsuarioCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001234_A247FacturaTotal, T001234_n247FacturaTotal
               }
               , new Object[] {
               T001236_A263FacturaPago, T001236_n263FacturaPago
               }
               , new Object[] {
               T001237_A41ClinicaCodigo, T001237_A185FacturaId, T001237_A260FacturaPId
               }
               , new Object[] {
               T001238_A41ClinicaCodigo, T001238_A185FacturaId
               }
               , new Object[] {
               T001239_A185FacturaId, T001239_A248FacturaDId, T001239_A249FacturaDPrecio, T001239_A250FacturaDCantidad, T001239_A41ClinicaCodigo, T001239_A30ArticuloCodigo
               }
               , new Object[] {
               T001240_A41ClinicaCodigo
               }
               , new Object[] {
               T001241_A41ClinicaCodigo, T001241_A185FacturaId, T001241_A248FacturaDId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001245_A41ClinicaCodigo, T001245_A185FacturaId, T001245_A248FacturaDId
               }
               , new Object[] {
               T001246_A41ClinicaCodigo
               }
               , new Object[] {
               T001247_A41ClinicaCodigo
               }
               , new Object[] {
               T001248_A41ClinicaCodigo
               }
               , new Object[] {
               T001249_A4UsuarioCodigo
               }
               , new Object[] {
               T001250_A41ClinicaCodigo
               }
            }
         );
      }

      private short nIsMod_60 ;
      private short GxWebError ;
      private short nRC_Gridfactura_facturadetalle ;
      private short nGXsfl_130_idx=1 ;
      private short gxcookieaux ;
      private short A188FacturaEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridfactura_facturadetalle_Backcolorstyle ;
      private short subGridfactura_facturadetalle_Allowcollapsing ;
      private short subGridfactura_facturadetalle_Collapsed ;
      private short nBlankRcdCount60 ;
      private short nRcdExists_60 ;
      private short RcdFound60 ;
      private short nBlankRcdUsr60 ;
      private short Z188FacturaEstado ;
      private short nRcdDeleted_60 ;
      private short GX_JID ;
      private short RcdFound49 ;
      private short Gx_BScreen ;
      private short subGridfactura_facturadetalle_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A91ConsultaId ;
      private int A185FacturaId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtFacturaId_Enabled ;
      private int edtFacturaFecha_Enabled ;
      private int edtFacturaHora_Enabled ;
      private int edtClienteCodigo_Enabled ;
      private int imgprompt_41_178_Visible ;
      private int A189FacturaDocto ;
      private int edtFacturaDocto_Enabled ;
      private int edtFacturaSerie_Enabled ;
      private int edtFacturaIva_Enabled ;
      private int edtFacturaTotal_Enabled ;
      private int edtFacturaPago_Enabled ;
      private int edtFacturaCae1_Enabled ;
      private int edtFacturaCae2_Enabled ;
      private int edtConsultaId_Enabled ;
      private int imgprompt_41_91_Visible ;
      private int edtCajaCodigo_Enabled ;
      private int imgprompt_41_132_Visible ;
      private int edtUsuarioCodigo_Enabled ;
      private int imgprompt_4_Visible ;
      private int edtFacturaFechaHora_Enabled ;
      private int A281CorteCajaIdF ;
      private int edtCorteCajaIdF_Enabled ;
      private int A248FacturaDId ;
      private int edtFacturaDId_Enabled ;
      private int edtArticuloCodigo_Enabled ;
      private int edtFacturaDPrecio_Enabled ;
      private int edtFacturaDCantidad_Enabled ;
      private int edtFacturaDTotal_Enabled ;
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
      private int Z185FacturaId ;
      private int Z189FacturaDocto ;
      private int Z281CorteCajaIdF ;
      private int Z91ConsultaId ;
      private int GRIDFACTURA_FACTURADETALLE_nFirstRecordOnPage ;
      private int Z248FacturaDId ;
      private int AnyError41 ;
      private int AnyError91 ;
      private int AnyError132 ;
      private int AnyError178 ;
      private int AnyError4 ;
      private int AnyError30 ;
      private int subGridfactura_facturadetalle_Backcolor ;
      private int subGridfactura_facturadetalle_Allbackcolor ;
      private int imgprompt_30_Visible ;
      private int defedtFacturaDId_Enabled ;
      private int idxLst ;
      private decimal A191FacturaIva ;
      private decimal A247FacturaTotal ;
      private decimal A263FacturaPago ;
      private decimal A249FacturaDPrecio ;
      private decimal A250FacturaDCantidad ;
      private decimal A251FacturaDTotal ;
      private decimal B247FacturaTotal ;
      private decimal Z191FacturaIva ;
      private decimal O247FacturaTotal ;
      private decimal s247FacturaTotal ;
      private decimal Z249FacturaDPrecio ;
      private decimal Z250FacturaDCantidad ;
      private decimal T251FacturaDTotal ;
      private decimal O251FacturaDTotal ;
      private decimal Z247FacturaTotal ;
      private decimal Z263FacturaPago ;
      private String sPrefix ;
      private String sGXsfl_130_idx="0001" ;
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
      private String lblTextblockfacturaid_Internalname ;
      private String lblTextblockfacturaid_Jsonclick ;
      private String edtFacturaId_Internalname ;
      private String edtFacturaId_Jsonclick ;
      private String lblTextblockfacturafecha_Internalname ;
      private String lblTextblockfacturafecha_Jsonclick ;
      private String edtFacturaFecha_Internalname ;
      private String edtFacturaFecha_Jsonclick ;
      private String lblTextblockfacturahora_Internalname ;
      private String lblTextblockfacturahora_Jsonclick ;
      private String A187FacturaHora ;
      private String edtFacturaHora_Internalname ;
      private String edtFacturaHora_Jsonclick ;
      private String lblTextblockfacturaestado_Internalname ;
      private String lblTextblockfacturaestado_Jsonclick ;
      private String cmbFacturaEstado_Internalname ;
      private String cmbFacturaEstado_Jsonclick ;
      private String lblTextblockclientecodigo_Internalname ;
      private String lblTextblockclientecodigo_Jsonclick ;
      private String edtClienteCodigo_Internalname ;
      private String edtClienteCodigo_Jsonclick ;
      private String imgprompt_41_178_Internalname ;
      private String imgprompt_41_178_Link ;
      private String lblTextblockfacturadocto_Internalname ;
      private String lblTextblockfacturadocto_Jsonclick ;
      private String edtFacturaDocto_Internalname ;
      private String edtFacturaDocto_Jsonclick ;
      private String lblTextblockfacturaserie_Internalname ;
      private String lblTextblockfacturaserie_Jsonclick ;
      private String edtFacturaSerie_Internalname ;
      private String edtFacturaSerie_Jsonclick ;
      private String lblTextblockfacturaiva_Internalname ;
      private String lblTextblockfacturaiva_Jsonclick ;
      private String edtFacturaIva_Internalname ;
      private String edtFacturaIva_Jsonclick ;
      private String lblTextblockfacturatotal_Internalname ;
      private String lblTextblockfacturatotal_Jsonclick ;
      private String edtFacturaTotal_Internalname ;
      private String edtFacturaTotal_Jsonclick ;
      private String lblTextblockfacturapago_Internalname ;
      private String lblTextblockfacturapago_Jsonclick ;
      private String edtFacturaPago_Internalname ;
      private String edtFacturaPago_Jsonclick ;
      private String lblTextblockfacturacae1_Internalname ;
      private String lblTextblockfacturacae1_Jsonclick ;
      private String edtFacturaCae1_Internalname ;
      private String lblTextblockfacturacae2_Internalname ;
      private String lblTextblockfacturacae2_Jsonclick ;
      private String edtFacturaCae2_Internalname ;
      private String lblTextblockconsultaid_Internalname ;
      private String lblTextblockconsultaid_Jsonclick ;
      private String edtConsultaId_Internalname ;
      private String edtConsultaId_Jsonclick ;
      private String imgprompt_41_91_Internalname ;
      private String imgprompt_41_91_Link ;
      private String lblTextblockcajacodigo_Internalname ;
      private String lblTextblockcajacodigo_Jsonclick ;
      private String edtCajaCodigo_Internalname ;
      private String edtCajaCodigo_Jsonclick ;
      private String imgprompt_41_132_Internalname ;
      private String imgprompt_41_132_Link ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_4_Link ;
      private String lblTextblockfacturafechahora_Internalname ;
      private String lblTextblockfacturafechahora_Jsonclick ;
      private String edtFacturaFechaHora_Internalname ;
      private String edtFacturaFechaHora_Jsonclick ;
      private String lblTextblockcortecajaidf_Internalname ;
      private String lblTextblockcortecajaidf_Jsonclick ;
      private String edtCorteCajaIdF_Internalname ;
      private String edtCorteCajaIdF_Jsonclick ;
      private String Gx_mode ;
      private String sMode60 ;
      private String edtFacturaDId_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlefacturadetalle_Internalname ;
      private String lblTitlefacturadetalle_Jsonclick ;
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
      private String Z187FacturaHora ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtArticuloCodigo_Internalname ;
      private String edtFacturaDPrecio_Internalname ;
      private String edtFacturaDCantidad_Internalname ;
      private String edtFacturaDTotal_Internalname ;
      private String sMode49 ;
      private String imgprompt_30_Internalname ;
      private String subGridfactura_facturadetalle_Class ;
      private String subGridfactura_facturadetalle_Linesclass ;
      private String imgprompt_30_Link ;
      private String ROClassString ;
      private String edtFacturaDId_Jsonclick ;
      private String edtArticuloCodigo_Jsonclick ;
      private String edtFacturaDPrecio_Jsonclick ;
      private String edtFacturaDCantidad_Jsonclick ;
      private String edtFacturaDTotal_Jsonclick ;
      private String GXCCtl ;
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
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char12 ;
      private String GXt_char11 ;
      private String subGridfactura_facturadetalle_Internalname ;
      private String GXt_char13 ;
      private DateTime A280FacturaFechaHora ;
      private DateTime Z280FacturaFechaHora ;
      private DateTime A186FacturaFecha ;
      private DateTime Z186FacturaFecha ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n247FacturaTotal ;
      private bool n263FacturaPago ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A132CajaCodigo ;
      private String A178ClienteCodigo ;
      private String A4UsuarioCodigo ;
      private String A30ArticuloCodigo ;
      private String A190FacturaSerie ;
      private String A192FacturaCae1 ;
      private String A229FacturaCae2 ;
      private String Z41ClinicaCodigo ;
      private String Z190FacturaSerie ;
      private String Z192FacturaCae1 ;
      private String Z229FacturaCae2 ;
      private String Z132CajaCodigo ;
      private String Z178ClienteCodigo ;
      private String Z4UsuarioCodigo ;
      private String Z30ArticuloCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridfactura_facturadetalleContainer ;
      private GXWebRow Gridfactura_facturadetalleRow ;
      private GXWebColumn Gridfactura_facturadetalleColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbFacturaEstado ;
      private IDataStoreProvider pr_default ;
      private int[] T001217_A185FacturaId ;
      private DateTime[] T001217_A186FacturaFecha ;
      private String[] T001217_A187FacturaHora ;
      private short[] T001217_A188FacturaEstado ;
      private int[] T001217_A189FacturaDocto ;
      private String[] T001217_A190FacturaSerie ;
      private decimal[] T001217_A191FacturaIva ;
      private String[] T001217_A192FacturaCae1 ;
      private String[] T001217_A229FacturaCae2 ;
      private DateTime[] T001217_A280FacturaFechaHora ;
      private int[] T001217_A281CorteCajaIdF ;
      private String[] T001217_A41ClinicaCodigo ;
      private int[] T001217_A91ConsultaId ;
      private String[] T001217_A132CajaCodigo ;
      private String[] T001217_A178ClienteCodigo ;
      private String[] T001217_A4UsuarioCodigo ;
      private decimal[] T001217_A247FacturaTotal ;
      private bool[] T001217_n247FacturaTotal ;
      private decimal[] T001217_A263FacturaPago ;
      private bool[] T001217_n263FacturaPago ;
      private String[] T00127_A41ClinicaCodigo ;
      private String[] T00128_A41ClinicaCodigo ;
      private String[] T00129_A41ClinicaCodigo ;
      private decimal[] T001212_A247FacturaTotal ;
      private bool[] T001212_n247FacturaTotal ;
      private decimal[] T001214_A263FacturaPago ;
      private bool[] T001214_n263FacturaPago ;
      private String[] T001210_A4UsuarioCodigo ;
      private String[] T001218_A41ClinicaCodigo ;
      private String[] T001219_A41ClinicaCodigo ;
      private String[] T001220_A41ClinicaCodigo ;
      private decimal[] T001222_A247FacturaTotal ;
      private bool[] T001222_n247FacturaTotal ;
      private decimal[] T001224_A263FacturaPago ;
      private bool[] T001224_n263FacturaPago ;
      private String[] T001225_A4UsuarioCodigo ;
      private String[] T001226_A41ClinicaCodigo ;
      private int[] T001226_A185FacturaId ;
      private int[] T00126_A185FacturaId ;
      private DateTime[] T00126_A186FacturaFecha ;
      private String[] T00126_A187FacturaHora ;
      private short[] T00126_A188FacturaEstado ;
      private int[] T00126_A189FacturaDocto ;
      private String[] T00126_A190FacturaSerie ;
      private decimal[] T00126_A191FacturaIva ;
      private String[] T00126_A192FacturaCae1 ;
      private String[] T00126_A229FacturaCae2 ;
      private DateTime[] T00126_A280FacturaFechaHora ;
      private int[] T00126_A281CorteCajaIdF ;
      private String[] T00126_A41ClinicaCodigo ;
      private int[] T00126_A91ConsultaId ;
      private String[] T00126_A132CajaCodigo ;
      private String[] T00126_A178ClienteCodigo ;
      private String[] T00126_A4UsuarioCodigo ;
      private String[] T001227_A41ClinicaCodigo ;
      private int[] T001227_A185FacturaId ;
      private String[] T001228_A41ClinicaCodigo ;
      private int[] T001228_A185FacturaId ;
      private int[] T001229_A185FacturaId ;
      private DateTime[] T001229_A186FacturaFecha ;
      private String[] T001229_A187FacturaHora ;
      private short[] T001229_A188FacturaEstado ;
      private int[] T001229_A189FacturaDocto ;
      private String[] T001229_A190FacturaSerie ;
      private decimal[] T001229_A191FacturaIva ;
      private String[] T001229_A192FacturaCae1 ;
      private String[] T001229_A229FacturaCae2 ;
      private DateTime[] T001229_A280FacturaFechaHora ;
      private int[] T001229_A281CorteCajaIdF ;
      private String[] T001229_A41ClinicaCodigo ;
      private int[] T001229_A91ConsultaId ;
      private String[] T001229_A132CajaCodigo ;
      private String[] T001229_A178ClienteCodigo ;
      private String[] T001229_A4UsuarioCodigo ;
      private decimal[] T001234_A247FacturaTotal ;
      private bool[] T001234_n247FacturaTotal ;
      private decimal[] T001236_A263FacturaPago ;
      private bool[] T001236_n263FacturaPago ;
      private String[] T001237_A41ClinicaCodigo ;
      private int[] T001237_A185FacturaId ;
      private int[] T001237_A260FacturaPId ;
      private String[] T001238_A41ClinicaCodigo ;
      private int[] T001238_A185FacturaId ;
      private int[] T001239_A185FacturaId ;
      private int[] T001239_A248FacturaDId ;
      private decimal[] T001239_A249FacturaDPrecio ;
      private decimal[] T001239_A250FacturaDCantidad ;
      private String[] T001239_A41ClinicaCodigo ;
      private String[] T001239_A30ArticuloCodigo ;
      private String[] T00124_A41ClinicaCodigo ;
      private String[] T001240_A41ClinicaCodigo ;
      private String[] T001241_A41ClinicaCodigo ;
      private int[] T001241_A185FacturaId ;
      private int[] T001241_A248FacturaDId ;
      private int[] T00123_A185FacturaId ;
      private int[] T00123_A248FacturaDId ;
      private decimal[] T00123_A249FacturaDPrecio ;
      private decimal[] T00123_A250FacturaDCantidad ;
      private String[] T00123_A41ClinicaCodigo ;
      private String[] T00123_A30ArticuloCodigo ;
      private int[] T00122_A185FacturaId ;
      private int[] T00122_A248FacturaDId ;
      private decimal[] T00122_A249FacturaDPrecio ;
      private decimal[] T00122_A250FacturaDCantidad ;
      private String[] T00122_A41ClinicaCodigo ;
      private String[] T00122_A30ArticuloCodigo ;
      private String[] T001245_A41ClinicaCodigo ;
      private int[] T001245_A185FacturaId ;
      private int[] T001245_A248FacturaDId ;
      private String[] T001246_A41ClinicaCodigo ;
      private String[] T001247_A41ClinicaCodigo ;
      private String[] T001248_A41ClinicaCodigo ;
      private String[] T001249_A4UsuarioCodigo ;
      private String[] T001250_A41ClinicaCodigo ;
      private int[] T00125_A185FacturaId ;
      private DateTime[] T00125_A186FacturaFecha ;
      private String[] T00125_A187FacturaHora ;
      private short[] T00125_A188FacturaEstado ;
      private int[] T00125_A189FacturaDocto ;
      private String[] T00125_A190FacturaSerie ;
      private decimal[] T00125_A191FacturaIva ;
      private String[] T00125_A192FacturaCae1 ;
      private String[] T00125_A229FacturaCae2 ;
      private DateTime[] T00125_A280FacturaFechaHora ;
      private int[] T00125_A281CorteCajaIdF ;
      private String[] T00125_A41ClinicaCodigo ;
      private int[] T00125_A91ConsultaId ;
      private String[] T00125_A132CajaCodigo ;
      private String[] T00125_A178ClienteCodigo ;
      private String[] T00125_A4UsuarioCodigo ;
      private GXWebForm Form ;
   }

   public class factura__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new UpdateCursor(def[32])
         ,new UpdateCursor(def[33])
         ,new UpdateCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new ForEachCursor(def[36])
         ,new ForEachCursor(def[37])
         ,new ForEachCursor(def[38])
         ,new ForEachCursor(def[39])
         ,new ForEachCursor(def[40])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00125 ;
          prmT00125 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001217 ;
          prmT001217 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00127 ;
          prmT00127 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00128 ;
          prmT00128 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00129 ;
          prmT00129 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001212 ;
          prmT001212 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001214 ;
          prmT001214 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001210 ;
          prmT001210 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001218 ;
          prmT001218 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001219 ;
          prmT001219 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001220 ;
          prmT001220 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001222 ;
          prmT001222 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001224 ;
          prmT001224 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001225 ;
          prmT001225 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001226 ;
          prmT001226 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00126 ;
          prmT00126 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001227 ;
          prmT001227 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001228 ;
          prmT001228 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001229 ;
          prmT001229 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001230 ;
          prmT001230 = new Object[] {
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@FacturaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@FacturaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FacturaDocto",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@FacturaIva",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaCae1",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@FacturaCae2",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@FacturaFechaHora",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CorteCajaIdF",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001231 ;
          prmT001231 = new Object[] {
          new Object[] {"@FacturaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@FacturaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@FacturaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FacturaDocto",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@FacturaIva",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaCae1",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@FacturaCae2",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@FacturaFechaHora",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CorteCajaIdF",SqlDbType.Int,9,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001232 ;
          prmT001232 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001237 ;
          prmT001237 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001238 ;
          prmT001238 = new Object[] {
          } ;
          Object[] prmT001239 ;
          prmT001239 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00124 ;
          prmT00124 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001240 ;
          prmT001240 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001241 ;
          prmT001241 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00123 ;
          prmT00123 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00122 ;
          prmT00122 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001242 ;
          prmT001242 = new Object[] {
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaDCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001243 ;
          prmT001243 = new Object[] {
          new Object[] {"@FacturaDPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaDCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001244 ;
          prmT001244 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001245 ;
          prmT001245 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001234 ;
          prmT001234 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001236 ;
          prmT001236 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001246 ;
          prmT001246 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001247 ;
          prmT001247 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001248 ;
          prmT001248 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001249 ;
          prmT001249 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001250 ;
          prmT001250 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00122", "SELECT [FacturaId], [FacturaDId], [FacturaDPrecio], [FacturaDCantidad], [ClinicaCodigo], [ArticuloCodigo] FROM [FacturaDetalle] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaDId] = @FacturaDId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00122,1,0,true,false )
             ,new CursorDef("T00123", "SELECT [FacturaId], [FacturaDId], [FacturaDPrecio], [FacturaDCantidad], [ClinicaCodigo], [ArticuloCodigo] FROM [FacturaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaDId] = @FacturaDId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00123,1,0,true,false )
             ,new CursorDef("T00124", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00124,1,0,true,false )
             ,new CursorDef("T00125", "SELECT [FacturaId], [FacturaFecha], [FacturaHora], [FacturaEstado], [FacturaDocto], [FacturaSerie], [FacturaIva], [FacturaCae1], [FacturaCae2], [FacturaFechaHora], [CorteCajaIdF], [ClinicaCodigo], [ConsultaId], [CajaCodigo], [ClienteCodigo], [UsuarioCodigo] FROM [Factura] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00125,1,0,true,false )
             ,new CursorDef("T00126", "SELECT [FacturaId], [FacturaFecha], [FacturaHora], [FacturaEstado], [FacturaDocto], [FacturaSerie], [FacturaIva], [FacturaCae1], [FacturaCae2], [FacturaFechaHora], [CorteCajaIdF], [ClinicaCodigo], [ConsultaId], [CajaCodigo], [ClienteCodigo], [UsuarioCodigo] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00126,1,0,true,false )
             ,new CursorDef("T00127", "SELECT [ClinicaCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00127,1,0,true,false )
             ,new CursorDef("T00128", "SELECT [ClinicaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00128,1,0,true,false )
             ,new CursorDef("T00129", "SELECT [ClinicaCodigo] FROM [Cliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00129,1,0,true,false )
             ,new CursorDef("T001210", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001210,1,0,true,false )
             ,new CursorDef("T001212", "SELECT COALESCE( T1.[FacturaTotal], 0) AS FacturaTotal FROM (SELECT SUM([FacturaDPrecio] * CAST([FacturaDCantidad] AS decimal( 22, 5))) AS FacturaTotal, [ClinicaCodigo], [FacturaId] FROM [FacturaDetalle] WITH (UPDLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T1 WHERE T1.[ClinicaCodigo] = @ClinicaCodigo AND T1.[FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001212,1,0,true,false )
             ,new CursorDef("T001214", "SELECT COALESCE( T1.[FacturaPago], 0) AS FacturaPago FROM (SELECT SUM([FacturaPMonto]) AS FacturaPago, [ClinicaCodigo], [FacturaId] FROM [FacturaPago] WITH (NOLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T1 WHERE T1.[ClinicaCodigo] = @ClinicaCodigo AND T1.[FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001214,1,0,true,false )
             ,new CursorDef("T001217", "SELECT TM1.[FacturaId], TM1.[FacturaFecha], TM1.[FacturaHora], TM1.[FacturaEstado], TM1.[FacturaDocto], TM1.[FacturaSerie], TM1.[FacturaIva], TM1.[FacturaCae1], TM1.[FacturaCae2], TM1.[FacturaFechaHora], TM1.[CorteCajaIdF], TM1.[ClinicaCodigo], TM1.[ConsultaId], TM1.[CajaCodigo], TM1.[ClienteCodigo], TM1.[UsuarioCodigo], COALESCE( T2.[FacturaTotal], 0) AS FacturaTotal, COALESCE( T3.[FacturaPago], 0) AS FacturaPago FROM (([Factura] TM1 WITH (NOLOCK) LEFT JOIN (SELECT SUM([FacturaDPrecio] * CAST([FacturaDCantidad] AS decimal( 22, 5))) AS FacturaTotal, [ClinicaCodigo], [FacturaId] FROM [FacturaDetalle] WITH (NOLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T2 ON T2.[ClinicaCodigo] = TM1.[ClinicaCodigo] AND T2.[FacturaId] = TM1.[FacturaId]) LEFT JOIN (SELECT SUM([FacturaPMonto]) AS FacturaPago, [ClinicaCodigo], [FacturaId] FROM [FacturaPago] WITH (NOLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T3 ON T3.[ClinicaCodigo] = TM1.[ClinicaCodigo] AND T3.[FacturaId] = TM1.[FacturaId]) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[FacturaId] = @FacturaId ORDER BY TM1.[ClinicaCodigo], TM1.[FacturaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001217,100,0,true,false )
             ,new CursorDef("T001218", "SELECT [ClinicaCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001218,1,0,true,false )
             ,new CursorDef("T001219", "SELECT [ClinicaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001219,1,0,true,false )
             ,new CursorDef("T001220", "SELECT [ClinicaCodigo] FROM [Cliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001220,1,0,true,false )
             ,new CursorDef("T001222", "SELECT COALESCE( T1.[FacturaTotal], 0) AS FacturaTotal FROM (SELECT SUM([FacturaDPrecio] * CAST([FacturaDCantidad] AS decimal( 22, 5))) AS FacturaTotal, [ClinicaCodigo], [FacturaId] FROM [FacturaDetalle] WITH (UPDLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T1 WHERE T1.[ClinicaCodigo] = @ClinicaCodigo AND T1.[FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001222,1,0,true,false )
             ,new CursorDef("T001224", "SELECT COALESCE( T1.[FacturaPago], 0) AS FacturaPago FROM (SELECT SUM([FacturaPMonto]) AS FacturaPago, [ClinicaCodigo], [FacturaId] FROM [FacturaPago] WITH (NOLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T1 WHERE T1.[ClinicaCodigo] = @ClinicaCodigo AND T1.[FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001224,1,0,true,false )
             ,new CursorDef("T001225", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001225,1,0,true,false )
             ,new CursorDef("T001226", "SELECT [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001226,1,0,true,false )
             ,new CursorDef("T001227", "SELECT TOP 1 [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] > @FacturaId) ORDER BY [ClinicaCodigo], [FacturaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001227,1,0,true,true )
             ,new CursorDef("T001228", "SELECT TOP 1 [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] < @FacturaId) ORDER BY [ClinicaCodigo] DESC, [FacturaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001228,1,0,true,true )
             ,new CursorDef("T001229", "SELECT [FacturaId], [FacturaFecha], [FacturaHora], [FacturaEstado], [FacturaDocto], [FacturaSerie], [FacturaIva], [FacturaCae1], [FacturaCae2], [FacturaFechaHora], [CorteCajaIdF], [ClinicaCodigo], [ConsultaId], [CajaCodigo], [ClienteCodigo], [UsuarioCodigo] FROM [Factura] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001229,1,0,true,false )
             ,new CursorDef("T001230", "INSERT INTO [Factura] ([FacturaId], [FacturaFecha], [FacturaHora], [FacturaEstado], [FacturaDocto], [FacturaSerie], [FacturaIva], [FacturaCae1], [FacturaCae2], [FacturaFechaHora], [CorteCajaIdF], [ClinicaCodigo], [ConsultaId], [CajaCodigo], [ClienteCodigo], [UsuarioCodigo]) VALUES (@FacturaId, @FacturaFecha, @FacturaHora, @FacturaEstado, @FacturaDocto, @FacturaSerie, @FacturaIva, @FacturaCae1, @FacturaCae2, @FacturaFechaHora, @CorteCajaIdF, @ClinicaCodigo, @ConsultaId, @CajaCodigo, @ClienteCodigo, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmT001230)
             ,new CursorDef("T001231", "UPDATE [Factura] SET [FacturaFecha]=@FacturaFecha, [FacturaHora]=@FacturaHora, [FacturaEstado]=@FacturaEstado, [FacturaDocto]=@FacturaDocto, [FacturaSerie]=@FacturaSerie, [FacturaIva]=@FacturaIva, [FacturaCae1]=@FacturaCae1, [FacturaCae2]=@FacturaCae2, [FacturaFechaHora]=@FacturaFechaHora, [CorteCajaIdF]=@CorteCajaIdF, [ConsultaId]=@ConsultaId, [CajaCodigo]=@CajaCodigo, [ClienteCodigo]=@ClienteCodigo, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId", GxErrorMask.GX_NOMASK,prmT001231)
             ,new CursorDef("T001232", "DELETE FROM [Factura]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId", GxErrorMask.GX_NOMASK,prmT001232)
             ,new CursorDef("T001234", "SELECT COALESCE( T1.[FacturaTotal], 0) AS FacturaTotal FROM (SELECT SUM([FacturaDPrecio] * CAST([FacturaDCantidad] AS decimal( 22, 5))) AS FacturaTotal, [ClinicaCodigo], [FacturaId] FROM [FacturaDetalle] WITH (UPDLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T1 WHERE T1.[ClinicaCodigo] = @ClinicaCodigo AND T1.[FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001234,1,0,true,false )
             ,new CursorDef("T001236", "SELECT COALESCE( T1.[FacturaPago], 0) AS FacturaPago FROM (SELECT SUM([FacturaPMonto]) AS FacturaPago, [ClinicaCodigo], [FacturaId] FROM [FacturaPago] WITH (NOLOCK) GROUP BY [ClinicaCodigo], [FacturaId] ) T1 WHERE T1.[ClinicaCodigo] = @ClinicaCodigo AND T1.[FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001236,1,0,true,false )
             ,new CursorDef("T001237", "SELECT TOP 1 [ClinicaCodigo], [FacturaId], [FacturaPId] FROM [FacturaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001237,1,0,true,true )
             ,new CursorDef("T001238", "SELECT [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [FacturaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001238,100,0,true,false )
             ,new CursorDef("T001239", "SELECT [FacturaId], [FacturaDId], [FacturaDPrecio], [FacturaDCantidad], [ClinicaCodigo], [ArticuloCodigo] FROM [FacturaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] = @FacturaId and [FacturaDId] = @FacturaDId ORDER BY [ClinicaCodigo], [FacturaId], [FacturaDId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001239,11,0,true,false )
             ,new CursorDef("T001240", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001240,1,0,true,false )
             ,new CursorDef("T001241", "SELECT [ClinicaCodigo], [FacturaId], [FacturaDId] FROM [FacturaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaDId] = @FacturaDId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001241,1,0,true,false )
             ,new CursorDef("T001242", "INSERT INTO [FacturaDetalle] ([FacturaId], [FacturaDId], [FacturaDPrecio], [FacturaDCantidad], [ClinicaCodigo], [ArticuloCodigo]) VALUES (@FacturaId, @FacturaDId, @FacturaDPrecio, @FacturaDCantidad, @ClinicaCodigo, @ArticuloCodigo)", GxErrorMask.GX_NOMASK,prmT001242)
             ,new CursorDef("T001243", "UPDATE [FacturaDetalle] SET [FacturaDPrecio]=@FacturaDPrecio, [FacturaDCantidad]=@FacturaDCantidad, [ArticuloCodigo]=@ArticuloCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaDId] = @FacturaDId", GxErrorMask.GX_NOMASK,prmT001243)
             ,new CursorDef("T001244", "DELETE FROM [FacturaDetalle]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId AND [FacturaDId] = @FacturaDId", GxErrorMask.GX_NOMASK,prmT001244)
             ,new CursorDef("T001245", "SELECT [ClinicaCodigo], [FacturaId], [FacturaDId] FROM [FacturaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] = @FacturaId ORDER BY [ClinicaCodigo], [FacturaId], [FacturaDId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001245,11,0,true,false )
             ,new CursorDef("T001246", "SELECT [ClinicaCodigo] FROM [Cliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001246,1,0,true,false )
             ,new CursorDef("T001247", "SELECT [ClinicaCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001247,1,0,true,false )
             ,new CursorDef("T001248", "SELECT [ClinicaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001248,1,0,true,false )
             ,new CursorDef("T001249", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001249,1,0,true,false )
             ,new CursorDef("T001250", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001250,1,0,true,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(10) ;
                ((int[]) buf[10])[0] = rslt.getInt(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((int[]) buf[12])[0] = rslt.getInt(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(10) ;
                ((int[]) buf[10])[0] = rslt.getInt(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((int[]) buf[12])[0] = rslt.getInt(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 9 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 10 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(10) ;
                ((int[]) buf[10])[0] = rslt.getInt(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((int[]) buf[12])[0] = rslt.getInt(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((decimal[]) buf[16])[0] = rslt.getDecimal(17) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(17);
                ((decimal[]) buf[18])[0] = rslt.getDecimal(18) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(18);
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 15 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 16 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 21 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(10) ;
                ((int[]) buf[10])[0] = rslt.getInt(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((int[]) buf[12])[0] = rslt.getInt(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                break;
             case 25 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 26 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 29 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 30 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 31 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 35 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 36 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 37 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 38 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 39 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 40 :
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
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
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
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (DateTime)parms[9]);
                stmt.SetParameter(11, (int)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (int)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
                break;
             case 23 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (DateTime)parms[8]);
                stmt.SetParameter(10, (int)parms[9]);
                stmt.SetParameter(11, (int)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (int)parms[15]);
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 26 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 27 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 29 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 30 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 31 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 32 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 33 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                break;
             case 34 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 35 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 36 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 37 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 38 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 39 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 40 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
