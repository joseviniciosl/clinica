/*
               File: Usuario
        Description: Usuarios
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:7.40
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
   public class usuario : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"GRUPOCODIGO") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXDLAGRUPOCODIGO022( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A1GrupoCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A1GrupoCodigo) ;
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
         dynGrupoCodigo.Name = "GRUPOCODIGO" ;
         dynGrupoCodigo.WebTags = "" ;
         cmbUsuarioEstado.Name = "USUARIOESTADO" ;
         cmbUsuarioEstado.WebTags = "" ;
         cmbUsuarioEstado.addItem("0", "De baja", 0);
         cmbUsuarioEstado.addItem("1", "Activo", 0);
         if ( ( cmbUsuarioEstado.ItemCount > 0 ) && (0==A7UsuarioEstado) )
         {
            A7UsuarioEstado = (short)(NumberUtil.Val( cmbUsuarioEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7UsuarioEstado", StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Usuarios", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUsuarioCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Fantastic");
      }

      public usuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public usuario( IGxContext context )
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
         dynGrupoCodigo = new GXCombobox();
         cmbUsuarioEstado = new GXCombobox();
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
            wb_table1_2_022( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_022e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_022( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_022( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_022e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Usuarios"+"</legend>") ;
            wb_table3_27_022( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_022e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_022e( true) ;
         }
         else
         {
            wb_table1_2_022e( false) ;
         }
      }

      protected void wb_table3_27_022( bool wbgen )
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
            wb_table4_33_022( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_022e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_022e( true) ;
         }
         else
         {
            wb_table3_27_022e( false) ;
         }
      }

      protected void wb_table4_33_022( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioCodigo_Internalname, StringUtil.RTrim( A4UsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtUsuarioCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuarionombre_Internalname, "Usuario", "", "", lblTextblockusuarionombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsuarioNombre", A5UsuarioNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioNombre_Internalname, StringUtil.RTrim( A5UsuarioNombre), StringUtil.RTrim( context.localUtil.Format( A5UsuarioNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtUsuarioNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioNombre_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocontrasena_Internalname, "Contraseña", "", "", lblTextblockusuariocontrasena_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6UsuarioContrasena", A6UsuarioContrasena);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUsuarioContrasena_Internalname, StringUtil.RTrim( A6UsuarioContrasena), StringUtil.RTrim( context.localUtil.Format( A6UsuarioContrasena, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtUsuarioContrasena_Jsonclick, 0, ClassString, StyleString, "", 1, edtUsuarioContrasena_Enabled, 0, 10, "chr", 1, "row", 10, -1, 0, 0, 1, -1, true, "left", "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupocodigo_Internalname, "Grupo", "", "", lblTextblockgrupocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynGrupoCodigo, dynGrupoCodigo_Internalname, A1GrupoCodigo, 1, dynGrupoCodigo_Jsonclick, 0, "", "svchar", "", 1, dynGrupoCodigo.Enabled, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", true, "HLP_Usuario.htm");
            dynGrupoCodigo.CurrentValue = A1GrupoCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGrupoCodigo_Internalname, "Values", (String)(dynGrupoCodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuarioestado_Internalname, "Estado", "", "", lblTextblockusuarioestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Usuario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7UsuarioEstado", StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbUsuarioEstado, cmbUsuarioEstado_Internalname, StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0), 1, cmbUsuarioEstado_Jsonclick, 0, "", "int", "", 1, cmbUsuarioEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", "", true, "HLP_Usuario.htm");
            cmbUsuarioEstado.CurrentValue = StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuarioEstado_Internalname, "Values", (String)(cmbUsuarioEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_022e( true) ;
         }
         else
         {
            wb_table4_33_022e( false) ;
         }
      }

      protected void wb_table2_5_022( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div class=\"ToolbarMain\" style=\"WHITE-SPACE: nowrap\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOCODIGO"+"'), id:'"+"USUARIOCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USUARIOCODIGO"+"'), id:'"+"USUARIOCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Usuario.htm");
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
            wb_table2_5_022e( true) ;
         }
         else
         {
            wb_table2_5_022e( false) ;
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
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               A5UsuarioNombre = cgiGet( edtUsuarioNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsuarioNombre", A5UsuarioNombre);
               A6UsuarioContrasena = cgiGet( edtUsuarioContrasena_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6UsuarioContrasena", A6UsuarioContrasena);
               dynGrupoCodigo.CurrentValue = cgiGet( dynGrupoCodigo_Internalname) ;
               A1GrupoCodigo = cgiGet( dynGrupoCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
               cmbUsuarioEstado.CurrentValue = cgiGet( cmbUsuarioEstado_Internalname) ;
               A7UsuarioEstado = (short)(NumberUtil.Val( cgiGet( cmbUsuarioEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7UsuarioEstado", StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0));
               /* Read saved values. */
               Z4UsuarioCodigo = cgiGet( "Z4UsuarioCodigo") ;
               Z5UsuarioNombre = cgiGet( "Z5UsuarioNombre") ;
               Z6UsuarioContrasena = cgiGet( "Z6UsuarioContrasena") ;
               Z7UsuarioEstado = (short)(context.localUtil.CToN( cgiGet( "Z7UsuarioEstado"), ".", ",")) ;
               Z113UsuarioCorreo = cgiGet( "Z113UsuarioCorreo") ;
               Z365UsuarioTelefono = cgiGet( "Z365UsuarioTelefono") ;
               n365UsuarioTelefono = (String.IsNullOrEmpty(StringUtil.RTrim( A365UsuarioTelefono)) ? true : false) ;
               Z366UsuarioCelular = cgiGet( "Z366UsuarioCelular") ;
               n366UsuarioCelular = (String.IsNullOrEmpty(StringUtil.RTrim( A366UsuarioCelular)) ? true : false) ;
               Z367UsuarioDireccion = cgiGet( "Z367UsuarioDireccion") ;
               Z368UsuarioDPI = cgiGet( "Z368UsuarioDPI") ;
               n368UsuarioDPI = (String.IsNullOrEmpty(StringUtil.RTrim( A368UsuarioDPI)) ? true : false) ;
               Z1GrupoCodigo = cgiGet( "Z1GrupoCodigo") ;
               A113UsuarioCorreo = cgiGet( "Z113UsuarioCorreo") ;
               A365UsuarioTelefono = cgiGet( "Z365UsuarioTelefono") ;
               n365UsuarioTelefono = false ;
               n365UsuarioTelefono = (String.IsNullOrEmpty(StringUtil.RTrim( A365UsuarioTelefono)) ? true : false) ;
               A366UsuarioCelular = cgiGet( "Z366UsuarioCelular") ;
               n366UsuarioCelular = false ;
               n366UsuarioCelular = (String.IsNullOrEmpty(StringUtil.RTrim( A366UsuarioCelular)) ? true : false) ;
               A367UsuarioDireccion = cgiGet( "Z367UsuarioDireccion") ;
               A368UsuarioDPI = cgiGet( "Z368UsuarioDPI") ;
               n368UsuarioDPI = false ;
               n368UsuarioDPI = (String.IsNullOrEmpty(StringUtil.RTrim( A368UsuarioDPI)) ? true : false) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               A52UsuarioFoto = cgiGet( "USUARIOFOTO") ;
               n52UsuarioFoto = false ;
               n52UsuarioFoto = (String.IsNullOrEmpty(StringUtil.RTrim( A52UsuarioFoto)) ? true : false) ;
               A113UsuarioCorreo = cgiGet( "USUARIOCORREO") ;
               A365UsuarioTelefono = cgiGet( "USUARIOTELEFONO") ;
               n365UsuarioTelefono = (String.IsNullOrEmpty(StringUtil.RTrim( A365UsuarioTelefono)) ? true : false) ;
               A366UsuarioCelular = cgiGet( "USUARIOCELULAR") ;
               n366UsuarioCelular = (String.IsNullOrEmpty(StringUtil.RTrim( A366UsuarioCelular)) ? true : false) ;
               A367UsuarioDireccion = cgiGet( "USUARIODIRECCION") ;
               A368UsuarioDPI = cgiGet( "USUARIODPI") ;
               n368UsuarioDPI = (String.IsNullOrEmpty(StringUtil.RTrim( A368UsuarioDPI)) ? true : false) ;
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
                  A4UsuarioCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
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
               InitAll022( ) ;
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
         DisableAttributes022( ) ;
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

      protected void ResetCaption020( )
      {
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z5UsuarioNombre = T00023_A5UsuarioNombre[0] ;
               Z6UsuarioContrasena = T00023_A6UsuarioContrasena[0] ;
               Z7UsuarioEstado = T00023_A7UsuarioEstado[0] ;
               Z113UsuarioCorreo = T00023_A113UsuarioCorreo[0] ;
               Z365UsuarioTelefono = T00023_A365UsuarioTelefono[0] ;
               Z366UsuarioCelular = T00023_A366UsuarioCelular[0] ;
               Z367UsuarioDireccion = T00023_A367UsuarioDireccion[0] ;
               Z368UsuarioDPI = T00023_A368UsuarioDPI[0] ;
               Z1GrupoCodigo = T00023_A1GrupoCodigo[0] ;
            }
            else
            {
               Z5UsuarioNombre = A5UsuarioNombre ;
               Z6UsuarioContrasena = A6UsuarioContrasena ;
               Z7UsuarioEstado = A7UsuarioEstado ;
               Z113UsuarioCorreo = A113UsuarioCorreo ;
               Z365UsuarioTelefono = A365UsuarioTelefono ;
               Z366UsuarioCelular = A366UsuarioCelular ;
               Z367UsuarioDireccion = A367UsuarioDireccion ;
               Z368UsuarioDPI = A368UsuarioDPI ;
               Z1GrupoCodigo = A1GrupoCodigo ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z4UsuarioCodigo = A4UsuarioCodigo ;
            Z5UsuarioNombre = A5UsuarioNombre ;
            Z6UsuarioContrasena = A6UsuarioContrasena ;
            Z7UsuarioEstado = A7UsuarioEstado ;
            Z52UsuarioFoto = A52UsuarioFoto ;
            Z113UsuarioCorreo = A113UsuarioCorreo ;
            Z365UsuarioTelefono = A365UsuarioTelefono ;
            Z366UsuarioCelular = A366UsuarioCelular ;
            Z367UsuarioDireccion = A367UsuarioDireccion ;
            Z368UsuarioDPI = A368UsuarioDPI ;
            Z1GrupoCodigo = A1GrupoCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         GXAGRUPOCODIGO_html022( ) ;
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

      protected void Load022( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1 ;
            A5UsuarioNombre = T00025_A5UsuarioNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsuarioNombre", A5UsuarioNombre);
            A6UsuarioContrasena = T00025_A6UsuarioContrasena[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6UsuarioContrasena", A6UsuarioContrasena);
            A7UsuarioEstado = T00025_A7UsuarioEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7UsuarioEstado", StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0));
            A113UsuarioCorreo = T00025_A113UsuarioCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113UsuarioCorreo", A113UsuarioCorreo);
            A365UsuarioTelefono = T00025_A365UsuarioTelefono[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365UsuarioTelefono", A365UsuarioTelefono);
            n365UsuarioTelefono = T00025_n365UsuarioTelefono[0] ;
            A366UsuarioCelular = T00025_A366UsuarioCelular[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366UsuarioCelular", A366UsuarioCelular);
            n366UsuarioCelular = T00025_n366UsuarioCelular[0] ;
            A367UsuarioDireccion = T00025_A367UsuarioDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367UsuarioDireccion", A367UsuarioDireccion);
            A368UsuarioDPI = T00025_A368UsuarioDPI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368UsuarioDPI", A368UsuarioDPI);
            n368UsuarioDPI = T00025_n368UsuarioDPI[0] ;
            A1GrupoCodigo = T00025_A1GrupoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            A52UsuarioFoto = T00025_A52UsuarioFoto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioFoto", A52UsuarioFoto);
            n52UsuarioFoto = T00025_n52UsuarioFoto[0] ;
            ZM022( -2) ;
         }
         pr_default.close(3);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {A1GrupoCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError1 = 1 ;
            GX_msglist.addItem("No existe 'Grupos de usuarios'.", "ForeignKeyNotFound", 1, "GRUPOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = dynGrupoCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError1 == 0 )
         {
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( String A1GrupoCodigo )
      {
         /* Using cursor T00026 */
         pr_default.execute(4, new Object[] {A1GrupoCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError1 = 1 ;
            GX_msglist.addItem("No existe 'Grupos de usuarios'.", "ForeignKeyNotFound", 1, "GRUPOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = dynGrupoCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError1 == 0 )
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

      protected void GetKey022( )
      {
         /* Using cursor T00027 */
         pr_default.execute(5, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound2 = 1 ;
         }
         else
         {
            RcdFound2 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 2) ;
            RcdFound2 = 1 ;
            A4UsuarioCodigo = T00023_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            A5UsuarioNombre = T00023_A5UsuarioNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsuarioNombre", A5UsuarioNombre);
            A6UsuarioContrasena = T00023_A6UsuarioContrasena[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6UsuarioContrasena", A6UsuarioContrasena);
            A7UsuarioEstado = T00023_A7UsuarioEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7UsuarioEstado", StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0));
            A113UsuarioCorreo = T00023_A113UsuarioCorreo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113UsuarioCorreo", A113UsuarioCorreo);
            A365UsuarioTelefono = T00023_A365UsuarioTelefono[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365UsuarioTelefono", A365UsuarioTelefono);
            n365UsuarioTelefono = T00023_n365UsuarioTelefono[0] ;
            A366UsuarioCelular = T00023_A366UsuarioCelular[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366UsuarioCelular", A366UsuarioCelular);
            n366UsuarioCelular = T00023_n366UsuarioCelular[0] ;
            A367UsuarioDireccion = T00023_A367UsuarioDireccion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367UsuarioDireccion", A367UsuarioDireccion);
            A368UsuarioDPI = T00023_A368UsuarioDPI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368UsuarioDPI", A368UsuarioDPI);
            n368UsuarioDPI = T00023_n368UsuarioDPI[0] ;
            A1GrupoCodigo = T00023_A1GrupoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            A52UsuarioFoto = T00023_A52UsuarioFoto[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioFoto", A52UsuarioFoto);
            n52UsuarioFoto = T00023_n52UsuarioFoto[0] ;
            Z4UsuarioCodigo = A4UsuarioCodigo ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load022( ) ;
            Gx_mode = sMode2 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0 ;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode2 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
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
         RcdFound2 = 0 ;
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00028_A4UsuarioCodigo[0], A4UsuarioCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T00028_A4UsuarioCodigo[0], A4UsuarioCodigo) > 0 ) ) )
            {
               A4UsuarioCodigo = T00028_A4UsuarioCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               RcdFound2 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0 ;
         /* Using cursor T00029 */
         pr_default.execute(7, new Object[] {A4UsuarioCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00029_A4UsuarioCodigo[0], A4UsuarioCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T00029_A4UsuarioCodigo[0], A4UsuarioCodigo) < 0 ) ) )
            {
               A4UsuarioCodigo = T00029_A4UsuarioCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               RcdFound2 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey022( ) ;
         if ( RcdFound2 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "USUARIOCODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtUsuarioCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(A4UsuarioCodigo, Z4UsuarioCodigo) != 0 )
            {
               A4UsuarioCodigo = Z4UsuarioCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USUARIOCODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtUsuarioCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtUsuarioCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update022( ) ;
               GX_FocusControl = edtUsuarioCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A4UsuarioCodigo, Z4UsuarioCodigo) != 0 )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtUsuarioCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert022( ) ;
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
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USUARIOCODIGO");
                  AnyError = 1 ;
                  GX_FocusControl = edtUsuarioCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUsuarioCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert022( ) ;
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
         if ( StringUtil.StrCmp(A4UsuarioCodigo, Z4UsuarioCodigo) != 0 )
         {
            A4UsuarioCodigo = Z4UsuarioCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USUARIOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUsuarioCodigo_Internalname ;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USUARIOCODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtUsuarioNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioNombre_Internalname ;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound2 != 0 )
            {
               ScanNext022( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtUsuarioNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000210 */
            pr_default.execute(8, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuario"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z5UsuarioNombre, T000210_A5UsuarioNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z6UsuarioContrasena, T000210_A6UsuarioContrasena[0]) != 0 ) || ( Z7UsuarioEstado != T000210_A7UsuarioEstado[0] ) || ( StringUtil.StrCmp(Z113UsuarioCorreo, T000210_A113UsuarioCorreo[0]) != 0 ) || ( StringUtil.StrCmp(Z365UsuarioTelefono, T000210_A365UsuarioTelefono[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z366UsuarioCelular, T000210_A366UsuarioCelular[0]) != 0 ) || ( StringUtil.StrCmp(Z367UsuarioDireccion, T000210_A367UsuarioDireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z368UsuarioDPI, T000210_A368UsuarioDPI[0]) != 0 ) || ( StringUtil.StrCmp(Z1GrupoCodigo, T000210_A1GrupoCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Usuario"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000211 */
                     pr_default.execute(9, new Object[] {A4UsuarioCodigo, A5UsuarioNombre, A6UsuarioContrasena, A7UsuarioEstado, n52UsuarioFoto, A52UsuarioFoto, A113UsuarioCorreo, n365UsuarioTelefono, A365UsuarioTelefono, n366UsuarioCelular, A366UsuarioCelular, A367UsuarioDireccion, n368UsuarioDPI, A368UsuarioDPI, A1GrupoCodigo});
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
                           ResetCaption020( ) ;
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
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000212 */
                     pr_default.execute(10, new Object[] {A5UsuarioNombre, A6UsuarioContrasena, A7UsuarioEstado, A113UsuarioCorreo, n365UsuarioTelefono, A365UsuarioTelefono, n366UsuarioCelular, A366UsuarioCelular, A367UsuarioDireccion, n368UsuarioDPI, A368UsuarioDPI, A1GrupoCodigo, A4UsuarioCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Usuario"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption020( ) ;
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
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000213 */
            pr_default.execute(11, new Object[] {n52UsuarioFoto, A52UsuarioFoto, A4UsuarioCodigo});
            pr_default.close(11);
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000214 */
                  pr_default.execute(12, new Object[] {A4UsuarioCodigo});
                  pr_default.close(12);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound2 == 0 )
                        {
                           InitAll022( ) ;
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
                        ResetCaption020( ) ;
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
         sMode2 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel022( ) ;
         Gx_mode = sMode2 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000215 */
            pr_default.execute(13, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Nota de ingreso del paciente"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
            /* Using cursor T000216 */
            pr_default.execute(14, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Tabla de reporte de Balance General y Estado de Resultados"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
            /* Using cursor T000217 */
            pr_default.execute(15, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Movimiento Contable Reversado"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(15);
            /* Using cursor T000218 */
            pr_default.execute(16, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Depósitos Bancarios de Caja"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(16);
            /* Using cursor T000219 */
            pr_default.execute(17, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Encabezado de movimiento de inventario"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(17);
            /* Using cursor T000220 */
            pr_default.execute(18, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(18) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Movimiento mayorizado de partidas contables"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(18);
            /* Using cursor T000221 */
            pr_default.execute(19, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(19) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Encabezado de partida contable"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(19);
            /* Using cursor T000222 */
            pr_default.execute(20, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Factura a Pacientes"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(20);
            /* Using cursor T000223 */
            pr_default.execute(21, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(21) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Expediente Médico Físico"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(21);
            /* Using cursor T000224 */
            pr_default.execute(22, new Object[] {A4UsuarioCodigo});
            if ( (pr_default.getStatus(22) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Cortes de Caja"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(22);
         }
      }

      protected void EndLevel022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("Usuario");
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("Usuario");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart022( )
      {
         /* Using cursor T000225 */
         pr_default.execute(23);
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound2 = 1 ;
            A4UsuarioCodigo = T000225_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext022( )
      {
         pr_default.readNext(23);
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound2 = 1 ;
            A4UsuarioCodigo = T000225_A4UsuarioCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         }
      }

      protected void ScanEnd022( )
      {
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
         edtUsuarioCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioCodigo_Enabled), 5, 0)));
         edtUsuarioNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioNombre_Enabled), 5, 0)));
         edtUsuarioContrasena_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUsuarioContrasena_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUsuarioContrasena_Enabled), 5, 0)));
         dynGrupoCodigo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGrupoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynGrupoCodigo.Enabled), 5, 0)));
         cmbUsuarioEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbUsuarioEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbUsuarioEstado.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("usuario.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z4UsuarioCodigo", StringUtil.RTrim( Z4UsuarioCodigo));
         GxWebStd.gx_hidden_field( context, "Z5UsuarioNombre", StringUtil.RTrim( Z5UsuarioNombre));
         GxWebStd.gx_hidden_field( context, "Z6UsuarioContrasena", StringUtil.RTrim( Z6UsuarioContrasena));
         GxWebStd.gx_hidden_field( context, "Z7UsuarioEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7UsuarioEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z113UsuarioCorreo", StringUtil.RTrim( Z113UsuarioCorreo));
         GxWebStd.gx_hidden_field( context, "Z365UsuarioTelefono", StringUtil.RTrim( Z365UsuarioTelefono));
         GxWebStd.gx_hidden_field( context, "Z366UsuarioCelular", StringUtil.RTrim( Z366UsuarioCelular));
         GxWebStd.gx_hidden_field( context, "Z367UsuarioDireccion", StringUtil.RTrim( Z367UsuarioDireccion));
         GxWebStd.gx_hidden_field( context, "Z368UsuarioDPI", StringUtil.RTrim( Z368UsuarioDPI));
         GxWebStd.gx_hidden_field( context, "Z1GrupoCodigo", StringUtil.RTrim( Z1GrupoCodigo));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "USUARIOFOTO", StringUtil.RTrim( A52UsuarioFoto));
         GxWebStd.gx_hidden_field( context, "USUARIOCORREO", StringUtil.RTrim( A113UsuarioCorreo));
         GxWebStd.gx_hidden_field( context, "USUARIOTELEFONO", StringUtil.RTrim( A365UsuarioTelefono));
         GxWebStd.gx_hidden_field( context, "USUARIOCELULAR", StringUtil.RTrim( A366UsuarioCelular));
         GxWebStd.gx_hidden_field( context, "USUARIODIRECCION", StringUtil.RTrim( A367UsuarioDireccion));
         GxWebStd.gx_hidden_field( context, "USUARIODPI", StringUtil.RTrim( A368UsuarioDPI));
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
         return "Usuario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Usuarios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("usuario.aspx")  ;
      }

      protected void InitializeNonKey022( )
      {
         A5UsuarioNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5UsuarioNombre", A5UsuarioNombre);
         A6UsuarioContrasena = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6UsuarioContrasena", A6UsuarioContrasena);
         A1GrupoCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
         A7UsuarioEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7UsuarioEstado", StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0));
         A52UsuarioFoto = "" ;
         n52UsuarioFoto = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52UsuarioFoto", A52UsuarioFoto);
         A113UsuarioCorreo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113UsuarioCorreo", A113UsuarioCorreo);
         A365UsuarioTelefono = "" ;
         n365UsuarioTelefono = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365UsuarioTelefono", A365UsuarioTelefono);
         A366UsuarioCelular = "" ;
         n366UsuarioCelular = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A366UsuarioCelular", A366UsuarioCelular);
         A367UsuarioDireccion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367UsuarioDireccion", A367UsuarioDireccion);
         A368UsuarioDPI = "" ;
         n368UsuarioDPI = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368UsuarioDPI", A368UsuarioDPI);
      }

      protected void InitAll022( )
      {
         A4UsuarioCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4UsuarioCodigo", A4UsuarioCodigo);
         InitializeNonKey022( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?154889");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("usuario.js", "?154889");
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
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO" ;
         lblTextblockusuarionombre_Internalname = "TEXTBLOCKUSUARIONOMBRE" ;
         edtUsuarioNombre_Internalname = "USUARIONOMBRE" ;
         lblTextblockusuariocontrasena_Internalname = "TEXTBLOCKUSUARIOCONTRASENA" ;
         edtUsuarioContrasena_Internalname = "USUARIOCONTRASENA" ;
         lblTextblockgrupocodigo_Internalname = "TEXTBLOCKGRUPOCODIGO" ;
         dynGrupoCodigo_Internalname = "GRUPOCODIGO" ;
         lblTextblockusuarioestado_Internalname = "TEXTBLOCKUSUARIOESTADO" ;
         cmbUsuarioEstado_Internalname = "USUARIOESTADO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Usuarios" ;
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
         cmbUsuarioEstado_Jsonclick = "" ;
         cmbUsuarioEstado.Enabled = 1 ;
         dynGrupoCodigo_Jsonclick = "" ;
         dynGrupoCodigo.Enabled = 1 ;
         edtUsuarioContrasena_Jsonclick = "" ;
         edtUsuarioContrasena_Enabled = 1 ;
         edtUsuarioNombre_Jsonclick = "" ;
         edtUsuarioNombre_Enabled = 1 ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtUsuarioCodigo_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLAGRUPOCODIGO022( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLAGRUPOCODIGO_data022( ) ;
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

      protected void GXAGRUPOCODIGO_html022( )
      {
         String gxdynajaxvalue ;
         GXDLAGRUPOCODIGO_data022( ) ;
         gxdynajaxindex = 1 ;
         dynGrupoCodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynGrupoCodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLAGRUPOCODIGO_data022( )
      {
         /* Using cursor T000226 */
         pr_default.execute(24);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(24) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000226_A1GrupoCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000226_A2GrupoDescripcion[0]));
            pr_default.readNext(24);
         }
         pr_default.close(24);
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtUsuarioNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Usuariocodigo( String GX_Parm1 ,
                                       String GX_Parm2 ,
                                       String GX_Parm3 ,
                                       GXCombobox cmbGX_Parm4 ,
                                       String GX_Parm5 ,
                                       String GX_Parm6 ,
                                       String GX_Parm7 ,
                                       String GX_Parm8 ,
                                       String GX_Parm9 ,
                                       String GX_Parm10 ,
                                       GXCombobox dynGX_Parm11 )
      {
         A4UsuarioCodigo = GX_Parm1 ;
         A5UsuarioNombre = GX_Parm2 ;
         A6UsuarioContrasena = GX_Parm3 ;
         cmbUsuarioEstado = cmbGX_Parm4 ;
         A7UsuarioEstado = (short)(NumberUtil.Val( cmbUsuarioEstado.CurrentValue, ".")) ;
         cmbUsuarioEstado.CurrentValue = StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0) ;
         A52UsuarioFoto = GX_Parm5 ;
         n52UsuarioFoto = false ;
         A113UsuarioCorreo = GX_Parm6 ;
         A365UsuarioTelefono = GX_Parm7 ;
         n365UsuarioTelefono = false ;
         A366UsuarioCelular = GX_Parm8 ;
         n366UsuarioCelular = false ;
         A367UsuarioDireccion = GX_Parm9 ;
         A368UsuarioDPI = GX_Parm10 ;
         n368UsuarioDPI = false ;
         dynGrupoCodigo = dynGX_Parm11 ;
         A1GrupoCodigo = dynGrupoCodigo.CurrentValue ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         GXAGRUPOCODIGO_html022( ) ;
         dynGrupoCodigo.CurrentValue = A1GrupoCodigo ;
         isValidOutput.Add((Object)(StringUtil.RTrim( A5UsuarioNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A6UsuarioContrasena)));
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A1GrupoCodigo)) )
         {
            if ( ( dynGrupoCodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A1GrupoCodigo)) )
            {
               A1GrupoCodigo = dynGrupoCodigo.getItemValue(1) ;
            }
         }
         dynGrupoCodigo.CurrentValue = A1GrupoCodigo ;
         isValidOutput.Add((Object)(dynGrupoCodigo));
         cmbUsuarioEstado.CurrentValue = StringUtil.Str( (decimal)(A7UsuarioEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbUsuarioEstado));
         isValidOutput.Add((Object)(context.PathToRelativeUrl( A52UsuarioFoto)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A113UsuarioCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A365UsuarioTelefono)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A366UsuarioCelular)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A367UsuarioDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A368UsuarioDPI)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4UsuarioCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z5UsuarioNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z6UsuarioContrasena)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z1GrupoCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z7UsuarioEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(context.PathToRelativeUrl( Z52UsuarioFoto)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z113UsuarioCorreo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z365UsuarioTelefono)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z366UsuarioCelular)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z367UsuarioDireccion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z368UsuarioDPI)));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Grupocodigo( GXCombobox dynGX_Parm1 )
      {
         dynGrupoCodigo = dynGX_Parm1 ;
         A1GrupoCodigo = dynGrupoCodigo.CurrentValue ;
         /* Using cursor T000227 */
         pr_default.execute(25, new Object[] {A1GrupoCodigo});
         if ( (pr_default.getStatus(25) == 101) )
         {
            AnyError1 = 1 ;
            GX_msglist.addItem("No existe 'Grupos de usuarios'.", "ForeignKeyNotFound", 1, "GRUPOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = dynGrupoCodigo_Internalname ;
         }
         if ( AnyError1 == 0 )
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
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(25);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A1GrupoCodigo = "" ;
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
         lblTextblockusuariocodigo_Jsonclick = "" ;
         A4UsuarioCodigo = "" ;
         lblTextblockusuarionombre_Jsonclick = "" ;
         A5UsuarioNombre = "" ;
         lblTextblockusuariocontrasena_Jsonclick = "" ;
         A6UsuarioContrasena = "" ;
         lblTextblockgrupocodigo_Jsonclick = "" ;
         lblTextblockusuarioestado_Jsonclick = "" ;
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
         Z4UsuarioCodigo = "" ;
         Z5UsuarioNombre = "" ;
         Z6UsuarioContrasena = "" ;
         Z113UsuarioCorreo = "" ;
         Z365UsuarioTelefono = "" ;
         Z366UsuarioCelular = "" ;
         Z367UsuarioDireccion = "" ;
         Z368UsuarioDPI = "" ;
         Z1GrupoCodigo = "" ;
         A365UsuarioTelefono = "" ;
         A366UsuarioCelular = "" ;
         A368UsuarioDPI = "" ;
         A113UsuarioCorreo = "" ;
         A367UsuarioDireccion = "" ;
         Gx_mode = "" ;
         A52UsuarioFoto = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z52UsuarioFoto = "" ;
         T00025_A4UsuarioCodigo = new String[] {""} ;
         T00025_A5UsuarioNombre = new String[] {""} ;
         T00025_A6UsuarioContrasena = new String[] {""} ;
         T00025_A7UsuarioEstado = new short[1] ;
         T00025_A113UsuarioCorreo = new String[] {""} ;
         T00025_A365UsuarioTelefono = new String[] {""} ;
         T00025_n365UsuarioTelefono = new bool[] {false} ;
         T00025_A366UsuarioCelular = new String[] {""} ;
         T00025_n366UsuarioCelular = new bool[] {false} ;
         T00025_A367UsuarioDireccion = new String[] {""} ;
         T00025_A368UsuarioDPI = new String[] {""} ;
         T00025_n368UsuarioDPI = new bool[] {false} ;
         T00025_A1GrupoCodigo = new String[] {""} ;
         T00025_A52UsuarioFoto = new String[] {""} ;
         T00025_n52UsuarioFoto = new bool[] {false} ;
         T00024_A1GrupoCodigo = new String[] {""} ;
         T00026_A1GrupoCodigo = new String[] {""} ;
         T00027_A4UsuarioCodigo = new String[] {""} ;
         T00023_A4UsuarioCodigo = new String[] {""} ;
         T00023_A5UsuarioNombre = new String[] {""} ;
         T00023_A6UsuarioContrasena = new String[] {""} ;
         T00023_A7UsuarioEstado = new short[1] ;
         T00023_A113UsuarioCorreo = new String[] {""} ;
         T00023_A365UsuarioTelefono = new String[] {""} ;
         T00023_n365UsuarioTelefono = new bool[] {false} ;
         T00023_A366UsuarioCelular = new String[] {""} ;
         T00023_n366UsuarioCelular = new bool[] {false} ;
         T00023_A367UsuarioDireccion = new String[] {""} ;
         T00023_A368UsuarioDPI = new String[] {""} ;
         T00023_n368UsuarioDPI = new bool[] {false} ;
         T00023_A1GrupoCodigo = new String[] {""} ;
         T00023_A52UsuarioFoto = new String[] {""} ;
         T00023_n52UsuarioFoto = new bool[] {false} ;
         sMode2 = "" ;
         T00028_A4UsuarioCodigo = new String[] {""} ;
         T00029_A4UsuarioCodigo = new String[] {""} ;
         T000210_A4UsuarioCodigo = new String[] {""} ;
         T000210_A5UsuarioNombre = new String[] {""} ;
         T000210_A6UsuarioContrasena = new String[] {""} ;
         T000210_A7UsuarioEstado = new short[1] ;
         T000210_A113UsuarioCorreo = new String[] {""} ;
         T000210_A365UsuarioTelefono = new String[] {""} ;
         T000210_n365UsuarioTelefono = new bool[] {false} ;
         T000210_A366UsuarioCelular = new String[] {""} ;
         T000210_n366UsuarioCelular = new bool[] {false} ;
         T000210_A367UsuarioDireccion = new String[] {""} ;
         T000210_A368UsuarioDPI = new String[] {""} ;
         T000210_n368UsuarioDPI = new bool[] {false} ;
         T000210_A1GrupoCodigo = new String[] {""} ;
         T000210_A52UsuarioFoto = new String[] {""} ;
         T000210_n52UsuarioFoto = new bool[] {false} ;
         T000215_A41ClinicaCodigo = new String[] {""} ;
         T000215_A327NPacienteId = new int[1] ;
         T000216_A41ClinicaCodigo = new String[] {""} ;
         T000216_A302RBECtaContableCodigo = new String[] {""} ;
         T000217_A41ClinicaCodigo = new String[] {""} ;
         T000217_A199TipoParCodigo = new String[] {""} ;
         T000217_A290MovReversadoId = new int[1] ;
         T000217_A291MovReversadoLinea = new short[1] ;
         T000218_A41ClinicaCodigo = new String[] {""} ;
         T000218_A128CuentaBancariaCodigo = new String[] {""} ;
         T000218_A282DepositoId = new int[1] ;
         T000219_A41ClinicaCodigo = new String[] {""} ;
         T000219_A114TipoMICodigo = new String[] {""} ;
         T000219_A267MovimientoId = new int[1] ;
         T000220_A41ClinicaCodigo = new String[] {""} ;
         T000220_A199TipoParCodigo = new String[] {""} ;
         T000220_A217MovMayorizadoId = new int[1] ;
         T000220_A218MovMayorizadoLinea = new short[1] ;
         T000221_A41ClinicaCodigo = new String[] {""} ;
         T000221_A199TipoParCodigo = new String[] {""} ;
         T000221_A207PartidaId = new int[1] ;
         T000222_A41ClinicaCodigo = new String[] {""} ;
         T000222_A185FacturaId = new int[1] ;
         T000223_A41ClinicaCodigo = new String[] {""} ;
         T000223_A167ExpedienteId = new int[1] ;
         T000224_A41ClinicaCodigo = new String[] {""} ;
         T000224_A132CajaCodigo = new String[] {""} ;
         T000224_A153CorteCajaId = new int[1] ;
         T000225_A4UsuarioCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         GXt_char3 = "" ;
         T000226_A1GrupoCodigo = new String[] {""} ;
         T000226_A2GrupoDescripcion = new String[] {""} ;
         T000226_A3GrupoEstado = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         T000227_A1GrupoCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuario__default(),
            new Object[][] {
                new Object[] {
               T00022_A4UsuarioCodigo, T00022_A5UsuarioNombre, T00022_A6UsuarioContrasena, T00022_A7UsuarioEstado, T00022_A113UsuarioCorreo, T00022_A365UsuarioTelefono, T00022_n365UsuarioTelefono, T00022_A366UsuarioCelular, T00022_n366UsuarioCelular, T00022_A367UsuarioDireccion,
               T00022_A368UsuarioDPI, T00022_n368UsuarioDPI, T00022_A1GrupoCodigo, T00022_A52UsuarioFoto, T00022_n52UsuarioFoto
               }
               , new Object[] {
               T00023_A4UsuarioCodigo, T00023_A5UsuarioNombre, T00023_A6UsuarioContrasena, T00023_A7UsuarioEstado, T00023_A113UsuarioCorreo, T00023_A365UsuarioTelefono, T00023_n365UsuarioTelefono, T00023_A366UsuarioCelular, T00023_n366UsuarioCelular, T00023_A367UsuarioDireccion,
               T00023_A368UsuarioDPI, T00023_n368UsuarioDPI, T00023_A1GrupoCodigo, T00023_A52UsuarioFoto, T00023_n52UsuarioFoto
               }
               , new Object[] {
               T00024_A1GrupoCodigo
               }
               , new Object[] {
               T00025_A4UsuarioCodigo, T00025_A5UsuarioNombre, T00025_A6UsuarioContrasena, T00025_A7UsuarioEstado, T00025_A113UsuarioCorreo, T00025_A365UsuarioTelefono, T00025_n365UsuarioTelefono, T00025_A366UsuarioCelular, T00025_n366UsuarioCelular, T00025_A367UsuarioDireccion,
               T00025_A368UsuarioDPI, T00025_n368UsuarioDPI, T00025_A1GrupoCodigo, T00025_A52UsuarioFoto, T00025_n52UsuarioFoto
               }
               , new Object[] {
               T00026_A1GrupoCodigo
               }
               , new Object[] {
               T00027_A4UsuarioCodigo
               }
               , new Object[] {
               T00028_A4UsuarioCodigo
               }
               , new Object[] {
               T00029_A4UsuarioCodigo
               }
               , new Object[] {
               T000210_A4UsuarioCodigo, T000210_A5UsuarioNombre, T000210_A6UsuarioContrasena, T000210_A7UsuarioEstado, T000210_A113UsuarioCorreo, T000210_A365UsuarioTelefono, T000210_n365UsuarioTelefono, T000210_A366UsuarioCelular, T000210_n366UsuarioCelular, T000210_A367UsuarioDireccion,
               T000210_A368UsuarioDPI, T000210_n368UsuarioDPI, T000210_A1GrupoCodigo, T000210_A52UsuarioFoto, T000210_n52UsuarioFoto
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
               T000215_A41ClinicaCodigo, T000215_A327NPacienteId
               }
               , new Object[] {
               T000216_A41ClinicaCodigo, T000216_A302RBECtaContableCodigo
               }
               , new Object[] {
               T000217_A41ClinicaCodigo, T000217_A199TipoParCodigo, T000217_A290MovReversadoId, T000217_A291MovReversadoLinea
               }
               , new Object[] {
               T000218_A41ClinicaCodigo, T000218_A128CuentaBancariaCodigo, T000218_A282DepositoId
               }
               , new Object[] {
               T000219_A41ClinicaCodigo, T000219_A114TipoMICodigo, T000219_A267MovimientoId
               }
               , new Object[] {
               T000220_A41ClinicaCodigo, T000220_A199TipoParCodigo, T000220_A217MovMayorizadoId, T000220_A218MovMayorizadoLinea
               }
               , new Object[] {
               T000221_A41ClinicaCodigo, T000221_A199TipoParCodigo, T000221_A207PartidaId
               }
               , new Object[] {
               T000222_A41ClinicaCodigo, T000222_A185FacturaId
               }
               , new Object[] {
               T000223_A41ClinicaCodigo, T000223_A167ExpedienteId
               }
               , new Object[] {
               T000224_A41ClinicaCodigo, T000224_A132CajaCodigo, T000224_A153CorteCajaId
               }
               , new Object[] {
               T000225_A4UsuarioCodigo
               }
               , new Object[] {
               T000226_A1GrupoCodigo, T000226_A2GrupoDescripcion, T000226_A3GrupoEstado
               }
               , new Object[] {
               T000227_A1GrupoCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A7UsuarioEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z7UsuarioEstado ;
      private short GX_JID ;
      private short RcdFound2 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtUsuarioCodigo_Enabled ;
      private int edtUsuarioNombre_Enabled ;
      private int edtUsuarioContrasena_Enabled ;
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
      private int AnyError1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUsuarioCodigo_Internalname ;
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
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String lblTextblockusuarionombre_Internalname ;
      private String lblTextblockusuarionombre_Jsonclick ;
      private String edtUsuarioNombre_Internalname ;
      private String edtUsuarioNombre_Jsonclick ;
      private String lblTextblockusuariocontrasena_Internalname ;
      private String lblTextblockusuariocontrasena_Jsonclick ;
      private String edtUsuarioContrasena_Internalname ;
      private String edtUsuarioContrasena_Jsonclick ;
      private String lblTextblockgrupocodigo_Internalname ;
      private String lblTextblockgrupocodigo_Jsonclick ;
      private String dynGrupoCodigo_Internalname ;
      private String dynGrupoCodigo_Jsonclick ;
      private String lblTextblockusuarioestado_Internalname ;
      private String lblTextblockusuarioestado_Jsonclick ;
      private String cmbUsuarioEstado_Internalname ;
      private String cmbUsuarioEstado_Jsonclick ;
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
      private String sMode2 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String gxwrpcisep ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n365UsuarioTelefono ;
      private bool n366UsuarioCelular ;
      private bool n368UsuarioDPI ;
      private bool n52UsuarioFoto ;
      private bool Gx_longc ;
      private String A1GrupoCodigo ;
      private String A4UsuarioCodigo ;
      private String A5UsuarioNombre ;
      private String A6UsuarioContrasena ;
      private String Z4UsuarioCodigo ;
      private String Z5UsuarioNombre ;
      private String Z6UsuarioContrasena ;
      private String Z113UsuarioCorreo ;
      private String Z365UsuarioTelefono ;
      private String Z366UsuarioCelular ;
      private String Z367UsuarioDireccion ;
      private String Z368UsuarioDPI ;
      private String Z1GrupoCodigo ;
      private String A365UsuarioTelefono ;
      private String A366UsuarioCelular ;
      private String A368UsuarioDPI ;
      private String A113UsuarioCorreo ;
      private String A367UsuarioDireccion ;
      private String A52UsuarioFoto ;
      private String Z52UsuarioFoto ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynGrupoCodigo ;
      private GXCombobox cmbUsuarioEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T00025_A4UsuarioCodigo ;
      private String[] T00025_A5UsuarioNombre ;
      private String[] T00025_A6UsuarioContrasena ;
      private short[] T00025_A7UsuarioEstado ;
      private String[] T00025_A113UsuarioCorreo ;
      private String[] T00025_A365UsuarioTelefono ;
      private bool[] T00025_n365UsuarioTelefono ;
      private String[] T00025_A366UsuarioCelular ;
      private bool[] T00025_n366UsuarioCelular ;
      private String[] T00025_A367UsuarioDireccion ;
      private String[] T00025_A368UsuarioDPI ;
      private bool[] T00025_n368UsuarioDPI ;
      private String[] T00025_A1GrupoCodigo ;
      private String[] T00025_A52UsuarioFoto ;
      private bool[] T00025_n52UsuarioFoto ;
      private String[] T00024_A1GrupoCodigo ;
      private String[] T00026_A1GrupoCodigo ;
      private String[] T00027_A4UsuarioCodigo ;
      private String[] T00023_A4UsuarioCodigo ;
      private String[] T00023_A5UsuarioNombre ;
      private String[] T00023_A6UsuarioContrasena ;
      private short[] T00023_A7UsuarioEstado ;
      private String[] T00023_A113UsuarioCorreo ;
      private String[] T00023_A365UsuarioTelefono ;
      private bool[] T00023_n365UsuarioTelefono ;
      private String[] T00023_A366UsuarioCelular ;
      private bool[] T00023_n366UsuarioCelular ;
      private String[] T00023_A367UsuarioDireccion ;
      private String[] T00023_A368UsuarioDPI ;
      private bool[] T00023_n368UsuarioDPI ;
      private String[] T00023_A1GrupoCodigo ;
      private String[] T00023_A52UsuarioFoto ;
      private bool[] T00023_n52UsuarioFoto ;
      private String[] T00028_A4UsuarioCodigo ;
      private String[] T00029_A4UsuarioCodigo ;
      private String[] T000210_A4UsuarioCodigo ;
      private String[] T000210_A5UsuarioNombre ;
      private String[] T000210_A6UsuarioContrasena ;
      private short[] T000210_A7UsuarioEstado ;
      private String[] T000210_A113UsuarioCorreo ;
      private String[] T000210_A365UsuarioTelefono ;
      private bool[] T000210_n365UsuarioTelefono ;
      private String[] T000210_A366UsuarioCelular ;
      private bool[] T000210_n366UsuarioCelular ;
      private String[] T000210_A367UsuarioDireccion ;
      private String[] T000210_A368UsuarioDPI ;
      private bool[] T000210_n368UsuarioDPI ;
      private String[] T000210_A1GrupoCodigo ;
      private String[] T000210_A52UsuarioFoto ;
      private bool[] T000210_n52UsuarioFoto ;
      private String[] T000215_A41ClinicaCodigo ;
      private int[] T000215_A327NPacienteId ;
      private String[] T000216_A41ClinicaCodigo ;
      private String[] T000216_A302RBECtaContableCodigo ;
      private String[] T000217_A41ClinicaCodigo ;
      private String[] T000217_A199TipoParCodigo ;
      private int[] T000217_A290MovReversadoId ;
      private short[] T000217_A291MovReversadoLinea ;
      private String[] T000218_A41ClinicaCodigo ;
      private String[] T000218_A128CuentaBancariaCodigo ;
      private int[] T000218_A282DepositoId ;
      private String[] T000219_A41ClinicaCodigo ;
      private String[] T000219_A114TipoMICodigo ;
      private int[] T000219_A267MovimientoId ;
      private String[] T000220_A41ClinicaCodigo ;
      private String[] T000220_A199TipoParCodigo ;
      private int[] T000220_A217MovMayorizadoId ;
      private short[] T000220_A218MovMayorizadoLinea ;
      private String[] T000221_A41ClinicaCodigo ;
      private String[] T000221_A199TipoParCodigo ;
      private int[] T000221_A207PartidaId ;
      private String[] T000222_A41ClinicaCodigo ;
      private int[] T000222_A185FacturaId ;
      private String[] T000223_A41ClinicaCodigo ;
      private int[] T000223_A167ExpedienteId ;
      private String[] T000224_A41ClinicaCodigo ;
      private String[] T000224_A132CajaCodigo ;
      private int[] T000224_A153CorteCajaId ;
      private String[] T000225_A4UsuarioCodigo ;
      private String[] T000226_A1GrupoCodigo ;
      private String[] T000226_A2GrupoDescripcion ;
      private short[] T000226_A3GrupoEstado ;
      private String[] T000227_A1GrupoCodigo ;
      private String[] T00022_A4UsuarioCodigo ;
      private String[] T00022_A5UsuarioNombre ;
      private String[] T00022_A6UsuarioContrasena ;
      private short[] T00022_A7UsuarioEstado ;
      private String[] T00022_A113UsuarioCorreo ;
      private String[] T00022_A365UsuarioTelefono ;
      private String[] T00022_A366UsuarioCelular ;
      private String[] T00022_A367UsuarioDireccion ;
      private String[] T00022_A368UsuarioDPI ;
      private String[] T00022_A1GrupoCodigo ;
      private String[] T00022_A52UsuarioFoto ;
      private bool[] T00022_n365UsuarioTelefono ;
      private bool[] T00022_n366UsuarioCelular ;
      private bool[] T00022_n368UsuarioDPI ;
      private bool[] T00022_n52UsuarioFoto ;
      private GXWebForm Form ;
   }

   public class usuario__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
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
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@UsuarioContrasena",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@UsuarioFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@UsuarioCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@UsuarioTelefono",SqlDbType.VarChar,9,0} ,
          new Object[] {"@UsuarioCelular",SqlDbType.VarChar,9,0} ,
          new Object[] {"@UsuarioDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@UsuarioDPI",SqlDbType.VarChar,15,0} ,
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@UsuarioNombre",SqlDbType.VarChar,100,0} ,
          new Object[] {"@UsuarioContrasena",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@UsuarioCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@UsuarioTelefono",SqlDbType.VarChar,9,0} ,
          new Object[] {"@UsuarioCelular",SqlDbType.VarChar,9,0} ,
          new Object[] {"@UsuarioDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@UsuarioDPI",SqlDbType.VarChar,15,0} ,
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000213 ;
          prmT000213 = new Object[] {
          new Object[] {"@UsuarioFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000214 ;
          prmT000214 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000215 ;
          prmT000215 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000216 ;
          prmT000216 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000217 ;
          prmT000217 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000218 ;
          prmT000218 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000219 ;
          prmT000219 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000220 ;
          prmT000220 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000221 ;
          prmT000221 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000222 ;
          prmT000222 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000223 ;
          prmT000223 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000224 ;
          prmT000224 = new Object[] {
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000225 ;
          prmT000225 = new Object[] {
          } ;
          Object[] prmT000226 ;
          prmT000226 = new Object[] {
          } ;
          Object[] prmT000227 ;
          prmT000227 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT [UsuarioCodigo], [UsuarioNombre], [UsuarioContrasena], [UsuarioEstado], [UsuarioCorreo], [UsuarioTelefono], [UsuarioCelular], [UsuarioDireccion], [UsuarioDPI], [GrupoCodigo], [UsuarioFoto] FROM [Usuario] WITH (UPDLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,false )
             ,new CursorDef("T00023", "SELECT [UsuarioCodigo], [UsuarioNombre], [UsuarioContrasena], [UsuarioEstado], [UsuarioCorreo], [UsuarioTelefono], [UsuarioCelular], [UsuarioDireccion], [UsuarioDPI], [GrupoCodigo], [UsuarioFoto] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,false )
             ,new CursorDef("T00024", "SELECT [GrupoCodigo] FROM [GrupoUsuario] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1,0,true,false )
             ,new CursorDef("T00025", "SELECT TM1.[UsuarioCodigo], TM1.[UsuarioNombre], TM1.[UsuarioContrasena], TM1.[UsuarioEstado], TM1.[UsuarioCorreo], TM1.[UsuarioTelefono], TM1.[UsuarioCelular], TM1.[UsuarioDireccion], TM1.[UsuarioDPI], TM1.[GrupoCodigo], TM1.[UsuarioFoto] FROM [Usuario] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioCodigo] = @UsuarioCodigo ORDER BY TM1.[UsuarioCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,1,0,true,false )
             ,new CursorDef("T00026", "SELECT [GrupoCodigo] FROM [GrupoUsuario] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,1,0,true,false )
             ,new CursorDef("T00027", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,1,0,true,false )
             ,new CursorDef("T00028", "SELECT TOP 1 [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE ( [UsuarioCodigo] > @UsuarioCodigo) ORDER BY [UsuarioCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1,0,true,true )
             ,new CursorDef("T00029", "SELECT TOP 1 [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) WHERE ( [UsuarioCodigo] < @UsuarioCodigo) ORDER BY [UsuarioCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,1,0,true,true )
             ,new CursorDef("T000210", "SELECT [UsuarioCodigo], [UsuarioNombre], [UsuarioContrasena], [UsuarioEstado], [UsuarioCorreo], [UsuarioTelefono], [UsuarioCelular], [UsuarioDireccion], [UsuarioDPI], [GrupoCodigo], [UsuarioFoto] FROM [Usuario] WITH (UPDLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000210,1,0,true,false )
             ,new CursorDef("T000211", "INSERT INTO [Usuario] ([UsuarioCodigo], [UsuarioNombre], [UsuarioContrasena], [UsuarioEstado], [UsuarioFoto], [UsuarioCorreo], [UsuarioTelefono], [UsuarioCelular], [UsuarioDireccion], [UsuarioDPI], [GrupoCodigo]) VALUES (@UsuarioCodigo, @UsuarioNombre, @UsuarioContrasena, @UsuarioEstado, @UsuarioFoto, @UsuarioCorreo, @UsuarioTelefono, @UsuarioCelular, @UsuarioDireccion, @UsuarioDPI, @GrupoCodigo)", GxErrorMask.GX_NOMASK,prmT000211)
             ,new CursorDef("T000212", "UPDATE [Usuario] SET [UsuarioNombre]=@UsuarioNombre, [UsuarioContrasena]=@UsuarioContrasena, [UsuarioEstado]=@UsuarioEstado, [UsuarioCorreo]=@UsuarioCorreo, [UsuarioTelefono]=@UsuarioTelefono, [UsuarioCelular]=@UsuarioCelular, [UsuarioDireccion]=@UsuarioDireccion, [UsuarioDPI]=@UsuarioDPI, [GrupoCodigo]=@GrupoCodigo  WHERE [UsuarioCodigo] = @UsuarioCodigo", GxErrorMask.GX_NOMASK,prmT000212)
             ,new CursorDef("T000213", "UPDATE [Usuario] SET [UsuarioFoto]=@UsuarioFoto  WHERE [UsuarioCodigo] = @UsuarioCodigo", GxErrorMask.GX_NOMASK,prmT000213)
             ,new CursorDef("T000214", "DELETE FROM [Usuario]  WHERE [UsuarioCodigo] = @UsuarioCodigo", GxErrorMask.GX_NOMASK,prmT000214)
             ,new CursorDef("T000215", "SELECT TOP 1 [ClinicaCodigo], [NPacienteId] FROM [NotaPaciente] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000215,1,0,true,true )
             ,new CursorDef("T000216", "SELECT TOP 1 [ClinicaCodigo], [RBECtaContableCodigo] FROM [RepBalanceEstado] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000216,1,0,true,true )
             ,new CursorDef("T000217", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea] FROM [MovimientoReversado] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000217,1,0,true,true )
             ,new CursorDef("T000218", "SELECT TOP 1 [ClinicaCodigo], [CuentaBancariaCodigo], [DepositoId] FROM [DepositoBancario] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000218,1,0,true,true )
             ,new CursorDef("T000219", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo], [MovimientoId] FROM [MovimientoInv] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000219,1,0,true,true )
             ,new CursorDef("T000220", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea] FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000220,1,0,true,true )
             ,new CursorDef("T000221", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [PartidaId] FROM [PartidaEnc] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000221,1,0,true,true )
             ,new CursorDef("T000222", "SELECT TOP 1 [ClinicaCodigo], [FacturaId] FROM [Factura] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000222,1,0,true,true )
             ,new CursorDef("T000223", "SELECT TOP 1 [ClinicaCodigo], [ExpedienteId] FROM [Expediente] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000223,1,0,true,true )
             ,new CursorDef("T000224", "SELECT TOP 1 [ClinicaCodigo], [CajaCodigo], [CorteCajaId] FROM [CorteCaja] WITH (NOLOCK) WHERE [UsuarioCodigo] = @UsuarioCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000224,1,0,true,true )
             ,new CursorDef("T000225", "SELECT [UsuarioCodigo] FROM [Usuario] WITH (NOLOCK) ORDER BY [UsuarioCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000225,100,0,true,false )
             ,new CursorDef("T000226", "SELECT [GrupoCodigo], [GrupoDescripcion], [GrupoEstado] FROM [GrupoUsuario] WITH (NOLOCK) WHERE [GrupoEstado] = 1 ORDER BY [GrupoDescripcion] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000226,0,0,true,false )
             ,new CursorDef("T000227", "SELECT [GrupoCodigo] FROM [GrupoUsuario] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000227,1,0,true,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[13])[0] = rslt.getBLOBFile(11, "JPG", "") ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[13])[0] = rslt.getBLOBFile(11, "JPG", "") ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[13])[0] = rslt.getBLOBFile(11, "JPG", "") ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[13])[0] = rslt.getBLOBFile(11, "JPG", "") ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                stmt.SetParameter(6, (String)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[10]);
                }
                stmt.SetParameter(9, (String)parms[11]);
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[13]);
                }
                stmt.SetParameter(11, (String)parms[14]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[7]);
                }
                stmt.SetParameter(7, (String)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[10]);
                }
                stmt.SetParameter(9, (String)parms[11]);
                stmt.SetParameter(10, (String)parms[12]);
                break;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
