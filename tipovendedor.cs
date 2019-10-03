/*
               File: TipoVendedor
        Description: Tipo Vendedor
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:32.48
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
   public class tipovendedor : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridtipovendedor_tiporango") == 0 )
         {
            nRC_Gridtipovendedor_tiporango = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_65_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_65_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridtipovendedor_tiporango_newrow( nRC_Gridtipovendedor_tiporango, nGXsfl_65_idx, sGXsfl_65_idx) ;
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
         cmbTipoVendedorEsJefe.Name = "TIPOVENDEDORESJEFE" ;
         cmbTipoVendedorEsJefe.WebTags = "" ;
         cmbTipoVendedorEsJefe.addItem("0", "No", 0);
         cmbTipoVendedorEsJefe.addItem("1", "Si", 0);
         if ( ( cmbTipoVendedorEsJefe.ItemCount > 0 ) && (0==A378TipoVendedorEsJefe) )
         {
            A378TipoVendedorEsJefe = (short)(NumberUtil.Val( cmbTipoVendedorEsJefe.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378TipoVendedorEsJefe", StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0));
         }
         cmbTipoVendedorEstado.Name = "TIPOVENDEDORESTADO" ;
         cmbTipoVendedorEstado.WebTags = "" ;
         cmbTipoVendedorEstado.addItem("0", "De baja", 0);
         cmbTipoVendedorEstado.addItem("1", "Activo", 0);
         if ( ( cmbTipoVendedorEstado.ItemCount > 0 ) && (0==A372TipoVendedorEstado) )
         {
            A372TipoVendedorEstado = (short)(NumberUtil.Val( cmbTipoVendedorEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372TipoVendedorEstado", StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Tipo Vendedor", 0) ;
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

      public tipovendedor( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public tipovendedor( IGxContext context )
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
         cmbTipoVendedorEsJefe = new GXCombobox();
         cmbTipoVendedorEstado = new GXCombobox();
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
            wb_table1_2_1O76( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1O76e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1O76( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1O76( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1O76e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Tipo Vendedor"+"</legend>") ;
            wb_table3_27_1O76( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1O76e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1O76e( true) ;
         }
         else
         {
            wb_table1_2_1O76e( false) ;
         }
      }

      protected void wb_table3_27_1O76( bool wbgen )
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
            wb_table4_33_1O76( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1O76e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_TipoVendedor.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_TipoVendedor.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1O76e( true) ;
         }
         else
         {
            wb_table3_27_1O76e( false) ;
         }
      }

      protected void wb_table4_33_1O76( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_TipoVendedor.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipovendedorid_Internalname, "Vendedor", "", "", lblTextblocktipovendedorid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoVendedorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A370TipoVendedorId), 9, 0, ".", "")), ((edtTipoVendedorId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A370TipoVendedorId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A370TipoVendedorId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtTipoVendedorId_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoVendedorId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipovendedornombre_Internalname, "Descripción", "", "", lblTextblocktipovendedornombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A371TipoVendedorNombre", A371TipoVendedorNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoVendedorNombre_Internalname, StringUtil.RTrim( A371TipoVendedorNombre), StringUtil.RTrim( context.localUtil.Format( A371TipoVendedorNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtTipoVendedorNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoVendedorNombre_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipovendedoresjefe_Internalname, "Jefe?", "", "", lblTextblocktipovendedoresjefe_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378TipoVendedorEsJefe", StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoVendedorEsJefe, cmbTipoVendedorEsJefe_Internalname, StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0), 1, cmbTipoVendedorEsJefe_Jsonclick, 0, "", "int", "", 1, cmbTipoVendedorEsJefe.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", true, "HLP_TipoVendedor.htm");
            cmbTipoVendedorEsJefe.CurrentValue = StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoVendedorEsJefe_Internalname, "Values", (String)(cmbTipoVendedorEsJefe.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipovendedorestado_Internalname, "Estado", "", "", lblTextblocktipovendedorestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372TipoVendedorEstado", StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTipoVendedorEstado, cmbTipoVendedorEstado_Internalname, StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0), 1, cmbTipoVendedorEstado_Jsonclick, 0, "", "int", "", 1, cmbTipoVendedorEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", true, "HLP_TipoVendedor.htm");
            cmbTipoVendedorEstado.CurrentValue = StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoVendedorEstado_Internalname, "Values", (String)(cmbTipoVendedorEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_61_1O76( true) ;
         }
         return  ;
      }

      protected void wb_table5_61_1O76e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("GridName", "Gridtipovendedor_tiporango");
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("Class", "Grid");
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtipovendedor_tiporango_Backcolorstyle), 1, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("CmpContext", "");
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("InMasterPage", "false");
            Gridtipovendedor_tiporangoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A373TipoRangoId), 9, 0, ".", "")));
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoId_Enabled), 5, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddColumnProperties(Gridtipovendedor_tiporangoColumn);
            Gridtipovendedor_tiporangoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Value", StringUtil.RTrim( A374TipoRangoNombre));
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoNombre_Enabled), 5, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddColumnProperties(Gridtipovendedor_tiporangoColumn);
            Gridtipovendedor_tiporangoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A375TipoRangoInicial, 17, 2, ".", "")));
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoInicial_Enabled), 5, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddColumnProperties(Gridtipovendedor_tiporangoColumn);
            Gridtipovendedor_tiporangoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A376TipoRangoFinal, 17, 2, ".", "")));
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoFinal_Enabled), 5, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddColumnProperties(Gridtipovendedor_tiporangoColumn);
            Gridtipovendedor_tiporangoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A377TipoRangoPorcentaje, 17, 2, ".", "")));
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoPorcentaje_Enabled), 5, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddColumnProperties(Gridtipovendedor_tiporangoColumn);
            Gridtipovendedor_tiporangoColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A379TipoRangoPorcentajeJefe, 17, 2, ".", "")));
            Gridtipovendedor_tiporangoColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoPorcentajeJefe_Enabled), 5, 0, ".", "")));
            Gridtipovendedor_tiporangoContainer.AddColumnProperties(Gridtipovendedor_tiporangoColumn);
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("Allowselection", "false");
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("Allowcollapsing", ((subGridtipovendedor_tiporango_Allowcollapsing==1) ? "true" : "false"));
            Gridtipovendedor_tiporangoContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridtipovendedor_tiporango_Collapsed), 9, 0, ".", "")));
            nGXsfl_65_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount77 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_77 = 1 ;
                  ScanStart1O77( ) ;
                  while ( RcdFound77 != 0 )
                  {
                     init_level_properties77( ) ;
                     getByPrimaryKey1O77( ) ;
                     AddRow1O77( ) ;
                     ScanNext1O77( ) ;
                  }
                  ScanEnd1O77( ) ;
                  nBlankRcdCount77 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal1O77( ) ;
               standaloneModal1O77( ) ;
               sMode77 = Gx_mode ;
               while ( nGXsfl_65_idx < nRC_Gridtipovendedor_tiporango )
               {
                  ReadRow1O77( ) ;
                  edtTipoRangoId_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOID_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  edtTipoRangoNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGONOMBRE_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  edtTipoRangoInicial_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOINICIAL_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  edtTipoRangoFinal_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOFINAL_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  edtTipoRangoPorcentaje_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  edtTipoRangoPorcentajeJefe_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_77 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal1O77( ) ;
                  }
                  SendRow1O77( ) ;
               }
               Gx_mode = sMode77 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount77 = 5 ;
               nRcdExists_77 = 1 ;
               ScanStart1O77( ) ;
               while ( RcdFound77 != 0 )
               {
                  init_level_properties77( ) ;
                  getByPrimaryKey1O77( ) ;
                  standaloneNotModal1O77( ) ;
                  standaloneModal1O77( ) ;
                  AddRow1O77( ) ;
                  ScanNext1O77( ) ;
               }
               ScanEnd1O77( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode77 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll1O77( ) ;
            init_level_properties77( ) ;
            standaloneNotModal1O77( ) ;
            standaloneModal1O77( ) ;
            nRcdExists_77 = 0 ;
            nIsMod_77 = 0 ;
            nBlankRcdCount77 = (short)(nBlankRcdUsr77+nBlankRcdCount77) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount77 > 0 )
            {
               AddRow1O77( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtTipoRangoId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount77 = (short)(nBlankRcdCount77-1) ;
            }
            Gx_mode = sMode77 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridtipovendedor_tiporangoContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridtipovendedor_tiporango", (Object)(Gridtipovendedor_tiporangoContainer));
            GxWebStd.gx_hidden_field( context, "Gridtipovendedor_tiporangoContainerData", Gridtipovendedor_tiporangoContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridtipovendedor_tiporangoContainerData"+"V", Gridtipovendedor_tiporangoContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridtipovendedor_tiporangoContainerData"+"V"+"\" value='"+Gridtipovendedor_tiporangoContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1O76e( true) ;
         }
         else
         {
            wb_table4_33_1O76e( false) ;
         }
      }

      protected void wb_table5_61_1O76( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitletiporango_Internalname, "Tipo Rango", "", "", lblTitletiporango_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_TipoVendedor.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_61_1O76e( true) ;
         }
         else
         {
            wb_table5_61_1O76e( false) ;
         }
      }

      protected void wb_table2_5_1O76( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0240.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOVENDEDORID"+"'), id:'"+"TIPOVENDEDORID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0240.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOVENDEDORID"+"'), id:'"+"TIPOVENDEDORID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TipoVendedor.htm");
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
            wb_table2_5_1O76e( true) ;
         }
         else
         {
            wb_table2_5_1O76e( false) ;
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
         /* Execute user event: E111O2 */
         E111O2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtTipoVendedorId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoVendedorId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPOVENDEDORID");
                  AnyError = 1 ;
                  GX_FocusControl = edtTipoVendedorId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A370TipoVendedorId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
               }
               else
               {
                  A370TipoVendedorId = (int)(context.localUtil.CToN( cgiGet( edtTipoVendedorId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
               }
               A371TipoVendedorNombre = cgiGet( edtTipoVendedorNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A371TipoVendedorNombre", A371TipoVendedorNombre);
               cmbTipoVendedorEsJefe.Name = cmbTipoVendedorEsJefe_Internalname ;
               cmbTipoVendedorEsJefe.CurrentValue = cgiGet( cmbTipoVendedorEsJefe_Internalname) ;
               A378TipoVendedorEsJefe = (short)(NumberUtil.Val( cgiGet( cmbTipoVendedorEsJefe_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378TipoVendedorEsJefe", StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0));
               cmbTipoVendedorEstado.Name = cmbTipoVendedorEstado_Internalname ;
               cmbTipoVendedorEstado.CurrentValue = cgiGet( cmbTipoVendedorEstado_Internalname) ;
               A372TipoVendedorEstado = (short)(NumberUtil.Val( cgiGet( cmbTipoVendedorEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372TipoVendedorEstado", StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z370TipoVendedorId = (int)(context.localUtil.CToN( cgiGet( "Z370TipoVendedorId"), ".", ",")) ;
               Z371TipoVendedorNombre = cgiGet( "Z371TipoVendedorNombre") ;
               Z378TipoVendedorEsJefe = (short)(context.localUtil.CToN( cgiGet( "Z378TipoVendedorEsJefe"), ".", ",")) ;
               Z372TipoVendedorEstado = (short)(context.localUtil.CToN( cgiGet( "Z372TipoVendedorEstado"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridtipovendedor_tiporango = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridtipovendedor_tiporango"), ".", ",")) ;
               AV7ClinicaCodigo = cgiGet( "vCLINICACODIGO") ;
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
                  A370TipoVendedorId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E111O2 */
                           E111O2 ();
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
               InitAll1O76( ) ;
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
         DisableAttributes1O76( ) ;
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

      protected void CONFIRM_1O77( )
      {
         nGXsfl_65_idx = 0 ;
         while ( nGXsfl_65_idx < nRC_Gridtipovendedor_tiporango )
         {
            ReadRow1O77( ) ;
            if ( ( nRcdExists_77 != 0 ) || ( nIsMod_77 != 0 ) )
            {
               GetKey1O77( ) ;
               if ( ( nRcdExists_77 == 0 ) && ( nRcdDeleted_77 == 0 ) )
               {
                  if ( RcdFound77 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate1O77( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable1O77( ) ;
                        CloseExtendedTableCursors1O77( ) ;
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
                     GX_FocusControl = edtTipoRangoId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound77 != 0 )
                  {
                     if ( nRcdDeleted_77 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey1O77( ) ;
                        Load1O77( ) ;
                        BeforeValidate1O77( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls1O77( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_77 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate1O77( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable1O77( ) ;
                              CloseExtendedTableCursors1O77( ) ;
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
                     if ( nRcdDeleted_77 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtTipoRangoId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTipoRangoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A373TipoRangoId), 9, 0, ".", ""))) ;
            ChangePostValue( edtTipoRangoNombre_Internalname, StringUtil.RTrim( A374TipoRangoNombre)) ;
            ChangePostValue( edtTipoRangoInicial_Internalname, StringUtil.LTrim( StringUtil.NToC( A375TipoRangoInicial, 17, 2, ".", ""))) ;
            ChangePostValue( edtTipoRangoFinal_Internalname, StringUtil.LTrim( StringUtil.NToC( A376TipoRangoFinal, 17, 2, ".", ""))) ;
            ChangePostValue( edtTipoRangoPorcentaje_Internalname, StringUtil.LTrim( StringUtil.NToC( A377TipoRangoPorcentaje, 17, 2, ".", ""))) ;
            ChangePostValue( edtTipoRangoPorcentajeJefe_Internalname, StringUtil.LTrim( StringUtil.NToC( A379TipoRangoPorcentajeJefe, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z373TipoRangoId_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z373TipoRangoId), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z374TipoRangoNombre_"+sGXsfl_65_idx, StringUtil.RTrim( Z374TipoRangoNombre)) ;
            ChangePostValue( "ZT_"+"Z375TipoRangoInicial_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z375TipoRangoInicial, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z376TipoRangoFinal_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z376TipoRangoFinal, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z377TipoRangoPorcentaje_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z377TipoRangoPorcentaje, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z379TipoRangoPorcentajeJefe_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z379TipoRangoPorcentajeJefe, 17, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_77_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_77), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_77_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_77), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_77_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_77), 4, 0, ".", ""))) ;
            if ( nIsMod_77 != 0 )
            {
               ChangePostValue( "TIPORANGOID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGONOMBRE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGOINICIAL_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoInicial_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGOFINAL_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoFinal_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoPorcentaje_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoPorcentajeJefe_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption1O0( )
      {
      }

      protected void E111O2( )
      {
         /* Start Routine */
         GXt_SdtParametros10 = AV8Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros10) ;
         AV8Parametros = GXt_SdtParametros10 ;
         AV7ClinicaCodigo = AV8Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ClinicaCodigo", AV7ClinicaCodigo);
      }

      protected void ZM1O76( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z371TipoVendedorNombre = T001O5_A371TipoVendedorNombre[0] ;
               Z378TipoVendedorEsJefe = T001O5_A378TipoVendedorEsJefe[0] ;
               Z372TipoVendedorEstado = T001O5_A372TipoVendedorEstado[0] ;
            }
            else
            {
               Z371TipoVendedorNombre = A371TipoVendedorNombre ;
               Z378TipoVendedorEsJefe = A378TipoVendedorEsJefe ;
               Z372TipoVendedorEstado = A372TipoVendedorEstado ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z370TipoVendedorId = A370TipoVendedorId ;
            Z371TipoVendedorNombre = A371TipoVendedorNombre ;
            Z378TipoVendedorEsJefe = A378TipoVendedorEsJefe ;
            Z372TipoVendedorEstado = A372TipoVendedorEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         imgprompt_41_Visible = edtClinicaCodigo_Visible ;
         imgprompt_41_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00g0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
         A41ClinicaCodigo = AV7ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
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

      protected void Load1O76( )
      {
         /* Using cursor T001O7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound76 = 1 ;
            A371TipoVendedorNombre = T001O7_A371TipoVendedorNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A371TipoVendedorNombre", A371TipoVendedorNombre);
            A378TipoVendedorEsJefe = T001O7_A378TipoVendedorEsJefe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378TipoVendedorEsJefe", StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0));
            A372TipoVendedorEstado = T001O7_A372TipoVendedorEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372TipoVendedorEstado", StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0));
            ZM1O76( -4) ;
         }
         pr_default.close(5);
         OnLoadActions1O76( ) ;
      }

      protected void OnLoadActions1O76( )
      {
      }

      protected void CheckExtendedTable1O76( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T001O6 */
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
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors1O76( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo )
      {
         /* Using cursor T001O8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(6) == 101) )
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
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey1O76( )
      {
         /* Using cursor T001O9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound76 = 1 ;
         }
         else
         {
            RcdFound76 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001O5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM1O76( 4) ;
            RcdFound76 = 1 ;
            A370TipoVendedorId = T001O5_A370TipoVendedorId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
            A371TipoVendedorNombre = T001O5_A371TipoVendedorNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A371TipoVendedorNombre", A371TipoVendedorNombre);
            A378TipoVendedorEsJefe = T001O5_A378TipoVendedorEsJefe[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378TipoVendedorEsJefe", StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0));
            A372TipoVendedorEstado = T001O5_A372TipoVendedorEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372TipoVendedorEstado", StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0));
            A41ClinicaCodigo = T001O5_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z370TipoVendedorId = A370TipoVendedorId ;
            sMode76 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1O76( ) ;
            Gx_mode = sMode76 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound76 = 0 ;
            InitializeNonKey1O76( ) ;
            sMode76 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode76 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey1O76( ) ;
         if ( RcdFound76 == 0 )
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
         RcdFound76 = 0 ;
         /* Using cursor T001O10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001O10_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001O10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001O10_A370TipoVendedorId[0] < A370TipoVendedorId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001O10_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001O10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001O10_A370TipoVendedorId[0] > A370TipoVendedorId ) ) )
            {
               A41ClinicaCodigo = T001O10_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A370TipoVendedorId = T001O10_A370TipoVendedorId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
               RcdFound76 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound76 = 0 ;
         /* Using cursor T001O11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001O11_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T001O11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001O11_A370TipoVendedorId[0] > A370TipoVendedorId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001O11_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T001O11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T001O11_A370TipoVendedorId[0] < A370TipoVendedorId ) ) )
            {
               A41ClinicaCodigo = T001O11_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A370TipoVendedorId = T001O11_A370TipoVendedorId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
               RcdFound76 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1O76( ) ;
         if ( RcdFound76 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A370TipoVendedorId != Z370TipoVendedorId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A370TipoVendedorId = Z370TipoVendedorId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
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
               Update1O76( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A370TipoVendedorId != Z370TipoVendedorId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1O76( ) ;
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
                  Insert1O76( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A370TipoVendedorId != Z370TipoVendedorId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A370TipoVendedorId = Z370TipoVendedorId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
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
         if ( RcdFound76 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtTipoVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1O76( ) ;
         if ( RcdFound76 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1O76( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound76 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoVendedorNombre_Internalname ;
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
         if ( RcdFound76 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1O76( ) ;
         if ( RcdFound76 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound76 != 0 )
            {
               ScanNext1O76( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTipoVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1O76( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1O76( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001O12 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoVendedor"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z371TipoVendedorNombre, T001O12_A371TipoVendedorNombre[0]) != 0 ) || ( Z378TipoVendedorEsJefe != T001O12_A378TipoVendedorEsJefe[0] ) || ( Z372TipoVendedorEstado != T001O12_A372TipoVendedorEstado[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoVendedor"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1O76( )
      {
         BeforeValidate1O76( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1O76( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1O76( 0) ;
            CheckOptimisticConcurrency1O76( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1O76( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1O76( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001O13 */
                     pr_default.execute(11, new Object[] {A370TipoVendedorId, A371TipoVendedorNombre, A378TipoVendedorEsJefe, A372TipoVendedorEstado, A41ClinicaCodigo});
                     pr_default.close(11);
                     if ( (pr_default.getStatus(11) == 1) )
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
                           ProcessLevel1O76( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption1O0( ) ;
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
               Load1O76( ) ;
            }
            EndLevel1O76( ) ;
         }
         CloseExtendedTableCursors1O76( ) ;
      }

      protected void Update1O76( )
      {
         BeforeValidate1O76( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1O76( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1O76( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1O76( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1O76( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001O14 */
                     pr_default.execute(12, new Object[] {A371TipoVendedorNombre, A378TipoVendedorEsJefe, A372TipoVendedorEstado, A41ClinicaCodigo, A370TipoVendedorId});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoVendedor"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1O76( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel1O76( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption1O0( ) ;
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
            EndLevel1O76( ) ;
         }
         CloseExtendedTableCursors1O76( ) ;
      }

      protected void DeferredUpdate1O76( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1O76( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1O76( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1O76( ) ;
            AfterConfirm1O76( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1O76( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart1O77( ) ;
                  while ( RcdFound77 != 0 )
                  {
                     getByPrimaryKey1O77( ) ;
                     Delete1O77( ) ;
                     ScanNext1O77( ) ;
                  }
                  ScanEnd1O77( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001O15 */
                     pr_default.execute(13, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
                     pr_default.close(13);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound76 == 0 )
                           {
                              InitAll1O76( ) ;
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
                           ResetCaption1O0( ) ;
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
         sMode76 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1O76( ) ;
         Gx_mode = sMode76 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1O76( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001O16 */
            pr_default.execute(14, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Vendedores"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel1O77( )
      {
         nGXsfl_65_idx = 0 ;
         while ( nGXsfl_65_idx < nRC_Gridtipovendedor_tiporango )
         {
            ReadRow1O77( ) ;
            if ( ( nRcdExists_77 != 0 ) || ( nIsMod_77 != 0 ) )
            {
               standaloneNotModal1O77( ) ;
               GetKey1O77( ) ;
               if ( ( nRcdExists_77 == 0 ) && ( nRcdDeleted_77 == 0 ) )
               {
                  if ( RcdFound77 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert1O77( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtTipoRangoId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound77 != 0 )
                  {
                     if ( ( nRcdDeleted_77 != 0 ) && ( nRcdExists_77 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete1O77( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_77 != 0 ) && ( nRcdExists_77 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update1O77( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_77 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtTipoRangoId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtTipoRangoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A373TipoRangoId), 9, 0, ".", ""))) ;
            ChangePostValue( edtTipoRangoNombre_Internalname, StringUtil.RTrim( A374TipoRangoNombre)) ;
            ChangePostValue( edtTipoRangoInicial_Internalname, StringUtil.LTrim( StringUtil.NToC( A375TipoRangoInicial, 17, 2, ".", ""))) ;
            ChangePostValue( edtTipoRangoFinal_Internalname, StringUtil.LTrim( StringUtil.NToC( A376TipoRangoFinal, 17, 2, ".", ""))) ;
            ChangePostValue( edtTipoRangoPorcentaje_Internalname, StringUtil.LTrim( StringUtil.NToC( A377TipoRangoPorcentaje, 17, 2, ".", ""))) ;
            ChangePostValue( edtTipoRangoPorcentajeJefe_Internalname, StringUtil.LTrim( StringUtil.NToC( A379TipoRangoPorcentajeJefe, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z373TipoRangoId_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z373TipoRangoId), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z374TipoRangoNombre_"+sGXsfl_65_idx, StringUtil.RTrim( Z374TipoRangoNombre)) ;
            ChangePostValue( "ZT_"+"Z375TipoRangoInicial_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z375TipoRangoInicial, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z376TipoRangoFinal_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z376TipoRangoFinal, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z377TipoRangoPorcentaje_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z377TipoRangoPorcentaje, 17, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z379TipoRangoPorcentajeJefe_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z379TipoRangoPorcentajeJefe, 17, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_77_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_77), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_77_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_77), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_77_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_77), 4, 0, ".", ""))) ;
            if ( nIsMod_77 != 0 )
            {
               ChangePostValue( "TIPORANGOID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGONOMBRE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGOINICIAL_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoInicial_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGOFINAL_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoFinal_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoPorcentaje_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoPorcentajeJefe_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll1O77( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_77 = 0 ;
         nIsMod_77 = 0 ;
         nRcdDeleted_77 = 0 ;
      }

      protected void ProcessLevel1O76( )
      {
         /* Save parent mode. */
         sMode76 = Gx_mode ;
         ProcessNestedLevel1O77( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode76 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel1O76( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1O76( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("TipoVendedor");
            if ( AnyError == 0 )
            {
               ConfirmValues1O0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("TipoVendedor");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1O76( )
      {
         /* Using cursor T001O17 */
         pr_default.execute(15);
         RcdFound76 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound76 = 1 ;
            A41ClinicaCodigo = T001O17_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A370TipoVendedorId = T001O17_A370TipoVendedorId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1O76( )
      {
         pr_default.readNext(15);
         RcdFound76 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound76 = 1 ;
            A41ClinicaCodigo = T001O17_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A370TipoVendedorId = T001O17_A370TipoVendedorId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
         }
      }

      protected void ScanEnd1O76( )
      {
      }

      protected void AfterConfirm1O76( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1O76( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1O76( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1O76( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1O76( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1O76( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1O76( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtTipoVendedorId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoVendedorId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoVendedorId_Enabled), 5, 0)));
         edtTipoVendedorNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoVendedorNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoVendedorNombre_Enabled), 5, 0)));
         cmbTipoVendedorEsJefe.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoVendedorEsJefe_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoVendedorEsJefe.Enabled), 5, 0)));
         cmbTipoVendedorEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoVendedorEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTipoVendedorEstado.Enabled), 5, 0)));
      }

      protected void ZM1O77( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z374TipoRangoNombre = T001O3_A374TipoRangoNombre[0] ;
               Z375TipoRangoInicial = T001O3_A375TipoRangoInicial[0] ;
               Z376TipoRangoFinal = T001O3_A376TipoRangoFinal[0] ;
               Z377TipoRangoPorcentaje = T001O3_A377TipoRangoPorcentaje[0] ;
               Z379TipoRangoPorcentajeJefe = T001O3_A379TipoRangoPorcentajeJefe[0] ;
            }
            else
            {
               Z374TipoRangoNombre = A374TipoRangoNombre ;
               Z375TipoRangoInicial = A375TipoRangoInicial ;
               Z376TipoRangoFinal = A376TipoRangoFinal ;
               Z377TipoRangoPorcentaje = A377TipoRangoPorcentaje ;
               Z379TipoRangoPorcentajeJefe = A379TipoRangoPorcentajeJefe ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z370TipoVendedorId = A370TipoVendedorId ;
            Z373TipoRangoId = A373TipoRangoId ;
            Z374TipoRangoNombre = A374TipoRangoNombre ;
            Z375TipoRangoInicial = A375TipoRangoInicial ;
            Z376TipoRangoFinal = A376TipoRangoFinal ;
            Z377TipoRangoPorcentaje = A377TipoRangoPorcentaje ;
            Z379TipoRangoPorcentajeJefe = A379TipoRangoPorcentajeJefe ;
         }
      }

      protected void standaloneNotModal1O77( )
      {
      }

      protected void standaloneModal1O77( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtTipoRangoId_Enabled = 0 ;
         }
         else
         {
            edtTipoRangoId_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode77, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode77, "DLT") == 0 ) )
         {
            DisableAttributes1O77( ) ;
         }
      }

      protected void Load1O77( )
      {
         /* Using cursor T001O18 */
         pr_default.execute(16, new Object[] {A41ClinicaCodigo, A370TipoVendedorId, A373TipoRangoId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound77 = 1 ;
            A374TipoRangoNombre = T001O18_A374TipoRangoNombre[0] ;
            A375TipoRangoInicial = T001O18_A375TipoRangoInicial[0] ;
            A376TipoRangoFinal = T001O18_A376TipoRangoFinal[0] ;
            A377TipoRangoPorcentaje = T001O18_A377TipoRangoPorcentaje[0] ;
            A379TipoRangoPorcentajeJefe = T001O18_A379TipoRangoPorcentajeJefe[0] ;
            ZM1O77( -6) ;
         }
         pr_default.close(16);
         OnLoadActions1O77( ) ;
      }

      protected void OnLoadActions1O77( )
      {
      }

      protected void CheckExtendedTable1O77( )
      {
         Gx_BScreen = 1 ;
         standaloneModal1O77( ) ;
      }

      protected void CloseExtendedTableCursors1O77( )
      {
      }

      protected void enableDisable1O77( )
      {
      }

      protected void GetKey1O77( )
      {
         /* Using cursor T001O19 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo, A370TipoVendedorId, A373TipoRangoId});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound77 = 1 ;
         }
         else
         {
            RcdFound77 = 0 ;
         }
         pr_default.close(17);
      }

      protected void getByPrimaryKey1O77( )
      {
         /* Using cursor T001O3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A370TipoVendedorId, A373TipoRangoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1O77( 6) ;
            RcdFound77 = 1 ;
            InitializeNonKey1O77( ) ;
            A373TipoRangoId = T001O3_A373TipoRangoId[0] ;
            A374TipoRangoNombre = T001O3_A374TipoRangoNombre[0] ;
            A375TipoRangoInicial = T001O3_A375TipoRangoInicial[0] ;
            A376TipoRangoFinal = T001O3_A376TipoRangoFinal[0] ;
            A377TipoRangoPorcentaje = T001O3_A377TipoRangoPorcentaje[0] ;
            A379TipoRangoPorcentajeJefe = T001O3_A379TipoRangoPorcentajeJefe[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z370TipoVendedorId = A370TipoVendedorId ;
            Z373TipoRangoId = A373TipoRangoId ;
            sMode77 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1O77( ) ;
            Load1O77( ) ;
            Gx_mode = sMode77 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound77 = 0 ;
            InitializeNonKey1O77( ) ;
            sMode77 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal1O77( ) ;
            Gx_mode = sMode77 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency1O77( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001O2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A370TipoVendedorId, A373TipoRangoId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoVendedorRango"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z374TipoRangoNombre, T001O2_A374TipoRangoNombre[0]) != 0 ) || ( Z375TipoRangoInicial != T001O2_A375TipoRangoInicial[0] ) || ( Z376TipoRangoFinal != T001O2_A376TipoRangoFinal[0] ) || ( Z377TipoRangoPorcentaje != T001O2_A377TipoRangoPorcentaje[0] ) || ( Z379TipoRangoPorcentajeJefe != T001O2_A379TipoRangoPorcentajeJefe[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TipoVendedorRango"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1O77( )
      {
         BeforeValidate1O77( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1O77( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1O77( 0) ;
            CheckOptimisticConcurrency1O77( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1O77( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1O77( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001O20 */
                     pr_default.execute(18, new Object[] {A41ClinicaCodigo, A370TipoVendedorId, A373TipoRangoId, A374TipoRangoNombre, A375TipoRangoInicial, A376TipoRangoFinal, A377TipoRangoPorcentaje, A379TipoRangoPorcentajeJefe});
                     pr_default.close(18);
                     if ( (pr_default.getStatus(18) == 1) )
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
               Load1O77( ) ;
            }
            EndLevel1O77( ) ;
         }
         CloseExtendedTableCursors1O77( ) ;
      }

      protected void Update1O77( )
      {
         BeforeValidate1O77( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1O77( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1O77( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1O77( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1O77( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001O21 */
                     pr_default.execute(19, new Object[] {A374TipoRangoNombre, A375TipoRangoInicial, A376TipoRangoFinal, A377TipoRangoPorcentaje, A379TipoRangoPorcentajeJefe, A41ClinicaCodigo, A370TipoVendedorId, A373TipoRangoId});
                     pr_default.close(19);
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TipoVendedorRango"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1O77( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey1O77( ) ;
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
            EndLevel1O77( ) ;
         }
         CloseExtendedTableCursors1O77( ) ;
      }

      protected void DeferredUpdate1O77( )
      {
      }

      protected void Delete1O77( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1O77( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1O77( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1O77( ) ;
            AfterConfirm1O77( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1O77( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001O22 */
                  pr_default.execute(20, new Object[] {A41ClinicaCodigo, A370TipoVendedorId, A373TipoRangoId});
                  pr_default.close(20);
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
         sMode77 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1O77( ) ;
         Gx_mode = sMode77 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1O77( )
      {
         standaloneModal1O77( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1O77( )
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

      protected void ScanStart1O77( )
      {
         /* Using cursor T001O23 */
         pr_default.execute(21, new Object[] {A41ClinicaCodigo, A370TipoVendedorId});
         RcdFound77 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound77 = 1 ;
            A373TipoRangoId = T001O23_A373TipoRangoId[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1O77( )
      {
         pr_default.readNext(21);
         RcdFound77 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound77 = 1 ;
            A373TipoRangoId = T001O23_A373TipoRangoId[0] ;
         }
      }

      protected void ScanEnd1O77( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm1O77( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1O77( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1O77( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1O77( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1O77( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1O77( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1O77( )
      {
         edtTipoRangoId_Enabled = 0 ;
         edtTipoRangoNombre_Enabled = 0 ;
         edtTipoRangoInicial_Enabled = 0 ;
         edtTipoRangoFinal_Enabled = 0 ;
         edtTipoRangoPorcentaje_Enabled = 0 ;
         edtTipoRangoPorcentajeJefe_Enabled = 0 ;
      }

      protected void AddRow1O77( )
      {
         nGXsfl_65_idx = (short)(nGXsfl_65_idx+1) ;
         sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
         edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_65_idx ;
         edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_65_idx ;
         edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_65_idx ;
         edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_65_idx ;
         edtTipoRangoPorcentaje_Internalname = "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx ;
         edtTipoRangoPorcentajeJefe_Internalname = "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx ;
         SendRow1O77( ) ;
      }

      protected void SendRow1O77( )
      {
         Gridtipovendedor_tiporangoRow = GXWebRow.GetNew(context) ;
         if ( subGridtipovendedor_tiporango_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridtipovendedor_tiporango_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridtipovendedor_tiporango_Class, "") != 0 )
            {
               subGridtipovendedor_tiporango_Linesclass = subGridtipovendedor_tiporango_Class+"Odd" ;
            }
         }
         else if ( subGridtipovendedor_tiporango_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridtipovendedor_tiporango_Backstyle = 0 ;
            subGridtipovendedor_tiporango_Backcolor = subGridtipovendedor_tiporango_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipovendedor_tiporangoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipovendedor_tiporango_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridtipovendedor_tiporango_Class, "") != 0 )
            {
               subGridtipovendedor_tiporango_Linesclass = subGridtipovendedor_tiporango_Class+"Uniform" ;
            }
         }
         else if ( subGridtipovendedor_tiporango_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridtipovendedor_tiporango_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridtipovendedor_tiporango_Class, "") != 0 )
            {
               subGridtipovendedor_tiporango_Linesclass = subGridtipovendedor_tiporango_Class+"Odd" ;
            }
            subGridtipovendedor_tiporango_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipovendedor_tiporangoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipovendedor_tiporango_Backcolor), 9, 0)));
         }
         else if ( subGridtipovendedor_tiporango_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridtipovendedor_tiporango_Backstyle = 1 ;
            if ( ((int)(nGXsfl_65_idx) % (2)) == 0 )
            {
               subGridtipovendedor_tiporango_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipovendedor_tiporangoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipovendedor_tiporango_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridtipovendedor_tiporango_Class, "") != 0 )
               {
                  subGridtipovendedor_tiporango_Linesclass = subGridtipovendedor_tiporango_Class+"Even" ;
               }
            }
            else
            {
               subGridtipovendedor_tiporango_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridtipovendedor_tiporangoContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridtipovendedor_tiporango_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridtipovendedor_tiporango_Class, "") != 0 )
               {
                  subGridtipovendedor_tiporango_Linesclass = subGridtipovendedor_tiporango_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_77_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipovendedor_tiporangoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A373TipoRangoId), 9, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A373TipoRangoId), "ZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(66);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoRangoId_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_77_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipovendedor_tiporangoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoNombre_Internalname,StringUtil.RTrim( A374TipoRangoNombre),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(67);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoRangoNombre_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)65,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_77_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipovendedor_tiporangoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoInicial_Internalname,StringUtil.LTrim( StringUtil.NToC( A375TipoRangoInicial, 17, 2, ".", "")),((edtTipoRangoInicial_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A375TipoRangoInicial, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A375TipoRangoInicial, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(68);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoInicial_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoRangoInicial_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_77_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipovendedor_tiporangoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoFinal_Internalname,StringUtil.LTrim( StringUtil.NToC( A376TipoRangoFinal, 17, 2, ".", "")),((edtTipoRangoFinal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A376TipoRangoFinal, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A376TipoRangoFinal, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(69);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoFinal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoRangoFinal_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_77_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipovendedor_tiporangoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoPorcentaje_Internalname,StringUtil.LTrim( StringUtil.NToC( A377TipoRangoPorcentaje, 17, 2, ".", "")),((edtTipoRangoPorcentaje_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A377TipoRangoPorcentaje, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A377TipoRangoPorcentaje, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(70);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoPorcentaje_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoRangoPorcentaje_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_77_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridtipovendedor_tiporangoRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoRangoPorcentajeJefe_Internalname,StringUtil.LTrim( StringUtil.NToC( A379TipoRangoPorcentajeJefe, 17, 2, ".", "")),((edtTipoRangoPorcentajeJefe_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A379TipoRangoPorcentajeJefe, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A379TipoRangoPorcentajeJefe, "ZZZZZZZZZZZZZ9.99")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(71);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoRangoPorcentajeJefe_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTipoRangoPorcentajeJefe_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridtipovendedor_tiporangoRow);
         GXCCtl = "Z373TipoRangoId_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z373TipoRangoId), 9, 0, ".", "")));
         GXCCtl = "Z374TipoRangoNombre_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z374TipoRangoNombre));
         GXCCtl = "Z375TipoRangoInicial_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z375TipoRangoInicial, 17, 2, ".", "")));
         GXCCtl = "Z376TipoRangoFinal_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z376TipoRangoFinal, 17, 2, ".", "")));
         GXCCtl = "Z377TipoRangoPorcentaje_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z377TipoRangoPorcentaje, 17, 2, ".", "")));
         GXCCtl = "Z379TipoRangoPorcentajeJefe_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z379TipoRangoPorcentajeJefe, 17, 2, ".", "")));
         GXCCtl = "nRcdDeleted_77_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_77), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_77_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_77), 4, 0, ".", "")));
         GXCCtl = "nIsMod_77_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_77), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPORANGOID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPORANGONOMBRE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPORANGOINICIAL_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoInicial_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPORANGOFINAL_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoFinal_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoPorcentaje_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTipoRangoPorcentajeJefe_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridtipovendedor_tiporangoContainer.AddRow(Gridtipovendedor_tiporangoRow);
      }

      protected void ReadRow1O77( )
      {
         nGXsfl_65_idx = (short)(nGXsfl_65_idx+1) ;
         sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
         edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_65_idx ;
         edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_65_idx ;
         edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_65_idx ;
         edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_65_idx ;
         edtTipoRangoPorcentaje_Internalname = "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx ;
         edtTipoRangoPorcentajeJefe_Internalname = "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx ;
         edtTipoRangoId_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOID_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         edtTipoRangoNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGONOMBRE_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         edtTipoRangoInicial_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOINICIAL_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         edtTipoRangoFinal_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOFINAL_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         edtTipoRangoPorcentaje_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         edtTipoRangoPorcentajeJefe_Enabled = (int)(context.localUtil.CToN( cgiGet( "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoRangoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoRangoId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPORANGOID");
            AnyError = 1 ;
            GX_FocusControl = edtTipoRangoId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A373TipoRangoId = 0 ;
         }
         else
         {
            A373TipoRangoId = (int)(context.localUtil.CToN( cgiGet( edtTipoRangoId_Internalname), ".", ",")) ;
         }
         A374TipoRangoNombre = cgiGet( edtTipoRangoNombre_Internalname) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoRangoInicial_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoRangoInicial_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPORANGOINICIAL");
            AnyError = 1 ;
            GX_FocusControl = edtTipoRangoInicial_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A375TipoRangoInicial = 0 ;
         }
         else
         {
            A375TipoRangoInicial = context.localUtil.CToN( cgiGet( edtTipoRangoInicial_Internalname), ".", ",") ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoRangoFinal_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoRangoFinal_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPORANGOFINAL");
            AnyError = 1 ;
            GX_FocusControl = edtTipoRangoFinal_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A376TipoRangoFinal = 0 ;
         }
         else
         {
            A376TipoRangoFinal = context.localUtil.CToN( cgiGet( edtTipoRangoFinal_Internalname), ".", ",") ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoRangoPorcentaje_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoRangoPorcentaje_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPORANGOPORCENTAJE");
            AnyError = 1 ;
            GX_FocusControl = edtTipoRangoPorcentaje_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A377TipoRangoPorcentaje = 0 ;
         }
         else
         {
            A377TipoRangoPorcentaje = context.localUtil.CToN( cgiGet( edtTipoRangoPorcentaje_Internalname), ".", ",") ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtTipoRangoPorcentajeJefe_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoRangoPorcentajeJefe_Internalname), ".", ",") > 99999999999999.99m ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPORANGOPORCENTAJEJEFE");
            AnyError = 1 ;
            GX_FocusControl = edtTipoRangoPorcentajeJefe_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A379TipoRangoPorcentajeJefe = 0 ;
         }
         else
         {
            A379TipoRangoPorcentajeJefe = context.localUtil.CToN( cgiGet( edtTipoRangoPorcentajeJefe_Internalname), ".", ",") ;
         }
         GXCCtl = "Z373TipoRangoId_" + sGXsfl_65_idx ;
         Z373TipoRangoId = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z374TipoRangoNombre_" + sGXsfl_65_idx ;
         Z374TipoRangoNombre = cgiGet( GXCCtl) ;
         GXCCtl = "Z375TipoRangoInicial_" + sGXsfl_65_idx ;
         Z375TipoRangoInicial = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z376TipoRangoFinal_" + sGXsfl_65_idx ;
         Z376TipoRangoFinal = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z377TipoRangoPorcentaje_" + sGXsfl_65_idx ;
         Z377TipoRangoPorcentaje = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "Z379TipoRangoPorcentajeJefe_" + sGXsfl_65_idx ;
         Z379TipoRangoPorcentajeJefe = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "nRcdDeleted_77_" + sGXsfl_65_idx ;
         nRcdDeleted_77 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_77_" + sGXsfl_65_idx ;
         nRcdExists_77 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_77_" + sGXsfl_65_idx ;
         nIsMod_77 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtTipoRangoId_Enabled = edtTipoRangoId_Enabled ;
      }

      protected void ConfirmValues1O0( )
      {
         nGXsfl_65_idx = 0 ;
         sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
         edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_65_idx ;
         edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_65_idx ;
         edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_65_idx ;
         edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_65_idx ;
         edtTipoRangoPorcentaje_Internalname = "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx ;
         edtTipoRangoPorcentajeJefe_Internalname = "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx ;
         while ( nGXsfl_65_idx < nRC_Gridtipovendedor_tiporango )
         {
            nGXsfl_65_idx = (short)(nGXsfl_65_idx+1) ;
            sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
            edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_65_idx ;
            edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_65_idx ;
            edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_65_idx ;
            edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_65_idx ;
            edtTipoRangoPorcentaje_Internalname = "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx ;
            edtTipoRangoPorcentajeJefe_Internalname = "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx ;
            ChangePostValue( "Z373TipoRangoId_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z373TipoRangoId_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z373TipoRangoId_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z374TipoRangoNombre_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z374TipoRangoNombre_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z374TipoRangoNombre_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z375TipoRangoInicial_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z375TipoRangoInicial_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z375TipoRangoInicial_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z376TipoRangoFinal_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z376TipoRangoFinal_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z376TipoRangoFinal_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z377TipoRangoPorcentaje_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z377TipoRangoPorcentaje_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z377TipoRangoPorcentaje_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z379TipoRangoPorcentajeJefe_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z379TipoRangoPorcentajeJefe_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z379TipoRangoPorcentajeJefe_"+sGXsfl_65_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tipovendedor.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z370TipoVendedorId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z370TipoVendedorId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z371TipoVendedorNombre", StringUtil.RTrim( Z371TipoVendedorNombre));
         GxWebStd.gx_hidden_field( context, "Z378TipoVendedorEsJefe", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z378TipoVendedorEsJefe), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z372TipoVendedorEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z372TipoVendedorEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridtipovendedor_tiporango", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_65_idx), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV7ClinicaCodigo));
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
         return "TipoVendedor" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tipo Vendedor" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tipovendedor.aspx")  ;
      }

      protected void InitializeNonKey1O76( )
      {
         A371TipoVendedorNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A371TipoVendedorNombre", A371TipoVendedorNombre);
         A378TipoVendedorEsJefe = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378TipoVendedorEsJefe", StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0));
         A372TipoVendedorEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372TipoVendedorEstado", StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0));
      }

      protected void InitAll1O76( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A370TipoVendedorId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370TipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0)));
         InitializeNonKey1O76( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey1O77( )
      {
         A374TipoRangoNombre = "" ;
         A375TipoRangoInicial = 0 ;
         A376TipoRangoFinal = 0 ;
         A377TipoRangoPorcentaje = 0 ;
         A379TipoRangoPorcentajeJefe = 0 ;
      }

      protected void InitAll1O77( )
      {
         A373TipoRangoId = 0 ;
         InitializeNonKey1O77( ) ;
      }

      protected void StandaloneModalInsert1O77( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1573520");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("tipovendedor.js", "?1573520");
         /* End function include_jscripts */
      }

      protected void init_level_properties77( )
      {
         edtTipoRangoId_Enabled = defedtTipoRangoId_Enabled ;
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
         lblTextblocktipovendedorid_Internalname = "TEXTBLOCKTIPOVENDEDORID" ;
         edtTipoVendedorId_Internalname = "TIPOVENDEDORID" ;
         lblTextblocktipovendedornombre_Internalname = "TEXTBLOCKTIPOVENDEDORNOMBRE" ;
         edtTipoVendedorNombre_Internalname = "TIPOVENDEDORNOMBRE" ;
         lblTextblocktipovendedoresjefe_Internalname = "TEXTBLOCKTIPOVENDEDORESJEFE" ;
         cmbTipoVendedorEsJefe_Internalname = "TIPOVENDEDORESJEFE" ;
         lblTextblocktipovendedorestado_Internalname = "TEXTBLOCKTIPOVENDEDORESTADO" ;
         cmbTipoVendedorEstado_Internalname = "TIPOVENDEDORESTADO" ;
         lblTitletiporango_Internalname = "TITLETIPORANGO" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_Internalname = "PROMPT_41" ;
         subGridtipovendedor_tiporango_Internalname = "GRIDTIPOVENDEDOR_TIPORANGO" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Tipo Vendedor" ;
         edtTipoRangoPorcentajeJefe_Jsonclick = "" ;
         edtTipoRangoPorcentaje_Jsonclick = "" ;
         edtTipoRangoFinal_Jsonclick = "" ;
         edtTipoRangoInicial_Jsonclick = "" ;
         edtTipoRangoNombre_Jsonclick = "" ;
         edtTipoRangoId_Jsonclick = "" ;
         subGridtipovendedor_tiporango_Class = "Grid" ;
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
         subGridtipovendedor_tiporango_Allowcollapsing = 0 ;
         edtTipoRangoPorcentajeJefe_Enabled = 1 ;
         edtTipoRangoPorcentaje_Enabled = 1 ;
         edtTipoRangoFinal_Enabled = 1 ;
         edtTipoRangoInicial_Enabled = 1 ;
         edtTipoRangoNombre_Enabled = 1 ;
         edtTipoRangoId_Enabled = 1 ;
         subGridtipovendedor_tiporango_Backcolorstyle = 2 ;
         cmbTipoVendedorEstado_Jsonclick = "" ;
         cmbTipoVendedorEstado.Enabled = 1 ;
         cmbTipoVendedorEsJefe_Jsonclick = "" ;
         cmbTipoVendedorEsJefe.Enabled = 1 ;
         edtTipoVendedorNombre_Jsonclick = "" ;
         edtTipoVendedorNombre_Enabled = 1 ;
         edtTipoVendedorId_Jsonclick = "" ;
         edtTipoVendedorId_Enabled = 1 ;
         imgprompt_41_Link = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Enabled = 1 ;
         edtClinicaCodigo_Visible = 1 ;
         lblTextblockclinicacodigo_Visible = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         imgprompt_41_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridtipovendedor_tiporango_newrow( short nRC_Gridtipovendedor_tiporango ,
                                                            short nGXsfl_65_idx ,
                                                            String sGXsfl_65_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_65_idx ;
         edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_65_idx ;
         edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_65_idx ;
         edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_65_idx ;
         edtTipoRangoPorcentaje_Internalname = "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx ;
         edtTipoRangoPorcentajeJefe_Internalname = "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx ;
         while ( nGXsfl_65_idx <= nRC_Gridtipovendedor_tiporango )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal1O77( ) ;
            standaloneModal1O77( ) ;
            cmbTipoVendedorEsJefe.Name = "TIPOVENDEDORESJEFE" ;
            cmbTipoVendedorEsJefe.WebTags = "" ;
            cmbTipoVendedorEsJefe.addItem("0", "No", 0);
            cmbTipoVendedorEsJefe.addItem("1", "Si", 0);
            if ( ( cmbTipoVendedorEsJefe.ItemCount > 0 ) && (0==A378TipoVendedorEsJefe) )
            {
               A378TipoVendedorEsJefe = (short)(NumberUtil.Val( cmbTipoVendedorEsJefe.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378TipoVendedorEsJefe", StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0));
            }
            cmbTipoVendedorEstado.Name = "TIPOVENDEDORESTADO" ;
            cmbTipoVendedorEstado.WebTags = "" ;
            cmbTipoVendedorEstado.addItem("0", "De baja", 0);
            cmbTipoVendedorEstado.addItem("1", "Activo", 0);
            if ( ( cmbTipoVendedorEstado.ItemCount > 0 ) && (0==A372TipoVendedorEstado) )
            {
               A372TipoVendedorEstado = (short)(NumberUtil.Val( cmbTipoVendedorEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372TipoVendedorEstado", StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0));
            }
            dynload_actions( ) ;
            SendRow1O77( ) ;
            nGXsfl_65_idx = (short)(nGXsfl_65_idx+1) ;
            sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
            edtTipoRangoId_Internalname = "TIPORANGOID_"+sGXsfl_65_idx ;
            edtTipoRangoNombre_Internalname = "TIPORANGONOMBRE_"+sGXsfl_65_idx ;
            edtTipoRangoInicial_Internalname = "TIPORANGOINICIAL_"+sGXsfl_65_idx ;
            edtTipoRangoFinal_Internalname = "TIPORANGOFINAL_"+sGXsfl_65_idx ;
            edtTipoRangoPorcentaje_Internalname = "TIPORANGOPORCENTAJE_"+sGXsfl_65_idx ;
            edtTipoRangoPorcentajeJefe_Internalname = "TIPORANGOPORCENTAJEJEFE_"+sGXsfl_65_idx ;
         }
         context.GX_webresponse.AddString(Gridtipovendedor_tiporangoContainer.ToJavascriptSource());
         /* End function gxnrGridtipovendedor_tiporango_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T001O24 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(22) == 101) )
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
         pr_default.close(22);
         GX_FocusControl = edtTipoVendedorNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T001O24 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(22) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(22);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Tipovendedorid( String GX_Parm1 ,
                                        String GX_Parm2 ,
                                        int GX_Parm3 ,
                                        String GX_Parm4 ,
                                        GXCombobox cmbGX_Parm5 ,
                                        GXCombobox cmbGX_Parm6 )
      {
         AV7ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A370TipoVendedorId = GX_Parm3 ;
         A371TipoVendedorNombre = GX_Parm4 ;
         cmbTipoVendedorEsJefe = cmbGX_Parm5 ;
         A378TipoVendedorEsJefe = (short)(NumberUtil.Val( cmbTipoVendedorEsJefe.CurrentValue, ".")) ;
         cmbTipoVendedorEsJefe.CurrentValue = StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0) ;
         cmbTipoVendedorEstado = cmbGX_Parm6 ;
         A372TipoVendedorEstado = (short)(NumberUtil.Val( cmbTipoVendedorEstado.CurrentValue, ".")) ;
         cmbTipoVendedorEstado.CurrentValue = StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0) ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A371TipoVendedorNombre)));
         cmbTipoVendedorEsJefe.CurrentValue = StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoVendedorEsJefe));
         cmbTipoVendedorEstado.CurrentValue = StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbTipoVendedorEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z370TipoVendedorId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z371TipoVendedorNombre)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z378TipoVendedorEsJefe), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z372TipoVendedorEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(Gridtipovendedor_tiporangoContainer));
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
         pr_default.close(21);
         pr_default.close(15);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(22);
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
         lblTextblocktipovendedorid_Jsonclick = "" ;
         lblTextblocktipovendedornombre_Jsonclick = "" ;
         A371TipoVendedorNombre = "" ;
         lblTextblocktipovendedoresjefe_Jsonclick = "" ;
         lblTextblocktipovendedorestado_Jsonclick = "" ;
         Gridtipovendedor_tiporangoContainer = new GXWebGrid( context);
         Gridtipovendedor_tiporangoColumn = new GXWebColumn();
         A374TipoRangoNombre = "" ;
         Gx_mode = "" ;
         sMode77 = "" ;
         edtTipoRangoId_Internalname = "" ;
         lblTitletiporango_Jsonclick = "" ;
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
         Z371TipoVendedorNombre = "" ;
         AV7ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtTipoRangoNombre_Internalname = "" ;
         edtTipoRangoInicial_Internalname = "" ;
         edtTipoRangoFinal_Internalname = "" ;
         edtTipoRangoPorcentaje_Internalname = "" ;
         edtTipoRangoPorcentajeJefe_Internalname = "" ;
         Z374TipoRangoNombre = "" ;
         AV8Parametros = new SdtParametros(context);
         GXt_SdtParametros10 = new SdtParametros(context);
         T001O7_A370TipoVendedorId = new int[1] ;
         T001O7_A371TipoVendedorNombre = new String[] {""} ;
         T001O7_A378TipoVendedorEsJefe = new short[1] ;
         T001O7_A372TipoVendedorEstado = new short[1] ;
         T001O7_A41ClinicaCodigo = new String[] {""} ;
         T001O6_A41ClinicaCodigo = new String[] {""} ;
         T001O8_A41ClinicaCodigo = new String[] {""} ;
         T001O9_A41ClinicaCodigo = new String[] {""} ;
         T001O9_A370TipoVendedorId = new int[1] ;
         T001O5_A370TipoVendedorId = new int[1] ;
         T001O5_A371TipoVendedorNombre = new String[] {""} ;
         T001O5_A378TipoVendedorEsJefe = new short[1] ;
         T001O5_A372TipoVendedorEstado = new short[1] ;
         T001O5_A41ClinicaCodigo = new String[] {""} ;
         sMode76 = "" ;
         T001O10_A41ClinicaCodigo = new String[] {""} ;
         T001O10_A370TipoVendedorId = new int[1] ;
         T001O11_A41ClinicaCodigo = new String[] {""} ;
         T001O11_A370TipoVendedorId = new int[1] ;
         T001O12_A370TipoVendedorId = new int[1] ;
         T001O12_A371TipoVendedorNombre = new String[] {""} ;
         T001O12_A378TipoVendedorEsJefe = new short[1] ;
         T001O12_A372TipoVendedorEstado = new short[1] ;
         T001O12_A41ClinicaCodigo = new String[] {""} ;
         T001O16_A41ClinicaCodigo = new String[] {""} ;
         T001O16_A317VendedorCodigo = new String[] {""} ;
         T001O17_A41ClinicaCodigo = new String[] {""} ;
         T001O17_A370TipoVendedorId = new int[1] ;
         T001O18_A41ClinicaCodigo = new String[] {""} ;
         T001O18_A370TipoVendedorId = new int[1] ;
         T001O18_A373TipoRangoId = new int[1] ;
         T001O18_A374TipoRangoNombre = new String[] {""} ;
         T001O18_A375TipoRangoInicial = new decimal[1] ;
         T001O18_A376TipoRangoFinal = new decimal[1] ;
         T001O18_A377TipoRangoPorcentaje = new decimal[1] ;
         T001O18_A379TipoRangoPorcentajeJefe = new decimal[1] ;
         T001O19_A41ClinicaCodigo = new String[] {""} ;
         T001O19_A370TipoVendedorId = new int[1] ;
         T001O19_A373TipoRangoId = new int[1] ;
         T001O3_A41ClinicaCodigo = new String[] {""} ;
         T001O3_A370TipoVendedorId = new int[1] ;
         T001O3_A373TipoRangoId = new int[1] ;
         T001O3_A374TipoRangoNombre = new String[] {""} ;
         T001O3_A375TipoRangoInicial = new decimal[1] ;
         T001O3_A376TipoRangoFinal = new decimal[1] ;
         T001O3_A377TipoRangoPorcentaje = new decimal[1] ;
         T001O3_A379TipoRangoPorcentajeJefe = new decimal[1] ;
         T001O2_A41ClinicaCodigo = new String[] {""} ;
         T001O2_A370TipoVendedorId = new int[1] ;
         T001O2_A373TipoRangoId = new int[1] ;
         T001O2_A374TipoRangoNombre = new String[] {""} ;
         T001O2_A375TipoRangoInicial = new decimal[1] ;
         T001O2_A376TipoRangoFinal = new decimal[1] ;
         T001O2_A377TipoRangoPorcentaje = new decimal[1] ;
         T001O2_A379TipoRangoPorcentajeJefe = new decimal[1] ;
         T001O23_A41ClinicaCodigo = new String[] {""} ;
         T001O23_A370TipoVendedorId = new int[1] ;
         T001O23_A373TipoRangoId = new int[1] ;
         Gridtipovendedor_tiporangoRow = new GXWebRow();
         subGridtipovendedor_tiporango_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         GXt_char14 = "" ;
         GXt_char15 = "" ;
         GXt_char16 = "" ;
         GXt_char17 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char19 = "" ;
         GXt_char18 = "" ;
         GXt_char20 = "" ;
         T001O24_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipovendedor__default(),
            new Object[][] {
                new Object[] {
               T001O2_A41ClinicaCodigo, T001O2_A370TipoVendedorId, T001O2_A373TipoRangoId, T001O2_A374TipoRangoNombre, T001O2_A375TipoRangoInicial, T001O2_A376TipoRangoFinal, T001O2_A377TipoRangoPorcentaje, T001O2_A379TipoRangoPorcentajeJefe
               }
               , new Object[] {
               T001O3_A41ClinicaCodigo, T001O3_A370TipoVendedorId, T001O3_A373TipoRangoId, T001O3_A374TipoRangoNombre, T001O3_A375TipoRangoInicial, T001O3_A376TipoRangoFinal, T001O3_A377TipoRangoPorcentaje, T001O3_A379TipoRangoPorcentajeJefe
               }
               , new Object[] {
               T001O4_A370TipoVendedorId, T001O4_A371TipoVendedorNombre, T001O4_A378TipoVendedorEsJefe, T001O4_A372TipoVendedorEstado, T001O4_A41ClinicaCodigo
               }
               , new Object[] {
               T001O5_A370TipoVendedorId, T001O5_A371TipoVendedorNombre, T001O5_A378TipoVendedorEsJefe, T001O5_A372TipoVendedorEstado, T001O5_A41ClinicaCodigo
               }
               , new Object[] {
               T001O6_A41ClinicaCodigo
               }
               , new Object[] {
               T001O7_A370TipoVendedorId, T001O7_A371TipoVendedorNombre, T001O7_A378TipoVendedorEsJefe, T001O7_A372TipoVendedorEstado, T001O7_A41ClinicaCodigo
               }
               , new Object[] {
               T001O8_A41ClinicaCodigo
               }
               , new Object[] {
               T001O9_A41ClinicaCodigo, T001O9_A370TipoVendedorId
               }
               , new Object[] {
               T001O10_A41ClinicaCodigo, T001O10_A370TipoVendedorId
               }
               , new Object[] {
               T001O11_A41ClinicaCodigo, T001O11_A370TipoVendedorId
               }
               , new Object[] {
               T001O12_A370TipoVendedorId, T001O12_A371TipoVendedorNombre, T001O12_A378TipoVendedorEsJefe, T001O12_A372TipoVendedorEstado, T001O12_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001O16_A41ClinicaCodigo, T001O16_A317VendedorCodigo
               }
               , new Object[] {
               T001O17_A41ClinicaCodigo, T001O17_A370TipoVendedorId
               }
               , new Object[] {
               T001O18_A41ClinicaCodigo, T001O18_A370TipoVendedorId, T001O18_A373TipoRangoId, T001O18_A374TipoRangoNombre, T001O18_A375TipoRangoInicial, T001O18_A376TipoRangoFinal, T001O18_A377TipoRangoPorcentaje, T001O18_A379TipoRangoPorcentajeJefe
               }
               , new Object[] {
               T001O19_A41ClinicaCodigo, T001O19_A370TipoVendedorId, T001O19_A373TipoRangoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001O23_A41ClinicaCodigo, T001O23_A370TipoVendedorId, T001O23_A373TipoRangoId
               }
               , new Object[] {
               T001O24_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridtipovendedor_tiporango ;
      private short nGXsfl_65_idx=1 ;
      private short gxcookieaux ;
      private short A378TipoVendedorEsJefe ;
      private short A372TipoVendedorEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridtipovendedor_tiporango_Backcolorstyle ;
      private short subGridtipovendedor_tiporango_Allowcollapsing ;
      private short subGridtipovendedor_tiporango_Collapsed ;
      private short nBlankRcdCount77 ;
      private short nRcdExists_77 ;
      private short RcdFound77 ;
      private short nIsMod_77 ;
      private short nBlankRcdUsr77 ;
      private short Z378TipoVendedorEsJefe ;
      private short Z372TipoVendedorEstado ;
      private short nRcdDeleted_77 ;
      private short GX_JID ;
      private short RcdFound76 ;
      private short Gx_BScreen ;
      private short subGridtipovendedor_tiporango_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int lblTextblockclinicacodigo_Visible ;
      private int edtClinicaCodigo_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int imgprompt_41_Visible ;
      private int A370TipoVendedorId ;
      private int edtTipoVendedorId_Enabled ;
      private int edtTipoVendedorNombre_Enabled ;
      private int A373TipoRangoId ;
      private int edtTipoRangoId_Enabled ;
      private int edtTipoRangoNombre_Enabled ;
      private int edtTipoRangoInicial_Enabled ;
      private int edtTipoRangoFinal_Enabled ;
      private int edtTipoRangoPorcentaje_Enabled ;
      private int edtTipoRangoPorcentajeJefe_Enabled ;
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
      private int Z370TipoVendedorId ;
      private int GRIDTIPOVENDEDOR_TIPORANGO_nFirstRecordOnPage ;
      private int Z373TipoRangoId ;
      private int AnyError41 ;
      private int subGridtipovendedor_tiporango_Backcolor ;
      private int subGridtipovendedor_tiporango_Allbackcolor ;
      private int defedtTipoRangoId_Enabled ;
      private int idxLst ;
      private decimal A375TipoRangoInicial ;
      private decimal A376TipoRangoFinal ;
      private decimal A377TipoRangoPorcentaje ;
      private decimal A379TipoRangoPorcentajeJefe ;
      private decimal Z375TipoRangoInicial ;
      private decimal Z376TipoRangoFinal ;
      private decimal Z377TipoRangoPorcentaje ;
      private decimal Z379TipoRangoPorcentajeJefe ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_65_idx="0001" ;
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
      private String lblTextblocktipovendedorid_Internalname ;
      private String lblTextblocktipovendedorid_Jsonclick ;
      private String edtTipoVendedorId_Internalname ;
      private String edtTipoVendedorId_Jsonclick ;
      private String lblTextblocktipovendedornombre_Internalname ;
      private String lblTextblocktipovendedornombre_Jsonclick ;
      private String edtTipoVendedorNombre_Internalname ;
      private String edtTipoVendedorNombre_Jsonclick ;
      private String lblTextblocktipovendedoresjefe_Internalname ;
      private String lblTextblocktipovendedoresjefe_Jsonclick ;
      private String cmbTipoVendedorEsJefe_Internalname ;
      private String cmbTipoVendedorEsJefe_Jsonclick ;
      private String lblTextblocktipovendedorestado_Internalname ;
      private String lblTextblocktipovendedorestado_Jsonclick ;
      private String cmbTipoVendedorEstado_Internalname ;
      private String cmbTipoVendedorEstado_Jsonclick ;
      private String Gx_mode ;
      private String sMode77 ;
      private String edtTipoRangoId_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitletiporango_Internalname ;
      private String lblTitletiporango_Jsonclick ;
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
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtTipoRangoNombre_Internalname ;
      private String edtTipoRangoInicial_Internalname ;
      private String edtTipoRangoFinal_Internalname ;
      private String edtTipoRangoPorcentaje_Internalname ;
      private String edtTipoRangoPorcentajeJefe_Internalname ;
      private String sMode76 ;
      private String subGridtipovendedor_tiporango_Class ;
      private String subGridtipovendedor_tiporango_Linesclass ;
      private String ROClassString ;
      private String edtTipoRangoId_Jsonclick ;
      private String edtTipoRangoNombre_Jsonclick ;
      private String edtTipoRangoInicial_Jsonclick ;
      private String edtTipoRangoFinal_Jsonclick ;
      private String edtTipoRangoPorcentaje_Jsonclick ;
      private String edtTipoRangoPorcentajeJefe_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private String GXt_char14 ;
      private String GXt_char15 ;
      private String GXt_char16 ;
      private String GXt_char17 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char19 ;
      private String GXt_char18 ;
      private String subGridtipovendedor_tiporango_Internalname ;
      private String GXt_char20 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A371TipoVendedorNombre ;
      private String A374TipoRangoNombre ;
      private String Z41ClinicaCodigo ;
      private String Z371TipoVendedorNombre ;
      private String AV7ClinicaCodigo ;
      private String Z374TipoRangoNombre ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridtipovendedor_tiporangoContainer ;
      private GXWebRow Gridtipovendedor_tiporangoRow ;
      private GXWebColumn Gridtipovendedor_tiporangoColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTipoVendedorEsJefe ;
      private GXCombobox cmbTipoVendedorEstado ;
      private IDataStoreProvider pr_default ;
      private int[] T001O7_A370TipoVendedorId ;
      private String[] T001O7_A371TipoVendedorNombre ;
      private short[] T001O7_A378TipoVendedorEsJefe ;
      private short[] T001O7_A372TipoVendedorEstado ;
      private String[] T001O7_A41ClinicaCodigo ;
      private String[] T001O6_A41ClinicaCodigo ;
      private String[] T001O8_A41ClinicaCodigo ;
      private String[] T001O9_A41ClinicaCodigo ;
      private int[] T001O9_A370TipoVendedorId ;
      private int[] T001O5_A370TipoVendedorId ;
      private String[] T001O5_A371TipoVendedorNombre ;
      private short[] T001O5_A378TipoVendedorEsJefe ;
      private short[] T001O5_A372TipoVendedorEstado ;
      private String[] T001O5_A41ClinicaCodigo ;
      private String[] T001O10_A41ClinicaCodigo ;
      private int[] T001O10_A370TipoVendedorId ;
      private String[] T001O11_A41ClinicaCodigo ;
      private int[] T001O11_A370TipoVendedorId ;
      private int[] T001O12_A370TipoVendedorId ;
      private String[] T001O12_A371TipoVendedorNombre ;
      private short[] T001O12_A378TipoVendedorEsJefe ;
      private short[] T001O12_A372TipoVendedorEstado ;
      private String[] T001O12_A41ClinicaCodigo ;
      private String[] T001O16_A41ClinicaCodigo ;
      private String[] T001O16_A317VendedorCodigo ;
      private String[] T001O17_A41ClinicaCodigo ;
      private int[] T001O17_A370TipoVendedorId ;
      private String[] T001O18_A41ClinicaCodigo ;
      private int[] T001O18_A370TipoVendedorId ;
      private int[] T001O18_A373TipoRangoId ;
      private String[] T001O18_A374TipoRangoNombre ;
      private decimal[] T001O18_A375TipoRangoInicial ;
      private decimal[] T001O18_A376TipoRangoFinal ;
      private decimal[] T001O18_A377TipoRangoPorcentaje ;
      private decimal[] T001O18_A379TipoRangoPorcentajeJefe ;
      private String[] T001O19_A41ClinicaCodigo ;
      private int[] T001O19_A370TipoVendedorId ;
      private int[] T001O19_A373TipoRangoId ;
      private String[] T001O3_A41ClinicaCodigo ;
      private int[] T001O3_A370TipoVendedorId ;
      private int[] T001O3_A373TipoRangoId ;
      private String[] T001O3_A374TipoRangoNombre ;
      private decimal[] T001O3_A375TipoRangoInicial ;
      private decimal[] T001O3_A376TipoRangoFinal ;
      private decimal[] T001O3_A377TipoRangoPorcentaje ;
      private decimal[] T001O3_A379TipoRangoPorcentajeJefe ;
      private String[] T001O2_A41ClinicaCodigo ;
      private int[] T001O2_A370TipoVendedorId ;
      private int[] T001O2_A373TipoRangoId ;
      private String[] T001O2_A374TipoRangoNombre ;
      private decimal[] T001O2_A375TipoRangoInicial ;
      private decimal[] T001O2_A376TipoRangoFinal ;
      private decimal[] T001O2_A377TipoRangoPorcentaje ;
      private decimal[] T001O2_A379TipoRangoPorcentajeJefe ;
      private String[] T001O23_A41ClinicaCodigo ;
      private int[] T001O23_A370TipoVendedorId ;
      private int[] T001O23_A373TipoRangoId ;
      private String[] T001O24_A41ClinicaCodigo ;
      private int[] T001O4_A370TipoVendedorId ;
      private String[] T001O4_A371TipoVendedorNombre ;
      private short[] T001O4_A378TipoVendedorEsJefe ;
      private short[] T001O4_A372TipoVendedorEstado ;
      private String[] T001O4_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV8Parametros ;
      private SdtParametros GXt_SdtParametros10 ;
   }

   public class tipovendedor__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001O4 ;
          prmT001O4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O7 ;
          prmT001O7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O6 ;
          prmT001O6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001O8 ;
          prmT001O8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001O9 ;
          prmT001O9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O5 ;
          prmT001O5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O10 ;
          prmT001O10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O11 ;
          prmT001O11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O12 ;
          prmT001O12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O13 ;
          prmT001O13 = new Object[] {
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoVendedorNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@TipoVendedorEsJefe",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoVendedorEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001O14 ;
          prmT001O14 = new Object[] {
          new Object[] {"@TipoVendedorNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@TipoVendedorEsJefe",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoVendedorEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O15 ;
          prmT001O15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O16 ;
          prmT001O16 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O17 ;
          prmT001O17 = new Object[] {
          } ;
          Object[] prmT001O18 ;
          prmT001O18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoRangoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O19 ;
          prmT001O19 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoRangoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O3 ;
          prmT001O3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoRangoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O2 ;
          prmT001O2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoRangoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O20 ;
          prmT001O20 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoRangoId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoRangoNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@TipoRangoInicial",SqlDbType.Decimal,17,2} ,
          new Object[] {"@TipoRangoFinal",SqlDbType.Decimal,17,2} ,
          new Object[] {"@TipoRangoPorcentaje",SqlDbType.Decimal,17,2} ,
          new Object[] {"@TipoRangoPorcentajeJefe",SqlDbType.Decimal,17,2}
          } ;
          Object[] prmT001O21 ;
          prmT001O21 = new Object[] {
          new Object[] {"@TipoRangoNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@TipoRangoInicial",SqlDbType.Decimal,17,2} ,
          new Object[] {"@TipoRangoFinal",SqlDbType.Decimal,17,2} ,
          new Object[] {"@TipoRangoPorcentaje",SqlDbType.Decimal,17,2} ,
          new Object[] {"@TipoRangoPorcentajeJefe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoRangoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O22 ;
          prmT001O22 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0} ,
          new Object[] {"@TipoRangoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O23 ;
          prmT001O23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoVendedorId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001O24 ;
          prmT001O24 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001O2", "SELECT [ClinicaCodigo], [TipoVendedorId], [TipoRangoId], [TipoRangoNombre], [TipoRangoInicial], [TipoRangoFinal], [TipoRangoPorcentaje], [TipoRangoPorcentajeJefe] FROM [TipoVendedorRango] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId AND [TipoRangoId] = @TipoRangoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O2,1,0,true,false )
             ,new CursorDef("T001O3", "SELECT [ClinicaCodigo], [TipoVendedorId], [TipoRangoId], [TipoRangoNombre], [TipoRangoInicial], [TipoRangoFinal], [TipoRangoPorcentaje], [TipoRangoPorcentajeJefe] FROM [TipoVendedorRango] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId AND [TipoRangoId] = @TipoRangoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O3,1,0,true,false )
             ,new CursorDef("T001O4", "SELECT [TipoVendedorId], [TipoVendedorNombre], [TipoVendedorEsJefe], [TipoVendedorEstado], [ClinicaCodigo] FROM [TipoVendedor] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O4,1,0,true,false )
             ,new CursorDef("T001O5", "SELECT [TipoVendedorId], [TipoVendedorNombre], [TipoVendedorEsJefe], [TipoVendedorEstado], [ClinicaCodigo] FROM [TipoVendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O5,1,0,true,false )
             ,new CursorDef("T001O6", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O6,1,0,true,false )
             ,new CursorDef("T001O7", "SELECT TM1.[TipoVendedorId], TM1.[TipoVendedorNombre], TM1.[TipoVendedorEsJefe], TM1.[TipoVendedorEstado], TM1.[ClinicaCodigo] FROM [TipoVendedor] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[TipoVendedorId] = @TipoVendedorId ORDER BY TM1.[ClinicaCodigo], TM1.[TipoVendedorId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O7,100,0,true,false )
             ,new CursorDef("T001O8", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O8,1,0,true,false )
             ,new CursorDef("T001O9", "SELECT [ClinicaCodigo], [TipoVendedorId] FROM [TipoVendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O9,1,0,true,false )
             ,new CursorDef("T001O10", "SELECT TOP 1 [ClinicaCodigo], [TipoVendedorId] FROM [TipoVendedor] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoVendedorId] > @TipoVendedorId) ORDER BY [ClinicaCodigo], [TipoVendedorId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O10,1,0,true,true )
             ,new CursorDef("T001O11", "SELECT TOP 1 [ClinicaCodigo], [TipoVendedorId] FROM [TipoVendedor] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [TipoVendedorId] < @TipoVendedorId) ORDER BY [ClinicaCodigo] DESC, [TipoVendedorId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O11,1,0,true,true )
             ,new CursorDef("T001O12", "SELECT [TipoVendedorId], [TipoVendedorNombre], [TipoVendedorEsJefe], [TipoVendedorEstado], [ClinicaCodigo] FROM [TipoVendedor] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O12,1,0,true,false )
             ,new CursorDef("T001O13", "INSERT INTO [TipoVendedor] ([TipoVendedorId], [TipoVendedorNombre], [TipoVendedorEsJefe], [TipoVendedorEstado], [ClinicaCodigo]) VALUES (@TipoVendedorId, @TipoVendedorNombre, @TipoVendedorEsJefe, @TipoVendedorEstado, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT001O13)
             ,new CursorDef("T001O14", "UPDATE [TipoVendedor] SET [TipoVendedorNombre]=@TipoVendedorNombre, [TipoVendedorEsJefe]=@TipoVendedorEsJefe, [TipoVendedorEstado]=@TipoVendedorEstado  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId", GxErrorMask.GX_NOMASK,prmT001O14)
             ,new CursorDef("T001O15", "DELETE FROM [TipoVendedor]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId", GxErrorMask.GX_NOMASK,prmT001O15)
             ,new CursorDef("T001O16", "SELECT TOP 1 [ClinicaCodigo], [VendedorCodigo] FROM [Vendedor] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O16,1,0,true,true )
             ,new CursorDef("T001O17", "SELECT [ClinicaCodigo], [TipoVendedorId] FROM [TipoVendedor] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [TipoVendedorId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001O17,100,0,true,false )
             ,new CursorDef("T001O18", "SELECT [ClinicaCodigo], [TipoVendedorId], [TipoRangoId], [TipoRangoNombre], [TipoRangoInicial], [TipoRangoFinal], [TipoRangoPorcentaje], [TipoRangoPorcentajeJefe] FROM [TipoVendedorRango] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoVendedorId] = @TipoVendedorId and [TipoRangoId] = @TipoRangoId ORDER BY [ClinicaCodigo], [TipoVendedorId], [TipoRangoId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O18,11,0,true,false )
             ,new CursorDef("T001O19", "SELECT [ClinicaCodigo], [TipoVendedorId], [TipoRangoId] FROM [TipoVendedorRango] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId AND [TipoRangoId] = @TipoRangoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O19,1,0,true,false )
             ,new CursorDef("T001O20", "INSERT INTO [TipoVendedorRango] ([ClinicaCodigo], [TipoVendedorId], [TipoRangoId], [TipoRangoNombre], [TipoRangoInicial], [TipoRangoFinal], [TipoRangoPorcentaje], [TipoRangoPorcentajeJefe]) VALUES (@ClinicaCodigo, @TipoVendedorId, @TipoRangoId, @TipoRangoNombre, @TipoRangoInicial, @TipoRangoFinal, @TipoRangoPorcentaje, @TipoRangoPorcentajeJefe)", GxErrorMask.GX_NOMASK,prmT001O20)
             ,new CursorDef("T001O21", "UPDATE [TipoVendedorRango] SET [TipoRangoNombre]=@TipoRangoNombre, [TipoRangoInicial]=@TipoRangoInicial, [TipoRangoFinal]=@TipoRangoFinal, [TipoRangoPorcentaje]=@TipoRangoPorcentaje, [TipoRangoPorcentajeJefe]=@TipoRangoPorcentajeJefe  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId AND [TipoRangoId] = @TipoRangoId", GxErrorMask.GX_NOMASK,prmT001O21)
             ,new CursorDef("T001O22", "DELETE FROM [TipoVendedorRango]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoVendedorId] = @TipoVendedorId AND [TipoRangoId] = @TipoRangoId", GxErrorMask.GX_NOMASK,prmT001O22)
             ,new CursorDef("T001O23", "SELECT [ClinicaCodigo], [TipoVendedorId], [TipoRangoId] FROM [TipoVendedorRango] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoVendedorId] = @TipoVendedorId ORDER BY [ClinicaCodigo], [TipoVendedorId], [TipoRangoId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O23,11,0,true,false )
             ,new CursorDef("T001O24", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001O24,1,0,true,false )
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 22 :
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                stmt.SetParameter(8, (decimal)parms[7]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                stmt.SetParameter(8, (int)parms[7]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
