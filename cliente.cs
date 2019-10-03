/*
               File: Cliente
        Description: Clientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:1.17
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
   public class cliente : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A138TipoCliCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138TipoCliCodigo", A138TipoCliCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A41ClinicaCodigo, A138TipoCliCodigo) ;
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
         cmbClienteEstado.Name = "CLIENTEESTADO" ;
         cmbClienteEstado.WebTags = "" ;
         cmbClienteEstado.addItem("0", "De baja", 0);
         cmbClienteEstado.addItem("1", "Activo", 0);
         if ( ( cmbClienteEstado.ItemCount > 0 ) && (0==A184ClienteEstado) )
         {
            A184ClienteEstado = (short)(NumberUtil.Val( cmbClienteEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184ClienteEstado", StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Clientes", 0) ;
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

      public cliente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public cliente( IGxContext context )
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
         cmbClienteEstado = new GXCombobox();
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
            wb_table1_2_1148( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1148e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1148( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1148( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1148e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Clientes"+"</legend>") ;
            wb_table3_27_1148( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1148e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1148e( true) ;
         }
         else
         {
            wb_table1_2_1148e( false) ;
         }
      }

      protected void wb_table3_27_1148( bool wbgen )
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
            wb_table4_33_1148( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1148e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1148e( true) ;
         }
         else
         {
            wb_table3_27_1148e( false) ;
         }
      }

      protected void wb_table4_33_1148( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclientecodigo_Internalname, "Cliente", "", "", lblTextblockclientecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClienteCodigo_Internalname, StringUtil.RTrim( A178ClienteCodigo), StringUtil.RTrim( context.localUtil.Format( A178ClienteCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtClienteCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClienteCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclientenombre_Internalname, "Nombre", "", "", lblTextblockclientenombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179ClienteNombre", A179ClienteNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClienteNombre_Internalname, StringUtil.RTrim( A179ClienteNombre), StringUtil.RTrim( context.localUtil.Format( A179ClienteNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtClienteNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtClienteNombre_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclientetelefono1_Internalname, "Teléfono_1", "", "", lblTextblockclientetelefono1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180ClienteTelefono1", A180ClienteTelefono1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClienteTelefono1_Internalname, StringUtil.RTrim( A180ClienteTelefono1), StringUtil.RTrim( context.localUtil.Format( A180ClienteTelefono1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtClienteTelefono1_Jsonclick, 0, ClassString, StyleString, "", 1, edtClienteTelefono1_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclientetelefono2_Internalname, "Teléfono_2", "", "", lblTextblockclientetelefono2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181ClienteTelefono2", A181ClienteTelefono2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClienteTelefono2_Internalname, StringUtil.RTrim( A181ClienteTelefono2), StringUtil.RTrim( context.localUtil.Format( A181ClienteTelefono2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", "", "", "", edtClienteTelefono2_Jsonclick, 0, ClassString, StyleString, "", 1, edtClienteTelefono2_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclientedireccion_Internalname, "Dirección", "", "", lblTextblockclientedireccion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182ClienteDireccion", A182ClienteDireccion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClienteDireccion_Internalname, StringUtil.RTrim( A182ClienteDireccion), StringUtil.RTrim( context.localUtil.Format( A182ClienteDireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtClienteDireccion_Jsonclick, 0, ClassString, StyleString, "", 1, edtClienteDireccion_Enabled, 0, 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, true, "left", "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclientecorreo_Internalname, "Correo", "", "", lblTextblockclientecorreo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ClienteCorreo", A183ClienteCorreo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClienteCorreo_Internalname, StringUtil.RTrim( A183ClienteCorreo), StringUtil.RTrim( context.localUtil.Format( A183ClienteCorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", "", "", "", edtClienteCorreo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClienteCorreo_Enabled, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoclicodigo_Internalname, "Tipo", "", "", lblTextblocktipoclicodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138TipoCliCodigo", A138TipoCliCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTipoCliCodigo_Internalname, StringUtil.RTrim( A138TipoCliCodigo), StringUtil.RTrim( context.localUtil.Format( A138TipoCliCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", "", "", "", edtTipoCliCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtTipoCliCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Cliente.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_138_Internalname, "prompt.gif", imgprompt_41_138_Link, "", "", "Fantastic", imgprompt_41_138_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockclienteestado_Internalname, "Estado", "", "", lblTextblockclienteestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cliente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184ClienteEstado", StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbClienteEstado, cmbClienteEstado_Internalname, StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0), 1, cmbClienteEstado_Jsonclick, 0, "", "int", "", 1, cmbClienteEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(78);\"", "", true, "HLP_Cliente.htm");
            cmbClienteEstado.CurrentValue = StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbClienteEstado_Internalname, "Values", (String)(cmbClienteEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1148e( true) ;
         }
         else
         {
            wb_table4_33_1148e( false) ;
         }
      }

      protected void wb_table2_5_1148( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CLIENTECODIGO"+"'), id:'"+"CLIENTECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx01c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CLIENTECODIGO"+"'), id:'"+"CLIENTECODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cliente.htm");
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
            wb_table2_5_1148e( true) ;
         }
         else
         {
            wb_table2_5_1148e( false) ;
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
         /* Execute user event: E11112 */
         E11112 ();
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
               A178ClienteCodigo = cgiGet( edtClienteCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
               A179ClienteNombre = cgiGet( edtClienteNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179ClienteNombre", A179ClienteNombre);
               A180ClienteTelefono1 = cgiGet( edtClienteTelefono1_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180ClienteTelefono1", A180ClienteTelefono1);
               A181ClienteTelefono2 = cgiGet( edtClienteTelefono2_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181ClienteTelefono2", A181ClienteTelefono2);
               A182ClienteDireccion = cgiGet( edtClienteDireccion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182ClienteDireccion", A182ClienteDireccion);
               A183ClienteCorreo = cgiGet( edtClienteCorreo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ClienteCorreo", A183ClienteCorreo);
               A138TipoCliCodigo = cgiGet( edtTipoCliCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138TipoCliCodigo", A138TipoCliCodigo);
               cmbClienteEstado.CurrentValue = cgiGet( cmbClienteEstado_Internalname) ;
               A184ClienteEstado = (short)(NumberUtil.Val( cgiGet( cmbClienteEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184ClienteEstado", StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z178ClienteCodigo = cgiGet( "Z178ClienteCodigo") ;
               Z179ClienteNombre = cgiGet( "Z179ClienteNombre") ;
               Z180ClienteTelefono1 = cgiGet( "Z180ClienteTelefono1") ;
               Z181ClienteTelefono2 = cgiGet( "Z181ClienteTelefono2") ;
               Z182ClienteDireccion = cgiGet( "Z182ClienteDireccion") ;
               Z183ClienteCorreo = cgiGet( "Z183ClienteCorreo") ;
               Z184ClienteEstado = (short)(context.localUtil.CToN( cgiGet( "Z184ClienteEstado"), ".", ",")) ;
               Z138TipoCliCodigo = cgiGet( "Z138TipoCliCodigo") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV8ClinicaCodigo = cgiGet( "vCLINICACODIGO") ;
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
                  A178ClienteCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
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
                           /* Execute user event: E11112 */
                           E11112 ();
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
               InitAll1148( ) ;
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
         DisableAttributes1148( ) ;
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

      protected void ResetCaption110( )
      {
      }

      protected void E11112( )
      {
         /* Start Routine */
         GXt_SdtParametros3 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV7Parametros = GXt_SdtParametros3 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM1148( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z179ClienteNombre = T00113_A179ClienteNombre[0] ;
               Z180ClienteTelefono1 = T00113_A180ClienteTelefono1[0] ;
               Z181ClienteTelefono2 = T00113_A181ClienteTelefono2[0] ;
               Z182ClienteDireccion = T00113_A182ClienteDireccion[0] ;
               Z183ClienteCorreo = T00113_A183ClienteCorreo[0] ;
               Z184ClienteEstado = T00113_A184ClienteEstado[0] ;
               Z138TipoCliCodigo = T00113_A138TipoCliCodigo[0] ;
            }
            else
            {
               Z179ClienteNombre = A179ClienteNombre ;
               Z180ClienteTelefono1 = A180ClienteTelefono1 ;
               Z181ClienteTelefono2 = A181ClienteTelefono2 ;
               Z182ClienteDireccion = A182ClienteDireccion ;
               Z183ClienteCorreo = A183ClienteCorreo ;
               Z184ClienteEstado = A184ClienteEstado ;
               Z138TipoCliCodigo = A138TipoCliCodigo ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z178ClienteCodigo = A178ClienteCodigo ;
            Z179ClienteNombre = A179ClienteNombre ;
            Z180ClienteTelefono1 = A180ClienteTelefono1 ;
            Z181ClienteTelefono2 = A181ClienteTelefono2 ;
            Z182ClienteDireccion = A182ClienteDireccion ;
            Z183ClienteCorreo = A183ClienteCorreo ;
            Z184ClienteEstado = A184ClienteEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z138TipoCliCodigo = A138TipoCliCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         lblTextblockclinicacodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblockclinicacodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblockclinicacodigo_Visible), 5, 0)));
         edtClinicaCodigo_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Visible), 5, 0)));
         imgprompt_41_138_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0120.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"TIPOCLICODIGO"+"'), id:'"+"TIPOCLICODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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
      }

      protected void Load1148( )
      {
         /* Using cursor T00115 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound48 = 1 ;
            A179ClienteNombre = T00115_A179ClienteNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179ClienteNombre", A179ClienteNombre);
            A180ClienteTelefono1 = T00115_A180ClienteTelefono1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180ClienteTelefono1", A180ClienteTelefono1);
            A181ClienteTelefono2 = T00115_A181ClienteTelefono2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181ClienteTelefono2", A181ClienteTelefono2);
            A182ClienteDireccion = T00115_A182ClienteDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182ClienteDireccion", A182ClienteDireccion);
            A183ClienteCorreo = T00115_A183ClienteCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ClienteCorreo", A183ClienteCorreo);
            A184ClienteEstado = T00115_A184ClienteEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184ClienteEstado", StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0));
            A138TipoCliCodigo = T00115_A138TipoCliCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138TipoCliCodigo", A138TipoCliCodigo);
            ZM1148( -4) ;
         }
         pr_default.close(3);
         OnLoadActions1148( ) ;
      }

      protected void OnLoadActions1148( )
      {
      }

      protected void CheckExtendedTable1148( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00114 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A138TipoCliCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError138 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Clientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError138 == 0 ) )
         {
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors1148( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo ,
                               String A138TipoCliCodigo )
      {
         /* Using cursor T00116 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A138TipoCliCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError41 = 1 ;
            AnyError138 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Clientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError138 == 0 ) )
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

      protected void GetKey1148( )
      {
         /* Using cursor T00117 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound48 = 1 ;
         }
         else
         {
            RcdFound48 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00113 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1148( 4) ;
            RcdFound48 = 1 ;
            A178ClienteCodigo = T00113_A178ClienteCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
            A179ClienteNombre = T00113_A179ClienteNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179ClienteNombre", A179ClienteNombre);
            A180ClienteTelefono1 = T00113_A180ClienteTelefono1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180ClienteTelefono1", A180ClienteTelefono1);
            A181ClienteTelefono2 = T00113_A181ClienteTelefono2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181ClienteTelefono2", A181ClienteTelefono2);
            A182ClienteDireccion = T00113_A182ClienteDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182ClienteDireccion", A182ClienteDireccion);
            A183ClienteCorreo = T00113_A183ClienteCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ClienteCorreo", A183ClienteCorreo);
            A184ClienteEstado = T00113_A184ClienteEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184ClienteEstado", StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0));
            A41ClinicaCodigo = T00113_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A138TipoCliCodigo = T00113_A138TipoCliCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138TipoCliCodigo", A138TipoCliCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z178ClienteCodigo = A178ClienteCodigo ;
            sMode48 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1148( ) ;
            Gx_mode = sMode48 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound48 = 0 ;
            InitializeNonKey1148( ) ;
            sMode48 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode48 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1148( ) ;
         if ( RcdFound48 == 0 )
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
         RcdFound48 = 0 ;
         /* Using cursor T00118 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00118_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00118_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00118_A178ClienteCodigo[0], A178ClienteCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00118_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00118_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00118_A178ClienteCodigo[0], A178ClienteCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T00118_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A178ClienteCodigo = T00118_A178ClienteCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
               RcdFound48 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound48 = 0 ;
         /* Using cursor T00119 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00119_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T00119_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00119_A178ClienteCodigo[0], A178ClienteCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00119_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T00119_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T00119_A178ClienteCodigo[0], A178ClienteCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T00119_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A178ClienteCodigo = T00119_A178ClienteCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
               RcdFound48 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1148( ) ;
         if ( RcdFound48 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A178ClienteCodigo, Z178ClienteCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A178ClienteCodigo = Z178ClienteCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
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
               Update1148( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A178ClienteCodigo, Z178ClienteCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert1148( ) ;
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
                  Insert1148( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A178ClienteCodigo, Z178ClienteCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A178ClienteCodigo = Z178ClienteCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
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
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtClienteNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1148( ) ;
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClienteNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1148( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClienteNombre_Internalname ;
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
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClienteNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1148( ) ;
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound48 != 0 )
            {
               ScanNext1148( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtClienteNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1148( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1148( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001110 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cliente"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z179ClienteNombre, T001110_A179ClienteNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z180ClienteTelefono1, T001110_A180ClienteTelefono1[0]) != 0 ) || ( StringUtil.StrCmp(Z181ClienteTelefono2, T001110_A181ClienteTelefono2[0]) != 0 ) || ( StringUtil.StrCmp(Z182ClienteDireccion, T001110_A182ClienteDireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z183ClienteCorreo, T001110_A183ClienteCorreo[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z184ClienteEstado != T001110_A184ClienteEstado[0] ) || ( StringUtil.StrCmp(Z138TipoCliCodigo, T001110_A138TipoCliCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Cliente"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1148( )
      {
         BeforeValidate1148( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1148( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1148( 0) ;
            CheckOptimisticConcurrency1148( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1148( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1148( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001111 */
                     pr_default.execute(9, new Object[] {A178ClienteCodigo, A179ClienteNombre, A180ClienteTelefono1, A181ClienteTelefono2, A182ClienteDireccion, A183ClienteCorreo, A184ClienteEstado, A41ClinicaCodigo, A138TipoCliCodigo});
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
                           ResetCaption110( ) ;
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
               Load1148( ) ;
            }
            EndLevel1148( ) ;
         }
         CloseExtendedTableCursors1148( ) ;
      }

      protected void Update1148( )
      {
         BeforeValidate1148( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1148( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1148( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1148( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1148( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001112 */
                     pr_default.execute(10, new Object[] {A179ClienteNombre, A180ClienteTelefono1, A181ClienteTelefono2, A182ClienteDireccion, A183ClienteCorreo, A184ClienteEstado, A138TipoCliCodigo, A41ClinicaCodigo, A178ClienteCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cliente"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1148( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption110( ) ;
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
            EndLevel1148( ) ;
         }
         CloseExtendedTableCursors1148( ) ;
      }

      protected void DeferredUpdate1148( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1148( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1148( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1148( ) ;
            AfterConfirm1148( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1148( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001113 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound48 == 0 )
                        {
                           InitAll1148( ) ;
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
                        ResetCaption110( ) ;
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
         sMode48 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1148( ) ;
         Gx_mode = sMode48 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1148( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001114 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Factura a Pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel1148( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1148( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("Cliente");
            if ( AnyError == 0 )
            {
               ConfirmValues110( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("Cliente");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1148( )
      {
         /* Using cursor T001115 */
         pr_default.execute(13);
         RcdFound48 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound48 = 1 ;
            A41ClinicaCodigo = T001115_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A178ClienteCodigo = T001115_A178ClienteCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1148( )
      {
         pr_default.readNext(13);
         RcdFound48 = 0 ;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound48 = 1 ;
            A41ClinicaCodigo = T001115_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A178ClienteCodigo = T001115_A178ClienteCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
         }
      }

      protected void ScanEnd1148( )
      {
      }

      protected void AfterConfirm1148( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1148( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1148( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1148( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1148( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1148( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1148( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtClienteCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteCodigo_Enabled), 5, 0)));
         edtClienteNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteNombre_Enabled), 5, 0)));
         edtClienteTelefono1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefono1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefono1_Enabled), 5, 0)));
         edtClienteTelefono2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteTelefono2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteTelefono2_Enabled), 5, 0)));
         edtClienteDireccion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteDireccion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteDireccion_Enabled), 5, 0)));
         edtClienteCorreo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClienteCorreo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClienteCorreo_Enabled), 5, 0)));
         edtTipoCliCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTipoCliCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTipoCliCodigo_Enabled), 5, 0)));
         cmbClienteEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbClienteEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbClienteEstado.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues110( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("cliente.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z178ClienteCodigo", StringUtil.RTrim( Z178ClienteCodigo));
         GxWebStd.gx_hidden_field( context, "Z179ClienteNombre", StringUtil.RTrim( Z179ClienteNombre));
         GxWebStd.gx_hidden_field( context, "Z180ClienteTelefono1", StringUtil.RTrim( Z180ClienteTelefono1));
         GxWebStd.gx_hidden_field( context, "Z181ClienteTelefono2", StringUtil.RTrim( Z181ClienteTelefono2));
         GxWebStd.gx_hidden_field( context, "Z182ClienteDireccion", StringUtil.RTrim( Z182ClienteDireccion));
         GxWebStd.gx_hidden_field( context, "Z183ClienteCorreo", StringUtil.RTrim( Z183ClienteCorreo));
         GxWebStd.gx_hidden_field( context, "Z184ClienteEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z184ClienteEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z138TipoCliCodigo", StringUtil.RTrim( Z138TipoCliCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV8ClinicaCodigo));
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
         return "Cliente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Clientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cliente.aspx")  ;
      }

      protected void InitializeNonKey1148( )
      {
         A179ClienteNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179ClienteNombre", A179ClienteNombre);
         A180ClienteTelefono1 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180ClienteTelefono1", A180ClienteTelefono1);
         A181ClienteTelefono2 = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181ClienteTelefono2", A181ClienteTelefono2);
         A182ClienteDireccion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182ClienteDireccion", A182ClienteDireccion);
         A183ClienteCorreo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183ClienteCorreo", A183ClienteCorreo);
         A138TipoCliCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A138TipoCliCodigo", A138TipoCliCodigo);
         A184ClienteEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184ClienteEstado", StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0));
      }

      protected void InitAll1148( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A178ClienteCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178ClienteCodigo", A178ClienteCodigo);
         InitializeNonKey1148( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?156277");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("cliente.js", "?156278");
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
         lblTextblockclientecodigo_Internalname = "TEXTBLOCKCLIENTECODIGO" ;
         edtClienteCodigo_Internalname = "CLIENTECODIGO" ;
         lblTextblockclientenombre_Internalname = "TEXTBLOCKCLIENTENOMBRE" ;
         edtClienteNombre_Internalname = "CLIENTENOMBRE" ;
         lblTextblockclientetelefono1_Internalname = "TEXTBLOCKCLIENTETELEFONO1" ;
         edtClienteTelefono1_Internalname = "CLIENTETELEFONO1" ;
         lblTextblockclientetelefono2_Internalname = "TEXTBLOCKCLIENTETELEFONO2" ;
         edtClienteTelefono2_Internalname = "CLIENTETELEFONO2" ;
         lblTextblockclientedireccion_Internalname = "TEXTBLOCKCLIENTEDIRECCION" ;
         edtClienteDireccion_Internalname = "CLIENTEDIRECCION" ;
         lblTextblockclientecorreo_Internalname = "TEXTBLOCKCLIENTECORREO" ;
         edtClienteCorreo_Internalname = "CLIENTECORREO" ;
         lblTextblocktipoclicodigo_Internalname = "TEXTBLOCKTIPOCLICODIGO" ;
         edtTipoCliCodigo_Internalname = "TIPOCLICODIGO" ;
         lblTextblockclienteestado_Internalname = "TEXTBLOCKCLIENTEESTADO" ;
         cmbClienteEstado_Internalname = "CLIENTEESTADO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_138_Internalname = "PROMPT_41_138" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Clientes" ;
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
         cmbClienteEstado_Jsonclick = "" ;
         cmbClienteEstado.Enabled = 1 ;
         imgprompt_41_138_Visible = 1 ;
         imgprompt_41_138_Link = "" ;
         edtTipoCliCodigo_Jsonclick = "" ;
         edtTipoCliCodigo_Enabled = 1 ;
         edtClienteCorreo_Jsonclick = "" ;
         edtClienteCorreo_Enabled = 1 ;
         edtClienteDireccion_Jsonclick = "" ;
         edtClienteDireccion_Enabled = 1 ;
         edtClienteTelefono2_Jsonclick = "" ;
         edtClienteTelefono2_Enabled = 1 ;
         edtClienteTelefono1_Jsonclick = "" ;
         edtClienteTelefono1_Enabled = 1 ;
         edtClienteNombre_Jsonclick = "" ;
         edtClienteNombre_Enabled = 1 ;
         edtClienteCodigo_Jsonclick = "" ;
         edtClienteCodigo_Enabled = 1 ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Enabled = 1 ;
         edtClinicaCodigo_Visible = 1 ;
         lblTextblockclinicacodigo_Visible = 1 ;
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
         GX_FocusControl = edtClienteNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clientecodigo( String GX_Parm1 ,
                                       String GX_Parm2 ,
                                       String GX_Parm3 ,
                                       String GX_Parm4 ,
                                       String GX_Parm5 ,
                                       String GX_Parm6 ,
                                       String GX_Parm7 ,
                                       String GX_Parm8 ,
                                       GXCombobox cmbGX_Parm9 ,
                                       String GX_Parm10 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A178ClienteCodigo = GX_Parm3 ;
         A179ClienteNombre = GX_Parm4 ;
         A180ClienteTelefono1 = GX_Parm5 ;
         A181ClienteTelefono2 = GX_Parm6 ;
         A182ClienteDireccion = GX_Parm7 ;
         A183ClienteCorreo = GX_Parm8 ;
         cmbClienteEstado = cmbGX_Parm9 ;
         A184ClienteEstado = (short)(NumberUtil.Val( cmbClienteEstado.CurrentValue, ".")) ;
         cmbClienteEstado.CurrentValue = StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0) ;
         A138TipoCliCodigo = GX_Parm10 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A179ClienteNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A180ClienteTelefono1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A181ClienteTelefono2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A182ClienteDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A183ClienteCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A138TipoCliCodigo)));
         cmbClienteEstado.CurrentValue = StringUtil.Str( (decimal)(A184ClienteEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbClienteEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z178ClienteCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z179ClienteNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z180ClienteTelefono1)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z181ClienteTelefono2)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z182ClienteDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z183ClienteCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z138TipoCliCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z184ClienteEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Tipoclicodigo( String GX_Parm1 ,
                                       String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A138TipoCliCodigo = GX_Parm2 ;
         /* Using cursor T001116 */
         pr_default.execute(14, new Object[] {A41ClinicaCodigo, A138TipoCliCodigo});
         if ( (pr_default.getStatus(14) == 101) )
         {
            AnyError41 = 1 ;
            AnyError138 = 1 ;
            GX_msglist.addItem("No existe 'Tipos de Clientes'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError138 == 0 ) )
         {
         }
         pr_default.close(14);
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
         pr_default.close(13);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
         A138TipoCliCodigo = "" ;
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
         lblTextblockclientecodigo_Jsonclick = "" ;
         A178ClienteCodigo = "" ;
         lblTextblockclientenombre_Jsonclick = "" ;
         A179ClienteNombre = "" ;
         lblTextblockclientetelefono1_Jsonclick = "" ;
         A180ClienteTelefono1 = "" ;
         lblTextblockclientetelefono2_Jsonclick = "" ;
         A181ClienteTelefono2 = "" ;
         lblTextblockclientedireccion_Jsonclick = "" ;
         A182ClienteDireccion = "" ;
         lblTextblockclientecorreo_Jsonclick = "" ;
         A183ClienteCorreo = "" ;
         lblTextblocktipoclicodigo_Jsonclick = "" ;
         lblTextblockclienteestado_Jsonclick = "" ;
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
         Z178ClienteCodigo = "" ;
         Z179ClienteNombre = "" ;
         Z180ClienteTelefono1 = "" ;
         Z181ClienteTelefono2 = "" ;
         Z182ClienteDireccion = "" ;
         Z183ClienteCorreo = "" ;
         Z138TipoCliCodigo = "" ;
         Gx_mode = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         T00115_A178ClienteCodigo = new String[] {""} ;
         T00115_A179ClienteNombre = new String[] {""} ;
         T00115_A180ClienteTelefono1 = new String[] {""} ;
         T00115_A181ClienteTelefono2 = new String[] {""} ;
         T00115_A182ClienteDireccion = new String[] {""} ;
         T00115_A183ClienteCorreo = new String[] {""} ;
         T00115_A184ClienteEstado = new short[1] ;
         T00115_A41ClinicaCodigo = new String[] {""} ;
         T00115_A138TipoCliCodigo = new String[] {""} ;
         T00114_A41ClinicaCodigo = new String[] {""} ;
         T00116_A41ClinicaCodigo = new String[] {""} ;
         T00117_A41ClinicaCodigo = new String[] {""} ;
         T00117_A178ClienteCodigo = new String[] {""} ;
         T00113_A178ClienteCodigo = new String[] {""} ;
         T00113_A179ClienteNombre = new String[] {""} ;
         T00113_A180ClienteTelefono1 = new String[] {""} ;
         T00113_A181ClienteTelefono2 = new String[] {""} ;
         T00113_A182ClienteDireccion = new String[] {""} ;
         T00113_A183ClienteCorreo = new String[] {""} ;
         T00113_A184ClienteEstado = new short[1] ;
         T00113_A41ClinicaCodigo = new String[] {""} ;
         T00113_A138TipoCliCodigo = new String[] {""} ;
         sMode48 = "" ;
         T00118_A41ClinicaCodigo = new String[] {""} ;
         T00118_A178ClienteCodigo = new String[] {""} ;
         T00119_A41ClinicaCodigo = new String[] {""} ;
         T00119_A178ClienteCodigo = new String[] {""} ;
         T001110_A178ClienteCodigo = new String[] {""} ;
         T001110_A179ClienteNombre = new String[] {""} ;
         T001110_A180ClienteTelefono1 = new String[] {""} ;
         T001110_A181ClienteTelefono2 = new String[] {""} ;
         T001110_A182ClienteDireccion = new String[] {""} ;
         T001110_A183ClienteCorreo = new String[] {""} ;
         T001110_A184ClienteEstado = new short[1] ;
         T001110_A41ClinicaCodigo = new String[] {""} ;
         T001110_A138TipoCliCodigo = new String[] {""} ;
         T001114_A41ClinicaCodigo = new String[] {""} ;
         T001114_A185FacturaId = new int[1] ;
         T001115_A41ClinicaCodigo = new String[] {""} ;
         T001115_A178ClienteCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         T001116_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cliente__default(),
            new Object[][] {
                new Object[] {
               T00112_A178ClienteCodigo, T00112_A179ClienteNombre, T00112_A180ClienteTelefono1, T00112_A181ClienteTelefono2, T00112_A182ClienteDireccion, T00112_A183ClienteCorreo, T00112_A184ClienteEstado, T00112_A41ClinicaCodigo, T00112_A138TipoCliCodigo
               }
               , new Object[] {
               T00113_A178ClienteCodigo, T00113_A179ClienteNombre, T00113_A180ClienteTelefono1, T00113_A181ClienteTelefono2, T00113_A182ClienteDireccion, T00113_A183ClienteCorreo, T00113_A184ClienteEstado, T00113_A41ClinicaCodigo, T00113_A138TipoCliCodigo
               }
               , new Object[] {
               T00114_A41ClinicaCodigo
               }
               , new Object[] {
               T00115_A178ClienteCodigo, T00115_A179ClienteNombre, T00115_A180ClienteTelefono1, T00115_A181ClienteTelefono2, T00115_A182ClienteDireccion, T00115_A183ClienteCorreo, T00115_A184ClienteEstado, T00115_A41ClinicaCodigo, T00115_A138TipoCliCodigo
               }
               , new Object[] {
               T00116_A41ClinicaCodigo
               }
               , new Object[] {
               T00117_A41ClinicaCodigo, T00117_A178ClienteCodigo
               }
               , new Object[] {
               T00118_A41ClinicaCodigo, T00118_A178ClienteCodigo
               }
               , new Object[] {
               T00119_A41ClinicaCodigo, T00119_A178ClienteCodigo
               }
               , new Object[] {
               T001110_A178ClienteCodigo, T001110_A179ClienteNombre, T001110_A180ClienteTelefono1, T001110_A181ClienteTelefono2, T001110_A182ClienteDireccion, T001110_A183ClienteCorreo, T001110_A184ClienteEstado, T001110_A41ClinicaCodigo, T001110_A138TipoCliCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001114_A41ClinicaCodigo, T001114_A185FacturaId
               }
               , new Object[] {
               T001115_A41ClinicaCodigo, T001115_A178ClienteCodigo
               }
               , new Object[] {
               T001116_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A184ClienteEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z184ClienteEstado ;
      private short GX_JID ;
      private short RcdFound48 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int lblTextblockclinicacodigo_Visible ;
      private int edtClinicaCodigo_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtClienteCodigo_Enabled ;
      private int edtClienteNombre_Enabled ;
      private int edtClienteTelefono1_Enabled ;
      private int edtClienteTelefono2_Enabled ;
      private int edtClienteDireccion_Enabled ;
      private int edtClienteCorreo_Enabled ;
      private int edtTipoCliCodigo_Enabled ;
      private int imgprompt_41_138_Visible ;
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
      private int AnyError138 ;
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
      private String lblTextblockclientecodigo_Internalname ;
      private String lblTextblockclientecodigo_Jsonclick ;
      private String edtClienteCodigo_Internalname ;
      private String edtClienteCodigo_Jsonclick ;
      private String lblTextblockclientenombre_Internalname ;
      private String lblTextblockclientenombre_Jsonclick ;
      private String edtClienteNombre_Internalname ;
      private String edtClienteNombre_Jsonclick ;
      private String lblTextblockclientetelefono1_Internalname ;
      private String lblTextblockclientetelefono1_Jsonclick ;
      private String edtClienteTelefono1_Internalname ;
      private String edtClienteTelefono1_Jsonclick ;
      private String lblTextblockclientetelefono2_Internalname ;
      private String lblTextblockclientetelefono2_Jsonclick ;
      private String edtClienteTelefono2_Internalname ;
      private String edtClienteTelefono2_Jsonclick ;
      private String lblTextblockclientedireccion_Internalname ;
      private String lblTextblockclientedireccion_Jsonclick ;
      private String edtClienteDireccion_Internalname ;
      private String edtClienteDireccion_Jsonclick ;
      private String lblTextblockclientecorreo_Internalname ;
      private String lblTextblockclientecorreo_Jsonclick ;
      private String edtClienteCorreo_Internalname ;
      private String edtClienteCorreo_Jsonclick ;
      private String lblTextblocktipoclicodigo_Internalname ;
      private String lblTextblocktipoclicodigo_Jsonclick ;
      private String edtTipoCliCodigo_Internalname ;
      private String edtTipoCliCodigo_Jsonclick ;
      private String imgprompt_41_138_Internalname ;
      private String imgprompt_41_138_Link ;
      private String lblTextblockclienteestado_Internalname ;
      private String lblTextblockclienteestado_Jsonclick ;
      private String cmbClienteEstado_Internalname ;
      private String cmbClienteEstado_Jsonclick ;
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
      private String sMode48 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A41ClinicaCodigo ;
      private String A138TipoCliCodigo ;
      private String A178ClienteCodigo ;
      private String A179ClienteNombre ;
      private String A180ClienteTelefono1 ;
      private String A181ClienteTelefono2 ;
      private String A182ClienteDireccion ;
      private String A183ClienteCorreo ;
      private String Z41ClinicaCodigo ;
      private String Z178ClienteCodigo ;
      private String Z179ClienteNombre ;
      private String Z180ClienteTelefono1 ;
      private String Z181ClienteTelefono2 ;
      private String Z182ClienteDireccion ;
      private String Z183ClienteCorreo ;
      private String Z138TipoCliCodigo ;
      private String AV8ClinicaCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbClienteEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T00115_A178ClienteCodigo ;
      private String[] T00115_A179ClienteNombre ;
      private String[] T00115_A180ClienteTelefono1 ;
      private String[] T00115_A181ClienteTelefono2 ;
      private String[] T00115_A182ClienteDireccion ;
      private String[] T00115_A183ClienteCorreo ;
      private short[] T00115_A184ClienteEstado ;
      private String[] T00115_A41ClinicaCodigo ;
      private String[] T00115_A138TipoCliCodigo ;
      private String[] T00114_A41ClinicaCodigo ;
      private String[] T00116_A41ClinicaCodigo ;
      private String[] T00117_A41ClinicaCodigo ;
      private String[] T00117_A178ClienteCodigo ;
      private String[] T00113_A178ClienteCodigo ;
      private String[] T00113_A179ClienteNombre ;
      private String[] T00113_A180ClienteTelefono1 ;
      private String[] T00113_A181ClienteTelefono2 ;
      private String[] T00113_A182ClienteDireccion ;
      private String[] T00113_A183ClienteCorreo ;
      private short[] T00113_A184ClienteEstado ;
      private String[] T00113_A41ClinicaCodigo ;
      private String[] T00113_A138TipoCliCodigo ;
      private String[] T00118_A41ClinicaCodigo ;
      private String[] T00118_A178ClienteCodigo ;
      private String[] T00119_A41ClinicaCodigo ;
      private String[] T00119_A178ClienteCodigo ;
      private String[] T001110_A178ClienteCodigo ;
      private String[] T001110_A179ClienteNombre ;
      private String[] T001110_A180ClienteTelefono1 ;
      private String[] T001110_A181ClienteTelefono2 ;
      private String[] T001110_A182ClienteDireccion ;
      private String[] T001110_A183ClienteCorreo ;
      private short[] T001110_A184ClienteEstado ;
      private String[] T001110_A41ClinicaCodigo ;
      private String[] T001110_A138TipoCliCodigo ;
      private String[] T001114_A41ClinicaCodigo ;
      private int[] T001114_A185FacturaId ;
      private String[] T001115_A41ClinicaCodigo ;
      private String[] T001115_A178ClienteCodigo ;
      private String[] T001116_A41ClinicaCodigo ;
      private String[] T00112_A178ClienteCodigo ;
      private String[] T00112_A179ClienteNombre ;
      private String[] T00112_A180ClienteTelefono1 ;
      private String[] T00112_A181ClienteTelefono2 ;
      private String[] T00112_A182ClienteDireccion ;
      private String[] T00112_A183ClienteCorreo ;
      private short[] T00112_A184ClienteEstado ;
      private String[] T00112_A41ClinicaCodigo ;
      private String[] T00112_A138TipoCliCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class cliente__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00112 ;
          prmT00112 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00115 ;
          prmT00115 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00114 ;
          prmT00114 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoCliCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00116 ;
          prmT00116 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoCliCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00117 ;
          prmT00117 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00113 ;
          prmT00113 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00118 ;
          prmT00118 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00119 ;
          prmT00119 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001110 ;
          prmT001110 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001111 ;
          prmT001111 = new Object[] {
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClienteTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@ClienteTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@ClienteDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@ClienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@ClienteEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoCliCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001112 ;
          prmT001112 = new Object[] {
          new Object[] {"@ClienteNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClienteTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@ClienteTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@ClienteDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@ClienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@ClienteEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TipoCliCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001113 ;
          prmT001113 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001114 ;
          prmT001114 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT001115 ;
          prmT001115 = new Object[] {
          } ;
          Object[] prmT001116 ;
          prmT001116 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoCliCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00112", "SELECT [ClienteCodigo], [ClienteNombre], [ClienteTelefono1], [ClienteTelefono2], [ClienteDireccion], [ClienteCorreo], [ClienteEstado], [ClinicaCodigo], [TipoCliCodigo] FROM [Cliente] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00112,1,0,true,false )
             ,new CursorDef("T00113", "SELECT [ClienteCodigo], [ClienteNombre], [ClienteTelefono1], [ClienteTelefono2], [ClienteDireccion], [ClienteCorreo], [ClienteEstado], [ClinicaCodigo], [TipoCliCodigo] FROM [Cliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00113,1,0,true,false )
             ,new CursorDef("T00114", "SELECT [ClinicaCodigo] FROM [TipoCliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoCliCodigo] = @TipoCliCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00114,1,0,true,false )
             ,new CursorDef("T00115", "SELECT TM1.[ClienteCodigo], TM1.[ClienteNombre], TM1.[ClienteTelefono1], TM1.[ClienteTelefono2], TM1.[ClienteDireccion], TM1.[ClienteCorreo], TM1.[ClienteEstado], TM1.[ClinicaCodigo], TM1.[TipoCliCodigo] FROM [Cliente] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[ClienteCodigo] = @ClienteCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[ClienteCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00115,100,0,true,false )
             ,new CursorDef("T00116", "SELECT [ClinicaCodigo] FROM [TipoCliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoCliCodigo] = @TipoCliCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00116,1,0,true,false )
             ,new CursorDef("T00117", "SELECT [ClinicaCodigo], [ClienteCodigo] FROM [Cliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00117,1,0,true,false )
             ,new CursorDef("T00118", "SELECT TOP 1 [ClinicaCodigo], [ClienteCodigo] FROM [Cliente] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ClienteCodigo] > @ClienteCodigo) ORDER BY [ClinicaCodigo], [ClienteCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00118,1,0,true,true )
             ,new CursorDef("T00119", "SELECT TOP 1 [ClinicaCodigo], [ClienteCodigo] FROM [Cliente] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ClienteCodigo] < @ClienteCodigo) ORDER BY [ClinicaCodigo] DESC, [ClienteCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00119,1,0,true,true )
             ,new CursorDef("T001110", "SELECT [ClienteCodigo], [ClienteNombre], [ClienteTelefono1], [ClienteTelefono2], [ClienteDireccion], [ClienteCorreo], [ClienteEstado], [ClinicaCodigo], [TipoCliCodigo] FROM [Cliente] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001110,1,0,true,false )
             ,new CursorDef("T001111", "INSERT INTO [Cliente] ([ClienteCodigo], [ClienteNombre], [ClienteTelefono1], [ClienteTelefono2], [ClienteDireccion], [ClienteCorreo], [ClienteEstado], [ClinicaCodigo], [TipoCliCodigo]) VALUES (@ClienteCodigo, @ClienteNombre, @ClienteTelefono1, @ClienteTelefono2, @ClienteDireccion, @ClienteCorreo, @ClienteEstado, @ClinicaCodigo, @TipoCliCodigo)", GxErrorMask.GX_NOMASK,prmT001111)
             ,new CursorDef("T001112", "UPDATE [Cliente] SET [ClienteNombre]=@ClienteNombre, [ClienteTelefono1]=@ClienteTelefono1, [ClienteTelefono2]=@ClienteTelefono2, [ClienteDireccion]=@ClienteDireccion, [ClienteCorreo]=@ClienteCorreo, [ClienteEstado]=@ClienteEstado, [TipoCliCodigo]=@TipoCliCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo", GxErrorMask.GX_NOMASK,prmT001112)
             ,new CursorDef("T001113", "DELETE FROM [Cliente]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo", GxErrorMask.GX_NOMASK,prmT001113)
             ,new CursorDef("T001114", "SELECT TOP 1 [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ClienteCodigo] = @ClienteCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001114,1,0,true,true )
             ,new CursorDef("T001115", "SELECT [ClinicaCodigo], [ClienteCodigo] FROM [Cliente] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [ClienteCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001115,100,0,true,false )
             ,new CursorDef("T001116", "SELECT [ClinicaCodigo] FROM [TipoCliente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoCliCodigo] = @TipoCliCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT001116,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 14 :
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
