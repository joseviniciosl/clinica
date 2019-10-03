/*
               File: Bodega
        Description: Bodegas
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:18.13
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
   public class bodega : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         cmbBodegaEstado.Name = "BODEGAESTADO" ;
         cmbBodegaEstado.WebTags = "" ;
         cmbBodegaEstado.addItem("0", "De baja", 0);
         cmbBodegaEstado.addItem("1", "Activo", 0);
         if ( ( cmbBodegaEstado.ItemCount > 0 ) && (0==A123BodegaEstado) )
         {
            A123BodegaEstado = (short)(NumberUtil.Val( cmbBodegaEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BodegaEstado", StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Bodegas", 0) ;
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

      public bodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public bodega( IGxContext context )
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
         cmbBodegaEstado = new GXCombobox();
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
            wb_table1_2_0M30( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0M30e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0M30( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0M30( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0M30e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Bodegas"+"</legend>") ;
            wb_table3_27_0M30( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0M30e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0M30e( true) ;
         }
         else
         {
            wb_table1_2_0M30e( false) ;
         }
      }

      protected void wb_table3_27_0M30( bool wbgen )
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
            wb_table4_33_0M30( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0M30e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Bodega.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Bodega.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Bodega.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0M30e( true) ;
         }
         else
         {
            wb_table3_27_0M30e( false) ;
         }
      }

      protected void wb_table4_33_0M30( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Bodega.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Bodega.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Bodega.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbodegacodigo_Internalname, "Bodega", "", "", lblTextblockbodegacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Bodega.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBodegaCodigo_Internalname, StringUtil.RTrim( A121BodegaCodigo), StringUtil.RTrim( context.localUtil.Format( A121BodegaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtBodegaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtBodegaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Bodega.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbodegadescripcion_Internalname, "Descripción", "", "", lblTextblockbodegadescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Bodega.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BodegaDescripcion", A122BodegaDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBodegaDescripcion_Internalname, StringUtil.RTrim( A122BodegaDescripcion), StringUtil.RTrim( context.localUtil.Format( A122BodegaDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtBodegaDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtBodegaDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Bodega.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbodegaestado_Internalname, "Estado", "", "", lblTextblockbodegaestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Bodega.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BodegaEstado", StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBodegaEstado, cmbBodegaEstado_Internalname, StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0), 1, cmbBodegaEstado_Jsonclick, 0, "", "int", "", 1, cmbBodegaEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", true, "HLP_Bodega.htm");
            cmbBodegaEstado.CurrentValue = StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBodegaEstado_Internalname, "Values", (String)(cmbBodegaEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0M30e( true) ;
         }
         else
         {
            wb_table4_33_0M30e( false) ;
         }
      }

      protected void wb_table2_5_0M30( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00u0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"BODEGACODIGO"+"'), id:'"+"BODEGACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00u0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"BODEGACODIGO"+"'), id:'"+"BODEGACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Bodega.htm");
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
            wb_table2_5_0M30e( true) ;
         }
         else
         {
            wb_table2_5_0M30e( false) ;
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
         /* Execute user event: E110M2 */
         E110M2 ();
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
               A121BodegaCodigo = cgiGet( edtBodegaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
               A122BodegaDescripcion = cgiGet( edtBodegaDescripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BodegaDescripcion", A122BodegaDescripcion);
               cmbBodegaEstado.CurrentValue = cgiGet( cmbBodegaEstado_Internalname) ;
               A123BodegaEstado = (short)(NumberUtil.Val( cgiGet( cmbBodegaEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BodegaEstado", StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z121BodegaCodigo = cgiGet( "Z121BodegaCodigo") ;
               Z122BodegaDescripcion = cgiGet( "Z122BodegaDescripcion") ;
               Z123BodegaEstado = (short)(context.localUtil.CToN( cgiGet( "Z123BodegaEstado"), ".", ",")) ;
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
                  A121BodegaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
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
                           /* Execute user event: E110M2 */
                           E110M2 ();
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
               InitAll0M30( ) ;
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
         DisableAttributes0M30( ) ;
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

      protected void ResetCaption0M0( )
      {
      }

      protected void E110M2( )
      {
         /* Start Routine */
         GXt_SdtParametros3 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV7Parametros = GXt_SdtParametros3 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM0M30( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z122BodegaDescripcion = T000M3_A122BodegaDescripcion[0] ;
               Z123BodegaEstado = T000M3_A123BodegaEstado[0] ;
            }
            else
            {
               Z122BodegaDescripcion = A122BodegaDescripcion ;
               Z123BodegaEstado = A123BodegaEstado ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z121BodegaCodigo = A121BodegaCodigo ;
            Z122BodegaDescripcion = A122BodegaDescripcion ;
            Z123BodegaEstado = A123BodegaEstado ;
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

      protected void Load0M30( )
      {
         /* Using cursor T000M5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound30 = 1 ;
            A122BodegaDescripcion = T000M5_A122BodegaDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BodegaDescripcion", A122BodegaDescripcion);
            A123BodegaEstado = T000M5_A123BodegaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BodegaEstado", StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0));
            ZM0M30( -4) ;
         }
         pr_default.close(3);
         OnLoadActions0M30( ) ;
      }

      protected void OnLoadActions0M30( )
      {
      }

      protected void CheckExtendedTable0M30( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000M4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(2) == 101) )
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
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0M30( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo )
      {
         /* Using cursor T000M6 */
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

      protected void GetKey0M30( )
      {
         /* Using cursor T000M7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound30 = 1 ;
         }
         else
         {
            RcdFound30 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000M3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0M30( 4) ;
            RcdFound30 = 1 ;
            A121BodegaCodigo = T000M3_A121BodegaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
            A122BodegaDescripcion = T000M3_A122BodegaDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BodegaDescripcion", A122BodegaDescripcion);
            A123BodegaEstado = T000M3_A123BodegaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BodegaEstado", StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0));
            A41ClinicaCodigo = T000M3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z121BodegaCodigo = A121BodegaCodigo ;
            sMode30 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0M30( ) ;
            Gx_mode = sMode30 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound30 = 0 ;
            InitializeNonKey0M30( ) ;
            sMode30 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode30 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0M30( ) ;
         if ( RcdFound30 == 0 )
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
         RcdFound30 = 0 ;
         /* Using cursor T000M8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000M8_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000M8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000M8_A121BodegaCodigo[0], A121BodegaCodigo) < 0 ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( StringUtil.StrCmp(T000M8_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000M8_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000M8_A121BodegaCodigo[0], A121BodegaCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T000M8_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A121BodegaCodigo = T000M8_A121BodegaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
               RcdFound30 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound30 = 0 ;
         /* Using cursor T000M9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000M9_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000M9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000M9_A121BodegaCodigo[0], A121BodegaCodigo) > 0 ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( StringUtil.StrCmp(T000M9_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000M9_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000M9_A121BodegaCodigo[0], A121BodegaCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T000M9_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A121BodegaCodigo = T000M9_A121BodegaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
               RcdFound30 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0M30( ) ;
         if ( RcdFound30 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A121BodegaCodigo, Z121BodegaCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A121BodegaCodigo = Z121BodegaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
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
               Update0M30( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A121BodegaCodigo, Z121BodegaCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0M30( ) ;
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
                  Insert0M30( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A121BodegaCodigo, Z121BodegaCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A121BodegaCodigo = Z121BodegaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
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
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtBodegaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0M30( ) ;
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBodegaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0M30( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBodegaDescripcion_Internalname ;
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
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBodegaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0M30( ) ;
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound30 != 0 )
            {
               ScanNext0M30( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBodegaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0M30( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0M30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000M10 */
            pr_default.execute(8, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Bodega"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z122BodegaDescripcion, T000M10_A122BodegaDescripcion[0]) != 0 ) || ( Z123BodegaEstado != T000M10_A123BodegaEstado[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Bodega"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0M30( )
      {
         BeforeValidate0M30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M30( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0M30( 0) ;
            CheckOptimisticConcurrency0M30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0M30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000M11 */
                     pr_default.execute(9, new Object[] {A121BodegaCodigo, A122BodegaDescripcion, A123BodegaEstado, A41ClinicaCodigo});
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
                           ResetCaption0M0( ) ;
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
               Load0M30( ) ;
            }
            EndLevel0M30( ) ;
         }
         CloseExtendedTableCursors0M30( ) ;
      }

      protected void Update0M30( )
      {
         BeforeValidate0M30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M30( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0M30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000M12 */
                     pr_default.execute(10, new Object[] {A122BodegaDescripcion, A123BodegaEstado, A41ClinicaCodigo, A121BodegaCodigo});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Bodega"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0M30( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption0M0( ) ;
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
            EndLevel0M30( ) ;
         }
         CloseExtendedTableCursors0M30( ) ;
      }

      protected void DeferredUpdate0M30( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0M30( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M30( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0M30( ) ;
            AfterConfirm0M30( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0M30( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000M13 */
                  pr_default.execute(11, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound30 == 0 )
                        {
                           InitAll0M30( ) ;
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
                        ResetCaption0M0( ) ;
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
         sMode30 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0M30( ) ;
         Gx_mode = sMode30 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0M30( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000M14 */
            pr_default.execute(12, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Inventario de bodegas"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
            /* Using cursor T000M15 */
            pr_default.execute(13, new Object[] {A41ClinicaCodigo, A121BodegaCodigo});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Encabezado de movimiento de inventario"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel0M30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0M30( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("Bodega");
            if ( AnyError == 0 )
            {
               ConfirmValues0M0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("Bodega");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0M30( )
      {
         /* Using cursor T000M16 */
         pr_default.execute(14);
         RcdFound30 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound30 = 1 ;
            A41ClinicaCodigo = T000M16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A121BodegaCodigo = T000M16_A121BodegaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0M30( )
      {
         pr_default.readNext(14);
         RcdFound30 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound30 = 1 ;
            A41ClinicaCodigo = T000M16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A121BodegaCodigo = T000M16_A121BodegaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
         }
      }

      protected void ScanEnd0M30( )
      {
      }

      protected void AfterConfirm0M30( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0M30( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0M30( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0M30( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0M30( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0M30( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0M30( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtBodegaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodegaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodegaCodigo_Enabled), 5, 0)));
         edtBodegaDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBodegaDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBodegaDescripcion_Enabled), 5, 0)));
         cmbBodegaEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBodegaEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBodegaEstado.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0M0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("bodega.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z121BodegaCodigo", StringUtil.RTrim( Z121BodegaCodigo));
         GxWebStd.gx_hidden_field( context, "Z122BodegaDescripcion", StringUtil.RTrim( Z122BodegaDescripcion));
         GxWebStd.gx_hidden_field( context, "Z123BodegaEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z123BodegaEstado), 1, 0, ".", "")));
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
         return "Bodega" ;
      }

      public override String GetPgmdesc( )
      {
         return "Bodegas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("bodega.aspx")  ;
      }

      protected void InitializeNonKey0M30( )
      {
         A122BodegaDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BodegaDescripcion", A122BodegaDescripcion);
         A123BodegaEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BodegaEstado", StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0));
      }

      protected void InitAll0M30( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A121BodegaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BodegaCodigo", A121BodegaCodigo);
         InitializeNonKey0M30( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1551943");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("bodega.js", "?1551943");
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
         lblTextblockbodegacodigo_Internalname = "TEXTBLOCKBODEGACODIGO" ;
         edtBodegaCodigo_Internalname = "BODEGACODIGO" ;
         lblTextblockbodegadescripcion_Internalname = "TEXTBLOCKBODEGADESCRIPCION" ;
         edtBodegaDescripcion_Internalname = "BODEGADESCRIPCION" ;
         lblTextblockbodegaestado_Internalname = "TEXTBLOCKBODEGAESTADO" ;
         cmbBodegaEstado_Internalname = "BODEGAESTADO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_Internalname = "PROMPT_41" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Bodegas" ;
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
         cmbBodegaEstado_Jsonclick = "" ;
         cmbBodegaEstado.Enabled = 1 ;
         edtBodegaDescripcion_Jsonclick = "" ;
         edtBodegaDescripcion_Enabled = 1 ;
         edtBodegaCodigo_Jsonclick = "" ;
         edtBodegaCodigo_Enabled = 1 ;
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

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000M17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(15) == 101) )
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
         pr_default.close(15);
         GX_FocusControl = edtBodegaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T000M17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(15) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(15);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Bodegacodigo( String GX_Parm1 ,
                                      String GX_Parm2 ,
                                      String GX_Parm3 ,
                                      String GX_Parm4 ,
                                      GXCombobox cmbGX_Parm5 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A121BodegaCodigo = GX_Parm3 ;
         A122BodegaDescripcion = GX_Parm4 ;
         cmbBodegaEstado = cmbGX_Parm5 ;
         A123BodegaEstado = (short)(NumberUtil.Val( cmbBodegaEstado.CurrentValue, ".")) ;
         cmbBodegaEstado.CurrentValue = StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0) ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A122BodegaDescripcion)));
         cmbBodegaEstado.CurrentValue = StringUtil.Str( (decimal)(A123BodegaEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbBodegaEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z121BodegaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z122BodegaDescripcion)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z123BodegaEstado), 1, 0, ".", ""))));
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
         pr_default.close(14);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(15);
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
         lblTextblockbodegacodigo_Jsonclick = "" ;
         A121BodegaCodigo = "" ;
         lblTextblockbodegadescripcion_Jsonclick = "" ;
         A122BodegaDescripcion = "" ;
         lblTextblockbodegaestado_Jsonclick = "" ;
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
         Z121BodegaCodigo = "" ;
         Z122BodegaDescripcion = "" ;
         Gx_mode = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         T000M5_A121BodegaCodigo = new String[] {""} ;
         T000M5_A122BodegaDescripcion = new String[] {""} ;
         T000M5_A123BodegaEstado = new short[1] ;
         T000M5_A41ClinicaCodigo = new String[] {""} ;
         T000M4_A41ClinicaCodigo = new String[] {""} ;
         T000M6_A41ClinicaCodigo = new String[] {""} ;
         T000M7_A41ClinicaCodigo = new String[] {""} ;
         T000M7_A121BodegaCodigo = new String[] {""} ;
         T000M3_A121BodegaCodigo = new String[] {""} ;
         T000M3_A122BodegaDescripcion = new String[] {""} ;
         T000M3_A123BodegaEstado = new short[1] ;
         T000M3_A41ClinicaCodigo = new String[] {""} ;
         sMode30 = "" ;
         T000M8_A41ClinicaCodigo = new String[] {""} ;
         T000M8_A121BodegaCodigo = new String[] {""} ;
         T000M9_A41ClinicaCodigo = new String[] {""} ;
         T000M9_A121BodegaCodigo = new String[] {""} ;
         T000M10_A121BodegaCodigo = new String[] {""} ;
         T000M10_A122BodegaDescripcion = new String[] {""} ;
         T000M10_A123BodegaEstado = new short[1] ;
         T000M10_A41ClinicaCodigo = new String[] {""} ;
         T000M14_A41ClinicaCodigo = new String[] {""} ;
         T000M14_A121BodegaCodigo = new String[] {""} ;
         T000M14_A30ArticuloCodigo = new String[] {""} ;
         T000M15_A41ClinicaCodigo = new String[] {""} ;
         T000M15_A114TipoMICodigo = new String[] {""} ;
         T000M15_A267MovimientoId = new int[1] ;
         T000M16_A41ClinicaCodigo = new String[] {""} ;
         T000M16_A121BodegaCodigo = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         T000M17_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bodega__default(),
            new Object[][] {
                new Object[] {
               T000M2_A121BodegaCodigo, T000M2_A122BodegaDescripcion, T000M2_A123BodegaEstado, T000M2_A41ClinicaCodigo
               }
               , new Object[] {
               T000M3_A121BodegaCodigo, T000M3_A122BodegaDescripcion, T000M3_A123BodegaEstado, T000M3_A41ClinicaCodigo
               }
               , new Object[] {
               T000M4_A41ClinicaCodigo
               }
               , new Object[] {
               T000M5_A121BodegaCodigo, T000M5_A122BodegaDescripcion, T000M5_A123BodegaEstado, T000M5_A41ClinicaCodigo
               }
               , new Object[] {
               T000M6_A41ClinicaCodigo
               }
               , new Object[] {
               T000M7_A41ClinicaCodigo, T000M7_A121BodegaCodigo
               }
               , new Object[] {
               T000M8_A41ClinicaCodigo, T000M8_A121BodegaCodigo
               }
               , new Object[] {
               T000M9_A41ClinicaCodigo, T000M9_A121BodegaCodigo
               }
               , new Object[] {
               T000M10_A121BodegaCodigo, T000M10_A122BodegaDescripcion, T000M10_A123BodegaEstado, T000M10_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000M14_A41ClinicaCodigo, T000M14_A121BodegaCodigo, T000M14_A30ArticuloCodigo
               }
               , new Object[] {
               T000M15_A41ClinicaCodigo, T000M15_A114TipoMICodigo, T000M15_A267MovimientoId
               }
               , new Object[] {
               T000M16_A41ClinicaCodigo, T000M16_A121BodegaCodigo
               }
               , new Object[] {
               T000M17_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A123BodegaEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z123BodegaEstado ;
      private short GX_JID ;
      private short RcdFound30 ;
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
      private int imgprompt_41_Visible ;
      private int edtBodegaCodigo_Enabled ;
      private int edtBodegaDescripcion_Enabled ;
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
      private String imgprompt_41_Internalname ;
      private String imgprompt_41_Link ;
      private String lblTextblockbodegacodigo_Internalname ;
      private String lblTextblockbodegacodigo_Jsonclick ;
      private String edtBodegaCodigo_Internalname ;
      private String edtBodegaCodigo_Jsonclick ;
      private String lblTextblockbodegadescripcion_Internalname ;
      private String lblTextblockbodegadescripcion_Jsonclick ;
      private String edtBodegaDescripcion_Internalname ;
      private String edtBodegaDescripcion_Jsonclick ;
      private String lblTextblockbodegaestado_Internalname ;
      private String lblTextblockbodegaestado_Jsonclick ;
      private String cmbBodegaEstado_Internalname ;
      private String cmbBodegaEstado_Jsonclick ;
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
      private String sMode30 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A121BodegaCodigo ;
      private String A122BodegaDescripcion ;
      private String Z41ClinicaCodigo ;
      private String Z121BodegaCodigo ;
      private String Z122BodegaDescripcion ;
      private String AV8ClinicaCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBodegaEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T000M5_A121BodegaCodigo ;
      private String[] T000M5_A122BodegaDescripcion ;
      private short[] T000M5_A123BodegaEstado ;
      private String[] T000M5_A41ClinicaCodigo ;
      private String[] T000M4_A41ClinicaCodigo ;
      private String[] T000M6_A41ClinicaCodigo ;
      private String[] T000M7_A41ClinicaCodigo ;
      private String[] T000M7_A121BodegaCodigo ;
      private String[] T000M3_A121BodegaCodigo ;
      private String[] T000M3_A122BodegaDescripcion ;
      private short[] T000M3_A123BodegaEstado ;
      private String[] T000M3_A41ClinicaCodigo ;
      private String[] T000M8_A41ClinicaCodigo ;
      private String[] T000M8_A121BodegaCodigo ;
      private String[] T000M9_A41ClinicaCodigo ;
      private String[] T000M9_A121BodegaCodigo ;
      private String[] T000M10_A121BodegaCodigo ;
      private String[] T000M10_A122BodegaDescripcion ;
      private short[] T000M10_A123BodegaEstado ;
      private String[] T000M10_A41ClinicaCodigo ;
      private String[] T000M14_A41ClinicaCodigo ;
      private String[] T000M14_A121BodegaCodigo ;
      private String[] T000M14_A30ArticuloCodigo ;
      private String[] T000M15_A41ClinicaCodigo ;
      private String[] T000M15_A114TipoMICodigo ;
      private int[] T000M15_A267MovimientoId ;
      private String[] T000M16_A41ClinicaCodigo ;
      private String[] T000M16_A121BodegaCodigo ;
      private String[] T000M17_A41ClinicaCodigo ;
      private String[] T000M2_A121BodegaCodigo ;
      private String[] T000M2_A122BodegaDescripcion ;
      private short[] T000M2_A123BodegaEstado ;
      private String[] T000M2_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class bodega__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[15])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000M2 ;
          prmT000M2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M5 ;
          prmT000M5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M4 ;
          prmT000M4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M6 ;
          prmT000M6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M7 ;
          prmT000M7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M3 ;
          prmT000M3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M8 ;
          prmT000M8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M9 ;
          prmT000M9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M10 ;
          prmT000M10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M11 ;
          prmT000M11 = new Object[] {
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@BodegaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M12 ;
          prmT000M12 = new Object[] {
          new Object[] {"@BodegaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@BodegaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M13 ;
          prmT000M13 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M14 ;
          prmT000M14 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M15 ;
          prmT000M15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000M16 ;
          prmT000M16 = new Object[] {
          } ;
          Object[] prmT000M17 ;
          prmT000M17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000M2", "SELECT [BodegaCodigo], [BodegaDescripcion], [BodegaEstado], [ClinicaCodigo] FROM [Bodega] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M2,1,0,true,false )
             ,new CursorDef("T000M3", "SELECT [BodegaCodigo], [BodegaDescripcion], [BodegaEstado], [ClinicaCodigo] FROM [Bodega] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M3,1,0,true,false )
             ,new CursorDef("T000M4", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M4,1,0,true,false )
             ,new CursorDef("T000M5", "SELECT TM1.[BodegaCodigo], TM1.[BodegaDescripcion], TM1.[BodegaEstado], TM1.[ClinicaCodigo] FROM [Bodega] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[BodegaCodigo] = @BodegaCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[BodegaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M5,100,0,true,false )
             ,new CursorDef("T000M6", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M6,1,0,true,false )
             ,new CursorDef("T000M7", "SELECT [ClinicaCodigo], [BodegaCodigo] FROM [Bodega] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M7,1,0,true,false )
             ,new CursorDef("T000M8", "SELECT TOP 1 [ClinicaCodigo], [BodegaCodigo] FROM [Bodega] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [BodegaCodigo] > @BodegaCodigo) ORDER BY [ClinicaCodigo], [BodegaCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M8,1,0,true,true )
             ,new CursorDef("T000M9", "SELECT TOP 1 [ClinicaCodigo], [BodegaCodigo] FROM [Bodega] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [BodegaCodigo] < @BodegaCodigo) ORDER BY [ClinicaCodigo] DESC, [BodegaCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M9,1,0,true,true )
             ,new CursorDef("T000M10", "SELECT [BodegaCodigo], [BodegaDescripcion], [BodegaEstado], [ClinicaCodigo] FROM [Bodega] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M10,1,0,true,false )
             ,new CursorDef("T000M11", "INSERT INTO [Bodega] ([BodegaCodigo], [BodegaDescripcion], [BodegaEstado], [ClinicaCodigo]) VALUES (@BodegaCodigo, @BodegaDescripcion, @BodegaEstado, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT000M11)
             ,new CursorDef("T000M12", "UPDATE [Bodega] SET [BodegaDescripcion]=@BodegaDescripcion, [BodegaEstado]=@BodegaEstado  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo", GxErrorMask.GX_NOMASK,prmT000M12)
             ,new CursorDef("T000M13", "DELETE FROM [Bodega]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo", GxErrorMask.GX_NOMASK,prmT000M13)
             ,new CursorDef("T000M14", "SELECT TOP 1 [ClinicaCodigo], [BodegaCodigo], [ArticuloCodigo] FROM [Inventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M14,1,0,true,true )
             ,new CursorDef("T000M15", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo], [MovimientoId] FROM [MovimientoInv] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M15,1,0,true,true )
             ,new CursorDef("T000M16", "SELECT [ClinicaCodigo], [BodegaCodigo] FROM [Bodega] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [BodegaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M16,100,0,true,false )
             ,new CursorDef("T000M17", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M17,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 15 :
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
