/*
               File: Articulo
        Description: Maestro de productos y servicios
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:26.98
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
   public class articulo : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"CATEGORIACODIGO") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLACATEGORIACODIGO0812( A41ClinicaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"SUBCATEGORIACODIGO") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A27CategoriaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLASUBCATEGORIACODIGO0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A27CategoriaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
            A124SubCategoriaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SubCategoriaCodigo", A124SubCategoriaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A41ClinicaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A380UnidadMedidaCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A380UnidadMedidaCodigo", A380UnidadMedidaCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_9( A41ClinicaCodigo, A380UnidadMedidaCodigo) ;
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
         dynCategoriaCodigo.Name = "CATEGORIACODIGO" ;
         dynCategoriaCodigo.WebTags = "" ;
         dynSubCategoriaCodigo.Name = "SUBCATEGORIACODIGO" ;
         dynSubCategoriaCodigo.WebTags = "" ;
         cmbArticuloTipo.Name = "ARTICULOTIPO" ;
         cmbArticuloTipo.WebTags = "" ;
         cmbArticuloTipo.addItem("0", "Servicio", 0);
         cmbArticuloTipo.addItem("1", "Producto", 0);
         if ( ( cmbArticuloTipo.ItemCount > 0 ) && (0==A33ArticuloTipo) )
         {
            A33ArticuloTipo = (short)(NumberUtil.Val( cmbArticuloTipo.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33ArticuloTipo", StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0));
         }
         cmbArticuloEstado.Name = "ARTICULOESTADO" ;
         cmbArticuloEstado.WebTags = "" ;
         cmbArticuloEstado.addItem("0", "De baja", 0);
         cmbArticuloEstado.addItem("1", "Activo", 0);
         if ( ( cmbArticuloEstado.ItemCount > 0 ) && (0==A34ArticuloEstado) )
         {
            A34ArticuloEstado = (short)(NumberUtil.Val( cmbArticuloEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34ArticuloEstado", StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0));
         }
         cmbArticuloCirugia.Name = "ARTICULOCIRUGIA" ;
         cmbArticuloCirugia.WebTags = "" ;
         cmbArticuloCirugia.addItem("0", "No", 0);
         cmbArticuloCirugia.addItem("1", "Si", 0);
         if ( ( cmbArticuloCirugia.ItemCount > 0 ) && (0==A387ArticuloCirugia) )
         {
            A387ArticuloCirugia = (short)(NumberUtil.Val( cmbArticuloCirugia.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387ArticuloCirugia", StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Maestro de productos y servicios", 0) ;
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

      public articulo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public articulo( IGxContext context )
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
         dynCategoriaCodigo = new GXCombobox();
         dynSubCategoriaCodigo = new GXCombobox();
         cmbArticuloTipo = new GXCombobox();
         cmbArticuloEstado = new GXCombobox();
         cmbArticuloCirugia = new GXCombobox();
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
            wb_table1_2_0812( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0812e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0812( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0812( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0812e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Maestro de productos y servicios"+"</legend>") ;
            wb_table3_27_0812( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0812e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0812e( true) ;
         }
         else
         {
            wb_table1_2_0812e( false) ;
         }
      }

      protected void wb_table3_27_0812( bool wbgen )
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
            wb_table4_33_0812( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0812e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Articulo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Articulo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0812e( true) ;
         }
         else
         {
            wb_table3_27_0812e( false) ;
         }
      }

      protected void wb_table4_33_0812( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Articulo.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulocodigo_Internalname, "Artículo", "", "", lblTextblockarticulocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloCodigo_Internalname, StringUtil.RTrim( A30ArticuloCodigo), StringUtil.RTrim( context.localUtil.Format( A30ArticuloCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtArticuloCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulodescripcion_Internalname, "Artículo", "", "", lblTextblockarticulodescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31ArticuloDescripcion", A31ArticuloDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloDescripcion_Internalname, StringUtil.RTrim( A31ArticuloDescripcion), StringUtil.RTrim( context.localUtil.Format( A31ArticuloDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtArticuloDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloprecio_Internalname, "Precio", "", "", lblTextblockarticuloprecio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32ArticuloPrecio", StringUtil.LTrim( StringUtil.Str( A32ArticuloPrecio, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A32ArticuloPrecio, 17, 2, ".", "")), ((edtArticuloPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A32ArticuloPrecio, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A32ArticuloPrecio, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(53);\"", "", "", "", "", edtArticuloPrecio_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloPrecio_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulocosto_Internalname, "Costo", "", "", lblTextblockarticulocosto_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ArticuloCosto", StringUtil.LTrim( StringUtil.Str( A60ArticuloCosto, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloCosto_Internalname, StringUtil.LTrim( StringUtil.NToC( A60ArticuloCosto, 17, 2, ".", "")), ((edtArticuloCosto_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A60ArticuloCosto, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A60ArticuloCosto, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(58);\"", "", "", "", "", edtArticuloCosto_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloCosto_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:23px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcategoriacodigo_Internalname, "Descripción", "", "", lblTextblockcategoriacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynCategoriaCodigo, dynCategoriaCodigo_Internalname, A27CategoriaCodigo, 1, dynCategoriaCodigo_Jsonclick, 0, "", "svchar", "", 1, dynCategoriaCodigo.Enabled, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", true, "HLP_Articulo.htm");
            dynCategoriaCodigo.CurrentValue = A27CategoriaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynCategoriaCodigo_Internalname, "Values", (String)(dynCategoriaCodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:22px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksubcategoriacodigo_Internalname, "Sub_Categoría", "", "", lblTextblocksubcategoriacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SubCategoriaCodigo", A124SubCategoriaCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynSubCategoriaCodigo, dynSubCategoriaCodigo_Internalname, A124SubCategoriaCodigo, 1, dynSubCategoriaCodigo_Jsonclick, 0, "", "svchar", "", 1, dynSubCategoriaCodigo.Enabled, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", true, "HLP_Articulo.htm");
            dynSubCategoriaCodigo.CurrentValue = A124SubCategoriaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynSubCategoriaCodigo_Internalname, "Values", (String)(dynSubCategoriaCodigo.ToJavascriptSource()));
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_27_124_Internalname, "prompt.gif", imgprompt_27_124_Link, "", "", "Fantastic", imgprompt_27_124_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulotipo_Internalname, "Tipo", "", "", lblTextblockarticulotipo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33ArticuloTipo", StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbArticuloTipo, cmbArticuloTipo_Internalname, StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0), 1, cmbArticuloTipo_Jsonclick, 0, "", "int", "", 1, cmbArticuloTipo.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", true, "HLP_Articulo.htm");
            cmbArticuloTipo.CurrentValue = StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbArticuloTipo_Internalname, "Values", (String)(cmbArticuloTipo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloestado_Internalname, "Estado", "", "", lblTextblockarticuloestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34ArticuloEstado", StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbArticuloEstado, cmbArticuloEstado_Internalname, StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0), 1, cmbArticuloEstado_Jsonclick, 0, "", "int", "", 1, cmbArticuloEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", true, "HLP_Articulo.htm");
            cmbArticuloEstado.CurrentValue = StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbArticuloEstado_Internalname, "Values", (String)(cmbArticuloEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloestado2_Internalname, "Es cirugía?", "", "", lblTextblockarticuloestado2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387ArticuloCirugia", StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbArticuloCirugia, cmbArticuloCirugia_Internalname, StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0), 1, cmbArticuloCirugia_Jsonclick, 0, "", "int", "", 1, cmbArticuloCirugia.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(83);\"", "", true, "HLP_Articulo.htm");
            cmbArticuloCirugia.CurrentValue = StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbArticuloCirugia_Internalname, "Values", (String)(cmbArticuloCirugia.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloestado3_Internalname, "Honorario Cirujano", "", "", lblTextblockarticuloestado3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ArticuloHonorarioCirujano", StringUtil.LTrim( StringUtil.Str( A394ArticuloHonorarioCirujano, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloHonorarioCirujano_Internalname, StringUtil.LTrim( StringUtil.NToC( A394ArticuloHonorarioCirujano, 17, 2, ".", "")), ((edtArticuloHonorarioCirujano_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A394ArticuloHonorarioCirujano, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A394ArticuloHonorarioCirujano, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(88);\"", "", "", "", "", edtArticuloHonorarioCirujano_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloHonorarioCirujano_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloestado4_Internalname, "Honorario Anestesiologo", "", "", lblTextblockarticuloestado4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389ArticuloHonorarioAnestesiologo", StringUtil.LTrim( StringUtil.Str( A389ArticuloHonorarioAnestesiologo, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloHonorarioAnestesiologo_Internalname, StringUtil.LTrim( StringUtil.NToC( A389ArticuloHonorarioAnestesiologo, 17, 2, ".", "")), ((edtArticuloHonorarioAnestesiologo_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A389ArticuloHonorarioAnestesiologo, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A389ArticuloHonorarioAnestesiologo, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(93);\"", "", "", "", "", edtArticuloHonorarioAnestesiologo_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloHonorarioAnestesiologo_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloestado5_Internalname, "Implantes", "", "", lblTextblockarticuloestado5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390ArticuloImplante", StringUtil.LTrim( StringUtil.Str( A390ArticuloImplante, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloImplante_Internalname, StringUtil.LTrim( StringUtil.NToC( A390ArticuloImplante, 17, 2, ".", "")), ((edtArticuloImplante_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A390ArticuloImplante, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A390ArticuloImplante, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(98);\"", "", "", "", "", edtArticuloImplante_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloImplante_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:20px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloestado6_Internalname, "Medicamentos", "", "", lblTextblockarticuloestado6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391ArticuloMedicamento", StringUtil.LTrim( StringUtil.Str( A391ArticuloMedicamento, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloMedicamento_Internalname, StringUtil.LTrim( StringUtil.NToC( A391ArticuloMedicamento, 17, 2, ".", "")), ((edtArticuloMedicamento_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A391ArticuloMedicamento, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A391ArticuloMedicamento, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(103);\"", "", "", "", "", edtArticuloMedicamento_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloMedicamento_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticuloestado7_Internalname, "Otros", "", "", lblTextblockarticuloestado7_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392ArticuloOtro", StringUtil.LTrim( StringUtil.Str( A392ArticuloOtro, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloOtro_Internalname, StringUtil.LTrim( StringUtil.NToC( A392ArticuloOtro, 17, 2, ".", "")), ((edtArticuloOtro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A392ArticuloOtro, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A392ArticuloOtro, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(108);\"", "", "", "", "", edtArticuloOtro_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloOtro_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Articulo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0812e( true) ;
         }
         else
         {
            wb_table4_33_0812e( false) ;
         }
      }

      protected void wb_table2_5_0812( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOCODIGO"+"'), id:'"+"ARTICULOCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOCODIGO"+"'), id:'"+"ARTICULOCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Articulo.htm");
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
            wb_table2_5_0812e( true) ;
         }
         else
         {
            wb_table2_5_0812e( false) ;
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
         /* Execute user event: E11082 */
         E11082 ();
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
               A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
               A31ArticuloDescripcion = cgiGet( edtArticuloDescripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31ArticuloDescripcion", A31ArticuloDescripcion);
               if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloPrecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloPrecio_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOPRECIO");
                  AnyError = 1 ;
                  GX_FocusControl = edtArticuloPrecio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A32ArticuloPrecio = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32ArticuloPrecio", StringUtil.LTrim( StringUtil.Str( A32ArticuloPrecio, 17, 2)));
               }
               else
               {
                  A32ArticuloPrecio = context.localUtil.CToN( cgiGet( edtArticuloPrecio_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32ArticuloPrecio", StringUtil.LTrim( StringUtil.Str( A32ArticuloPrecio, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloCosto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloCosto_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOCOSTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtArticuloCosto_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A60ArticuloCosto = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ArticuloCosto", StringUtil.LTrim( StringUtil.Str( A60ArticuloCosto, 17, 2)));
               }
               else
               {
                  A60ArticuloCosto = context.localUtil.CToN( cgiGet( edtArticuloCosto_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ArticuloCosto", StringUtil.LTrim( StringUtil.Str( A60ArticuloCosto, 17, 2)));
               }
               dynCategoriaCodigo.CurrentValue = cgiGet( dynCategoriaCodigo_Internalname) ;
               A27CategoriaCodigo = cgiGet( dynCategoriaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
               dynSubCategoriaCodigo.CurrentValue = cgiGet( dynSubCategoriaCodigo_Internalname) ;
               A124SubCategoriaCodigo = cgiGet( dynSubCategoriaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SubCategoriaCodigo", A124SubCategoriaCodigo);
               cmbArticuloTipo.CurrentValue = cgiGet( cmbArticuloTipo_Internalname) ;
               A33ArticuloTipo = (short)(NumberUtil.Val( cgiGet( cmbArticuloTipo_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33ArticuloTipo", StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0));
               cmbArticuloEstado.CurrentValue = cgiGet( cmbArticuloEstado_Internalname) ;
               A34ArticuloEstado = (short)(NumberUtil.Val( cgiGet( cmbArticuloEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34ArticuloEstado", StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0));
               cmbArticuloCirugia.CurrentValue = cgiGet( cmbArticuloCirugia_Internalname) ;
               A387ArticuloCirugia = (short)(NumberUtil.Val( cgiGet( cmbArticuloCirugia_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387ArticuloCirugia", StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0));
               if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloHonorarioCirujano_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloHonorarioCirujano_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOHONORARIOCIRUJANO");
                  AnyError = 1 ;
                  GX_FocusControl = edtArticuloHonorarioCirujano_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A394ArticuloHonorarioCirujano = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ArticuloHonorarioCirujano", StringUtil.LTrim( StringUtil.Str( A394ArticuloHonorarioCirujano, 17, 2)));
               }
               else
               {
                  A394ArticuloHonorarioCirujano = context.localUtil.CToN( cgiGet( edtArticuloHonorarioCirujano_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ArticuloHonorarioCirujano", StringUtil.LTrim( StringUtil.Str( A394ArticuloHonorarioCirujano, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloHonorarioAnestesiologo_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloHonorarioAnestesiologo_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOHONORARIOANESTESIOLOGO");
                  AnyError = 1 ;
                  GX_FocusControl = edtArticuloHonorarioAnestesiologo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A389ArticuloHonorarioAnestesiologo = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389ArticuloHonorarioAnestesiologo", StringUtil.LTrim( StringUtil.Str( A389ArticuloHonorarioAnestesiologo, 17, 2)));
               }
               else
               {
                  A389ArticuloHonorarioAnestesiologo = context.localUtil.CToN( cgiGet( edtArticuloHonorarioAnestesiologo_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389ArticuloHonorarioAnestesiologo", StringUtil.LTrim( StringUtil.Str( A389ArticuloHonorarioAnestesiologo, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloImplante_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloImplante_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOIMPLANTE");
                  AnyError = 1 ;
                  GX_FocusControl = edtArticuloImplante_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A390ArticuloImplante = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390ArticuloImplante", StringUtil.LTrim( StringUtil.Str( A390ArticuloImplante, 17, 2)));
               }
               else
               {
                  A390ArticuloImplante = context.localUtil.CToN( cgiGet( edtArticuloImplante_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390ArticuloImplante", StringUtil.LTrim( StringUtil.Str( A390ArticuloImplante, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloMedicamento_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloMedicamento_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOMEDICAMENTO");
                  AnyError = 1 ;
                  GX_FocusControl = edtArticuloMedicamento_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A391ArticuloMedicamento = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391ArticuloMedicamento", StringUtil.LTrim( StringUtil.Str( A391ArticuloMedicamento, 17, 2)));
               }
               else
               {
                  A391ArticuloMedicamento = context.localUtil.CToN( cgiGet( edtArticuloMedicamento_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391ArticuloMedicamento", StringUtil.LTrim( StringUtil.Str( A391ArticuloMedicamento, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtArticuloOtro_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtArticuloOtro_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ARTICULOOTRO");
                  AnyError = 1 ;
                  GX_FocusControl = edtArticuloOtro_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A392ArticuloOtro = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392ArticuloOtro", StringUtil.LTrim( StringUtil.Str( A392ArticuloOtro, 17, 2)));
               }
               else
               {
                  A392ArticuloOtro = context.localUtil.CToN( cgiGet( edtArticuloOtro_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392ArticuloOtro", StringUtil.LTrim( StringUtil.Str( A392ArticuloOtro, 17, 2)));
               }
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z30ArticuloCodigo = cgiGet( "Z30ArticuloCodigo") ;
               Z31ArticuloDescripcion = cgiGet( "Z31ArticuloDescripcion") ;
               Z32ArticuloPrecio = context.localUtil.CToN( cgiGet( "Z32ArticuloPrecio"), ".", ",") ;
               Z60ArticuloCosto = context.localUtil.CToN( cgiGet( "Z60ArticuloCosto"), ".", ",") ;
               Z33ArticuloTipo = (short)(context.localUtil.CToN( cgiGet( "Z33ArticuloTipo"), ".", ",")) ;
               Z34ArticuloEstado = (short)(context.localUtil.CToN( cgiGet( "Z34ArticuloEstado"), ".", ",")) ;
               Z387ArticuloCirugia = (short)(context.localUtil.CToN( cgiGet( "Z387ArticuloCirugia"), ".", ",")) ;
               Z394ArticuloHonorarioCirujano = context.localUtil.CToN( cgiGet( "Z394ArticuloHonorarioCirujano"), ".", ",") ;
               Z389ArticuloHonorarioAnestesiologo = context.localUtil.CToN( cgiGet( "Z389ArticuloHonorarioAnestesiologo"), ".", ",") ;
               Z390ArticuloImplante = context.localUtil.CToN( cgiGet( "Z390ArticuloImplante"), ".", ",") ;
               Z391ArticuloMedicamento = context.localUtil.CToN( cgiGet( "Z391ArticuloMedicamento"), ".", ",") ;
               Z392ArticuloOtro = context.localUtil.CToN( cgiGet( "Z392ArticuloOtro"), ".", ",") ;
               Z27CategoriaCodigo = cgiGet( "Z27CategoriaCodigo") ;
               Z124SubCategoriaCodigo = cgiGet( "Z124SubCategoriaCodigo") ;
               Z380UnidadMedidaCodigo = cgiGet( "Z380UnidadMedidaCodigo") ;
               A380UnidadMedidaCodigo = cgiGet( "Z380UnidadMedidaCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               A393ArticuloCalculoTotal = context.localUtil.CToN( cgiGet( "ARTICULOCALCULOTOTAL"), ".", ",") ;
               AV8ClinicaCodigo = cgiGet( "vCLINICACODIGO") ;
               A380UnidadMedidaCodigo = cgiGet( "UNIDADMEDIDACODIGO") ;
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
                  A30ArticuloCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
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
                           /* Execute user event: E11082 */
                           E11082 ();
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
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0812( ) ;
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
         DisableAttributes0812( ) ;
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

      protected void ResetCaption080( )
      {
      }

      protected void E11082( )
      {
         /* Start Routine */
         GXt_SdtParametros3 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV7Parametros = GXt_SdtParametros3 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM0812( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z31ArticuloDescripcion = T00083_A31ArticuloDescripcion[0] ;
               Z32ArticuloPrecio = T00083_A32ArticuloPrecio[0] ;
               Z60ArticuloCosto = T00083_A60ArticuloCosto[0] ;
               Z33ArticuloTipo = T00083_A33ArticuloTipo[0] ;
               Z34ArticuloEstado = T00083_A34ArticuloEstado[0] ;
               Z387ArticuloCirugia = T00083_A387ArticuloCirugia[0] ;
               Z394ArticuloHonorarioCirujano = T00083_A394ArticuloHonorarioCirujano[0] ;
               Z389ArticuloHonorarioAnestesiologo = T00083_A389ArticuloHonorarioAnestesiologo[0] ;
               Z390ArticuloImplante = T00083_A390ArticuloImplante[0] ;
               Z391ArticuloMedicamento = T00083_A391ArticuloMedicamento[0] ;
               Z392ArticuloOtro = T00083_A392ArticuloOtro[0] ;
               Z27CategoriaCodigo = T00083_A27CategoriaCodigo[0] ;
               Z124SubCategoriaCodigo = T00083_A124SubCategoriaCodigo[0] ;
               Z380UnidadMedidaCodigo = T00083_A380UnidadMedidaCodigo[0] ;
            }
            else
            {
               Z31ArticuloDescripcion = A31ArticuloDescripcion ;
               Z32ArticuloPrecio = A32ArticuloPrecio ;
               Z60ArticuloCosto = A60ArticuloCosto ;
               Z33ArticuloTipo = A33ArticuloTipo ;
               Z34ArticuloEstado = A34ArticuloEstado ;
               Z387ArticuloCirugia = A387ArticuloCirugia ;
               Z394ArticuloHonorarioCirujano = A394ArticuloHonorarioCirujano ;
               Z389ArticuloHonorarioAnestesiologo = A389ArticuloHonorarioAnestesiologo ;
               Z390ArticuloImplante = A390ArticuloImplante ;
               Z391ArticuloMedicamento = A391ArticuloMedicamento ;
               Z392ArticuloOtro = A392ArticuloOtro ;
               Z27CategoriaCodigo = A27CategoriaCodigo ;
               Z124SubCategoriaCodigo = A124SubCategoriaCodigo ;
               Z380UnidadMedidaCodigo = A380UnidadMedidaCodigo ;
            }
         }
         if ( GX_JID == -7 )
         {
            Z30ArticuloCodigo = A30ArticuloCodigo ;
            Z31ArticuloDescripcion = A31ArticuloDescripcion ;
            Z32ArticuloPrecio = A32ArticuloPrecio ;
            Z60ArticuloCosto = A60ArticuloCosto ;
            Z33ArticuloTipo = A33ArticuloTipo ;
            Z34ArticuloEstado = A34ArticuloEstado ;
            Z387ArticuloCirugia = A387ArticuloCirugia ;
            Z394ArticuloHonorarioCirujano = A394ArticuloHonorarioCirujano ;
            Z389ArticuloHonorarioAnestesiologo = A389ArticuloHonorarioAnestesiologo ;
            Z390ArticuloImplante = A390ArticuloImplante ;
            Z391ArticuloMedicamento = A391ArticuloMedicamento ;
            Z392ArticuloOtro = A392ArticuloOtro ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z27CategoriaCodigo = A27CategoriaCodigo ;
            Z124SubCategoriaCodigo = A124SubCategoriaCodigo ;
            Z380UnidadMedidaCodigo = A380UnidadMedidaCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         imgprompt_41_Visible = edtClinicaCodigo_Visible ;
         imgprompt_41_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0260.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"UNIDADMEDIDACODIGO"+"'), id:'"+"UNIDADMEDIDACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         imgprompt_27_124_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00b1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+"}"+","+"{Ctrl:gx.dom.el('"+"CATEGORIACODIGO"+"'), id:'"+"CATEGORIACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"SUBCATEGORIACODIGO"+"'), id:'"+"SUBCATEGORIACODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         A41ClinicaCodigo = AV8ClinicaCodigo ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            GXACATEGORIACODIGO_html0812( A41ClinicaCodigo) ;
            GXASUBCATEGORIACODIGO_html0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         }
      }

      protected void Load0812( )
      {
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound12 = 1 ;
            A31ArticuloDescripcion = T00086_A31ArticuloDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31ArticuloDescripcion", A31ArticuloDescripcion);
            A32ArticuloPrecio = T00086_A32ArticuloPrecio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32ArticuloPrecio", StringUtil.LTrim( StringUtil.Str( A32ArticuloPrecio, 17, 2)));
            A60ArticuloCosto = T00086_A60ArticuloCosto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ArticuloCosto", StringUtil.LTrim( StringUtil.Str( A60ArticuloCosto, 17, 2)));
            A33ArticuloTipo = T00086_A33ArticuloTipo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33ArticuloTipo", StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0));
            A34ArticuloEstado = T00086_A34ArticuloEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34ArticuloEstado", StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0));
            A387ArticuloCirugia = T00086_A387ArticuloCirugia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387ArticuloCirugia", StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0));
            A394ArticuloHonorarioCirujano = T00086_A394ArticuloHonorarioCirujano[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ArticuloHonorarioCirujano", StringUtil.LTrim( StringUtil.Str( A394ArticuloHonorarioCirujano, 17, 2)));
            A389ArticuloHonorarioAnestesiologo = T00086_A389ArticuloHonorarioAnestesiologo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389ArticuloHonorarioAnestesiologo", StringUtil.LTrim( StringUtil.Str( A389ArticuloHonorarioAnestesiologo, 17, 2)));
            A390ArticuloImplante = T00086_A390ArticuloImplante[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390ArticuloImplante", StringUtil.LTrim( StringUtil.Str( A390ArticuloImplante, 17, 2)));
            A391ArticuloMedicamento = T00086_A391ArticuloMedicamento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391ArticuloMedicamento", StringUtil.LTrim( StringUtil.Str( A391ArticuloMedicamento, 17, 2)));
            A392ArticuloOtro = T00086_A392ArticuloOtro[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392ArticuloOtro", StringUtil.LTrim( StringUtil.Str( A392ArticuloOtro, 17, 2)));
            A27CategoriaCodigo = T00086_A27CategoriaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
            A124SubCategoriaCodigo = T00086_A124SubCategoriaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SubCategoriaCodigo", A124SubCategoriaCodigo);
            A380UnidadMedidaCodigo = T00086_A380UnidadMedidaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A380UnidadMedidaCodigo", A380UnidadMedidaCodigo);
            ZM0812( -7) ;
         }
         pr_default.close(4);
         OnLoadActions0812( ) ;
      }

      protected void OnLoadActions0812( )
      {
         GXACATEGORIACODIGO_html0812( A41ClinicaCodigo) ;
         GXASUBCATEGORIACODIGO_html0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         A393ArticuloCalculoTotal = (decimal)(A32ArticuloPrecio-A394ArticuloHonorarioCirujano-A389ArticuloHonorarioAnestesiologo-A390ArticuloImplante-A391ArticuloMedicamento-A392ArticuloOtro) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A393ArticuloCalculoTotal", StringUtil.LTrim( StringUtil.Str( A393ArticuloCalculoTotal, 17, 2)));
      }

      protected void CheckExtendedTable0812( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError27 = 1 ;
            AnyError124 = 1 ;
            GX_msglist.addItem("No existe 'Sub-Categorías'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError27 == 0 ) && ( AnyError124 == 0 ) )
         {
         }
         pr_default.close(2);
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A380UnidadMedidaCodigo});
         if ( (pr_default.getStatus(3) == 101) )
         {
            AnyError41 = 1 ;
            AnyError380 = 1 ;
            GX_msglist.addItem("No existe 'Unidades de medidas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError380 == 0 ) )
         {
         }
         pr_default.close(3);
         GXACATEGORIACODIGO_html0812( A41ClinicaCodigo) ;
         GXASUBCATEGORIACODIGO_html0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         A393ArticuloCalculoTotal = (decimal)(A32ArticuloPrecio-A394ArticuloHonorarioCirujano-A389ArticuloHonorarioAnestesiologo-A390ArticuloImplante-A391ArticuloMedicamento-A392ArticuloOtro) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A393ArticuloCalculoTotal", StringUtil.LTrim( StringUtil.Str( A393ArticuloCalculoTotal, 17, 2)));
      }

      protected void CloseExtendedTableCursors0812( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_8( String A41ClinicaCodigo ,
                               String A27CategoriaCodigo ,
                               String A124SubCategoriaCodigo )
      {
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError41 = 1 ;
            AnyError27 = 1 ;
            AnyError124 = 1 ;
            GX_msglist.addItem("No existe 'Sub-Categorías'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError27 == 0 ) && ( AnyError124 == 0 ) )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_9( String A41ClinicaCodigo ,
                               String A380UnidadMedidaCodigo )
      {
         /* Using cursor T00088 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A380UnidadMedidaCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError41 = 1 ;
            AnyError380 = 1 ;
            GX_msglist.addItem("No existe 'Unidades de medidas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError380 == 0 ) )
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

      protected void GetKey0812( )
      {
         /* Using cursor T00089 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound12 = 1 ;
         }
         else
         {
            RcdFound12 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0812( 7) ;
            RcdFound12 = 1 ;
            A30ArticuloCodigo = T00083_A30ArticuloCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
            A31ArticuloDescripcion = T00083_A31ArticuloDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31ArticuloDescripcion", A31ArticuloDescripcion);
            A32ArticuloPrecio = T00083_A32ArticuloPrecio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32ArticuloPrecio", StringUtil.LTrim( StringUtil.Str( A32ArticuloPrecio, 17, 2)));
            A60ArticuloCosto = T00083_A60ArticuloCosto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ArticuloCosto", StringUtil.LTrim( StringUtil.Str( A60ArticuloCosto, 17, 2)));
            A33ArticuloTipo = T00083_A33ArticuloTipo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33ArticuloTipo", StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0));
            A34ArticuloEstado = T00083_A34ArticuloEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34ArticuloEstado", StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0));
            A387ArticuloCirugia = T00083_A387ArticuloCirugia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387ArticuloCirugia", StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0));
            A394ArticuloHonorarioCirujano = T00083_A394ArticuloHonorarioCirujano[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ArticuloHonorarioCirujano", StringUtil.LTrim( StringUtil.Str( A394ArticuloHonorarioCirujano, 17, 2)));
            A389ArticuloHonorarioAnestesiologo = T00083_A389ArticuloHonorarioAnestesiologo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389ArticuloHonorarioAnestesiologo", StringUtil.LTrim( StringUtil.Str( A389ArticuloHonorarioAnestesiologo, 17, 2)));
            A390ArticuloImplante = T00083_A390ArticuloImplante[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390ArticuloImplante", StringUtil.LTrim( StringUtil.Str( A390ArticuloImplante, 17, 2)));
            A391ArticuloMedicamento = T00083_A391ArticuloMedicamento[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391ArticuloMedicamento", StringUtil.LTrim( StringUtil.Str( A391ArticuloMedicamento, 17, 2)));
            A392ArticuloOtro = T00083_A392ArticuloOtro[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392ArticuloOtro", StringUtil.LTrim( StringUtil.Str( A392ArticuloOtro, 17, 2)));
            A41ClinicaCodigo = T00083_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A27CategoriaCodigo = T00083_A27CategoriaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
            A124SubCategoriaCodigo = T00083_A124SubCategoriaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SubCategoriaCodigo", A124SubCategoriaCodigo);
            A380UnidadMedidaCodigo = T00083_A380UnidadMedidaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A380UnidadMedidaCodigo", A380UnidadMedidaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z30ArticuloCodigo = A30ArticuloCodigo ;
            sMode12 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0812( ) ;
            Gx_mode = sMode12 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound12 = 0 ;
            InitializeNonKey0812( ) ;
            sMode12 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode12 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0812( ) ;
         if ( RcdFound12 == 0 )
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
         RcdFound12 = 0 ;
         /* Using cursor T000810 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000810_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000810_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000810_A30ArticuloCodigo[0], A30ArticuloCodigo) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000810_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000810_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000810_A30ArticuloCodigo[0], A30ArticuloCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T000810_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A30ArticuloCodigo = T000810_A30ArticuloCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
               RcdFound12 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound12 = 0 ;
         /* Using cursor T000811 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000811_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000811_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000811_A30ArticuloCodigo[0], A30ArticuloCodigo) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000811_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000811_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000811_A30ArticuloCodigo[0], A30ArticuloCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T000811_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A30ArticuloCodigo = T000811_A30ArticuloCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
               RcdFound12 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0812( ) ;
         if ( RcdFound12 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A30ArticuloCodigo, Z30ArticuloCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A30ArticuloCodigo = Z30ArticuloCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
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
               Update0812( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A30ArticuloCodigo, Z30ArticuloCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0812( ) ;
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
                  Insert0812( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A30ArticuloCodigo, Z30ArticuloCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A30ArticuloCodigo = Z30ArticuloCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtArticuloDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0812( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtArticuloDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0812( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtArticuloDescripcion_Internalname ;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtArticuloDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0812( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound12 != 0 )
            {
               ScanNext0812( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtArticuloDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0812( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0812( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000812 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Articulo"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z31ArticuloDescripcion, T000812_A31ArticuloDescripcion[0]) != 0 ) || ( Z32ArticuloPrecio != T000812_A32ArticuloPrecio[0] ) || ( Z60ArticuloCosto != T000812_A60ArticuloCosto[0] ) || ( Z33ArticuloTipo != T000812_A33ArticuloTipo[0] ) || ( Z34ArticuloEstado != T000812_A34ArticuloEstado[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z387ArticuloCirugia != T000812_A387ArticuloCirugia[0] ) || ( Z394ArticuloHonorarioCirujano != T000812_A394ArticuloHonorarioCirujano[0] ) || ( Z389ArticuloHonorarioAnestesiologo != T000812_A389ArticuloHonorarioAnestesiologo[0] ) || ( Z390ArticuloImplante != T000812_A390ArticuloImplante[0] ) || ( Z391ArticuloMedicamento != T000812_A391ArticuloMedicamento[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z392ArticuloOtro != T000812_A392ArticuloOtro[0] ) || ( StringUtil.StrCmp(Z27CategoriaCodigo, T000812_A27CategoriaCodigo[0]) != 0 ) || ( StringUtil.StrCmp(Z124SubCategoriaCodigo, T000812_A124SubCategoriaCodigo[0]) != 0 ) || ( StringUtil.StrCmp(Z380UnidadMedidaCodigo, T000812_A380UnidadMedidaCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Articulo"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0812( )
      {
         BeforeValidate0812( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0812( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0812( 0) ;
            CheckOptimisticConcurrency0812( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0812( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0812( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000813 */
                     pr_default.execute(11, new Object[] {A30ArticuloCodigo, A31ArticuloDescripcion, A32ArticuloPrecio, A60ArticuloCosto, A33ArticuloTipo, A34ArticuloEstado, A387ArticuloCirugia, A394ArticuloHonorarioCirujano, A389ArticuloHonorarioAnestesiologo, A390ArticuloImplante, A391ArticuloMedicamento, A392ArticuloOtro, A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo, A380UnidadMedidaCodigo});
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
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                           ResetCaption080( ) ;
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
               Load0812( ) ;
            }
            EndLevel0812( ) ;
         }
         CloseExtendedTableCursors0812( ) ;
      }

      protected void Update0812( )
      {
         BeforeValidate0812( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0812( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0812( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0812( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0812( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000814 */
                     pr_default.execute(12, new Object[] {A31ArticuloDescripcion, A32ArticuloPrecio, A60ArticuloCosto, A33ArticuloTipo, A34ArticuloEstado, A387ArticuloCirugia, A394ArticuloHonorarioCirujano, A389ArticuloHonorarioAnestesiologo, A390ArticuloImplante, A391ArticuloMedicamento, A392ArticuloOtro, A27CategoriaCodigo, A124SubCategoriaCodigo, A380UnidadMedidaCodigo, A41ClinicaCodigo, A30ArticuloCodigo});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Articulo"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0812( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption080( ) ;
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
            EndLevel0812( ) ;
         }
         CloseExtendedTableCursors0812( ) ;
      }

      protected void DeferredUpdate0812( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0812( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0812( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0812( ) ;
            AfterConfirm0812( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0812( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000815 */
                  pr_default.execute(13, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
                  pr_default.close(13);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound12 == 0 )
                        {
                           InitAll0812( ) ;
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
                        ResetCaption080( ) ;
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
         sMode12 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0812( ) ;
         Gx_mode = sMode12 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0812( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            GXACATEGORIACODIGO_html0812( A41ClinicaCodigo) ;
            GXASUBCATEGORIACODIGO_html0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
            A393ArticuloCalculoTotal = (decimal)(A32ArticuloPrecio-A394ArticuloHonorarioCirujano-A389ArticuloHonorarioAnestesiologo-A390ArticuloImplante-A391ArticuloMedicamento-A392ArticuloOtro) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A393ArticuloCalculoTotal", StringUtil.LTrim( StringUtil.Str( A393ArticuloCalculoTotal, 17, 2)));
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000816 */
            pr_default.execute(14, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Inventario de bodegas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
            /* Using cursor T000817 */
            pr_default.execute(15, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Detalle de movimiento de inventario"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
            /* Using cursor T000818 */
            pr_default.execute(16, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Detalle de Factura a Pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(16);
            /* Using cursor T000819 */
            pr_default.execute(17, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Cargos de Consulta de Paciente"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel0812( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0812( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            context.CommitDataStores("Articulo");
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            context.RollbackDataStores("Articulo");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0812( )
      {
         /* Using cursor T000820 */
         pr_default.execute(18);
         RcdFound12 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound12 = 1 ;
            A41ClinicaCodigo = T000820_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A30ArticuloCodigo = T000820_A30ArticuloCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0812( )
      {
         pr_default.readNext(18);
         RcdFound12 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound12 = 1 ;
            A41ClinicaCodigo = T000820_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A30ArticuloCodigo = T000820_A30ArticuloCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
         }
      }

      protected void ScanEnd0812( )
      {
      }

      protected void AfterConfirm0812( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0812( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0812( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0812( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0812( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0812( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0812( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtArticuloCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCodigo_Enabled), 5, 0)));
         edtArticuloDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloDescripcion_Enabled), 5, 0)));
         edtArticuloPrecio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloPrecio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloPrecio_Enabled), 5, 0)));
         edtArticuloCosto_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCosto_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCosto_Enabled), 5, 0)));
         dynCategoriaCodigo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynCategoriaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynCategoriaCodigo.Enabled), 5, 0)));
         dynSubCategoriaCodigo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynSubCategoriaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynSubCategoriaCodigo.Enabled), 5, 0)));
         cmbArticuloTipo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbArticuloTipo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbArticuloTipo.Enabled), 5, 0)));
         cmbArticuloEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbArticuloEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbArticuloEstado.Enabled), 5, 0)));
         cmbArticuloCirugia.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbArticuloCirugia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbArticuloCirugia.Enabled), 5, 0)));
         edtArticuloHonorarioCirujano_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloHonorarioCirujano_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloHonorarioCirujano_Enabled), 5, 0)));
         edtArticuloHonorarioAnestesiologo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloHonorarioAnestesiologo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloHonorarioAnestesiologo_Enabled), 5, 0)));
         edtArticuloImplante_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloImplante_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloImplante_Enabled), 5, 0)));
         edtArticuloMedicamento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloMedicamento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloMedicamento_Enabled), 5, 0)));
         edtArticuloOtro_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloOtro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloOtro_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues080( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("articulo.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z30ArticuloCodigo", StringUtil.RTrim( Z30ArticuloCodigo));
         GxWebStd.gx_hidden_field( context, "Z31ArticuloDescripcion", StringUtil.RTrim( Z31ArticuloDescripcion));
         GxWebStd.gx_hidden_field( context, "Z32ArticuloPrecio", StringUtil.LTrim( StringUtil.NToC( Z32ArticuloPrecio, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z60ArticuloCosto", StringUtil.LTrim( StringUtil.NToC( Z60ArticuloCosto, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z33ArticuloTipo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33ArticuloTipo), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z34ArticuloEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34ArticuloEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z387ArticuloCirugia", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z387ArticuloCirugia), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z394ArticuloHonorarioCirujano", StringUtil.LTrim( StringUtil.NToC( Z394ArticuloHonorarioCirujano, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z389ArticuloHonorarioAnestesiologo", StringUtil.LTrim( StringUtil.NToC( Z389ArticuloHonorarioAnestesiologo, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z390ArticuloImplante", StringUtil.LTrim( StringUtil.NToC( Z390ArticuloImplante, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z391ArticuloMedicamento", StringUtil.LTrim( StringUtil.NToC( Z391ArticuloMedicamento, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z392ArticuloOtro", StringUtil.LTrim( StringUtil.NToC( Z392ArticuloOtro, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z27CategoriaCodigo", StringUtil.RTrim( Z27CategoriaCodigo));
         GxWebStd.gx_hidden_field( context, "Z124SubCategoriaCodigo", StringUtil.RTrim( Z124SubCategoriaCodigo));
         GxWebStd.gx_hidden_field( context, "Z380UnidadMedidaCodigo", StringUtil.RTrim( Z380UnidadMedidaCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "ARTICULOCALCULOTOTAL", StringUtil.LTrim( StringUtil.NToC( A393ArticuloCalculoTotal, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV8ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "UNIDADMEDIDACODIGO", StringUtil.RTrim( A380UnidadMedidaCodigo));
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
         return "Articulo" ;
      }

      public override String GetPgmdesc( )
      {
         return "Maestro de productos y servicios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("articulo.aspx")  ;
      }

      protected void InitializeNonKey0812( )
      {
         A393ArticuloCalculoTotal = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A393ArticuloCalculoTotal", StringUtil.LTrim( StringUtil.Str( A393ArticuloCalculoTotal, 17, 2)));
         A31ArticuloDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31ArticuloDescripcion", A31ArticuloDescripcion);
         A32ArticuloPrecio = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32ArticuloPrecio", StringUtil.LTrim( StringUtil.Str( A32ArticuloPrecio, 17, 2)));
         A60ArticuloCosto = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60ArticuloCosto", StringUtil.LTrim( StringUtil.Str( A60ArticuloCosto, 17, 2)));
         A27CategoriaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
         A124SubCategoriaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124SubCategoriaCodigo", A124SubCategoriaCodigo);
         A380UnidadMedidaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A380UnidadMedidaCodigo", A380UnidadMedidaCodigo);
         A33ArticuloTipo = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33ArticuloTipo", StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0));
         A34ArticuloEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34ArticuloEstado", StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0));
         A387ArticuloCirugia = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387ArticuloCirugia", StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0));
         A394ArticuloHonorarioCirujano = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394ArticuloHonorarioCirujano", StringUtil.LTrim( StringUtil.Str( A394ArticuloHonorarioCirujano, 17, 2)));
         A389ArticuloHonorarioAnestesiologo = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389ArticuloHonorarioAnestesiologo", StringUtil.LTrim( StringUtil.Str( A389ArticuloHonorarioAnestesiologo, 17, 2)));
         A390ArticuloImplante = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390ArticuloImplante", StringUtil.LTrim( StringUtil.Str( A390ArticuloImplante, 17, 2)));
         A391ArticuloMedicamento = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391ArticuloMedicamento", StringUtil.LTrim( StringUtil.Str( A391ArticuloMedicamento, 17, 2)));
         A392ArticuloOtro = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392ArticuloOtro", StringUtil.LTrim( StringUtil.Str( A392ArticuloOtro, 17, 2)));
      }

      protected void InitAll0812( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A30ArticuloCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
         InitializeNonKey0812( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1542959");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("articulo.js", "?1542960");
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
         lblTextblockarticulocodigo_Internalname = "TEXTBLOCKARTICULOCODIGO" ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO" ;
         lblTextblockarticulodescripcion_Internalname = "TEXTBLOCKARTICULODESCRIPCION" ;
         edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION" ;
         lblTextblockarticuloprecio_Internalname = "TEXTBLOCKARTICULOPRECIO" ;
         edtArticuloPrecio_Internalname = "ARTICULOPRECIO" ;
         lblTextblockarticulocosto_Internalname = "TEXTBLOCKARTICULOCOSTO" ;
         edtArticuloCosto_Internalname = "ARTICULOCOSTO" ;
         lblTextblockcategoriacodigo_Internalname = "TEXTBLOCKCATEGORIACODIGO" ;
         dynCategoriaCodigo_Internalname = "CATEGORIACODIGO" ;
         lblTextblocksubcategoriacodigo_Internalname = "TEXTBLOCKSUBCATEGORIACODIGO" ;
         dynSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO" ;
         lblTextblockarticulotipo_Internalname = "TEXTBLOCKARTICULOTIPO" ;
         cmbArticuloTipo_Internalname = "ARTICULOTIPO" ;
         lblTextblockarticuloestado_Internalname = "TEXTBLOCKARTICULOESTADO" ;
         cmbArticuloEstado_Internalname = "ARTICULOESTADO" ;
         lblTextblockarticuloestado2_Internalname = "TEXTBLOCKARTICULOESTADO2" ;
         cmbArticuloCirugia_Internalname = "ARTICULOCIRUGIA" ;
         lblTextblockarticuloestado3_Internalname = "TEXTBLOCKARTICULOESTADO3" ;
         edtArticuloHonorarioCirujano_Internalname = "ARTICULOHONORARIOCIRUJANO" ;
         lblTextblockarticuloestado4_Internalname = "TEXTBLOCKARTICULOESTADO4" ;
         edtArticuloHonorarioAnestesiologo_Internalname = "ARTICULOHONORARIOANESTESIOLOGO" ;
         lblTextblockarticuloestado5_Internalname = "TEXTBLOCKARTICULOESTADO5" ;
         edtArticuloImplante_Internalname = "ARTICULOIMPLANTE" ;
         lblTextblockarticuloestado6_Internalname = "TEXTBLOCKARTICULOESTADO6" ;
         edtArticuloMedicamento_Internalname = "ARTICULOMEDICAMENTO" ;
         lblTextblockarticuloestado7_Internalname = "TEXTBLOCKARTICULOESTADO7" ;
         edtArticuloOtro_Internalname = "ARTICULOOTRO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_Internalname = "PROMPT_41" ;
         imgprompt_27_124_Internalname = "PROMPT_27_124" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Maestro de productos y servicios" ;
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
         edtArticuloOtro_Jsonclick = "" ;
         edtArticuloOtro_Enabled = 1 ;
         edtArticuloMedicamento_Jsonclick = "" ;
         edtArticuloMedicamento_Enabled = 1 ;
         edtArticuloImplante_Jsonclick = "" ;
         edtArticuloImplante_Enabled = 1 ;
         edtArticuloHonorarioAnestesiologo_Jsonclick = "" ;
         edtArticuloHonorarioAnestesiologo_Enabled = 1 ;
         edtArticuloHonorarioCirujano_Jsonclick = "" ;
         edtArticuloHonorarioCirujano_Enabled = 1 ;
         cmbArticuloCirugia_Jsonclick = "" ;
         cmbArticuloCirugia.Enabled = 1 ;
         cmbArticuloEstado_Jsonclick = "" ;
         cmbArticuloEstado.Enabled = 1 ;
         cmbArticuloTipo_Jsonclick = "" ;
         cmbArticuloTipo.Enabled = 1 ;
         imgprompt_27_124_Visible = 1 ;
         imgprompt_27_124_Link = "" ;
         dynSubCategoriaCodigo_Jsonclick = "" ;
         dynSubCategoriaCodigo.Enabled = 1 ;
         dynCategoriaCodigo_Jsonclick = "" ;
         dynCategoriaCodigo.Enabled = 1 ;
         edtArticuloCosto_Jsonclick = "" ;
         edtArticuloCosto_Enabled = 1 ;
         edtArticuloPrecio_Jsonclick = "" ;
         edtArticuloPrecio_Enabled = 1 ;
         edtArticuloDescripcion_Jsonclick = "" ;
         edtArticuloDescripcion_Enabled = 1 ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtArticuloCodigo_Enabled = 1 ;
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
         GXACATEGORIACODIGO_html0812( A41ClinicaCodigo) ;
         GXASUBCATEGORIACODIGO_html0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         GXASUBCATEGORIACODIGO_html0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         /* End function dynload_actions */
      }

      protected void GXDLACATEGORIACODIGO0812( String A41ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLACATEGORIACODIGO_data0812( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXACATEGORIACODIGO_html0812( String A41ClinicaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLACATEGORIACODIGO_data0812( A41ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynCategoriaCodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynCategoriaCodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLACATEGORIACODIGO_data0812( String A41ClinicaCodigo )
      {
         /* Using cursor T000821 */
         pr_default.execute(19, new Object[] {A41ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(19) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000821_A27CategoriaCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000821_A28CategoriaDescripcion[0]));
            pr_default.readNext(19);
         }
         pr_default.close(19);
      }

      protected void GXDLASUBCATEGORIACODIGO0812( String A41ClinicaCodigo ,
                                                  String A27CategoriaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLASUBCATEGORIACODIGO_data0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXASUBCATEGORIACODIGO_html0812( String A41ClinicaCodigo ,
                                                     String A27CategoriaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLASUBCATEGORIACODIGO_data0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         gxdynajaxindex = 1 ;
         dynSubCategoriaCodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynSubCategoriaCodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLASUBCATEGORIACODIGO_data0812( String A41ClinicaCodigo ,
                                                       String A27CategoriaCodigo )
      {
         /* Using cursor T000822 */
         pr_default.execute(20, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(20) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000822_A124SubCategoriaCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000822_A125SubCategoriaDescripcion[0]));
            pr_default.readNext(20);
         }
         pr_default.close(20);
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtArticuloDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 ,
                                       String GX_Parm2 ,
                                       GXCombobox dynGX_Parm3 ,
                                       GXCombobox dynGX_Parm4 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A380UnidadMedidaCodigo = GX_Parm2 ;
         dynCategoriaCodigo = dynGX_Parm3 ;
         A27CategoriaCodigo = dynCategoriaCodigo.CurrentValue ;
         dynSubCategoriaCodigo = dynGX_Parm4 ;
         A124SubCategoriaCodigo = dynSubCategoriaCodigo.CurrentValue ;
         /* Using cursor T000823 */
         pr_default.execute(21, new Object[] {A41ClinicaCodigo, A380UnidadMedidaCodigo});
         if ( (pr_default.getStatus(21) == 101) )
         {
            AnyError41 = 1 ;
            AnyError380 = 1 ;
            GX_msglist.addItem("No existe 'Unidades de medidas'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError380 == 0 ) )
         {
         }
         pr_default.close(21);
         GXACATEGORIACODIGO_html0812( A41ClinicaCodigo) ;
         GXASUBCATEGORIACODIGO_html0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynCategoriaCodigo.CurrentValue = A27CategoriaCodigo ;
         dynSubCategoriaCodigo.CurrentValue = A124SubCategoriaCodigo ;
         isValidOutput.Add((Object)(dynCategoriaCodigo));
         isValidOutput.Add((Object)(dynSubCategoriaCodigo));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Articulocodigo( String GX_Parm1 ,
                                        String GX_Parm2 ,
                                        String GX_Parm3 ,
                                        String GX_Parm4 ,
                                        decimal GX_Parm5 ,
                                        decimal GX_Parm6 ,
                                        GXCombobox cmbGX_Parm7 ,
                                        GXCombobox cmbGX_Parm8 ,
                                        GXCombobox cmbGX_Parm9 ,
                                        decimal GX_Parm10 ,
                                        decimal GX_Parm11 ,
                                        decimal GX_Parm12 ,
                                        decimal GX_Parm13 ,
                                        decimal GX_Parm14 ,
                                        GXCombobox dynGX_Parm15 ,
                                        GXCombobox dynGX_Parm16 ,
                                        String GX_Parm17 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A30ArticuloCodigo = GX_Parm3 ;
         A31ArticuloDescripcion = GX_Parm4 ;
         A32ArticuloPrecio = GX_Parm5 ;
         A60ArticuloCosto = GX_Parm6 ;
         cmbArticuloTipo = cmbGX_Parm7 ;
         A33ArticuloTipo = (short)(NumberUtil.Val( cmbArticuloTipo.CurrentValue, ".")) ;
         cmbArticuloTipo.CurrentValue = StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0) ;
         cmbArticuloEstado = cmbGX_Parm8 ;
         A34ArticuloEstado = (short)(NumberUtil.Val( cmbArticuloEstado.CurrentValue, ".")) ;
         cmbArticuloEstado.CurrentValue = StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0) ;
         cmbArticuloCirugia = cmbGX_Parm9 ;
         A387ArticuloCirugia = (short)(NumberUtil.Val( cmbArticuloCirugia.CurrentValue, ".")) ;
         cmbArticuloCirugia.CurrentValue = StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0) ;
         A394ArticuloHonorarioCirujano = GX_Parm10 ;
         A389ArticuloHonorarioAnestesiologo = GX_Parm11 ;
         A390ArticuloImplante = GX_Parm12 ;
         A391ArticuloMedicamento = GX_Parm13 ;
         A392ArticuloOtro = GX_Parm14 ;
         dynCategoriaCodigo = dynGX_Parm15 ;
         A27CategoriaCodigo = dynCategoriaCodigo.CurrentValue ;
         dynSubCategoriaCodigo = dynGX_Parm16 ;
         A124SubCategoriaCodigo = dynSubCategoriaCodigo.CurrentValue ;
         A380UnidadMedidaCodigo = GX_Parm17 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynCategoriaCodigo.CurrentValue = A27CategoriaCodigo ;
         dynSubCategoriaCodigo.CurrentValue = A124SubCategoriaCodigo ;
         isValidOutput.Add((Object)(StringUtil.RTrim( A31ArticuloDescripcion)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A32ArticuloPrecio, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A60ArticuloCosto, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A380UnidadMedidaCodigo)));
         cmbArticuloTipo.CurrentValue = StringUtil.Str( (decimal)(A33ArticuloTipo), 1, 0) ;
         isValidOutput.Add((Object)(cmbArticuloTipo));
         cmbArticuloEstado.CurrentValue = StringUtil.Str( (decimal)(A34ArticuloEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbArticuloEstado));
         cmbArticuloCirugia.CurrentValue = StringUtil.Str( (decimal)(A387ArticuloCirugia), 1, 0) ;
         isValidOutput.Add((Object)(cmbArticuloCirugia));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A394ArticuloHonorarioCirujano, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A389ArticuloHonorarioAnestesiologo, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A390ArticuloImplante, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A391ArticuloMedicamento, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A392ArticuloOtro, 17, 2, ".", ""))));
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A27CategoriaCodigo)) )
         {
            if ( ( dynCategoriaCodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A27CategoriaCodigo)) )
            {
               A27CategoriaCodigo = dynCategoriaCodigo.getItemValue(1) ;
            }
         }
         dynCategoriaCodigo.CurrentValue = A27CategoriaCodigo ;
         isValidOutput.Add((Object)(dynCategoriaCodigo));
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A124SubCategoriaCodigo)) )
         {
            if ( ( dynSubCategoriaCodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A124SubCategoriaCodigo)) )
            {
               A124SubCategoriaCodigo = dynSubCategoriaCodigo.getItemValue(1) ;
            }
         }
         dynSubCategoriaCodigo.CurrentValue = A124SubCategoriaCodigo ;
         isValidOutput.Add((Object)(dynSubCategoriaCodigo));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A393ArticuloCalculoTotal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z30ArticuloCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z31ArticuloDescripcion)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z32ArticuloPrecio, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z60ArticuloCosto, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z380UnidadMedidaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33ArticuloTipo), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34ArticuloEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z387ArticuloCirugia), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z394ArticuloHonorarioCirujano, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z389ArticuloHonorarioAnestesiologo, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z390ArticuloImplante, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z391ArticuloMedicamento, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z392ArticuloOtro, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z27CategoriaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z124SubCategoriaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z393ArticuloCalculoTotal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Categoriacodigo( String GX_Parm1 ,
                                         GXCombobox dynGX_Parm2 ,
                                         GXCombobox dynGX_Parm3 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynCategoriaCodigo = dynGX_Parm2 ;
         A27CategoriaCodigo = dynCategoriaCodigo.CurrentValue ;
         dynSubCategoriaCodigo = dynGX_Parm3 ;
         A124SubCategoriaCodigo = dynSubCategoriaCodigo.CurrentValue ;
         GXASUBCATEGORIACODIGO_html0812( A41ClinicaCodigo, A27CategoriaCodigo) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynSubCategoriaCodigo.CurrentValue = A124SubCategoriaCodigo ;
         isValidOutput.Add((Object)(dynSubCategoriaCodigo));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Subcategoriacodigo( String GX_Parm1 ,
                                            GXCombobox dynGX_Parm2 ,
                                            GXCombobox dynGX_Parm3 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         dynCategoriaCodigo = dynGX_Parm2 ;
         A27CategoriaCodigo = dynCategoriaCodigo.CurrentValue ;
         dynSubCategoriaCodigo = dynGX_Parm3 ;
         A124SubCategoriaCodigo = dynSubCategoriaCodigo.CurrentValue ;
         /* Using cursor T000824 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
         if ( (pr_default.getStatus(22) == 101) )
         {
            AnyError41 = 1 ;
            AnyError27 = 1 ;
            AnyError124 = 1 ;
            GX_msglist.addItem("No existe 'Sub-Categorías'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError27 == 0 ) && ( AnyError124 == 0 ) )
         {
         }
         pr_default.close(22);
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
         pr_default.close(18);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(22);
         pr_default.close(21);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A27CategoriaCodigo = "" ;
         A124SubCategoriaCodigo = "" ;
         A380UnidadMedidaCodigo = "" ;
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
         lblTextblockarticulocodigo_Jsonclick = "" ;
         A30ArticuloCodigo = "" ;
         lblTextblockarticulodescripcion_Jsonclick = "" ;
         A31ArticuloDescripcion = "" ;
         lblTextblockarticuloprecio_Jsonclick = "" ;
         lblTextblockarticulocosto_Jsonclick = "" ;
         lblTextblockcategoriacodigo_Jsonclick = "" ;
         lblTextblocksubcategoriacodigo_Jsonclick = "" ;
         lblTextblockarticulotipo_Jsonclick = "" ;
         lblTextblockarticuloestado_Jsonclick = "" ;
         lblTextblockarticuloestado2_Jsonclick = "" ;
         lblTextblockarticuloestado3_Jsonclick = "" ;
         lblTextblockarticuloestado4_Jsonclick = "" ;
         lblTextblockarticuloestado5_Jsonclick = "" ;
         lblTextblockarticuloestado6_Jsonclick = "" ;
         lblTextblockarticuloestado7_Jsonclick = "" ;
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
         Z30ArticuloCodigo = "" ;
         Z31ArticuloDescripcion = "" ;
         Z27CategoriaCodigo = "" ;
         Z124SubCategoriaCodigo = "" ;
         Z380UnidadMedidaCodigo = "" ;
         Gx_mode = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         T00086_A30ArticuloCodigo = new String[] {""} ;
         T00086_A31ArticuloDescripcion = new String[] {""} ;
         T00086_A32ArticuloPrecio = new decimal[1] ;
         T00086_A60ArticuloCosto = new decimal[1] ;
         T00086_A33ArticuloTipo = new short[1] ;
         T00086_A34ArticuloEstado = new short[1] ;
         T00086_A387ArticuloCirugia = new short[1] ;
         T00086_A394ArticuloHonorarioCirujano = new decimal[1] ;
         T00086_A389ArticuloHonorarioAnestesiologo = new decimal[1] ;
         T00086_A390ArticuloImplante = new decimal[1] ;
         T00086_A391ArticuloMedicamento = new decimal[1] ;
         T00086_A392ArticuloOtro = new decimal[1] ;
         T00086_A41ClinicaCodigo = new String[] {""} ;
         T00086_A27CategoriaCodigo = new String[] {""} ;
         T00086_A124SubCategoriaCodigo = new String[] {""} ;
         T00086_A380UnidadMedidaCodigo = new String[] {""} ;
         T00084_A41ClinicaCodigo = new String[] {""} ;
         T00085_A41ClinicaCodigo = new String[] {""} ;
         T00087_A41ClinicaCodigo = new String[] {""} ;
         T00088_A41ClinicaCodigo = new String[] {""} ;
         T00089_A41ClinicaCodigo = new String[] {""} ;
         T00089_A30ArticuloCodigo = new String[] {""} ;
         T00083_A30ArticuloCodigo = new String[] {""} ;
         T00083_A31ArticuloDescripcion = new String[] {""} ;
         T00083_A32ArticuloPrecio = new decimal[1] ;
         T00083_A60ArticuloCosto = new decimal[1] ;
         T00083_A33ArticuloTipo = new short[1] ;
         T00083_A34ArticuloEstado = new short[1] ;
         T00083_A387ArticuloCirugia = new short[1] ;
         T00083_A394ArticuloHonorarioCirujano = new decimal[1] ;
         T00083_A389ArticuloHonorarioAnestesiologo = new decimal[1] ;
         T00083_A390ArticuloImplante = new decimal[1] ;
         T00083_A391ArticuloMedicamento = new decimal[1] ;
         T00083_A392ArticuloOtro = new decimal[1] ;
         T00083_A41ClinicaCodigo = new String[] {""} ;
         T00083_A27CategoriaCodigo = new String[] {""} ;
         T00083_A124SubCategoriaCodigo = new String[] {""} ;
         T00083_A380UnidadMedidaCodigo = new String[] {""} ;
         sMode12 = "" ;
         T000810_A41ClinicaCodigo = new String[] {""} ;
         T000810_A30ArticuloCodigo = new String[] {""} ;
         T000811_A41ClinicaCodigo = new String[] {""} ;
         T000811_A30ArticuloCodigo = new String[] {""} ;
         T000812_A30ArticuloCodigo = new String[] {""} ;
         T000812_A31ArticuloDescripcion = new String[] {""} ;
         T000812_A32ArticuloPrecio = new decimal[1] ;
         T000812_A60ArticuloCosto = new decimal[1] ;
         T000812_A33ArticuloTipo = new short[1] ;
         T000812_A34ArticuloEstado = new short[1] ;
         T000812_A387ArticuloCirugia = new short[1] ;
         T000812_A394ArticuloHonorarioCirujano = new decimal[1] ;
         T000812_A389ArticuloHonorarioAnestesiologo = new decimal[1] ;
         T000812_A390ArticuloImplante = new decimal[1] ;
         T000812_A391ArticuloMedicamento = new decimal[1] ;
         T000812_A392ArticuloOtro = new decimal[1] ;
         T000812_A41ClinicaCodigo = new String[] {""} ;
         T000812_A27CategoriaCodigo = new String[] {""} ;
         T000812_A124SubCategoriaCodigo = new String[] {""} ;
         T000812_A380UnidadMedidaCodigo = new String[] {""} ;
         T000816_A41ClinicaCodigo = new String[] {""} ;
         T000816_A121BodegaCodigo = new String[] {""} ;
         T000816_A30ArticuloCodigo = new String[] {""} ;
         T000817_A41ClinicaCodigo = new String[] {""} ;
         T000817_A114TipoMICodigo = new String[] {""} ;
         T000817_A267MovimientoId = new int[1] ;
         T000817_A272MovimientoLinea = new short[1] ;
         T000818_A41ClinicaCodigo = new String[] {""} ;
         T000818_A185FacturaId = new int[1] ;
         T000818_A248FacturaDId = new int[1] ;
         T000819_A41ClinicaCodigo = new String[] {""} ;
         T000819_A91ConsultaId = new int[1] ;
         T000819_A162CargoId = new int[1] ;
         T000820_A41ClinicaCodigo = new String[] {""} ;
         T000820_A30ArticuloCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         T000821_A41ClinicaCodigo = new String[] {""} ;
         T000821_A27CategoriaCodigo = new String[] {""} ;
         T000821_A28CategoriaDescripcion = new String[] {""} ;
         T000821_A29CategoriaEstado = new short[1] ;
         GXt_char4 = "" ;
         T000822_A41ClinicaCodigo = new String[] {""} ;
         T000822_A27CategoriaCodigo = new String[] {""} ;
         T000822_A124SubCategoriaCodigo = new String[] {""} ;
         T000822_A125SubCategoriaDescripcion = new String[] {""} ;
         T000823_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T000824_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.articulo__default(),
            new Object[][] {
                new Object[] {
               T00082_A30ArticuloCodigo, T00082_A31ArticuloDescripcion, T00082_A32ArticuloPrecio, T00082_A60ArticuloCosto, T00082_A33ArticuloTipo, T00082_A34ArticuloEstado, T00082_A387ArticuloCirugia, T00082_A394ArticuloHonorarioCirujano, T00082_A389ArticuloHonorarioAnestesiologo, T00082_A390ArticuloImplante,
               T00082_A391ArticuloMedicamento, T00082_A392ArticuloOtro, T00082_A41ClinicaCodigo, T00082_A27CategoriaCodigo, T00082_A124SubCategoriaCodigo, T00082_A380UnidadMedidaCodigo
               }
               , new Object[] {
               T00083_A30ArticuloCodigo, T00083_A31ArticuloDescripcion, T00083_A32ArticuloPrecio, T00083_A60ArticuloCosto, T00083_A33ArticuloTipo, T00083_A34ArticuloEstado, T00083_A387ArticuloCirugia, T00083_A394ArticuloHonorarioCirujano, T00083_A389ArticuloHonorarioAnestesiologo, T00083_A390ArticuloImplante,
               T00083_A391ArticuloMedicamento, T00083_A392ArticuloOtro, T00083_A41ClinicaCodigo, T00083_A27CategoriaCodigo, T00083_A124SubCategoriaCodigo, T00083_A380UnidadMedidaCodigo
               }
               , new Object[] {
               T00084_A41ClinicaCodigo
               }
               , new Object[] {
               T00085_A41ClinicaCodigo
               }
               , new Object[] {
               T00086_A30ArticuloCodigo, T00086_A31ArticuloDescripcion, T00086_A32ArticuloPrecio, T00086_A60ArticuloCosto, T00086_A33ArticuloTipo, T00086_A34ArticuloEstado, T00086_A387ArticuloCirugia, T00086_A394ArticuloHonorarioCirujano, T00086_A389ArticuloHonorarioAnestesiologo, T00086_A390ArticuloImplante,
               T00086_A391ArticuloMedicamento, T00086_A392ArticuloOtro, T00086_A41ClinicaCodigo, T00086_A27CategoriaCodigo, T00086_A124SubCategoriaCodigo, T00086_A380UnidadMedidaCodigo
               }
               , new Object[] {
               T00087_A41ClinicaCodigo
               }
               , new Object[] {
               T00088_A41ClinicaCodigo
               }
               , new Object[] {
               T00089_A41ClinicaCodigo, T00089_A30ArticuloCodigo
               }
               , new Object[] {
               T000810_A41ClinicaCodigo, T000810_A30ArticuloCodigo
               }
               , new Object[] {
               T000811_A41ClinicaCodigo, T000811_A30ArticuloCodigo
               }
               , new Object[] {
               T000812_A30ArticuloCodigo, T000812_A31ArticuloDescripcion, T000812_A32ArticuloPrecio, T000812_A60ArticuloCosto, T000812_A33ArticuloTipo, T000812_A34ArticuloEstado, T000812_A387ArticuloCirugia, T000812_A394ArticuloHonorarioCirujano, T000812_A389ArticuloHonorarioAnestesiologo, T000812_A390ArticuloImplante,
               T000812_A391ArticuloMedicamento, T000812_A392ArticuloOtro, T000812_A41ClinicaCodigo, T000812_A27CategoriaCodigo, T000812_A124SubCategoriaCodigo, T000812_A380UnidadMedidaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000816_A41ClinicaCodigo, T000816_A121BodegaCodigo, T000816_A30ArticuloCodigo
               }
               , new Object[] {
               T000817_A41ClinicaCodigo, T000817_A114TipoMICodigo, T000817_A267MovimientoId, T000817_A272MovimientoLinea
               }
               , new Object[] {
               T000818_A41ClinicaCodigo, T000818_A185FacturaId, T000818_A248FacturaDId
               }
               , new Object[] {
               T000819_A41ClinicaCodigo, T000819_A91ConsultaId, T000819_A162CargoId
               }
               , new Object[] {
               T000820_A41ClinicaCodigo, T000820_A30ArticuloCodigo
               }
               , new Object[] {
               T000821_A41ClinicaCodigo, T000821_A27CategoriaCodigo, T000821_A28CategoriaDescripcion, T000821_A29CategoriaEstado
               }
               , new Object[] {
               T000822_A41ClinicaCodigo, T000822_A27CategoriaCodigo, T000822_A124SubCategoriaCodigo, T000822_A125SubCategoriaDescripcion
               }
               , new Object[] {
               T000823_A41ClinicaCodigo
               }
               , new Object[] {
               T000824_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A33ArticuloTipo ;
      private short A34ArticuloEstado ;
      private short A387ArticuloCirugia ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z33ArticuloTipo ;
      private short Z34ArticuloEstado ;
      private short Z387ArticuloCirugia ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short RcdFound12 ;
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
      private int edtArticuloCodigo_Enabled ;
      private int edtArticuloDescripcion_Enabled ;
      private int edtArticuloPrecio_Enabled ;
      private int edtArticuloCosto_Enabled ;
      private int imgprompt_27_124_Visible ;
      private int edtArticuloHonorarioCirujano_Enabled ;
      private int edtArticuloHonorarioAnestesiologo_Enabled ;
      private int edtArticuloImplante_Enabled ;
      private int edtArticuloMedicamento_Enabled ;
      private int edtArticuloOtro_Enabled ;
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
      private int AnyError27 ;
      private int AnyError124 ;
      private int AnyError380 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private decimal A32ArticuloPrecio ;
      private decimal A60ArticuloCosto ;
      private decimal A394ArticuloHonorarioCirujano ;
      private decimal A389ArticuloHonorarioAnestesiologo ;
      private decimal A390ArticuloImplante ;
      private decimal A391ArticuloMedicamento ;
      private decimal A392ArticuloOtro ;
      private decimal Z32ArticuloPrecio ;
      private decimal Z60ArticuloCosto ;
      private decimal Z394ArticuloHonorarioCirujano ;
      private decimal Z389ArticuloHonorarioAnestesiologo ;
      private decimal Z390ArticuloImplante ;
      private decimal Z391ArticuloMedicamento ;
      private decimal Z392ArticuloOtro ;
      private decimal A393ArticuloCalculoTotal ;
      private decimal Z393ArticuloCalculoTotal ;
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
      private String lblTextblockarticulocodigo_Internalname ;
      private String lblTextblockarticulocodigo_Jsonclick ;
      private String edtArticuloCodigo_Internalname ;
      private String edtArticuloCodigo_Jsonclick ;
      private String lblTextblockarticulodescripcion_Internalname ;
      private String lblTextblockarticulodescripcion_Jsonclick ;
      private String edtArticuloDescripcion_Internalname ;
      private String edtArticuloDescripcion_Jsonclick ;
      private String lblTextblockarticuloprecio_Internalname ;
      private String lblTextblockarticuloprecio_Jsonclick ;
      private String edtArticuloPrecio_Internalname ;
      private String edtArticuloPrecio_Jsonclick ;
      private String lblTextblockarticulocosto_Internalname ;
      private String lblTextblockarticulocosto_Jsonclick ;
      private String edtArticuloCosto_Internalname ;
      private String edtArticuloCosto_Jsonclick ;
      private String lblTextblockcategoriacodigo_Internalname ;
      private String lblTextblockcategoriacodigo_Jsonclick ;
      private String dynCategoriaCodigo_Internalname ;
      private String dynCategoriaCodigo_Jsonclick ;
      private String lblTextblocksubcategoriacodigo_Internalname ;
      private String lblTextblocksubcategoriacodigo_Jsonclick ;
      private String dynSubCategoriaCodigo_Internalname ;
      private String dynSubCategoriaCodigo_Jsonclick ;
      private String imgprompt_27_124_Internalname ;
      private String imgprompt_27_124_Link ;
      private String lblTextblockarticulotipo_Internalname ;
      private String lblTextblockarticulotipo_Jsonclick ;
      private String cmbArticuloTipo_Internalname ;
      private String cmbArticuloTipo_Jsonclick ;
      private String lblTextblockarticuloestado_Internalname ;
      private String lblTextblockarticuloestado_Jsonclick ;
      private String cmbArticuloEstado_Internalname ;
      private String cmbArticuloEstado_Jsonclick ;
      private String lblTextblockarticuloestado2_Internalname ;
      private String lblTextblockarticuloestado2_Jsonclick ;
      private String cmbArticuloCirugia_Internalname ;
      private String cmbArticuloCirugia_Jsonclick ;
      private String lblTextblockarticuloestado3_Internalname ;
      private String lblTextblockarticuloestado3_Jsonclick ;
      private String edtArticuloHonorarioCirujano_Internalname ;
      private String edtArticuloHonorarioCirujano_Jsonclick ;
      private String lblTextblockarticuloestado4_Internalname ;
      private String lblTextblockarticuloestado4_Jsonclick ;
      private String edtArticuloHonorarioAnestesiologo_Internalname ;
      private String edtArticuloHonorarioAnestesiologo_Jsonclick ;
      private String lblTextblockarticuloestado5_Internalname ;
      private String lblTextblockarticuloestado5_Jsonclick ;
      private String edtArticuloImplante_Internalname ;
      private String edtArticuloImplante_Jsonclick ;
      private String lblTextblockarticuloestado6_Internalname ;
      private String lblTextblockarticuloestado6_Jsonclick ;
      private String edtArticuloMedicamento_Internalname ;
      private String edtArticuloMedicamento_Jsonclick ;
      private String lblTextblockarticuloestado7_Internalname ;
      private String lblTextblockarticuloestado7_Jsonclick ;
      private String edtArticuloOtro_Internalname ;
      private String edtArticuloOtro_Jsonclick ;
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
      private String sMode12 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String gxwrpcisep ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A27CategoriaCodigo ;
      private String A124SubCategoriaCodigo ;
      private String A380UnidadMedidaCodigo ;
      private String A30ArticuloCodigo ;
      private String A31ArticuloDescripcion ;
      private String Z41ClinicaCodigo ;
      private String Z30ArticuloCodigo ;
      private String Z31ArticuloDescripcion ;
      private String Z27CategoriaCodigo ;
      private String Z124SubCategoriaCodigo ;
      private String Z380UnidadMedidaCodigo ;
      private String AV8ClinicaCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynCategoriaCodigo ;
      private GXCombobox dynSubCategoriaCodigo ;
      private GXCombobox cmbArticuloTipo ;
      private GXCombobox cmbArticuloEstado ;
      private GXCombobox cmbArticuloCirugia ;
      private IDataStoreProvider pr_default ;
      private String[] T00086_A30ArticuloCodigo ;
      private String[] T00086_A31ArticuloDescripcion ;
      private decimal[] T00086_A32ArticuloPrecio ;
      private decimal[] T00086_A60ArticuloCosto ;
      private short[] T00086_A33ArticuloTipo ;
      private short[] T00086_A34ArticuloEstado ;
      private short[] T00086_A387ArticuloCirugia ;
      private decimal[] T00086_A394ArticuloHonorarioCirujano ;
      private decimal[] T00086_A389ArticuloHonorarioAnestesiologo ;
      private decimal[] T00086_A390ArticuloImplante ;
      private decimal[] T00086_A391ArticuloMedicamento ;
      private decimal[] T00086_A392ArticuloOtro ;
      private String[] T00086_A41ClinicaCodigo ;
      private String[] T00086_A27CategoriaCodigo ;
      private String[] T00086_A124SubCategoriaCodigo ;
      private String[] T00086_A380UnidadMedidaCodigo ;
      private String[] T00084_A41ClinicaCodigo ;
      private String[] T00085_A41ClinicaCodigo ;
      private String[] T00087_A41ClinicaCodigo ;
      private String[] T00088_A41ClinicaCodigo ;
      private String[] T00089_A41ClinicaCodigo ;
      private String[] T00089_A30ArticuloCodigo ;
      private String[] T00083_A30ArticuloCodigo ;
      private String[] T00083_A31ArticuloDescripcion ;
      private decimal[] T00083_A32ArticuloPrecio ;
      private decimal[] T00083_A60ArticuloCosto ;
      private short[] T00083_A33ArticuloTipo ;
      private short[] T00083_A34ArticuloEstado ;
      private short[] T00083_A387ArticuloCirugia ;
      private decimal[] T00083_A394ArticuloHonorarioCirujano ;
      private decimal[] T00083_A389ArticuloHonorarioAnestesiologo ;
      private decimal[] T00083_A390ArticuloImplante ;
      private decimal[] T00083_A391ArticuloMedicamento ;
      private decimal[] T00083_A392ArticuloOtro ;
      private String[] T00083_A41ClinicaCodigo ;
      private String[] T00083_A27CategoriaCodigo ;
      private String[] T00083_A124SubCategoriaCodigo ;
      private String[] T00083_A380UnidadMedidaCodigo ;
      private String[] T000810_A41ClinicaCodigo ;
      private String[] T000810_A30ArticuloCodigo ;
      private String[] T000811_A41ClinicaCodigo ;
      private String[] T000811_A30ArticuloCodigo ;
      private String[] T000812_A30ArticuloCodigo ;
      private String[] T000812_A31ArticuloDescripcion ;
      private decimal[] T000812_A32ArticuloPrecio ;
      private decimal[] T000812_A60ArticuloCosto ;
      private short[] T000812_A33ArticuloTipo ;
      private short[] T000812_A34ArticuloEstado ;
      private short[] T000812_A387ArticuloCirugia ;
      private decimal[] T000812_A394ArticuloHonorarioCirujano ;
      private decimal[] T000812_A389ArticuloHonorarioAnestesiologo ;
      private decimal[] T000812_A390ArticuloImplante ;
      private decimal[] T000812_A391ArticuloMedicamento ;
      private decimal[] T000812_A392ArticuloOtro ;
      private String[] T000812_A41ClinicaCodigo ;
      private String[] T000812_A27CategoriaCodigo ;
      private String[] T000812_A124SubCategoriaCodigo ;
      private String[] T000812_A380UnidadMedidaCodigo ;
      private String[] T000816_A41ClinicaCodigo ;
      private String[] T000816_A121BodegaCodigo ;
      private String[] T000816_A30ArticuloCodigo ;
      private String[] T000817_A41ClinicaCodigo ;
      private String[] T000817_A114TipoMICodigo ;
      private int[] T000817_A267MovimientoId ;
      private short[] T000817_A272MovimientoLinea ;
      private String[] T000818_A41ClinicaCodigo ;
      private int[] T000818_A185FacturaId ;
      private int[] T000818_A248FacturaDId ;
      private String[] T000819_A41ClinicaCodigo ;
      private int[] T000819_A91ConsultaId ;
      private int[] T000819_A162CargoId ;
      private String[] T000820_A41ClinicaCodigo ;
      private String[] T000820_A30ArticuloCodigo ;
      private String[] T000821_A41ClinicaCodigo ;
      private String[] T000821_A27CategoriaCodigo ;
      private String[] T000821_A28CategoriaDescripcion ;
      private short[] T000821_A29CategoriaEstado ;
      private String[] T000822_A41ClinicaCodigo ;
      private String[] T000822_A27CategoriaCodigo ;
      private String[] T000822_A124SubCategoriaCodigo ;
      private String[] T000822_A125SubCategoriaDescripcion ;
      private String[] T000823_A41ClinicaCodigo ;
      private String[] T000824_A41ClinicaCodigo ;
      private String[] T00082_A30ArticuloCodigo ;
      private String[] T00082_A31ArticuloDescripcion ;
      private decimal[] T00082_A32ArticuloPrecio ;
      private decimal[] T00082_A60ArticuloCosto ;
      private short[] T00082_A33ArticuloTipo ;
      private short[] T00082_A34ArticuloEstado ;
      private short[] T00082_A387ArticuloCirugia ;
      private decimal[] T00082_A394ArticuloHonorarioCirujano ;
      private decimal[] T00082_A389ArticuloHonorarioAnestesiologo ;
      private decimal[] T00082_A390ArticuloImplante ;
      private decimal[] T00082_A391ArticuloMedicamento ;
      private decimal[] T00082_A392ArticuloOtro ;
      private String[] T00082_A41ClinicaCodigo ;
      private String[] T00082_A27CategoriaCodigo ;
      private String[] T00082_A124SubCategoriaCodigo ;
      private String[] T00082_A380UnidadMedidaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class articulo__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00082 ;
          prmT00082 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00086 ;
          prmT00086 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00084 ;
          prmT00084 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00085 ;
          prmT00085 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UnidadMedidaCodigo",SqlDbType.VarChar,15,0}
          } ;
          Object[] prmT00087 ;
          prmT00087 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00088 ;
          prmT00088 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UnidadMedidaCodigo",SqlDbType.VarChar,15,0}
          } ;
          Object[] prmT00089 ;
          prmT00089 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00083 ;
          prmT00083 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000810 ;
          prmT000810 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000811 ;
          prmT000811 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000812 ;
          prmT000812 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000813 ;
          prmT000813 = new Object[] {
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ArticuloPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloCosto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ArticuloEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ArticuloCirugia",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ArticuloHonorarioCirujano",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloHonorarioAnestesiologo",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloImplante",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloMedicamento",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloOtro",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UnidadMedidaCodigo",SqlDbType.VarChar,15,0}
          } ;
          Object[] prmT000814 ;
          prmT000814 = new Object[] {
          new Object[] {"@ArticuloDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ArticuloPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloCosto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ArticuloEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ArticuloCirugia",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ArticuloHonorarioCirujano",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloHonorarioAnestesiologo",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloImplante",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloMedicamento",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloOtro",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UnidadMedidaCodigo",SqlDbType.VarChar,15,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000815 ;
          prmT000815 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000816 ;
          prmT000816 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000817 ;
          prmT000817 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000818 ;
          prmT000818 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000819 ;
          prmT000819 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000820 ;
          prmT000820 = new Object[] {
          } ;
          Object[] prmT000821 ;
          prmT000821 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000822 ;
          prmT000822 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000823 ;
          prmT000823 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UnidadMedidaCodigo",SqlDbType.VarChar,15,0}
          } ;
          Object[] prmT000824 ;
          prmT000824 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00082", "SELECT [ArticuloCodigo], [ArticuloDescripcion], [ArticuloPrecio], [ArticuloCosto], [ArticuloTipo], [ArticuloEstado], [ArticuloCirugia], [ArticuloHonorarioCirujano], [ArticuloHonorarioAnestesiologo], [ArticuloImplante], [ArticuloMedicamento], [ArticuloOtro], [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [UnidadMedidaCodigo] FROM [Articulo] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1,0,true,false )
             ,new CursorDef("T00083", "SELECT [ArticuloCodigo], [ArticuloDescripcion], [ArticuloPrecio], [ArticuloCosto], [ArticuloTipo], [ArticuloEstado], [ArticuloCirugia], [ArticuloHonorarioCirujano], [ArticuloHonorarioAnestesiologo], [ArticuloImplante], [ArticuloMedicamento], [ArticuloOtro], [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [UnidadMedidaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1,0,true,false )
             ,new CursorDef("T00084", "SELECT [ClinicaCodigo] FROM [SubCategoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,1,0,true,false )
             ,new CursorDef("T00085", "SELECT [ClinicaCodigo] FROM [UnidadMedida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [UnidadMedidaCodigo] = @UnidadMedidaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1,0,true,false )
             ,new CursorDef("T00086", "SELECT TM1.[ArticuloCodigo], TM1.[ArticuloDescripcion], TM1.[ArticuloPrecio], TM1.[ArticuloCosto], TM1.[ArticuloTipo], TM1.[ArticuloEstado], TM1.[ArticuloCirugia], TM1.[ArticuloHonorarioCirujano], TM1.[ArticuloHonorarioAnestesiologo], TM1.[ArticuloImplante], TM1.[ArticuloMedicamento], TM1.[ArticuloOtro], TM1.[ClinicaCodigo], TM1.[CategoriaCodigo], TM1.[SubCategoriaCodigo], TM1.[UnidadMedidaCodigo] FROM [Articulo] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[ArticuloCodigo] = @ArticuloCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[ArticuloCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,100,0,true,false )
             ,new CursorDef("T00087", "SELECT [ClinicaCodigo] FROM [SubCategoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1,0,true,false )
             ,new CursorDef("T00088", "SELECT [ClinicaCodigo] FROM [UnidadMedida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [UnidadMedidaCodigo] = @UnidadMedidaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00088,1,0,true,false )
             ,new CursorDef("T00089", "SELECT [ClinicaCodigo], [ArticuloCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00089,1,0,true,false )
             ,new CursorDef("T000810", "SELECT TOP 1 [ClinicaCodigo], [ArticuloCodigo] FROM [Articulo] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ArticuloCodigo] > @ArticuloCodigo) ORDER BY [ClinicaCodigo], [ArticuloCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000810,1,0,true,true )
             ,new CursorDef("T000811", "SELECT TOP 1 [ClinicaCodigo], [ArticuloCodigo] FROM [Articulo] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ArticuloCodigo] < @ArticuloCodigo) ORDER BY [ClinicaCodigo] DESC, [ArticuloCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000811,1,0,true,true )
             ,new CursorDef("T000812", "SELECT [ArticuloCodigo], [ArticuloDescripcion], [ArticuloPrecio], [ArticuloCosto], [ArticuloTipo], [ArticuloEstado], [ArticuloCirugia], [ArticuloHonorarioCirujano], [ArticuloHonorarioAnestesiologo], [ArticuloImplante], [ArticuloMedicamento], [ArticuloOtro], [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [UnidadMedidaCodigo] FROM [Articulo] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000812,1,0,true,false )
             ,new CursorDef("T000813", "INSERT INTO [Articulo] ([ArticuloCodigo], [ArticuloDescripcion], [ArticuloPrecio], [ArticuloCosto], [ArticuloTipo], [ArticuloEstado], [ArticuloCirugia], [ArticuloHonorarioCirujano], [ArticuloHonorarioAnestesiologo], [ArticuloImplante], [ArticuloMedicamento], [ArticuloOtro], [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [UnidadMedidaCodigo]) VALUES (@ArticuloCodigo, @ArticuloDescripcion, @ArticuloPrecio, @ArticuloCosto, @ArticuloTipo, @ArticuloEstado, @ArticuloCirugia, @ArticuloHonorarioCirujano, @ArticuloHonorarioAnestesiologo, @ArticuloImplante, @ArticuloMedicamento, @ArticuloOtro, @ClinicaCodigo, @CategoriaCodigo, @SubCategoriaCodigo, @UnidadMedidaCodigo)", GxErrorMask.GX_NOMASK,prmT000813)
             ,new CursorDef("T000814", "UPDATE [Articulo] SET [ArticuloDescripcion]=@ArticuloDescripcion, [ArticuloPrecio]=@ArticuloPrecio, [ArticuloCosto]=@ArticuloCosto, [ArticuloTipo]=@ArticuloTipo, [ArticuloEstado]=@ArticuloEstado, [ArticuloCirugia]=@ArticuloCirugia, [ArticuloHonorarioCirujano]=@ArticuloHonorarioCirujano, [ArticuloHonorarioAnestesiologo]=@ArticuloHonorarioAnestesiologo, [ArticuloImplante]=@ArticuloImplante, [ArticuloMedicamento]=@ArticuloMedicamento, [ArticuloOtro]=@ArticuloOtro, [CategoriaCodigo]=@CategoriaCodigo, [SubCategoriaCodigo]=@SubCategoriaCodigo, [UnidadMedidaCodigo]=@UnidadMedidaCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo", GxErrorMask.GX_NOMASK,prmT000814)
             ,new CursorDef("T000815", "DELETE FROM [Articulo]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo", GxErrorMask.GX_NOMASK,prmT000815)
             ,new CursorDef("T000816", "SELECT TOP 1 [ClinicaCodigo], [BodegaCodigo], [ArticuloCodigo] FROM [Inventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000816,1,0,true,true )
             ,new CursorDef("T000817", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoLinea] FROM [MovimientoInvDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000817,1,0,true,true )
             ,new CursorDef("T000818", "SELECT TOP 1 [ClinicaCodigo], [FacturaId], [FacturaDId] FROM [FacturaDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000818,1,0,true,true )
             ,new CursorDef("T000819", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [CargoId] FROM [Cargo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000819,1,0,true,true )
             ,new CursorDef("T000820", "SELECT [ClinicaCodigo], [ArticuloCodigo] FROM [Articulo] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [ArticuloCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000820,100,0,true,false )
             ,new CursorDef("T000821", "SELECT [ClinicaCodigo], [CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado] FROM [Categoria] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([CategoriaEstado] = 1) ORDER BY [CategoriaDescripcion] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000821,0,0,true,false )
             ,new CursorDef("T000822", "SELECT [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [SubCategoriaDescripcion] FROM [SubCategoria] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([CategoriaCodigo] = @CategoriaCodigo) ORDER BY [SubCategoriaDescripcion] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000822,0,0,true,false )
             ,new CursorDef("T000823", "SELECT [ClinicaCodigo] FROM [UnidadMedida] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [UnidadMedidaCodigo] = @UnidadMedidaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000823,1,0,true,false )
             ,new CursorDef("T000824", "SELECT [ClinicaCodigo] FROM [SubCategoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000824,1,0,true,false )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((decimal[]) buf[11])[0] = rslt.getDecimal(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((decimal[]) buf[11])[0] = rslt.getDecimal(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((decimal[]) buf[11])[0] = rslt.getDecimal(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((decimal[]) buf[10])[0] = rslt.getDecimal(11) ;
                ((decimal[]) buf[11])[0] = rslt.getDecimal(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
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
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (decimal)parms[7]);
                stmt.SetParameter(9, (decimal)parms[8]);
                stmt.SetParameter(10, (decimal)parms[9]);
                stmt.SetParameter(11, (decimal)parms[10]);
                stmt.SetParameter(12, (decimal)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                stmt.SetParameter(8, (decimal)parms[7]);
                stmt.SetParameter(9, (decimal)parms[8]);
                stmt.SetParameter(10, (decimal)parms[9]);
                stmt.SetParameter(11, (decimal)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
       }
    }

 }

}
