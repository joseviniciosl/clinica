/*
               File: Cargo
        Description: Cargos de Consulta de Paciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:5:52.72
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
   public class cargo : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A30ArticuloCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A41ClinicaCodigo, A30ArticuloCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
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
            gxLoad_4( A41ClinicaCodigo, A91ConsultaId) ;
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
         cmbCargoEstado.Name = "CARGOESTADO" ;
         cmbCargoEstado.WebTags = "" ;
         cmbCargoEstado.addItem("1", "Cargado", 0);
         cmbCargoEstado.addItem("2", "Facturado", 0);
         if ( ( cmbCargoEstado.ItemCount > 0 ) && (0==A166CargoEstado) )
         {
            A166CargoEstado = (short)(NumberUtil.Val( cmbCargoEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166CargoEstado", StringUtil.Str( (decimal)(A166CargoEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Cargos de Consulta de Paciente", 0) ;
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

      public cargo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public cargo( IGxContext context )
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
         cmbCargoEstado = new GXCombobox();
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
            wb_table1_2_0Z45( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0Z45e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0Z45( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0Z45( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0Z45e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Cargos de Consulta de Paciente"+"</legend>") ;
            wb_table3_27_0Z45( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0Z45e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0Z45e( true) ;
         }
         else
         {
            wb_table1_2_0Z45e( false) ;
         }
      }

      protected void wb_table3_27_0Z45( bool wbgen )
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
            wb_table4_33_0Z45( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0Z45e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Cargo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Cargo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0Z45e( true) ;
         }
         else
         {
            wb_table3_27_0Z45e( false) ;
         }
      }

      protected void wb_table4_33_0Z45( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultaid_Internalname, "Consulta", "", "", lblTextblockconsultaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtConsultaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")), ((edtConsultaId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtConsultaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtConsultaId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Cargo.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_91_Internalname, "prompt.gif", imgprompt_41_91_Link, "", "", "Fantastic", imgprompt_41_91_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcargoid_Internalname, "Id", "", "", lblTextblockcargoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCargoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A162CargoId), 9, 0, ".", "")), ((edtCargoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A162CargoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A162CargoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", "", "", "", "", edtCargoId_Jsonclick, 0, ClassString, StyleString, "", 1, edtCargoId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockarticulocodigo_Internalname, "Artículo", "", "", lblTextblockarticulocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtArticuloCodigo_Internalname, StringUtil.RTrim( A30ArticuloCodigo), StringUtil.RTrim( context.localUtil.Format( A30ArticuloCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", "", "", "", edtArticuloCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtArticuloCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Cargo.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_30_Internalname, "prompt.gif", imgprompt_41_30_Link, "", "", "Fantastic", imgprompt_41_30_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcargoprecio_Internalname, "Precio", "", "", lblTextblockcargoprecio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163CargoPrecio", StringUtil.LTrim( StringUtil.Str( A163CargoPrecio, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCargoPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A163CargoPrecio, 17, 2, ".", "")), ((edtCargoPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A163CargoPrecio, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A163CargoPrecio, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(58);\"", "", "", "", "", edtCargoPrecio_Jsonclick, 0, ClassString, StyleString, "", 1, edtCargoPrecio_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcargocantidad_Internalname, "Cantidad", "", "", lblTextblockcargocantidad_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164CargoCantidad", StringUtil.LTrim( StringUtil.Str( A164CargoCantidad, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCargoCantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( A164CargoCantidad, 17, 2, ".", "")), ((edtCargoCantidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A164CargoCantidad, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A164CargoCantidad, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(63);\"", "", "", "", "", edtCargoCantidad_Jsonclick, 0, ClassString, StyleString, "", 1, edtCargoCantidad_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcargototal_Internalname, "Total", "", "", lblTextblockcargototal_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165CargoTotal", StringUtil.LTrim( StringUtil.Str( A165CargoTotal, 17, 2)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCargoTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A165CargoTotal, 17, 2, ".", "")), ((edtCargoTotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A165CargoTotal, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( A165CargoTotal, "ZZZZZZZZZZZZZ9.99")), "", "", "", "", "", edtCargoTotal_Jsonclick, 0, ClassString, StyleString, "", 1, edtCargoTotal_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcargoestado_Internalname, "Estado", "", "", lblTextblockcargoestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Cargo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166CargoEstado", StringUtil.Str( (decimal)(A166CargoEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCargoEstado, cmbCargoEstado_Internalname, StringUtil.Str( (decimal)(A166CargoEstado), 1, 0), 1, cmbCargoEstado_Jsonclick, 0, "", "int", "", 1, cmbCargoEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", "", true, "HLP_Cargo.htm");
            cmbCargoEstado.CurrentValue = StringUtil.Str( (decimal)(A166CargoEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCargoEstado_Internalname, "Values", (String)(cmbCargoEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0Z45e( true) ;
         }
         else
         {
            wb_table4_33_0Z45e( false) ;
         }
      }

      protected void wb_table2_5_0Z45( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0190.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CARGOID"+"'), id:'"+"CARGOID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0190.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CARGOID"+"'), id:'"+"CARGOID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Cargo.htm");
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
            wb_table2_5_0Z45e( true) ;
         }
         else
         {
            wb_table2_5_0Z45e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtCargoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCargoId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CARGOID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCargoId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A162CargoId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
               }
               else
               {
                  A162CargoId = (int)(context.localUtil.CToN( cgiGet( edtCargoId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
               }
               A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtCargoPrecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCargoPrecio_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CARGOPRECIO");
                  AnyError = 1 ;
                  GX_FocusControl = edtCargoPrecio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A163CargoPrecio = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163CargoPrecio", StringUtil.LTrim( StringUtil.Str( A163CargoPrecio, 17, 2)));
               }
               else
               {
                  A163CargoPrecio = context.localUtil.CToN( cgiGet( edtCargoPrecio_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163CargoPrecio", StringUtil.LTrim( StringUtil.Str( A163CargoPrecio, 17, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCargoCantidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCargoCantidad_Internalname), ".", ",") > 99999999999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CARGOCANTIDAD");
                  AnyError = 1 ;
                  GX_FocusControl = edtCargoCantidad_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A164CargoCantidad = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164CargoCantidad", StringUtil.LTrim( StringUtil.Str( A164CargoCantidad, 17, 2)));
               }
               else
               {
                  A164CargoCantidad = context.localUtil.CToN( cgiGet( edtCargoCantidad_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164CargoCantidad", StringUtil.LTrim( StringUtil.Str( A164CargoCantidad, 17, 2)));
               }
               A165CargoTotal = context.localUtil.CToN( cgiGet( edtCargoTotal_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165CargoTotal", StringUtil.LTrim( StringUtil.Str( A165CargoTotal, 17, 2)));
               cmbCargoEstado.CurrentValue = cgiGet( cmbCargoEstado_Internalname) ;
               A166CargoEstado = (short)(NumberUtil.Val( cgiGet( cmbCargoEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166CargoEstado", StringUtil.Str( (decimal)(A166CargoEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z91ConsultaId = (int)(context.localUtil.CToN( cgiGet( "Z91ConsultaId"), ".", ",")) ;
               Z162CargoId = (int)(context.localUtil.CToN( cgiGet( "Z162CargoId"), ".", ",")) ;
               Z163CargoPrecio = context.localUtil.CToN( cgiGet( "Z163CargoPrecio"), ".", ",") ;
               Z164CargoCantidad = context.localUtil.CToN( cgiGet( "Z164CargoCantidad"), ".", ",") ;
               Z166CargoEstado = (short)(context.localUtil.CToN( cgiGet( "Z166CargoEstado"), ".", ",")) ;
               Z30ArticuloCodigo = cgiGet( "Z30ArticuloCodigo") ;
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
                  A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
                  A162CargoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
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
               InitAll0Z45( ) ;
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
         DisableAttributes0Z45( ) ;
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

      protected void ResetCaption0Z0( )
      {
      }

      protected void ZM0Z45( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z163CargoPrecio = T000Z3_A163CargoPrecio[0] ;
               Z164CargoCantidad = T000Z3_A164CargoCantidad[0] ;
               Z166CargoEstado = T000Z3_A166CargoEstado[0] ;
               Z30ArticuloCodigo = T000Z3_A30ArticuloCodigo[0] ;
            }
            else
            {
               Z163CargoPrecio = A163CargoPrecio ;
               Z164CargoCantidad = A164CargoCantidad ;
               Z166CargoEstado = A166CargoEstado ;
               Z30ArticuloCodigo = A30ArticuloCodigo ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z162CargoId = A162CargoId ;
            Z163CargoPrecio = A163CargoPrecio ;
            Z164CargoCantidad = A164CargoCantidad ;
            Z166CargoEstado = A166CargoEstado ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z30ArticuloCodigo = A30ArticuloCodigo ;
            Z91ConsultaId = A91ConsultaId ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_41_91_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CONSULTAID"+"'), id:'"+"CONSULTAID"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
         imgprompt_41_30_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"ARTICULOCODIGO"+"'), id:'"+"ARTICULOCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
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

      protected void Load0Z45( )
      {
         /* Using cursor T000Z6 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A91ConsultaId, A162CargoId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound45 = 1 ;
            A163CargoPrecio = T000Z6_A163CargoPrecio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163CargoPrecio", StringUtil.LTrim( StringUtil.Str( A163CargoPrecio, 17, 2)));
            A164CargoCantidad = T000Z6_A164CargoCantidad[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164CargoCantidad", StringUtil.LTrim( StringUtil.Str( A164CargoCantidad, 17, 2)));
            A166CargoEstado = T000Z6_A166CargoEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166CargoEstado", StringUtil.Str( (decimal)(A166CargoEstado), 1, 0));
            A30ArticuloCodigo = T000Z6_A30ArticuloCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
            ZM0Z45( -2) ;
         }
         pr_default.close(4);
         OnLoadActions0Z45( ) ;
      }

      protected void OnLoadActions0Z45( )
      {
         A165CargoTotal = (decimal)(A163CargoPrecio*A164CargoCantidad) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165CargoTotal", StringUtil.LTrim( StringUtil.Str( A165CargoTotal, 17, 2)));
      }

      protected void CheckExtendedTable0Z45( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000Z4 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            AnyError30 = 1 ;
            GX_msglist.addItem("No existe 'Maestro de productos y servicios'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError30 == 0 ) )
         {
         }
         pr_default.close(2);
         /* Using cursor T000Z5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(3) == 101) )
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
         pr_default.close(3);
         A165CargoTotal = (decimal)(A163CargoPrecio*A164CargoCantidad) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165CargoTotal", StringUtil.LTrim( StringUtil.Str( A165CargoTotal, 17, 2)));
      }

      protected void CloseExtendedTableCursors0Z45( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( String A41ClinicaCodigo ,
                               String A30ArticuloCodigo )
      {
         /* Using cursor T000Z7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(5) == 101) )
         {
            AnyError41 = 1 ;
            AnyError30 = 1 ;
            GX_msglist.addItem("No existe 'Maestro de productos y servicios'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError41 == 0 ) && ( AnyError30 == 0 ) )
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

      protected void gxLoad_4( String A41ClinicaCodigo ,
                               int A91ConsultaId )
      {
         /* Using cursor T000Z8 */
         pr_default.execute(6, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(6) == 101) )
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
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey0Z45( )
      {
         /* Using cursor T000Z9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A91ConsultaId, A162CargoId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound45 = 1 ;
         }
         else
         {
            RcdFound45 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000Z3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A91ConsultaId, A162CargoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Z45( 2) ;
            RcdFound45 = 1 ;
            A162CargoId = T000Z3_A162CargoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
            A163CargoPrecio = T000Z3_A163CargoPrecio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163CargoPrecio", StringUtil.LTrim( StringUtil.Str( A163CargoPrecio, 17, 2)));
            A164CargoCantidad = T000Z3_A164CargoCantidad[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164CargoCantidad", StringUtil.LTrim( StringUtil.Str( A164CargoCantidad, 17, 2)));
            A166CargoEstado = T000Z3_A166CargoEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166CargoEstado", StringUtil.Str( (decimal)(A166CargoEstado), 1, 0));
            A41ClinicaCodigo = T000Z3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A30ArticuloCodigo = T000Z3_A30ArticuloCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
            A91ConsultaId = T000Z3_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z91ConsultaId = A91ConsultaId ;
            Z162CargoId = A162CargoId ;
            sMode45 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0Z45( ) ;
            Gx_mode = sMode45 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound45 = 0 ;
            InitializeNonKey0Z45( ) ;
            sMode45 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode45 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Z45( ) ;
         if ( RcdFound45 == 0 )
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
         RcdFound45 = 0 ;
         /* Using cursor T000Z10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A91ConsultaId, A162CargoId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000Z10_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000Z10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Z10_A91ConsultaId[0] < A91ConsultaId ) || ( T000Z10_A91ConsultaId[0] == A91ConsultaId ) && ( StringUtil.StrCmp(T000Z10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Z10_A162CargoId[0] < A162CargoId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000Z10_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000Z10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Z10_A91ConsultaId[0] > A91ConsultaId ) || ( T000Z10_A91ConsultaId[0] == A91ConsultaId ) && ( StringUtil.StrCmp(T000Z10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Z10_A162CargoId[0] > A162CargoId ) ) )
            {
               A41ClinicaCodigo = T000Z10_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = T000Z10_A91ConsultaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               A162CargoId = T000Z10_A162CargoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
               RcdFound45 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound45 = 0 ;
         /* Using cursor T000Z11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A91ConsultaId, A162CargoId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000Z11_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000Z11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Z11_A91ConsultaId[0] > A91ConsultaId ) || ( T000Z11_A91ConsultaId[0] == A91ConsultaId ) && ( StringUtil.StrCmp(T000Z11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Z11_A162CargoId[0] > A162CargoId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000Z11_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000Z11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Z11_A91ConsultaId[0] < A91ConsultaId ) || ( T000Z11_A91ConsultaId[0] == A91ConsultaId ) && ( StringUtil.StrCmp(T000Z11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000Z11_A162CargoId[0] < A162CargoId ) ) )
            {
               A41ClinicaCodigo = T000Z11_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = T000Z11_A91ConsultaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               A162CargoId = T000Z11_A162CargoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
               RcdFound45 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0Z45( ) ;
         if ( RcdFound45 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) || ( A162CargoId != Z162CargoId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A91ConsultaId = Z91ConsultaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
               A162CargoId = Z162CargoId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
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
               Update0Z45( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) || ( A162CargoId != Z162CargoId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0Z45( ) ;
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
                  Insert0Z45( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A91ConsultaId != Z91ConsultaId ) || ( A162CargoId != Z162CargoId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = Z91ConsultaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A162CargoId = Z162CargoId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
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
         if ( RcdFound45 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtArticuloCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0Z45( ) ;
         if ( RcdFound45 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtArticuloCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0Z45( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound45 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtArticuloCodigo_Internalname ;
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
         if ( RcdFound45 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtArticuloCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0Z45( ) ;
         if ( RcdFound45 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound45 != 0 )
            {
               ScanNext0Z45( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtArticuloCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0Z45( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0Z45( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Z12 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A91ConsultaId, A162CargoId});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cargo"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( Z163CargoPrecio != T000Z12_A163CargoPrecio[0] ) || ( Z164CargoCantidad != T000Z12_A164CargoCantidad[0] ) || ( Z166CargoEstado != T000Z12_A166CargoEstado[0] ) || ( StringUtil.StrCmp(Z30ArticuloCodigo, T000Z12_A30ArticuloCodigo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Cargo"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0Z45( )
      {
         BeforeValidate0Z45( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z45( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Z45( 0) ;
            CheckOptimisticConcurrency0Z45( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z45( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Z45( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z13 */
                     pr_default.execute(11, new Object[] {A162CargoId, A163CargoPrecio, A164CargoCantidad, A166CargoEstado, A41ClinicaCodigo, A30ArticuloCodigo, A91ConsultaId});
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
                           ResetCaption0Z0( ) ;
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
               Load0Z45( ) ;
            }
            EndLevel0Z45( ) ;
         }
         CloseExtendedTableCursors0Z45( ) ;
      }

      protected void Update0Z45( )
      {
         BeforeValidate0Z45( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z45( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z45( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z45( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Z45( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z14 */
                     pr_default.execute(12, new Object[] {A163CargoPrecio, A164CargoCantidad, A166CargoEstado, A30ArticuloCodigo, A41ClinicaCodigo, A91ConsultaId, A162CargoId});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Cargo"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0Z45( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                           ResetCaption0Z0( ) ;
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
            EndLevel0Z45( ) ;
         }
         CloseExtendedTableCursors0Z45( ) ;
      }

      protected void DeferredUpdate0Z45( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0Z45( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z45( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Z45( ) ;
            AfterConfirm0Z45( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Z45( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000Z15 */
                  pr_default.execute(13, new Object[] {A41ClinicaCodigo, A91ConsultaId, A162CargoId});
                  pr_default.close(13);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound45 == 0 )
                        {
                           InitAll0Z45( ) ;
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
                        ResetCaption0Z0( ) ;
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
         sMode45 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0Z45( ) ;
         Gx_mode = sMode45 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0Z45( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            A165CargoTotal = (decimal)(A163CargoPrecio*A164CargoCantidad) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165CargoTotal", StringUtil.LTrim( StringUtil.Str( A165CargoTotal, 17, 2)));
         }
      }

      protected void EndLevel0Z45( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Z45( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            context.CommitDataStores("Cargo");
            if ( AnyError == 0 )
            {
               ConfirmValues0Z0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            context.RollbackDataStores("Cargo");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0Z45( )
      {
         /* Using cursor T000Z16 */
         pr_default.execute(14);
         RcdFound45 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound45 = 1 ;
            A41ClinicaCodigo = T000Z16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = T000Z16_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A162CargoId = T000Z16_A162CargoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Z45( )
      {
         pr_default.readNext(14);
         RcdFound45 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound45 = 1 ;
            A41ClinicaCodigo = T000Z16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A91ConsultaId = T000Z16_A91ConsultaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
            A162CargoId = T000Z16_A162CargoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
         }
      }

      protected void ScanEnd0Z45( )
      {
      }

      protected void AfterConfirm0Z45( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Z45( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Z45( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Z45( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Z45( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Z45( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Z45( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtConsultaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtConsultaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtConsultaId_Enabled), 5, 0)));
         edtCargoId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargoId_Enabled), 5, 0)));
         edtArticuloCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtArticuloCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtArticuloCodigo_Enabled), 5, 0)));
         edtCargoPrecio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargoPrecio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargoPrecio_Enabled), 5, 0)));
         edtCargoCantidad_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargoCantidad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargoCantidad_Enabled), 5, 0)));
         edtCargoTotal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargoTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargoTotal_Enabled), 5, 0)));
         cmbCargoEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCargoEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCargoEstado.Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0Z0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("cargo.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z91ConsultaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91ConsultaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z162CargoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z162CargoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z163CargoPrecio", StringUtil.LTrim( StringUtil.NToC( Z163CargoPrecio, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z164CargoCantidad", StringUtil.LTrim( StringUtil.NToC( Z164CargoCantidad, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z166CargoEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z166CargoEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z30ArticuloCodigo", StringUtil.RTrim( Z30ArticuloCodigo));
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
         return "Cargo" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cargos de Consulta de Paciente" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cargo.aspx")  ;
      }

      protected void InitializeNonKey0Z45( )
      {
         A165CargoTotal = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165CargoTotal", StringUtil.LTrim( StringUtil.Str( A165CargoTotal, 17, 2)));
         A30ArticuloCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30ArticuloCodigo", A30ArticuloCodigo);
         A163CargoPrecio = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163CargoPrecio", StringUtil.LTrim( StringUtil.Str( A163CargoPrecio, 17, 2)));
         A164CargoCantidad = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164CargoCantidad", StringUtil.LTrim( StringUtil.Str( A164CargoCantidad, 17, 2)));
         A166CargoEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166CargoEstado", StringUtil.Str( (decimal)(A166CargoEstado), 1, 0));
      }

      protected void InitAll0Z45( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A91ConsultaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A91ConsultaId), 9, 0)));
         A162CargoId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162CargoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A162CargoId), 9, 0)));
         InitializeNonKey0Z45( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1555463");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("cargo.js", "?1555463");
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
         lblTextblockconsultaid_Internalname = "TEXTBLOCKCONSULTAID" ;
         edtConsultaId_Internalname = "CONSULTAID" ;
         lblTextblockcargoid_Internalname = "TEXTBLOCKCARGOID" ;
         edtCargoId_Internalname = "CARGOID" ;
         lblTextblockarticulocodigo_Internalname = "TEXTBLOCKARTICULOCODIGO" ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO" ;
         lblTextblockcargoprecio_Internalname = "TEXTBLOCKCARGOPRECIO" ;
         edtCargoPrecio_Internalname = "CARGOPRECIO" ;
         lblTextblockcargocantidad_Internalname = "TEXTBLOCKCARGOCANTIDAD" ;
         edtCargoCantidad_Internalname = "CARGOCANTIDAD" ;
         lblTextblockcargototal_Internalname = "TEXTBLOCKCARGOTOTAL" ;
         edtCargoTotal_Internalname = "CARGOTOTAL" ;
         lblTextblockcargoestado_Internalname = "TEXTBLOCKCARGOESTADO" ;
         cmbCargoEstado_Internalname = "CARGOESTADO" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_41_91_Internalname = "PROMPT_41_91" ;
         imgprompt_41_30_Internalname = "PROMPT_41_30" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Cargos de Consulta de Paciente" ;
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
         cmbCargoEstado_Jsonclick = "" ;
         cmbCargoEstado.Enabled = 1 ;
         edtCargoTotal_Jsonclick = "" ;
         edtCargoTotal_Enabled = 0 ;
         edtCargoCantidad_Jsonclick = "" ;
         edtCargoCantidad_Enabled = 1 ;
         edtCargoPrecio_Jsonclick = "" ;
         edtCargoPrecio_Enabled = 1 ;
         imgprompt_41_30_Visible = 1 ;
         imgprompt_41_30_Link = "" ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtArticuloCodigo_Enabled = 1 ;
         edtCargoId_Jsonclick = "" ;
         edtCargoId_Enabled = 1 ;
         imgprompt_41_91_Visible = 1 ;
         imgprompt_41_91_Link = "" ;
         edtConsultaId_Jsonclick = "" ;
         edtConsultaId_Enabled = 1 ;
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
         /* Using cursor T000Z17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(15) == 101) )
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
         pr_default.close(15);
         GX_FocusControl = edtArticuloCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Consultaid( String GX_Parm1 ,
                                    int GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A91ConsultaId = GX_Parm2 ;
         /* Using cursor T000Z17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         if ( (pr_default.getStatus(15) == 101) )
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
         pr_default.close(15);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Cargoid( String GX_Parm1 ,
                                 int GX_Parm2 ,
                                 int GX_Parm3 ,
                                 decimal GX_Parm4 ,
                                 decimal GX_Parm5 ,
                                 GXCombobox cmbGX_Parm6 ,
                                 String GX_Parm7 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A91ConsultaId = GX_Parm2 ;
         A162CargoId = GX_Parm3 ;
         A163CargoPrecio = GX_Parm4 ;
         A164CargoCantidad = GX_Parm5 ;
         cmbCargoEstado = cmbGX_Parm6 ;
         A166CargoEstado = (short)(NumberUtil.Val( cmbCargoEstado.CurrentValue, ".")) ;
         cmbCargoEstado.CurrentValue = StringUtil.Str( (decimal)(A166CargoEstado), 1, 0) ;
         A30ArticuloCodigo = GX_Parm7 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A30ArticuloCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A163CargoPrecio, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A164CargoCantidad, 17, 2, ".", ""))));
         cmbCargoEstado.CurrentValue = StringUtil.Str( (decimal)(A166CargoEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbCargoEstado));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A165CargoTotal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91ConsultaId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z162CargoId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z30ArticuloCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z163CargoPrecio, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z164CargoCantidad, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z166CargoEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z165CargoTotal, 17, 2, ".", ""))));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Articulocodigo( String GX_Parm1 ,
                                        String GX_Parm2 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         A30ArticuloCodigo = GX_Parm2 ;
         /* Using cursor T000Z18 */
         pr_default.execute(16, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         if ( (pr_default.getStatus(16) == 101) )
         {
            AnyError41 = 1 ;
            AnyError30 = 1 ;
            GX_msglist.addItem("No existe 'Maestro de productos y servicios'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( ( AnyError41 == 0 ) && ( AnyError30 == 0 ) )
         {
         }
         pr_default.close(16);
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
         pr_default.close(14);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(16);
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A41ClinicaCodigo = "" ;
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
         lblTextblockconsultaid_Jsonclick = "" ;
         lblTextblockcargoid_Jsonclick = "" ;
         lblTextblockarticulocodigo_Jsonclick = "" ;
         lblTextblockcargoprecio_Jsonclick = "" ;
         lblTextblockcargocantidad_Jsonclick = "" ;
         lblTextblockcargototal_Jsonclick = "" ;
         lblTextblockcargoestado_Jsonclick = "" ;
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
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000Z6_A162CargoId = new int[1] ;
         T000Z6_A163CargoPrecio = new decimal[1] ;
         T000Z6_A164CargoCantidad = new decimal[1] ;
         T000Z6_A166CargoEstado = new short[1] ;
         T000Z6_A41ClinicaCodigo = new String[] {""} ;
         T000Z6_A30ArticuloCodigo = new String[] {""} ;
         T000Z6_A91ConsultaId = new int[1] ;
         T000Z4_A41ClinicaCodigo = new String[] {""} ;
         T000Z5_A41ClinicaCodigo = new String[] {""} ;
         T000Z7_A41ClinicaCodigo = new String[] {""} ;
         T000Z8_A41ClinicaCodigo = new String[] {""} ;
         T000Z9_A41ClinicaCodigo = new String[] {""} ;
         T000Z9_A91ConsultaId = new int[1] ;
         T000Z9_A162CargoId = new int[1] ;
         T000Z3_A162CargoId = new int[1] ;
         T000Z3_A163CargoPrecio = new decimal[1] ;
         T000Z3_A164CargoCantidad = new decimal[1] ;
         T000Z3_A166CargoEstado = new short[1] ;
         T000Z3_A41ClinicaCodigo = new String[] {""} ;
         T000Z3_A30ArticuloCodigo = new String[] {""} ;
         T000Z3_A91ConsultaId = new int[1] ;
         sMode45 = "" ;
         T000Z10_A41ClinicaCodigo = new String[] {""} ;
         T000Z10_A91ConsultaId = new int[1] ;
         T000Z10_A162CargoId = new int[1] ;
         T000Z11_A41ClinicaCodigo = new String[] {""} ;
         T000Z11_A91ConsultaId = new int[1] ;
         T000Z11_A162CargoId = new int[1] ;
         T000Z12_A162CargoId = new int[1] ;
         T000Z12_A163CargoPrecio = new decimal[1] ;
         T000Z12_A164CargoCantidad = new decimal[1] ;
         T000Z12_A166CargoEstado = new short[1] ;
         T000Z12_A41ClinicaCodigo = new String[] {""} ;
         T000Z12_A30ArticuloCodigo = new String[] {""} ;
         T000Z12_A91ConsultaId = new int[1] ;
         T000Z16_A41ClinicaCodigo = new String[] {""} ;
         T000Z16_A91ConsultaId = new int[1] ;
         T000Z16_A162CargoId = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         T000Z17_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         T000Z18_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cargo__default(),
            new Object[][] {
                new Object[] {
               T000Z2_A162CargoId, T000Z2_A163CargoPrecio, T000Z2_A164CargoCantidad, T000Z2_A166CargoEstado, T000Z2_A41ClinicaCodigo, T000Z2_A30ArticuloCodigo, T000Z2_A91ConsultaId
               }
               , new Object[] {
               T000Z3_A162CargoId, T000Z3_A163CargoPrecio, T000Z3_A164CargoCantidad, T000Z3_A166CargoEstado, T000Z3_A41ClinicaCodigo, T000Z3_A30ArticuloCodigo, T000Z3_A91ConsultaId
               }
               , new Object[] {
               T000Z4_A41ClinicaCodigo
               }
               , new Object[] {
               T000Z5_A41ClinicaCodigo
               }
               , new Object[] {
               T000Z6_A162CargoId, T000Z6_A163CargoPrecio, T000Z6_A164CargoCantidad, T000Z6_A166CargoEstado, T000Z6_A41ClinicaCodigo, T000Z6_A30ArticuloCodigo, T000Z6_A91ConsultaId
               }
               , new Object[] {
               T000Z7_A41ClinicaCodigo
               }
               , new Object[] {
               T000Z8_A41ClinicaCodigo
               }
               , new Object[] {
               T000Z9_A41ClinicaCodigo, T000Z9_A91ConsultaId, T000Z9_A162CargoId
               }
               , new Object[] {
               T000Z10_A41ClinicaCodigo, T000Z10_A91ConsultaId, T000Z10_A162CargoId
               }
               , new Object[] {
               T000Z11_A41ClinicaCodigo, T000Z11_A91ConsultaId, T000Z11_A162CargoId
               }
               , new Object[] {
               T000Z12_A162CargoId, T000Z12_A163CargoPrecio, T000Z12_A164CargoCantidad, T000Z12_A166CargoEstado, T000Z12_A41ClinicaCodigo, T000Z12_A30ArticuloCodigo, T000Z12_A91ConsultaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Z16_A41ClinicaCodigo, T000Z16_A91ConsultaId, T000Z16_A162CargoId
               }
               , new Object[] {
               T000Z17_A41ClinicaCodigo
               }
               , new Object[] {
               T000Z18_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short A166CargoEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z166CargoEstado ;
      private short GX_JID ;
      private short RcdFound45 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A91ConsultaId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtClinicaCodigo_Enabled ;
      private int edtConsultaId_Enabled ;
      private int imgprompt_41_91_Visible ;
      private int A162CargoId ;
      private int edtCargoId_Enabled ;
      private int edtArticuloCodigo_Enabled ;
      private int imgprompt_41_30_Visible ;
      private int edtCargoPrecio_Enabled ;
      private int edtCargoCantidad_Enabled ;
      private int edtCargoTotal_Enabled ;
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
      private int Z91ConsultaId ;
      private int Z162CargoId ;
      private int AnyError41 ;
      private int AnyError30 ;
      private int AnyError91 ;
      private int idxLst ;
      private decimal A163CargoPrecio ;
      private decimal A164CargoCantidad ;
      private decimal A165CargoTotal ;
      private decimal Z163CargoPrecio ;
      private decimal Z164CargoCantidad ;
      private decimal Z165CargoTotal ;
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
      private String lblTextblockconsultaid_Internalname ;
      private String lblTextblockconsultaid_Jsonclick ;
      private String edtConsultaId_Internalname ;
      private String edtConsultaId_Jsonclick ;
      private String imgprompt_41_91_Internalname ;
      private String imgprompt_41_91_Link ;
      private String lblTextblockcargoid_Internalname ;
      private String lblTextblockcargoid_Jsonclick ;
      private String edtCargoId_Internalname ;
      private String edtCargoId_Jsonclick ;
      private String lblTextblockarticulocodigo_Internalname ;
      private String lblTextblockarticulocodigo_Jsonclick ;
      private String edtArticuloCodigo_Internalname ;
      private String edtArticuloCodigo_Jsonclick ;
      private String imgprompt_41_30_Internalname ;
      private String imgprompt_41_30_Link ;
      private String lblTextblockcargoprecio_Internalname ;
      private String lblTextblockcargoprecio_Jsonclick ;
      private String edtCargoPrecio_Internalname ;
      private String edtCargoPrecio_Jsonclick ;
      private String lblTextblockcargocantidad_Internalname ;
      private String lblTextblockcargocantidad_Jsonclick ;
      private String edtCargoCantidad_Internalname ;
      private String edtCargoCantidad_Jsonclick ;
      private String lblTextblockcargototal_Internalname ;
      private String lblTextblockcargototal_Jsonclick ;
      private String edtCargoTotal_Internalname ;
      private String edtCargoTotal_Jsonclick ;
      private String lblTextblockcargoestado_Internalname ;
      private String lblTextblockcargoestado_Jsonclick ;
      private String cmbCargoEstado_Internalname ;
      private String cmbCargoEstado_Jsonclick ;
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
      private String sMode45 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A30ArticuloCodigo ;
      private String Z41ClinicaCodigo ;
      private String Z30ArticuloCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbCargoEstado ;
      private IDataStoreProvider pr_default ;
      private int[] T000Z6_A162CargoId ;
      private decimal[] T000Z6_A163CargoPrecio ;
      private decimal[] T000Z6_A164CargoCantidad ;
      private short[] T000Z6_A166CargoEstado ;
      private String[] T000Z6_A41ClinicaCodigo ;
      private String[] T000Z6_A30ArticuloCodigo ;
      private int[] T000Z6_A91ConsultaId ;
      private String[] T000Z4_A41ClinicaCodigo ;
      private String[] T000Z5_A41ClinicaCodigo ;
      private String[] T000Z7_A41ClinicaCodigo ;
      private String[] T000Z8_A41ClinicaCodigo ;
      private String[] T000Z9_A41ClinicaCodigo ;
      private int[] T000Z9_A91ConsultaId ;
      private int[] T000Z9_A162CargoId ;
      private int[] T000Z3_A162CargoId ;
      private decimal[] T000Z3_A163CargoPrecio ;
      private decimal[] T000Z3_A164CargoCantidad ;
      private short[] T000Z3_A166CargoEstado ;
      private String[] T000Z3_A41ClinicaCodigo ;
      private String[] T000Z3_A30ArticuloCodigo ;
      private int[] T000Z3_A91ConsultaId ;
      private String[] T000Z10_A41ClinicaCodigo ;
      private int[] T000Z10_A91ConsultaId ;
      private int[] T000Z10_A162CargoId ;
      private String[] T000Z11_A41ClinicaCodigo ;
      private int[] T000Z11_A91ConsultaId ;
      private int[] T000Z11_A162CargoId ;
      private int[] T000Z12_A162CargoId ;
      private decimal[] T000Z12_A163CargoPrecio ;
      private decimal[] T000Z12_A164CargoCantidad ;
      private short[] T000Z12_A166CargoEstado ;
      private String[] T000Z12_A41ClinicaCodigo ;
      private String[] T000Z12_A30ArticuloCodigo ;
      private int[] T000Z12_A91ConsultaId ;
      private String[] T000Z16_A41ClinicaCodigo ;
      private int[] T000Z16_A91ConsultaId ;
      private int[] T000Z16_A162CargoId ;
      private String[] T000Z17_A41ClinicaCodigo ;
      private String[] T000Z18_A41ClinicaCodigo ;
      private int[] T000Z2_A162CargoId ;
      private decimal[] T000Z2_A163CargoPrecio ;
      private decimal[] T000Z2_A164CargoCantidad ;
      private short[] T000Z2_A166CargoEstado ;
      private String[] T000Z2_A41ClinicaCodigo ;
      private String[] T000Z2_A30ArticuloCodigo ;
      private int[] T000Z2_A91ConsultaId ;
      private GXWebForm Form ;
   }

   public class cargo__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000Z2 ;
          prmT000Z2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z6 ;
          prmT000Z6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z4 ;
          prmT000Z4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z5 ;
          prmT000Z5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z7 ;
          prmT000Z7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000Z8 ;
          prmT000Z8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z9 ;
          prmT000Z9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z3 ;
          prmT000Z3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z10 ;
          prmT000Z10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z11 ;
          prmT000Z11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z12 ;
          prmT000Z12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z13 ;
          prmT000Z13 = new Object[] {
          new Object[] {"@CargoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CargoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CargoEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z14 ;
          prmT000Z14 = new Object[] {
          new Object[] {"@CargoPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CargoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CargoEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z15 ;
          prmT000Z15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z16 ;
          prmT000Z16 = new Object[] {
          } ;
          Object[] prmT000Z17 ;
          prmT000Z17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000Z18 ;
          prmT000Z18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000Z2", "SELECT [CargoId], [CargoPrecio], [CargoCantidad], [CargoEstado], [ClinicaCodigo], [ArticuloCodigo], [ConsultaId] FROM [Cargo] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [CargoId] = @CargoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z2,1,0,true,false )
             ,new CursorDef("T000Z3", "SELECT [CargoId], [CargoPrecio], [CargoCantidad], [CargoEstado], [ClinicaCodigo], [ArticuloCodigo], [ConsultaId] FROM [Cargo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [CargoId] = @CargoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z3,1,0,true,false )
             ,new CursorDef("T000Z4", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z4,1,0,true,false )
             ,new CursorDef("T000Z5", "SELECT [ClinicaCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z5,1,0,true,false )
             ,new CursorDef("T000Z6", "SELECT TM1.[CargoId], TM1.[CargoPrecio], TM1.[CargoCantidad], TM1.[CargoEstado], TM1.[ClinicaCodigo], TM1.[ArticuloCodigo], TM1.[ConsultaId] FROM [Cargo] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[ConsultaId] = @ConsultaId and TM1.[CargoId] = @CargoId ORDER BY TM1.[ClinicaCodigo], TM1.[ConsultaId], TM1.[CargoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z6,100,0,true,false )
             ,new CursorDef("T000Z7", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z7,1,0,true,false )
             ,new CursorDef("T000Z8", "SELECT [ClinicaCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z8,1,0,true,false )
             ,new CursorDef("T000Z9", "SELECT [ClinicaCodigo], [ConsultaId], [CargoId] FROM [Cargo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [CargoId] = @CargoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z9,1,0,true,false )
             ,new CursorDef("T000Z10", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [CargoId] FROM [Cargo] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] > @ConsultaId or [ConsultaId] = @ConsultaId and [ClinicaCodigo] = @ClinicaCodigo and [CargoId] > @CargoId) ORDER BY [ClinicaCodigo], [ConsultaId], [CargoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z10,1,0,true,true )
             ,new CursorDef("T000Z11", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [CargoId] FROM [Cargo] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] < @ConsultaId or [ConsultaId] = @ConsultaId and [ClinicaCodigo] = @ClinicaCodigo and [CargoId] < @CargoId) ORDER BY [ClinicaCodigo] DESC, [ConsultaId] DESC, [CargoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z11,1,0,true,true )
             ,new CursorDef("T000Z12", "SELECT [CargoId], [CargoPrecio], [CargoCantidad], [CargoEstado], [ClinicaCodigo], [ArticuloCodigo], [ConsultaId] FROM [Cargo] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [CargoId] = @CargoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z12,1,0,true,false )
             ,new CursorDef("T000Z13", "INSERT INTO [Cargo] ([CargoId], [CargoPrecio], [CargoCantidad], [CargoEstado], [ClinicaCodigo], [ArticuloCodigo], [ConsultaId]) VALUES (@CargoId, @CargoPrecio, @CargoCantidad, @CargoEstado, @ClinicaCodigo, @ArticuloCodigo, @ConsultaId)", GxErrorMask.GX_NOMASK,prmT000Z13)
             ,new CursorDef("T000Z14", "UPDATE [Cargo] SET [CargoPrecio]=@CargoPrecio, [CargoCantidad]=@CargoCantidad, [CargoEstado]=@CargoEstado, [ArticuloCodigo]=@ArticuloCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [CargoId] = @CargoId", GxErrorMask.GX_NOMASK,prmT000Z14)
             ,new CursorDef("T000Z15", "DELETE FROM [Cargo]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId AND [CargoId] = @CargoId", GxErrorMask.GX_NOMASK,prmT000Z15)
             ,new CursorDef("T000Z16", "SELECT [ClinicaCodigo], [ConsultaId], [CargoId] FROM [Cargo] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [ConsultaId], [CargoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z16,100,0,true,false )
             ,new CursorDef("T000Z17", "SELECT [ClinicaCodigo] FROM [Consulta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z17,1,0,true,false )
             ,new CursorDef("T000Z18", "SELECT [ClinicaCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z18,1,0,true,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 16 :
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
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 12 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
