/*
               File: Categoria
        Description: Categorías de productos y servicios
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:22.56
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
   public class categoria : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcategoria_subcategoria") == 0 )
         {
            nRC_Gridcategoria_subcategoria = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_60_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_60_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridcategoria_subcategoria_newrow( nRC_Gridcategoria_subcategoria, nGXsfl_60_idx, sGXsfl_60_idx) ;
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
         cmbCategoriaEstado.Name = "CATEGORIAESTADO" ;
         cmbCategoriaEstado.WebTags = "" ;
         cmbCategoriaEstado.addItem("0", "De baja", 0);
         cmbCategoriaEstado.addItem("1", "Activo", 0);
         if ( ( cmbCategoriaEstado.ItemCount > 0 ) && (0==A29CategoriaEstado) )
         {
            A29CategoriaEstado = (short)(NumberUtil.Val( cmbCategoriaEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29CategoriaEstado", StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Categorías de productos y servicios", 0) ;
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

      public categoria( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public categoria( IGxContext context )
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
         cmbCategoriaEstado = new GXCombobox();
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
            wb_table1_2_0710( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0710e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0710( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0710( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0710e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Categorías de productos y servicios"+"</legend>") ;
            wb_table3_27_0710( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0710e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0710e( true) ;
         }
         else
         {
            wb_table1_2_0710e( false) ;
         }
      }

      protected void wb_table3_27_0710( bool wbgen )
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
            wb_table4_33_0710( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0710e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Categoria.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Categoria.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0710e( true) ;
         }
         else
         {
            wb_table3_27_0710e( false) ;
         }
      }

      protected void wb_table4_33_0710( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Categoria.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcategoriacodigo_Internalname, "Categoría", "", "", lblTextblockcategoriacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCategoriaCodigo_Internalname, StringUtil.RTrim( A27CategoriaCodigo), StringUtil.RTrim( context.localUtil.Format( A27CategoriaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtCategoriaCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtCategoriaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcategoriadescripcion_Internalname, "Descripción", "", "", lblTextblockcategoriadescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CategoriaDescripcion", A28CategoriaDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCategoriaDescripcion_Internalname, StringUtil.RTrim( A28CategoriaDescripcion), StringUtil.RTrim( context.localUtil.Format( A28CategoriaDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtCategoriaDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtCategoriaDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcategoriaestado_Internalname, "Estado", "", "", lblTextblockcategoriaestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29CategoriaEstado", StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbCategoriaEstado, cmbCategoriaEstado_Internalname, StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0), 1, cmbCategoriaEstado_Jsonclick, 0, "", "int", "", 1, cmbCategoriaEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "", true, "HLP_Categoria.htm");
            cmbCategoriaEstado.CurrentValue = StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCategoriaEstado_Internalname, "Values", (String)(cmbCategoriaEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_56_0710( true) ;
         }
         return  ;
      }

      protected void wb_table5_56_0710e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridcategoria_subcategoriaContainer.AddObjectProperty("GridName", "Gridcategoria_subcategoria");
            Gridcategoria_subcategoriaContainer.AddObjectProperty("Class", "Grid");
            Gridcategoria_subcategoriaContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridcategoria_subcategoriaContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridcategoria_subcategoriaContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategoria_subcategoria_Backcolorstyle), 1, 0, ".", "")));
            Gridcategoria_subcategoriaContainer.AddObjectProperty("CmpContext", "");
            Gridcategoria_subcategoriaContainer.AddObjectProperty("InMasterPage", "false");
            Gridcategoria_subcategoriaColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcategoria_subcategoriaColumn.AddObjectProperty("Value", StringUtil.RTrim( A124SubCategoriaCodigo));
            Gridcategoria_subcategoriaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCategoriaCodigo_Enabled), 5, 0, ".", "")));
            Gridcategoria_subcategoriaContainer.AddColumnProperties(Gridcategoria_subcategoriaColumn);
            Gridcategoria_subcategoriaColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcategoria_subcategoriaColumn.AddObjectProperty("Value", StringUtil.RTrim( A125SubCategoriaDescripcion));
            Gridcategoria_subcategoriaColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCategoriaDescripcion_Enabled), 5, 0, ".", "")));
            Gridcategoria_subcategoriaContainer.AddColumnProperties(Gridcategoria_subcategoriaColumn);
            Gridcategoria_subcategoriaContainer.AddObjectProperty("Allowselection", "false");
            Gridcategoria_subcategoriaContainer.AddObjectProperty("Allowcollapsing", ((subGridcategoria_subcategoria_Allowcollapsing==1) ? "true" : "false"));
            Gridcategoria_subcategoriaContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcategoria_subcategoria_Collapsed), 9, 0, ".", "")));
            nGXsfl_60_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount11 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_11 = 1 ;
                  ScanStart0711( ) ;
                  while ( RcdFound11 != 0 )
                  {
                     init_level_properties11( ) ;
                     getByPrimaryKey0711( ) ;
                     AddRow0711( ) ;
                     ScanNext0711( ) ;
                  }
                  ScanEnd0711( ) ;
                  nBlankRcdCount11 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0711( ) ;
               standaloneModal0711( ) ;
               sMode11 = Gx_mode ;
               while ( nGXsfl_60_idx < nRC_Gridcategoria_subcategoria )
               {
                  ReadRow0711( ) ;
                  edtSubCategoriaCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATEGORIACODIGO_"+sGXsfl_60_idx+"Enabled"), ".", ",")) ;
                  edtSubCategoriaDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_11 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0711( ) ;
                  }
                  SendRow0711( ) ;
               }
               Gx_mode = sMode11 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount11 = 5 ;
               nRcdExists_11 = 1 ;
               ScanStart0711( ) ;
               while ( RcdFound11 != 0 )
               {
                  init_level_properties11( ) ;
                  getByPrimaryKey0711( ) ;
                  standaloneNotModal0711( ) ;
                  standaloneModal0711( ) ;
                  AddRow0711( ) ;
                  ScanNext0711( ) ;
               }
               ScanEnd0711( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode11 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0711( ) ;
            init_level_properties11( ) ;
            standaloneNotModal0711( ) ;
            standaloneModal0711( ) ;
            nRcdExists_11 = 0 ;
            nIsMod_11 = 0 ;
            nBlankRcdCount11 = (short)(nBlankRcdUsr11+nBlankRcdCount11) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount11 > 0 )
            {
               AddRow0711( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtSubCategoriaCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount11 = (short)(nBlankRcdCount11-1) ;
            }
            Gx_mode = sMode11 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridcategoria_subcategoriaContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcategoria_subcategoria", (Object)(Gridcategoria_subcategoriaContainer));
            GxWebStd.gx_hidden_field( context, "Gridcategoria_subcategoriaContainerData", Gridcategoria_subcategoriaContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridcategoria_subcategoriaContainerData"+"V", Gridcategoria_subcategoriaContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcategoria_subcategoriaContainerData"+"V"+"\" value='"+Gridcategoria_subcategoriaContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0710e( true) ;
         }
         else
         {
            wb_table4_33_0710e( false) ;
         }
      }

      protected void wb_table5_56_0710( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlesubcategoria_Internalname, "Sub-Categorías", "", "", lblTitlesubcategoria_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Categoria.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_56_0710e( true) ;
         }
         else
         {
            wb_table5_56_0710e( false) ;
         }
      }

      protected void wb_table2_5_0710( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CATEGORIACODIGO"+"'), id:'"+"CATEGORIACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CATEGORIACODIGO"+"'), id:'"+"CATEGORIACODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Categoria.htm");
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
            wb_table2_5_0710e( true) ;
         }
         else
         {
            wb_table2_5_0710e( false) ;
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
         /* Execute user event: E11072 */
         E11072 ();
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
               A27CategoriaCodigo = cgiGet( edtCategoriaCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
               A28CategoriaDescripcion = cgiGet( edtCategoriaDescripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CategoriaDescripcion", A28CategoriaDescripcion);
               cmbCategoriaEstado.Name = cmbCategoriaEstado_Internalname ;
               cmbCategoriaEstado.CurrentValue = cgiGet( cmbCategoriaEstado_Internalname) ;
               A29CategoriaEstado = (short)(NumberUtil.Val( cgiGet( cmbCategoriaEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29CategoriaEstado", StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0));
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z27CategoriaCodigo = cgiGet( "Z27CategoriaCodigo") ;
               Z28CategoriaDescripcion = cgiGet( "Z28CategoriaDescripcion") ;
               Z29CategoriaEstado = (short)(context.localUtil.CToN( cgiGet( "Z29CategoriaEstado"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridcategoria_subcategoria = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridcategoria_subcategoria"), ".", ",")) ;
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
                  A27CategoriaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
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
                           /* Execute user event: E11072 */
                           E11072 ();
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
               InitAll0710( ) ;
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
         DisableAttributes0710( ) ;
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

      protected void CONFIRM_0711( )
      {
         nGXsfl_60_idx = 0 ;
         while ( nGXsfl_60_idx < nRC_Gridcategoria_subcategoria )
         {
            ReadRow0711( ) ;
            if ( ( nRcdExists_11 != 0 ) || ( nIsMod_11 != 0 ) )
            {
               GetKey0711( ) ;
               if ( ( nRcdExists_11 == 0 ) && ( nRcdDeleted_11 == 0 ) )
               {
                  if ( RcdFound11 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0711( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0711( ) ;
                        CloseExtendedTableCursors0711( ) ;
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
                     GX_FocusControl = edtSubCategoriaCodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound11 != 0 )
                  {
                     if ( nRcdDeleted_11 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0711( ) ;
                        Load0711( ) ;
                        BeforeValidate0711( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0711( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_11 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0711( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0711( ) ;
                              CloseExtendedTableCursors0711( ) ;
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
                     if ( nRcdDeleted_11 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtSubCategoriaCodigo_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSubCategoriaCodigo_Internalname, StringUtil.RTrim( A124SubCategoriaCodigo)) ;
            ChangePostValue( edtSubCategoriaDescripcion_Internalname, StringUtil.RTrim( A125SubCategoriaDescripcion)) ;
            ChangePostValue( "ZT_"+"Z124SubCategoriaCodigo_"+sGXsfl_60_idx, StringUtil.RTrim( Z124SubCategoriaCodigo)) ;
            ChangePostValue( "ZT_"+"Z125SubCategoriaDescripcion_"+sGXsfl_60_idx, StringUtil.RTrim( Z125SubCategoriaDescripcion)) ;
            ChangePostValue( "nRcdDeleted_11_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_11_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_11_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", ""))) ;
            if ( nIsMod_11 != 0 )
            {
               ChangePostValue( "SUBCATEGORIACODIGO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCategoriaCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCategoriaDescripcion_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption070( )
      {
      }

      protected void E11072( )
      {
         /* Start Routine */
         GXt_SdtParametros6 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros6) ;
         AV7Parametros = GXt_SdtParametros6 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM0710( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z28CategoriaDescripcion = T00075_A28CategoriaDescripcion[0] ;
               Z29CategoriaEstado = T00075_A29CategoriaEstado[0] ;
            }
            else
            {
               Z28CategoriaDescripcion = A28CategoriaDescripcion ;
               Z29CategoriaEstado = A29CategoriaEstado ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z27CategoriaCodigo = A27CategoriaCodigo ;
            Z28CategoriaDescripcion = A28CategoriaDescripcion ;
            Z29CategoriaEstado = A29CategoriaEstado ;
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

      protected void Load0710( )
      {
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound10 = 1 ;
            A28CategoriaDescripcion = T00077_A28CategoriaDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CategoriaDescripcion", A28CategoriaDescripcion);
            A29CategoriaEstado = T00077_A29CategoriaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29CategoriaEstado", StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0));
            ZM0710( -4) ;
         }
         pr_default.close(5);
         OnLoadActions0710( ) ;
      }

      protected void OnLoadActions0710( )
      {
      }

      protected void CheckExtendedTable0710( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00076 */
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

      protected void CloseExtendedTableCursors0710( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo )
      {
         /* Using cursor T00078 */
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

      protected void GetKey0710( )
      {
         /* Using cursor T00079 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound10 = 1 ;
         }
         else
         {
            RcdFound10 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0710( 4) ;
            RcdFound10 = 1 ;
            A27CategoriaCodigo = T00075_A27CategoriaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
            A28CategoriaDescripcion = T00075_A28CategoriaDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CategoriaDescripcion", A28CategoriaDescripcion);
            A29CategoriaEstado = T00075_A29CategoriaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29CategoriaEstado", StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0));
            A41ClinicaCodigo = T00075_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z27CategoriaCodigo = A27CategoriaCodigo ;
            sMode10 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0710( ) ;
            Gx_mode = sMode10 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound10 = 0 ;
            InitializeNonKey0710( ) ;
            sMode10 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode10 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0710( ) ;
         if ( RcdFound10 == 0 )
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
         RcdFound10 = 0 ;
         /* Using cursor T000710 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000710_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000710_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000710_A27CategoriaCodigo[0], A27CategoriaCodigo) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000710_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000710_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000710_A27CategoriaCodigo[0], A27CategoriaCodigo) > 0 ) ) )
            {
               A41ClinicaCodigo = T000710_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A27CategoriaCodigo = T000710_A27CategoriaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
               RcdFound10 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0 ;
         /* Using cursor T000711 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000711_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000711_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000711_A27CategoriaCodigo[0], A27CategoriaCodigo) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000711_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000711_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(T000711_A27CategoriaCodigo[0], A27CategoriaCodigo) < 0 ) ) )
            {
               A41ClinicaCodigo = T000711_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A27CategoriaCodigo = T000711_A27CategoriaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
               RcdFound10 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0710( ) ;
         if ( RcdFound10 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A27CategoriaCodigo, Z27CategoriaCodigo) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A27CategoriaCodigo = Z27CategoriaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
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
               Update0710( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A27CategoriaCodigo, Z27CategoriaCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0710( ) ;
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
                  Insert0710( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A27CategoriaCodigo, Z27CategoriaCodigo) != 0 ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A27CategoriaCodigo = Z27CategoriaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCategoriaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0710( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCategoriaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0710( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCategoriaDescripcion_Internalname ;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCategoriaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0710( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound10 != 0 )
            {
               ScanNext0710( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCategoriaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0710( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0710( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000712 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Categoria"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z28CategoriaDescripcion, T000712_A28CategoriaDescripcion[0]) != 0 ) || ( Z29CategoriaEstado != T000712_A29CategoriaEstado[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Categoria"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0710( )
      {
         BeforeValidate0710( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0710( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0710( 0) ;
            CheckOptimisticConcurrency0710( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0710( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0710( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000713 */
                     pr_default.execute(11, new Object[] {A27CategoriaCodigo, A28CategoriaDescripcion, A29CategoriaEstado, A41ClinicaCodigo});
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
                           ProcessLevel0710( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption070( ) ;
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
               Load0710( ) ;
            }
            EndLevel0710( ) ;
         }
         CloseExtendedTableCursors0710( ) ;
      }

      protected void Update0710( )
      {
         BeforeValidate0710( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0710( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0710( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0710( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0710( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000714 */
                     pr_default.execute(12, new Object[] {A28CategoriaDescripcion, A29CategoriaEstado, A41ClinicaCodigo, A27CategoriaCodigo});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Categoria"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0710( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0710( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption070( ) ;
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
            EndLevel0710( ) ;
         }
         CloseExtendedTableCursors0710( ) ;
      }

      protected void DeferredUpdate0710( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0710( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0710( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0710( ) ;
            AfterConfirm0710( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0710( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000715 */
                  pr_default.execute(13, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
                  pr_default.close(13);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound10 == 0 )
                        {
                           InitAll0710( ) ;
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
                        ResetCaption070( ) ;
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
         sMode10 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0710( ) ;
         Gx_mode = sMode10 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0710( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000716 */
            pr_default.execute(14, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Sub-Categorías"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel0711( )
      {
         nGXsfl_60_idx = 0 ;
         while ( nGXsfl_60_idx < nRC_Gridcategoria_subcategoria )
         {
            ReadRow0711( ) ;
            if ( ( nRcdExists_11 != 0 ) || ( nIsMod_11 != 0 ) )
            {
               standaloneNotModal0711( ) ;
               GetKey0711( ) ;
               if ( ( nRcdExists_11 == 0 ) && ( nRcdDeleted_11 == 0 ) )
               {
                  if ( RcdFound11 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0711( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtSubCategoriaCodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound11 != 0 )
                  {
                     if ( ( nRcdDeleted_11 != 0 ) && ( nRcdExists_11 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0711( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_11 != 0 ) && ( nRcdExists_11 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0711( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_11 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtSubCategoriaCodigo_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSubCategoriaCodigo_Internalname, StringUtil.RTrim( A124SubCategoriaCodigo)) ;
            ChangePostValue( edtSubCategoriaDescripcion_Internalname, StringUtil.RTrim( A125SubCategoriaDescripcion)) ;
            ChangePostValue( "ZT_"+"Z124SubCategoriaCodigo_"+sGXsfl_60_idx, StringUtil.RTrim( Z124SubCategoriaCodigo)) ;
            ChangePostValue( "ZT_"+"Z125SubCategoriaDescripcion_"+sGXsfl_60_idx, StringUtil.RTrim( Z125SubCategoriaDescripcion)) ;
            ChangePostValue( "nRcdDeleted_11_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_11_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_11_"+sGXsfl_60_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", ""))) ;
            if ( nIsMod_11 != 0 )
            {
               ChangePostValue( "SUBCATEGORIACODIGO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCategoriaCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCategoriaDescripcion_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0711( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_11 = 0 ;
         nIsMod_11 = 0 ;
         nRcdDeleted_11 = 0 ;
      }

      protected void ProcessLevel0710( )
      {
         /* Save parent mode. */
         sMode10 = Gx_mode ;
         ProcessNestedLevel0711( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode10 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0710( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0710( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("Categoria");
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
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
            context.RollbackDataStores("Categoria");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0710( )
      {
         /* Using cursor T000717 */
         pr_default.execute(15);
         RcdFound10 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound10 = 1 ;
            A41ClinicaCodigo = T000717_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A27CategoriaCodigo = T000717_A27CategoriaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0710( )
      {
         pr_default.readNext(15);
         RcdFound10 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound10 = 1 ;
            A41ClinicaCodigo = T000717_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A27CategoriaCodigo = T000717_A27CategoriaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
         }
      }

      protected void ScanEnd0710( )
      {
      }

      protected void AfterConfirm0710( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0710( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0710( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0710( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0710( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0710( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0710( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtCategoriaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCategoriaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCategoriaCodigo_Enabled), 5, 0)));
         edtCategoriaDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCategoriaDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCategoriaDescripcion_Enabled), 5, 0)));
         cmbCategoriaEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCategoriaEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbCategoriaEstado.Enabled), 5, 0)));
      }

      protected void ZM0711( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z125SubCategoriaDescripcion = T00073_A125SubCategoriaDescripcion[0] ;
            }
            else
            {
               Z125SubCategoriaDescripcion = A125SubCategoriaDescripcion ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z27CategoriaCodigo = A27CategoriaCodigo ;
            Z124SubCategoriaCodigo = A124SubCategoriaCodigo ;
            Z125SubCategoriaDescripcion = A125SubCategoriaDescripcion ;
         }
      }

      protected void standaloneNotModal0711( )
      {
      }

      protected void standaloneModal0711( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSubCategoriaCodigo_Enabled = 0 ;
         }
         else
         {
            edtSubCategoriaCodigo_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode11, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode11, "DLT") == 0 ) )
         {
            DisableAttributes0711( ) ;
         }
      }

      protected void Load0711( )
      {
         /* Using cursor T000718 */
         pr_default.execute(16, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound11 = 1 ;
            A125SubCategoriaDescripcion = T000718_A125SubCategoriaDescripcion[0] ;
            ZM0711( -6) ;
         }
         pr_default.close(16);
         OnLoadActions0711( ) ;
      }

      protected void OnLoadActions0711( )
      {
      }

      protected void CheckExtendedTable0711( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0711( ) ;
      }

      protected void CloseExtendedTableCursors0711( )
      {
      }

      protected void enableDisable0711( )
      {
      }

      protected void GetKey0711( )
      {
         /* Using cursor T000719 */
         pr_default.execute(17, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound11 = 1 ;
         }
         else
         {
            RcdFound11 = 0 ;
         }
         pr_default.close(17);
      }

      protected void getByPrimaryKey0711( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0711( 6) ;
            RcdFound11 = 1 ;
            InitializeNonKey0711( ) ;
            A124SubCategoriaCodigo = T00073_A124SubCategoriaCodigo[0] ;
            A125SubCategoriaDescripcion = T00073_A125SubCategoriaDescripcion[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z27CategoriaCodigo = A27CategoriaCodigo ;
            Z124SubCategoriaCodigo = A124SubCategoriaCodigo ;
            sMode11 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0711( ) ;
            Load0711( ) ;
            Gx_mode = sMode11 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound11 = 0 ;
            InitializeNonKey0711( ) ;
            sMode11 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0711( ) ;
            Gx_mode = sMode11 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0711( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00072 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SubCategoria"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z125SubCategoriaDescripcion, T00072_A125SubCategoriaDescripcion[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SubCategoria"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0711( )
      {
         BeforeValidate0711( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0711( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0711( 0) ;
            CheckOptimisticConcurrency0711( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0711( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0711( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000720 */
                     pr_default.execute(18, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo, A125SubCategoriaDescripcion});
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
               Load0711( ) ;
            }
            EndLevel0711( ) ;
         }
         CloseExtendedTableCursors0711( ) ;
      }

      protected void Update0711( )
      {
         BeforeValidate0711( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0711( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0711( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0711( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0711( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000721 */
                     pr_default.execute(19, new Object[] {A125SubCategoriaDescripcion, A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
                     pr_default.close(19);
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SubCategoria"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0711( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0711( ) ;
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
            EndLevel0711( ) ;
         }
         CloseExtendedTableCursors0711( ) ;
      }

      protected void DeferredUpdate0711( )
      {
      }

      protected void Delete0711( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0711( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0711( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0711( ) ;
            AfterConfirm0711( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0711( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000722 */
                  pr_default.execute(20, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
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
         sMode11 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0711( ) ;
         Gx_mode = sMode11 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0711( )
      {
         standaloneModal0711( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000723 */
            pr_default.execute(21, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo, A124SubCategoriaCodigo});
            if ( (pr_default.getStatus(21) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Maestro de productos y servicios"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(21);
         }
      }

      protected void EndLevel0711( )
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

      protected void ScanStart0711( )
      {
         /* Using cursor T000724 */
         pr_default.execute(22, new Object[] {A41ClinicaCodigo, A27CategoriaCodigo});
         RcdFound11 = 0 ;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound11 = 1 ;
            A124SubCategoriaCodigo = T000724_A124SubCategoriaCodigo[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0711( )
      {
         pr_default.readNext(22);
         RcdFound11 = 0 ;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound11 = 1 ;
            A124SubCategoriaCodigo = T000724_A124SubCategoriaCodigo[0] ;
         }
      }

      protected void ScanEnd0711( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0711( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0711( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0711( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0711( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0711( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0711( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0711( )
      {
         edtSubCategoriaCodigo_Enabled = 0 ;
         edtSubCategoriaDescripcion_Enabled = 0 ;
      }

      protected void AddRow0711( )
      {
         nGXsfl_60_idx = (short)(nGXsfl_60_idx+1) ;
         sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
         edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_60_idx ;
         edtSubCategoriaDescripcion_Internalname = "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx ;
         SendRow0711( ) ;
      }

      protected void SendRow0711( )
      {
         Gridcategoria_subcategoriaRow = GXWebRow.GetNew(context) ;
         if ( subGridcategoria_subcategoria_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcategoria_subcategoria_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridcategoria_subcategoria_Class, "") != 0 )
            {
               subGridcategoria_subcategoria_Linesclass = subGridcategoria_subcategoria_Class+"Odd" ;
            }
         }
         else if ( subGridcategoria_subcategoria_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcategoria_subcategoria_Backstyle = 0 ;
            subGridcategoria_subcategoria_Backcolor = subGridcategoria_subcategoria_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcategoria_subcategoriaContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcategoria_subcategoria_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridcategoria_subcategoria_Class, "") != 0 )
            {
               subGridcategoria_subcategoria_Linesclass = subGridcategoria_subcategoria_Class+"Uniform" ;
            }
         }
         else if ( subGridcategoria_subcategoria_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcategoria_subcategoria_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridcategoria_subcategoria_Class, "") != 0 )
            {
               subGridcategoria_subcategoria_Linesclass = subGridcategoria_subcategoria_Class+"Odd" ;
            }
            subGridcategoria_subcategoria_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcategoria_subcategoriaContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcategoria_subcategoria_Backcolor), 9, 0)));
         }
         else if ( subGridcategoria_subcategoria_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcategoria_subcategoria_Backstyle = 1 ;
            if ( ((int)(nGXsfl_60_idx) % (2)) == 0 )
            {
               subGridcategoria_subcategoria_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcategoria_subcategoriaContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcategoria_subcategoria_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcategoria_subcategoria_Class, "") != 0 )
               {
                  subGridcategoria_subcategoria_Linesclass = subGridcategoria_subcategoria_Class+"Even" ;
               }
            }
            else
            {
               subGridcategoria_subcategoria_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcategoria_subcategoriaContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcategoria_subcategoria_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcategoria_subcategoria_Class, "") != 0 )
               {
                  subGridcategoria_subcategoria_Linesclass = subGridcategoria_subcategoria_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_11_" + sGXsfl_60_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_60_idx + "',60)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcategoria_subcategoriaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubCategoriaCodigo_Internalname,StringUtil.RTrim( A124SubCategoriaCodigo),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(61);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSubCategoriaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSubCategoriaCodigo_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)60,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_11_" + sGXsfl_60_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_60_idx + "',60)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcategoria_subcategoriaRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSubCategoriaDescripcion_Internalname,StringUtil.RTrim( A125SubCategoriaDescripcion),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(62);\"",(String)"",(String)"",(String)"",(String)"",(String)edtSubCategoriaDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtSubCategoriaDescripcion_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)60,(short)1,(short)-1,(bool)true,(String)"left"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcategoria_subcategoriaRow);
         GXCCtl = "Z124SubCategoriaCodigo_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z124SubCategoriaCodigo));
         GXCCtl = "Z125SubCategoriaDescripcion_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z125SubCategoriaDescripcion));
         GXCCtl = "nRcdDeleted_11_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_11), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_11_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_11), 4, 0, ".", "")));
         GXCCtl = "nIsMod_11_" + sGXsfl_60_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_11), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATEGORIACODIGO_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCategoriaCodigo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSubCategoriaDescripcion_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcategoria_subcategoriaContainer.AddRow(Gridcategoria_subcategoriaRow);
      }

      protected void ReadRow0711( )
      {
         nGXsfl_60_idx = (short)(nGXsfl_60_idx+1) ;
         sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
         edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_60_idx ;
         edtSubCategoriaDescripcion_Internalname = "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx ;
         edtSubCategoriaCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATEGORIACODIGO_"+sGXsfl_60_idx+"Enabled"), ".", ",")) ;
         edtSubCategoriaDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx+"Enabled"), ".", ",")) ;
         A124SubCategoriaCodigo = cgiGet( edtSubCategoriaCodigo_Internalname) ;
         A125SubCategoriaDescripcion = cgiGet( edtSubCategoriaDescripcion_Internalname) ;
         GXCCtl = "Z124SubCategoriaCodigo_" + sGXsfl_60_idx ;
         Z124SubCategoriaCodigo = cgiGet( GXCCtl) ;
         GXCCtl = "Z125SubCategoriaDescripcion_" + sGXsfl_60_idx ;
         Z125SubCategoriaDescripcion = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_11_" + sGXsfl_60_idx ;
         nRcdDeleted_11 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_11_" + sGXsfl_60_idx ;
         nRcdExists_11 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_11_" + sGXsfl_60_idx ;
         nIsMod_11 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtSubCategoriaCodigo_Enabled = edtSubCategoriaCodigo_Enabled ;
      }

      protected void ConfirmValues070( )
      {
         nGXsfl_60_idx = 0 ;
         sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
         edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_60_idx ;
         edtSubCategoriaDescripcion_Internalname = "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx ;
         while ( nGXsfl_60_idx < nRC_Gridcategoria_subcategoria )
         {
            nGXsfl_60_idx = (short)(nGXsfl_60_idx+1) ;
            sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
            edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_60_idx ;
            edtSubCategoriaDescripcion_Internalname = "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx ;
            ChangePostValue( "Z124SubCategoriaCodigo_"+sGXsfl_60_idx, cgiGet( "ZT_"+"Z124SubCategoriaCodigo_"+sGXsfl_60_idx)) ;
            DeletePostValue( "ZT_"+"Z124SubCategoriaCodigo_"+sGXsfl_60_idx) ;
            ChangePostValue( "Z125SubCategoriaDescripcion_"+sGXsfl_60_idx, cgiGet( "ZT_"+"Z125SubCategoriaDescripcion_"+sGXsfl_60_idx)) ;
            DeletePostValue( "ZT_"+"Z125SubCategoriaDescripcion_"+sGXsfl_60_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("categoria.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z27CategoriaCodigo", StringUtil.RTrim( Z27CategoriaCodigo));
         GxWebStd.gx_hidden_field( context, "Z28CategoriaDescripcion", StringUtil.RTrim( Z28CategoriaDescripcion));
         GxWebStd.gx_hidden_field( context, "Z29CategoriaEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29CategoriaEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridcategoria_subcategoria", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_60_idx), 4, 0, ".", "")));
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
         return "Categoria" ;
      }

      public override String GetPgmdesc( )
      {
         return "Categorías de productos y servicios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("categoria.aspx")  ;
      }

      protected void InitializeNonKey0710( )
      {
         A28CategoriaDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28CategoriaDescripcion", A28CategoriaDescripcion);
         A29CategoriaEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29CategoriaEstado", StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0));
      }

      protected void InitAll0710( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A27CategoriaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27CategoriaCodigo", A27CategoriaCodigo);
         InitializeNonKey0710( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0711( )
      {
         A125SubCategoriaDescripcion = "" ;
      }

      protected void InitAll0711( )
      {
         A124SubCategoriaCodigo = "" ;
         InitializeNonKey0711( ) ;
      }

      protected void StandaloneModalInsert0711( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1542480");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("categoria.js", "?1542480");
         /* End function include_jscripts */
      }

      protected void init_level_properties11( )
      {
         edtSubCategoriaCodigo_Enabled = defedtSubCategoriaCodigo_Enabled ;
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
         lblTextblockcategoriacodigo_Internalname = "TEXTBLOCKCATEGORIACODIGO" ;
         edtCategoriaCodigo_Internalname = "CATEGORIACODIGO" ;
         lblTextblockcategoriadescripcion_Internalname = "TEXTBLOCKCATEGORIADESCRIPCION" ;
         edtCategoriaDescripcion_Internalname = "CATEGORIADESCRIPCION" ;
         lblTextblockcategoriaestado_Internalname = "TEXTBLOCKCATEGORIAESTADO" ;
         cmbCategoriaEstado_Internalname = "CATEGORIAESTADO" ;
         lblTitlesubcategoria_Internalname = "TITLESUBCATEGORIA" ;
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
         subGridcategoria_subcategoria_Internalname = "GRIDCATEGORIA_SUBCATEGORIA" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Categorías de productos y servicios" ;
         edtSubCategoriaDescripcion_Jsonclick = "" ;
         edtSubCategoriaCodigo_Jsonclick = "" ;
         subGridcategoria_subcategoria_Class = "Grid" ;
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
         subGridcategoria_subcategoria_Allowcollapsing = 0 ;
         edtSubCategoriaDescripcion_Enabled = 1 ;
         edtSubCategoriaCodigo_Enabled = 1 ;
         subGridcategoria_subcategoria_Backcolorstyle = 2 ;
         cmbCategoriaEstado_Jsonclick = "" ;
         cmbCategoriaEstado.Enabled = 1 ;
         edtCategoriaDescripcion_Jsonclick = "" ;
         edtCategoriaDescripcion_Enabled = 1 ;
         edtCategoriaCodigo_Jsonclick = "" ;
         edtCategoriaCodigo_Enabled = 1 ;
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

      protected void gxnrGridcategoria_subcategoria_newrow( short nRC_Gridcategoria_subcategoria ,
                                                            short nGXsfl_60_idx ,
                                                            String sGXsfl_60_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_60_idx ;
         edtSubCategoriaDescripcion_Internalname = "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx ;
         while ( nGXsfl_60_idx <= nRC_Gridcategoria_subcategoria )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0711( ) ;
            standaloneModal0711( ) ;
            cmbCategoriaEstado.Name = "CATEGORIAESTADO" ;
            cmbCategoriaEstado.WebTags = "" ;
            cmbCategoriaEstado.addItem("0", "De baja", 0);
            cmbCategoriaEstado.addItem("1", "Activo", 0);
            if ( ( cmbCategoriaEstado.ItemCount > 0 ) && (0==A29CategoriaEstado) )
            {
               A29CategoriaEstado = (short)(NumberUtil.Val( cmbCategoriaEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29CategoriaEstado", StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0));
            }
            dynload_actions( ) ;
            SendRow0711( ) ;
            nGXsfl_60_idx = (short)(nGXsfl_60_idx+1) ;
            sGXsfl_60_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_60_idx), 4, 0)), 4, "0") ;
            edtSubCategoriaCodigo_Internalname = "SUBCATEGORIACODIGO_"+sGXsfl_60_idx ;
            edtSubCategoriaDescripcion_Internalname = "SUBCATEGORIADESCRIPCION_"+sGXsfl_60_idx ;
         }
         context.GX_webresponse.AddString(Gridcategoria_subcategoriaContainer.ToJavascriptSource());
         /* End function gxnrGridcategoria_subcategoria_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000725 */
         pr_default.execute(23, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(23) == 101) )
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
         pr_default.close(23);
         GX_FocusControl = edtCategoriaDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T000725 */
         pr_default.execute(23, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(23) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(23);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Categoriacodigo( String GX_Parm1 ,
                                         String GX_Parm2 ,
                                         String GX_Parm3 ,
                                         String GX_Parm4 ,
                                         GXCombobox cmbGX_Parm5 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A27CategoriaCodigo = GX_Parm3 ;
         A28CategoriaDescripcion = GX_Parm4 ;
         cmbCategoriaEstado = cmbGX_Parm5 ;
         A29CategoriaEstado = (short)(NumberUtil.Val( cmbCategoriaEstado.CurrentValue, ".")) ;
         cmbCategoriaEstado.CurrentValue = StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0) ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A28CategoriaDescripcion)));
         cmbCategoriaEstado.CurrentValue = StringUtil.Str( (decimal)(A29CategoriaEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbCategoriaEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z27CategoriaCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z28CategoriaDescripcion)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29CategoriaEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(Gridcategoria_subcategoriaContainer));
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
         pr_default.close(22);
         pr_default.close(15);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(23);
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
         lblTextblockcategoriacodigo_Jsonclick = "" ;
         A27CategoriaCodigo = "" ;
         lblTextblockcategoriadescripcion_Jsonclick = "" ;
         A28CategoriaDescripcion = "" ;
         lblTextblockcategoriaestado_Jsonclick = "" ;
         Gridcategoria_subcategoriaContainer = new GXWebGrid( context);
         Gridcategoria_subcategoriaColumn = new GXWebColumn();
         A124SubCategoriaCodigo = "" ;
         A125SubCategoriaDescripcion = "" ;
         Gx_mode = "" ;
         sMode11 = "" ;
         edtSubCategoriaCodigo_Internalname = "" ;
         lblTitlesubcategoria_Jsonclick = "" ;
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
         Z27CategoriaCodigo = "" ;
         Z28CategoriaDescripcion = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtSubCategoriaDescripcion_Internalname = "" ;
         Z124SubCategoriaCodigo = "" ;
         Z125SubCategoriaDescripcion = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros6 = new SdtParametros(context);
         T00077_A27CategoriaCodigo = new String[] {""} ;
         T00077_A28CategoriaDescripcion = new String[] {""} ;
         T00077_A29CategoriaEstado = new short[1] ;
         T00077_A41ClinicaCodigo = new String[] {""} ;
         T00076_A41ClinicaCodigo = new String[] {""} ;
         T00078_A41ClinicaCodigo = new String[] {""} ;
         T00079_A41ClinicaCodigo = new String[] {""} ;
         T00079_A27CategoriaCodigo = new String[] {""} ;
         T00075_A27CategoriaCodigo = new String[] {""} ;
         T00075_A28CategoriaDescripcion = new String[] {""} ;
         T00075_A29CategoriaEstado = new short[1] ;
         T00075_A41ClinicaCodigo = new String[] {""} ;
         sMode10 = "" ;
         T000710_A41ClinicaCodigo = new String[] {""} ;
         T000710_A27CategoriaCodigo = new String[] {""} ;
         T000711_A41ClinicaCodigo = new String[] {""} ;
         T000711_A27CategoriaCodigo = new String[] {""} ;
         T000712_A27CategoriaCodigo = new String[] {""} ;
         T000712_A28CategoriaDescripcion = new String[] {""} ;
         T000712_A29CategoriaEstado = new short[1] ;
         T000712_A41ClinicaCodigo = new String[] {""} ;
         T000716_A41ClinicaCodigo = new String[] {""} ;
         T000716_A27CategoriaCodigo = new String[] {""} ;
         T000716_A124SubCategoriaCodigo = new String[] {""} ;
         T000717_A41ClinicaCodigo = new String[] {""} ;
         T000717_A27CategoriaCodigo = new String[] {""} ;
         T000718_A41ClinicaCodigo = new String[] {""} ;
         T000718_A27CategoriaCodigo = new String[] {""} ;
         T000718_A124SubCategoriaCodigo = new String[] {""} ;
         T000718_A125SubCategoriaDescripcion = new String[] {""} ;
         T000719_A41ClinicaCodigo = new String[] {""} ;
         T000719_A27CategoriaCodigo = new String[] {""} ;
         T000719_A124SubCategoriaCodigo = new String[] {""} ;
         T00073_A41ClinicaCodigo = new String[] {""} ;
         T00073_A27CategoriaCodigo = new String[] {""} ;
         T00073_A124SubCategoriaCodigo = new String[] {""} ;
         T00073_A125SubCategoriaDescripcion = new String[] {""} ;
         T00072_A41ClinicaCodigo = new String[] {""} ;
         T00072_A27CategoriaCodigo = new String[] {""} ;
         T00072_A124SubCategoriaCodigo = new String[] {""} ;
         T00072_A125SubCategoriaDescripcion = new String[] {""} ;
         T000723_A41ClinicaCodigo = new String[] {""} ;
         T000723_A30ArticuloCodigo = new String[] {""} ;
         T000724_A41ClinicaCodigo = new String[] {""} ;
         T000724_A27CategoriaCodigo = new String[] {""} ;
         T000724_A124SubCategoriaCodigo = new String[] {""} ;
         Gridcategoria_subcategoriaRow = new GXWebRow();
         subGridcategoria_subcategoria_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char7 = "" ;
         GXt_char5 = "" ;
         GXt_char8 = "" ;
         T000725_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.categoria__default(),
            new Object[][] {
                new Object[] {
               T00072_A41ClinicaCodigo, T00072_A27CategoriaCodigo, T00072_A124SubCategoriaCodigo, T00072_A125SubCategoriaDescripcion
               }
               , new Object[] {
               T00073_A41ClinicaCodigo, T00073_A27CategoriaCodigo, T00073_A124SubCategoriaCodigo, T00073_A125SubCategoriaDescripcion
               }
               , new Object[] {
               T00074_A27CategoriaCodigo, T00074_A28CategoriaDescripcion, T00074_A29CategoriaEstado, T00074_A41ClinicaCodigo
               }
               , new Object[] {
               T00075_A27CategoriaCodigo, T00075_A28CategoriaDescripcion, T00075_A29CategoriaEstado, T00075_A41ClinicaCodigo
               }
               , new Object[] {
               T00076_A41ClinicaCodigo
               }
               , new Object[] {
               T00077_A27CategoriaCodigo, T00077_A28CategoriaDescripcion, T00077_A29CategoriaEstado, T00077_A41ClinicaCodigo
               }
               , new Object[] {
               T00078_A41ClinicaCodigo
               }
               , new Object[] {
               T00079_A41ClinicaCodigo, T00079_A27CategoriaCodigo
               }
               , new Object[] {
               T000710_A41ClinicaCodigo, T000710_A27CategoriaCodigo
               }
               , new Object[] {
               T000711_A41ClinicaCodigo, T000711_A27CategoriaCodigo
               }
               , new Object[] {
               T000712_A27CategoriaCodigo, T000712_A28CategoriaDescripcion, T000712_A29CategoriaEstado, T000712_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000716_A41ClinicaCodigo, T000716_A27CategoriaCodigo, T000716_A124SubCategoriaCodigo
               }
               , new Object[] {
               T000717_A41ClinicaCodigo, T000717_A27CategoriaCodigo
               }
               , new Object[] {
               T000718_A41ClinicaCodigo, T000718_A27CategoriaCodigo, T000718_A124SubCategoriaCodigo, T000718_A125SubCategoriaDescripcion
               }
               , new Object[] {
               T000719_A41ClinicaCodigo, T000719_A27CategoriaCodigo, T000719_A124SubCategoriaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000723_A41ClinicaCodigo, T000723_A30ArticuloCodigo
               }
               , new Object[] {
               T000724_A41ClinicaCodigo, T000724_A27CategoriaCodigo, T000724_A124SubCategoriaCodigo
               }
               , new Object[] {
               T000725_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridcategoria_subcategoria ;
      private short nGXsfl_60_idx=1 ;
      private short gxcookieaux ;
      private short A29CategoriaEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridcategoria_subcategoria_Backcolorstyle ;
      private short subGridcategoria_subcategoria_Allowcollapsing ;
      private short subGridcategoria_subcategoria_Collapsed ;
      private short nBlankRcdCount11 ;
      private short nRcdExists_11 ;
      private short RcdFound11 ;
      private short nIsMod_11 ;
      private short nBlankRcdUsr11 ;
      private short Z29CategoriaEstado ;
      private short nRcdDeleted_11 ;
      private short GX_JID ;
      private short RcdFound10 ;
      private short Gx_BScreen ;
      private short subGridcategoria_subcategoria_Backstyle ;
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
      private int edtCategoriaCodigo_Enabled ;
      private int edtCategoriaDescripcion_Enabled ;
      private int edtSubCategoriaCodigo_Enabled ;
      private int edtSubCategoriaDescripcion_Enabled ;
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
      private int GRIDCATEGORIA_SUBCATEGORIA_nFirstRecordOnPage ;
      private int AnyError41 ;
      private int subGridcategoria_subcategoria_Backcolor ;
      private int subGridcategoria_subcategoria_Allbackcolor ;
      private int defedtSubCategoriaCodigo_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_60_idx="0001" ;
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
      private String lblTextblockcategoriacodigo_Internalname ;
      private String lblTextblockcategoriacodigo_Jsonclick ;
      private String edtCategoriaCodigo_Internalname ;
      private String edtCategoriaCodigo_Jsonclick ;
      private String lblTextblockcategoriadescripcion_Internalname ;
      private String lblTextblockcategoriadescripcion_Jsonclick ;
      private String edtCategoriaDescripcion_Internalname ;
      private String edtCategoriaDescripcion_Jsonclick ;
      private String lblTextblockcategoriaestado_Internalname ;
      private String lblTextblockcategoriaestado_Jsonclick ;
      private String cmbCategoriaEstado_Internalname ;
      private String cmbCategoriaEstado_Jsonclick ;
      private String Gx_mode ;
      private String sMode11 ;
      private String edtSubCategoriaCodigo_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlesubcategoria_Internalname ;
      private String lblTitlesubcategoria_Jsonclick ;
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
      private String edtSubCategoriaDescripcion_Internalname ;
      private String sMode10 ;
      private String subGridcategoria_subcategoria_Class ;
      private String subGridcategoria_subcategoria_Linesclass ;
      private String ROClassString ;
      private String edtSubCategoriaCodigo_Jsonclick ;
      private String edtSubCategoriaDescripcion_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char7 ;
      private String GXt_char5 ;
      private String subGridcategoria_subcategoria_Internalname ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A27CategoriaCodigo ;
      private String A28CategoriaDescripcion ;
      private String A124SubCategoriaCodigo ;
      private String A125SubCategoriaDescripcion ;
      private String Z41ClinicaCodigo ;
      private String Z27CategoriaCodigo ;
      private String Z28CategoriaDescripcion ;
      private String AV8ClinicaCodigo ;
      private String Z124SubCategoriaCodigo ;
      private String Z125SubCategoriaDescripcion ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridcategoria_subcategoriaContainer ;
      private GXWebRow Gridcategoria_subcategoriaRow ;
      private GXWebColumn Gridcategoria_subcategoriaColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbCategoriaEstado ;
      private IDataStoreProvider pr_default ;
      private String[] T00077_A27CategoriaCodigo ;
      private String[] T00077_A28CategoriaDescripcion ;
      private short[] T00077_A29CategoriaEstado ;
      private String[] T00077_A41ClinicaCodigo ;
      private String[] T00076_A41ClinicaCodigo ;
      private String[] T00078_A41ClinicaCodigo ;
      private String[] T00079_A41ClinicaCodigo ;
      private String[] T00079_A27CategoriaCodigo ;
      private String[] T00075_A27CategoriaCodigo ;
      private String[] T00075_A28CategoriaDescripcion ;
      private short[] T00075_A29CategoriaEstado ;
      private String[] T00075_A41ClinicaCodigo ;
      private String[] T000710_A41ClinicaCodigo ;
      private String[] T000710_A27CategoriaCodigo ;
      private String[] T000711_A41ClinicaCodigo ;
      private String[] T000711_A27CategoriaCodigo ;
      private String[] T000712_A27CategoriaCodigo ;
      private String[] T000712_A28CategoriaDescripcion ;
      private short[] T000712_A29CategoriaEstado ;
      private String[] T000712_A41ClinicaCodigo ;
      private String[] T000716_A41ClinicaCodigo ;
      private String[] T000716_A27CategoriaCodigo ;
      private String[] T000716_A124SubCategoriaCodigo ;
      private String[] T000717_A41ClinicaCodigo ;
      private String[] T000717_A27CategoriaCodigo ;
      private String[] T000718_A41ClinicaCodigo ;
      private String[] T000718_A27CategoriaCodigo ;
      private String[] T000718_A124SubCategoriaCodigo ;
      private String[] T000718_A125SubCategoriaDescripcion ;
      private String[] T000719_A41ClinicaCodigo ;
      private String[] T000719_A27CategoriaCodigo ;
      private String[] T000719_A124SubCategoriaCodigo ;
      private String[] T00073_A41ClinicaCodigo ;
      private String[] T00073_A27CategoriaCodigo ;
      private String[] T00073_A124SubCategoriaCodigo ;
      private String[] T00073_A125SubCategoriaDescripcion ;
      private String[] T00072_A41ClinicaCodigo ;
      private String[] T00072_A27CategoriaCodigo ;
      private String[] T00072_A124SubCategoriaCodigo ;
      private String[] T00072_A125SubCategoriaDescripcion ;
      private String[] T000723_A41ClinicaCodigo ;
      private String[] T000723_A30ArticuloCodigo ;
      private String[] T000724_A41ClinicaCodigo ;
      private String[] T000724_A27CategoriaCodigo ;
      private String[] T000724_A124SubCategoriaCodigo ;
      private String[] T000725_A41ClinicaCodigo ;
      private String[] T00074_A27CategoriaCodigo ;
      private String[] T00074_A28CategoriaDescripcion ;
      private short[] T00074_A29CategoriaEstado ;
      private String[] T00074_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros6 ;
   }

   public class categoria__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[23])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00074 ;
          prmT00074 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000712 ;
          prmT000712 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000713 ;
          prmT000713 = new Object[] {
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@CategoriaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000714 ;
          prmT000714 = new Object[] {
          new Object[] {"@CategoriaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@CategoriaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000715 ;
          prmT000715 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000716 ;
          prmT000716 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000717 ;
          prmT000717 = new Object[] {
          } ;
          Object[] prmT000718 ;
          prmT000718 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000719 ;
          prmT000719 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000720 ;
          prmT000720 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaDescripcion",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmT000721 ;
          prmT000721 = new Object[] {
          new Object[] {"@SubCategoriaDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000722 ;
          prmT000722 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000723 ;
          prmT000723 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@SubCategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000724 ;
          prmT000724 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CategoriaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000725 ;
          prmT000725 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00072", "SELECT [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [SubCategoriaDescripcion] FROM [SubCategoria] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1,0,true,false )
             ,new CursorDef("T00073", "SELECT [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [SubCategoriaDescripcion] FROM [SubCategoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1,0,true,false )
             ,new CursorDef("T00074", "SELECT [CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado], [ClinicaCodigo] FROM [Categoria] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,1,0,true,false )
             ,new CursorDef("T00075", "SELECT [CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado], [ClinicaCodigo] FROM [Categoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1,0,true,false )
             ,new CursorDef("T00076", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1,0,true,false )
             ,new CursorDef("T00077", "SELECT TM1.[CategoriaCodigo], TM1.[CategoriaDescripcion], TM1.[CategoriaEstado], TM1.[ClinicaCodigo] FROM [Categoria] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CategoriaCodigo] = @CategoriaCodigo ORDER BY TM1.[ClinicaCodigo], TM1.[CategoriaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,100,0,true,false )
             ,new CursorDef("T00078", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00078,1,0,true,false )
             ,new CursorDef("T00079", "SELECT [ClinicaCodigo], [CategoriaCodigo] FROM [Categoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00079,1,0,true,false )
             ,new CursorDef("T000710", "SELECT TOP 1 [ClinicaCodigo], [CategoriaCodigo] FROM [Categoria] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CategoriaCodigo] > @CategoriaCodigo) ORDER BY [ClinicaCodigo], [CategoriaCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000710,1,0,true,true )
             ,new CursorDef("T000711", "SELECT TOP 1 [ClinicaCodigo], [CategoriaCodigo] FROM [Categoria] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CategoriaCodigo] < @CategoriaCodigo) ORDER BY [ClinicaCodigo] DESC, [CategoriaCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000711,1,0,true,true )
             ,new CursorDef("T000712", "SELECT [CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado], [ClinicaCodigo] FROM [Categoria] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000712,1,0,true,false )
             ,new CursorDef("T000713", "INSERT INTO [Categoria] ([CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado], [ClinicaCodigo]) VALUES (@CategoriaCodigo, @CategoriaDescripcion, @CategoriaEstado, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT000713)
             ,new CursorDef("T000714", "UPDATE [Categoria] SET [CategoriaDescripcion]=@CategoriaDescripcion, [CategoriaEstado]=@CategoriaEstado  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo", GxErrorMask.GX_NOMASK,prmT000714)
             ,new CursorDef("T000715", "DELETE FROM [Categoria]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo", GxErrorMask.GX_NOMASK,prmT000715)
             ,new CursorDef("T000716", "SELECT TOP 1 [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo] FROM [SubCategoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000716,1,0,true,true )
             ,new CursorDef("T000717", "SELECT [ClinicaCodigo], [CategoriaCodigo] FROM [Categoria] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CategoriaCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000717,100,0,true,false )
             ,new CursorDef("T000718", "SELECT [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [SubCategoriaDescripcion] FROM [SubCategoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CategoriaCodigo] = @CategoriaCodigo and [SubCategoriaCodigo] = @SubCategoriaCodigo ORDER BY [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000718,11,0,true,false )
             ,new CursorDef("T000719", "SELECT [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo] FROM [SubCategoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000719,1,0,true,false )
             ,new CursorDef("T000720", "INSERT INTO [SubCategoria] ([ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [SubCategoriaDescripcion]) VALUES (@ClinicaCodigo, @CategoriaCodigo, @SubCategoriaCodigo, @SubCategoriaDescripcion)", GxErrorMask.GX_NOMASK,prmT000720)
             ,new CursorDef("T000721", "UPDATE [SubCategoria] SET [SubCategoriaDescripcion]=@SubCategoriaDescripcion  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo", GxErrorMask.GX_NOMASK,prmT000721)
             ,new CursorDef("T000722", "DELETE FROM [SubCategoria]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo", GxErrorMask.GX_NOMASK,prmT000722)
             ,new CursorDef("T000723", "SELECT TOP 1 [ClinicaCodigo], [ArticuloCodigo] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CategoriaCodigo] = @CategoriaCodigo AND [SubCategoriaCodigo] = @SubCategoriaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000723,1,0,true,true )
             ,new CursorDef("T000724", "SELECT [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo] FROM [SubCategoria] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CategoriaCodigo] = @CategoriaCodigo ORDER BY [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000724,11,0,true,false )
             ,new CursorDef("T000725", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000725,1,0,true,false )
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
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 23 :
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
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
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
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
