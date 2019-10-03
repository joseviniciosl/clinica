/*
               File: Menu
        Description: Menús y opciones
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:10.74
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
   public class menu : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridmenu_opcion") == 0 )
         {
            nRC_Gridmenu_opcion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_55_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_55_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridmenu_opcion_newrow( nRC_Gridmenu_opcion, nGXsfl_55_idx, sGXsfl_55_idx) ;
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
         cmbMenuEstado.Name = "MENUESTADO" ;
         cmbMenuEstado.WebTags = "" ;
         cmbMenuEstado.addItem("0", "De baja", 0);
         cmbMenuEstado.addItem("1", "Activo", 0);
         if ( ( cmbMenuEstado.ItemCount > 0 ) && (0==A10MenuEstado) )
         {
            A10MenuEstado = (short)(NumberUtil.Val( cmbMenuEstado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10MenuEstado", StringUtil.Str( (decimal)(A10MenuEstado), 1, 0));
         }
         GXCCtl = "OPCIONESTADO_" + sGXsfl_55_idx ;
         cmbOpcionEstado.Name = GXCCtl ;
         cmbOpcionEstado.WebTags = "" ;
         cmbOpcionEstado.addItem("0", "De baja", 0);
         cmbOpcionEstado.addItem("1", "Activo", 0);
         if ( ( cmbOpcionEstado.ItemCount > 0 ) && (0==A14OpcionEstado) )
         {
            A14OpcionEstado = (short)(NumberUtil.Val( cmbOpcionEstado.getItemValue(1), ".")) ;
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Menús y opciones", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtMenuId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Fantastic");
      }

      public menu( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public menu( IGxContext context )
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
         cmbMenuEstado = new GXCombobox();
         cmbOpcionEstado = new GXCombobox();
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
            wb_table1_2_033( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_033e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_033( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_033( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_033e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Menús y opciones"+"</legend>") ;
            wb_table3_27_033( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_033e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_033e( true) ;
         }
         else
         {
            wb_table1_2_033e( false) ;
         }
      }

      protected void wb_table3_27_033( bool wbgen )
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
            wb_table4_33_033( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_033e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Menu.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_033e( true) ;
         }
         else
         {
            wb_table3_27_033e( false) ;
         }
      }

      protected void wb_table4_33_033( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockmenuid_Internalname, "Id", "", "", lblTextblockmenuid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Menu.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMenuId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8MenuId), 9, 0, ".", "")), ((edtMenuId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8MenuId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A8MenuId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(38);\"", "", "", "", "", edtMenuId_Jsonclick, 0, ClassString, StyleString, "", 1, edtMenuId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Menu.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmenudescripcion_Internalname, "Menú", "", "", lblTextblockmenudescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Menu.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMenuDescripcion_Internalname, StringUtil.RTrim( A9MenuDescripcion), StringUtil.RTrim( context.localUtil.Format( A9MenuDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtMenuDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtMenuDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Menu.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmenuestado_Internalname, "Estado", "", "", lblTextblockmenuestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Menu.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10MenuEstado", StringUtil.Str( (decimal)(A10MenuEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbMenuEstado, cmbMenuEstado_Internalname, StringUtil.Str( (decimal)(A10MenuEstado), 1, 0), 1, cmbMenuEstado_Jsonclick, 0, "", "int", "", 1, cmbMenuEstado.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", true, "HLP_Menu.htm");
            cmbMenuEstado.CurrentValue = StringUtil.Str( (decimal)(A10MenuEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMenuEstado_Internalname, "Values", (String)(cmbMenuEstado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_51_033( true) ;
         }
         return  ;
      }

      protected void wb_table5_51_033e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridmenu_opcionContainer.AddObjectProperty("GridName", "Gridmenu_opcion");
            Gridmenu_opcionContainer.AddObjectProperty("Class", "Grid");
            Gridmenu_opcionContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridmenu_opcionContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridmenu_opcionContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmenu_opcion_Backcolorstyle), 1, 0, ".", "")));
            Gridmenu_opcionContainer.AddObjectProperty("CmpContext", "");
            Gridmenu_opcionContainer.AddObjectProperty("InMasterPage", "false");
            Gridmenu_opcionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmenu_opcionColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11OpcionId), 9, 0, ".", "")));
            Gridmenu_opcionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionId_Enabled), 5, 0, ".", "")));
            Gridmenu_opcionContainer.AddColumnProperties(Gridmenu_opcionColumn);
            Gridmenu_opcionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmenu_opcionColumn.AddObjectProperty("Value", StringUtil.RTrim( A12OpcionDescripcion));
            Gridmenu_opcionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionDescripcion_Enabled), 5, 0, ".", "")));
            Gridmenu_opcionContainer.AddColumnProperties(Gridmenu_opcionColumn);
            Gridmenu_opcionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmenu_opcionColumn.AddObjectProperty("Value", StringUtil.RTrim( A13OpcionObjeto));
            Gridmenu_opcionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionObjeto_Enabled), 5, 0, ".", "")));
            Gridmenu_opcionContainer.AddColumnProperties(Gridmenu_opcionColumn);
            Gridmenu_opcionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridmenu_opcionColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14OpcionEstado), 1, 0, ".", "")));
            Gridmenu_opcionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbOpcionEstado.Enabled), 5, 0, ".", "")));
            Gridmenu_opcionContainer.AddColumnProperties(Gridmenu_opcionColumn);
            Gridmenu_opcionContainer.AddObjectProperty("Allowselection", "false");
            Gridmenu_opcionContainer.AddObjectProperty("Allowcollapsing", ((subGridmenu_opcion_Allowcollapsing==1) ? "true" : "false"));
            Gridmenu_opcionContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridmenu_opcion_Collapsed), 9, 0, ".", "")));
            nGXsfl_55_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount4 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_4 = 1 ;
                  ScanStart034( ) ;
                  while ( RcdFound4 != 0 )
                  {
                     init_level_properties4( ) ;
                     getByPrimaryKey034( ) ;
                     AddRow034( ) ;
                     ScanNext034( ) ;
                  }
                  ScanEnd034( ) ;
                  nBlankRcdCount4 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal034( ) ;
               standaloneModal034( ) ;
               sMode4 = Gx_mode ;
               while ( nGXsfl_55_idx < nRC_Gridmenu_opcion )
               {
                  ReadRow034( ) ;
                  edtOpcionId_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONID_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
                  edtOpcionDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONDESCRIPCION_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
                  edtOpcionObjeto_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONOBJETO_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
                  cmbOpcionEstado.Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONESTADO_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_4 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal034( ) ;
                  }
                  SendRow034( ) ;
               }
               Gx_mode = sMode4 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount4 = 5 ;
               nRcdExists_4 = 1 ;
               ScanStart034( ) ;
               while ( RcdFound4 != 0 )
               {
                  init_level_properties4( ) ;
                  getByPrimaryKey034( ) ;
                  standaloneNotModal034( ) ;
                  standaloneModal034( ) ;
                  AddRow034( ) ;
                  ScanNext034( ) ;
               }
               ScanEnd034( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode4 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll034( ) ;
            init_level_properties4( ) ;
            standaloneNotModal034( ) ;
            standaloneModal034( ) ;
            nRcdExists_4 = 0 ;
            nIsMod_4 = 0 ;
            nBlankRcdCount4 = (short)(nBlankRcdUsr4+nBlankRcdCount4) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount4 > 0 )
            {
               AddRow034( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtOpcionId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount4 = (short)(nBlankRcdCount4-1) ;
            }
            Gx_mode = sMode4 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridmenu_opcionContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridmenu_opcion", (Object)(Gridmenu_opcionContainer));
            GxWebStd.gx_hidden_field( context, "Gridmenu_opcionContainerData", Gridmenu_opcionContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridmenu_opcionContainerData"+"V", Gridmenu_opcionContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridmenu_opcionContainerData"+"V"+"\" value='"+Gridmenu_opcionContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_033e( true) ;
         }
         else
         {
            wb_table4_33_033e( false) ;
         }
      }

      protected void wb_table5_51_033( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitleopcion_Internalname, "Opciones", "", "", lblTitleopcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Menu.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_51_033e( true) ;
         }
         else
         {
            wb_table5_51_033e( false) ;
         }
      }

      protected void wb_table2_5_033( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MENUID"+"'), id:'"+"MENUID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MENUID"+"'), id:'"+"MENUID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Menu.htm");
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
            wb_table2_5_033e( true) ;
         }
         else
         {
            wb_table2_5_033e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtMenuId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtMenuId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "MENUID");
                  AnyError = 1 ;
                  GX_FocusControl = edtMenuId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A8MenuId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
               }
               else
               {
                  A8MenuId = (int)(context.localUtil.CToN( cgiGet( edtMenuId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
               }
               A9MenuDescripcion = cgiGet( edtMenuDescripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
               cmbMenuEstado.Name = cmbMenuEstado_Internalname ;
               cmbMenuEstado.CurrentValue = cgiGet( cmbMenuEstado_Internalname) ;
               A10MenuEstado = (short)(NumberUtil.Val( cgiGet( cmbMenuEstado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10MenuEstado", StringUtil.Str( (decimal)(A10MenuEstado), 1, 0));
               /* Read saved values. */
               Z8MenuId = (int)(context.localUtil.CToN( cgiGet( "Z8MenuId"), ".", ",")) ;
               Z9MenuDescripcion = cgiGet( "Z9MenuDescripcion") ;
               Z10MenuEstado = (short)(context.localUtil.CToN( cgiGet( "Z10MenuEstado"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridmenu_opcion = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridmenu_opcion"), ".", ",")) ;
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
                  A8MenuId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
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
               InitAll033( ) ;
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
         DisableAttributes033( ) ;
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

      protected void CONFIRM_034( )
      {
         nGXsfl_55_idx = 0 ;
         while ( nGXsfl_55_idx < nRC_Gridmenu_opcion )
         {
            ReadRow034( ) ;
            if ( ( nRcdExists_4 != 0 ) || ( nIsMod_4 != 0 ) )
            {
               GetKey034( ) ;
               if ( ( nRcdExists_4 == 0 ) && ( nRcdDeleted_4 == 0 ) )
               {
                  if ( RcdFound4 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate034( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable034( ) ;
                        CloseExtendedTableCursors034( ) ;
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
                     GX_FocusControl = edtOpcionId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound4 != 0 )
                  {
                     if ( nRcdDeleted_4 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey034( ) ;
                        Load034( ) ;
                        BeforeValidate034( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls034( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_4 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate034( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable034( ) ;
                              CloseExtendedTableCursors034( ) ;
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
                     if ( nRcdDeleted_4 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtOpcionId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtOpcionId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11OpcionId), 9, 0, ".", ""))) ;
            ChangePostValue( edtOpcionDescripcion_Internalname, StringUtil.RTrim( A12OpcionDescripcion)) ;
            ChangePostValue( edtOpcionObjeto_Internalname, StringUtil.RTrim( A13OpcionObjeto)) ;
            ChangePostValue( cmbOpcionEstado_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14OpcionEstado), 1, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11OpcionId_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11OpcionId), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z12OpcionDescripcion_"+sGXsfl_55_idx, StringUtil.RTrim( Z12OpcionDescripcion)) ;
            ChangePostValue( "ZT_"+"Z13OpcionObjeto_"+sGXsfl_55_idx, StringUtil.RTrim( Z13OpcionObjeto)) ;
            ChangePostValue( "ZT_"+"Z14OpcionEstado_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14OpcionEstado), 1, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_4_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_4_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_4_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ".", ""))) ;
            if ( nIsMod_4 != 0 )
            {
               ChangePostValue( "OPCIONID_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONDESCRIPCION_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionDescripcion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONOBJETO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionObjeto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONESTADO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbOpcionEstado.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption030( )
      {
      }

      protected void ZM033( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z9MenuDescripcion = T00035_A9MenuDescripcion[0] ;
               Z10MenuEstado = T00035_A10MenuEstado[0] ;
            }
            else
            {
               Z9MenuDescripcion = A9MenuDescripcion ;
               Z10MenuEstado = A10MenuEstado ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z8MenuId = A8MenuId ;
            Z9MenuDescripcion = A9MenuDescripcion ;
            Z10MenuEstado = A10MenuEstado ;
         }
      }

      protected void standaloneNotModal( )
      {
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

      protected void Load033( )
      {
         /* Using cursor T00036 */
         pr_default.execute(4, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound3 = 1 ;
            A9MenuDescripcion = T00036_A9MenuDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
            A10MenuEstado = T00036_A10MenuEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10MenuEstado", StringUtil.Str( (decimal)(A10MenuEstado), 1, 0));
            ZM033( -1) ;
         }
         pr_default.close(4);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
      }

      protected void CheckExtendedTable033( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors033( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey033( )
      {
         /* Using cursor T00037 */
         pr_default.execute(5, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound3 = 1 ;
         }
         else
         {
            RcdFound3 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00035 */
         pr_default.execute(3, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM033( 1) ;
            RcdFound3 = 1 ;
            A8MenuId = T00035_A8MenuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
            A9MenuDescripcion = T00035_A9MenuDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
            A10MenuEstado = T00035_A10MenuEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10MenuEstado", StringUtil.Str( (decimal)(A10MenuEstado), 1, 0));
            Z8MenuId = A8MenuId ;
            sMode3 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load033( ) ;
            Gx_mode = sMode3 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound3 = 0 ;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode3 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( RcdFound3 == 0 )
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
         RcdFound3 = 0 ;
         /* Using cursor T00038 */
         pr_default.execute(6, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00038_A8MenuId[0] < A8MenuId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00038_A8MenuId[0] > A8MenuId ) ) )
            {
               A8MenuId = T00038_A8MenuId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
               RcdFound3 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound3 = 0 ;
         /* Using cursor T00039 */
         pr_default.execute(7, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00039_A8MenuId[0] > A8MenuId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00039_A8MenuId[0] < A8MenuId ) ) )
            {
               A8MenuId = T00039_A8MenuId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
               RcdFound3 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey033( ) ;
         if ( RcdFound3 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "MENUID");
               AnyError = 1 ;
               GX_FocusControl = edtMenuId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A8MenuId != Z8MenuId )
            {
               A8MenuId = Z8MenuId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "MENUID");
               AnyError = 1 ;
               GX_FocusControl = edtMenuId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtMenuId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update033( ) ;
               GX_FocusControl = edtMenuId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A8MenuId != Z8MenuId )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtMenuId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert033( ) ;
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
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "MENUID");
                  AnyError = 1 ;
                  GX_FocusControl = edtMenuId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtMenuId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert033( ) ;
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
         if ( A8MenuId != Z8MenuId )
         {
            A8MenuId = Z8MenuId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "MENUID");
            AnyError = 1 ;
            GX_FocusControl = edtMenuId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtMenuId_Internalname ;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "MENUID");
            AnyError = 1 ;
         }
         GX_FocusControl = edtMenuDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMenuDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd033( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMenuDescripcion_Internalname ;
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
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMenuDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound3 != 0 )
            {
               ScanNext033( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtMenuDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd033( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000310 */
            pr_default.execute(8, new Object[] {A8MenuId});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Menu"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z9MenuDescripcion, T000310_A9MenuDescripcion[0]) != 0 ) || ( Z10MenuEstado != T000310_A10MenuEstado[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Menu"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM033( 0) ;
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000311 */
                     pr_default.execute(9, new Object[] {A8MenuId, A9MenuDescripcion, A10MenuEstado});
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
                           ProcessLevel033( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption030( ) ;
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
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000312 */
                     pr_default.execute(10, new Object[] {A9MenuDescripcion, A10MenuEstado, A8MenuId});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Menu"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate033( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel033( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption030( ) ;
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
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls033( ) ;
            AfterConfirm033( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete033( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000313 */
                  pr_default.execute(11, new Object[] {A8MenuId});
                  pr_default.close(11);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound3 == 0 )
                        {
                           InitAll033( ) ;
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
                        ResetCaption030( ) ;
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
         sMode3 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel033( ) ;
         Gx_mode = sMode3 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000314 */
            pr_default.execute(12, new Object[] {A8MenuId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Accesos al sistema"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(12);
            /* Using cursor T000315 */
            pr_default.execute(13, new Object[] {A8MenuId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Opciones"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
         }
      }

      protected void ProcessNestedLevel034( )
      {
         nGXsfl_55_idx = 0 ;
         while ( nGXsfl_55_idx < nRC_Gridmenu_opcion )
         {
            ReadRow034( ) ;
            if ( ( nRcdExists_4 != 0 ) || ( nIsMod_4 != 0 ) )
            {
               standaloneNotModal034( ) ;
               GetKey034( ) ;
               if ( ( nRcdExists_4 == 0 ) && ( nRcdDeleted_4 == 0 ) )
               {
                  if ( RcdFound4 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert034( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtOpcionId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound4 != 0 )
                  {
                     if ( ( nRcdDeleted_4 != 0 ) && ( nRcdExists_4 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete034( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_4 != 0 ) && ( nRcdExists_4 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update034( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_4 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtOpcionId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtOpcionId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11OpcionId), 9, 0, ".", ""))) ;
            ChangePostValue( edtOpcionDescripcion_Internalname, StringUtil.RTrim( A12OpcionDescripcion)) ;
            ChangePostValue( edtOpcionObjeto_Internalname, StringUtil.RTrim( A13OpcionObjeto)) ;
            ChangePostValue( cmbOpcionEstado_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14OpcionEstado), 1, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11OpcionId_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11OpcionId), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z12OpcionDescripcion_"+sGXsfl_55_idx, StringUtil.RTrim( Z12OpcionDescripcion)) ;
            ChangePostValue( "ZT_"+"Z13OpcionObjeto_"+sGXsfl_55_idx, StringUtil.RTrim( Z13OpcionObjeto)) ;
            ChangePostValue( "ZT_"+"Z14OpcionEstado_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14OpcionEstado), 1, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_4_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_4_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_4_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ".", ""))) ;
            if ( nIsMod_4 != 0 )
            {
               ChangePostValue( "OPCIONID_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONDESCRIPCION_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionDescripcion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONOBJETO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionObjeto_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONESTADO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbOpcionEstado.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll034( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_4 = 0 ;
         nIsMod_4 = 0 ;
         nRcdDeleted_4 = 0 ;
      }

      protected void ProcessLevel033( )
      {
         /* Save parent mode. */
         sMode3 = Gx_mode ;
         ProcessNestedLevel034( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode3 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete033( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("Menu");
            if ( AnyError == 0 )
            {
               ConfirmValues030( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("Menu");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart033( )
      {
         /* Using cursor T000316 */
         pr_default.execute(14);
         RcdFound3 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound3 = 1 ;
            A8MenuId = T000316_A8MenuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext033( )
      {
         pr_default.readNext(14);
         RcdFound3 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound3 = 1 ;
            A8MenuId = T000316_A8MenuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
         }
      }

      protected void ScanEnd033( )
      {
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes033( )
      {
         edtMenuId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenuId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenuId_Enabled), 5, 0)));
         edtMenuDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenuDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenuDescripcion_Enabled), 5, 0)));
         cmbMenuEstado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMenuEstado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbMenuEstado.Enabled), 5, 0)));
      }

      protected void ZM034( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z12OpcionDescripcion = T00033_A12OpcionDescripcion[0] ;
               Z13OpcionObjeto = T00033_A13OpcionObjeto[0] ;
               Z14OpcionEstado = T00033_A14OpcionEstado[0] ;
            }
            else
            {
               Z12OpcionDescripcion = A12OpcionDescripcion ;
               Z13OpcionObjeto = A13OpcionObjeto ;
               Z14OpcionEstado = A14OpcionEstado ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z8MenuId = A8MenuId ;
            Z11OpcionId = A11OpcionId ;
            Z12OpcionDescripcion = A12OpcionDescripcion ;
            Z13OpcionObjeto = A13OpcionObjeto ;
            Z14OpcionEstado = A14OpcionEstado ;
         }
      }

      protected void standaloneNotModal034( )
      {
      }

      protected void standaloneModal034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtOpcionId_Enabled = 0 ;
         }
         else
         {
            edtOpcionId_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode4, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode4, "DLT") == 0 ) )
         {
            DisableAttributes034( ) ;
         }
      }

      protected void Load034( )
      {
         /* Using cursor T000317 */
         pr_default.execute(15, new Object[] {A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound4 = 1 ;
            A12OpcionDescripcion = T000317_A12OpcionDescripcion[0] ;
            A13OpcionObjeto = T000317_A13OpcionObjeto[0] ;
            A14OpcionEstado = T000317_A14OpcionEstado[0] ;
            ZM034( -2) ;
         }
         pr_default.close(15);
         OnLoadActions034( ) ;
      }

      protected void OnLoadActions034( )
      {
      }

      protected void CheckExtendedTable034( )
      {
         Gx_BScreen = 1 ;
         standaloneModal034( ) ;
      }

      protected void CloseExtendedTableCursors034( )
      {
      }

      protected void enableDisable034( )
      {
      }

      protected void GetKey034( )
      {
         /* Using cursor T000318 */
         pr_default.execute(16, new Object[] {A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound4 = 1 ;
         }
         else
         {
            RcdFound4 = 0 ;
         }
         pr_default.close(16);
      }

      protected void getByPrimaryKey034( )
      {
         /* Using cursor T00033 */
         pr_default.execute(1, new Object[] {A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM034( 2) ;
            RcdFound4 = 1 ;
            InitializeNonKey034( ) ;
            A11OpcionId = T00033_A11OpcionId[0] ;
            A12OpcionDescripcion = T00033_A12OpcionDescripcion[0] ;
            A13OpcionObjeto = T00033_A13OpcionObjeto[0] ;
            A14OpcionEstado = T00033_A14OpcionEstado[0] ;
            Z8MenuId = A8MenuId ;
            Z11OpcionId = A11OpcionId ;
            sMode4 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal034( ) ;
            Load034( ) ;
            Gx_mode = sMode4 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound4 = 0 ;
            InitializeNonKey034( ) ;
            sMode4 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal034( ) ;
            Gx_mode = sMode4 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00032 */
            pr_default.execute(0, new Object[] {A8MenuId, A11OpcionId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Opcion"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z12OpcionDescripcion, T00032_A12OpcionDescripcion[0]) != 0 ) || ( StringUtil.StrCmp(Z13OpcionObjeto, T00032_A13OpcionObjeto[0]) != 0 ) || ( Z14OpcionEstado != T00032_A14OpcionEstado[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Opcion"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM034( 0) ;
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000319 */
                     pr_default.execute(17, new Object[] {A8MenuId, A11OpcionId, A12OpcionDescripcion, A13OpcionObjeto, A14OpcionEstado});
                     pr_default.close(17);
                     if ( (pr_default.getStatus(17) == 1) )
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
               Load034( ) ;
            }
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void Update034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000320 */
                     pr_default.execute(18, new Object[] {A12OpcionDescripcion, A13OpcionObjeto, A14OpcionEstado, A8MenuId, A11OpcionId});
                     pr_default.close(18);
                     if ( (pr_default.getStatus(18) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Opcion"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate034( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey034( ) ;
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
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void DeferredUpdate034( )
      {
      }

      protected void Delete034( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls034( ) ;
            AfterConfirm034( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete034( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000321 */
                  pr_default.execute(19, new Object[] {A8MenuId, A11OpcionId});
                  pr_default.close(19);
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
         sMode4 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel034( ) ;
         Gx_mode = sMode4 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls034( )
      {
         standaloneModal034( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000322 */
            pr_default.execute(20, new Object[] {A8MenuId, A11OpcionId});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Opcion"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(20);
         }
      }

      protected void EndLevel034( )
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

      protected void ScanStart034( )
      {
         /* Using cursor T000323 */
         pr_default.execute(21, new Object[] {A8MenuId});
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound4 = 1 ;
            A11OpcionId = T000323_A11OpcionId[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext034( )
      {
         pr_default.readNext(21);
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound4 = 1 ;
            A11OpcionId = T000323_A11OpcionId[0] ;
         }
      }

      protected void ScanEnd034( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm034( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert034( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate034( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete034( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete034( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate034( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes034( )
      {
         edtOpcionId_Enabled = 0 ;
         edtOpcionDescripcion_Enabled = 0 ;
         edtOpcionObjeto_Enabled = 0 ;
         cmbOpcionEstado.Enabled = 0 ;
      }

      protected void AddRow034( )
      {
         nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_55_idx ;
         edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_55_idx ;
         edtOpcionObjeto_Internalname = "OPCIONOBJETO_"+sGXsfl_55_idx ;
         cmbOpcionEstado_Internalname = "OPCIONESTADO_"+sGXsfl_55_idx ;
         SendRow034( ) ;
      }

      protected void SendRow034( )
      {
         Gridmenu_opcionRow = GXWebRow.GetNew(context) ;
         if ( subGridmenu_opcion_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridmenu_opcion_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridmenu_opcion_Class, "") != 0 )
            {
               subGridmenu_opcion_Linesclass = subGridmenu_opcion_Class+"Odd" ;
            }
         }
         else if ( subGridmenu_opcion_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridmenu_opcion_Backstyle = 0 ;
            subGridmenu_opcion_Backcolor = subGridmenu_opcion_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmenu_opcionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmenu_opcion_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridmenu_opcion_Class, "") != 0 )
            {
               subGridmenu_opcion_Linesclass = subGridmenu_opcion_Class+"Uniform" ;
            }
         }
         else if ( subGridmenu_opcion_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridmenu_opcion_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridmenu_opcion_Class, "") != 0 )
            {
               subGridmenu_opcion_Linesclass = subGridmenu_opcion_Class+"Odd" ;
            }
            subGridmenu_opcion_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmenu_opcionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmenu_opcion_Backcolor), 9, 0)));
         }
         else if ( subGridmenu_opcion_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridmenu_opcion_Backstyle = 1 ;
            if ( ((int)(nGXsfl_55_idx) % (2)) == 0 )
            {
               subGridmenu_opcion_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmenu_opcionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmenu_opcion_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridmenu_opcion_Class, "") != 0 )
               {
                  subGridmenu_opcion_Linesclass = subGridmenu_opcion_Class+"Even" ;
               }
            }
            else
            {
               subGridmenu_opcion_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridmenu_opcionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridmenu_opcion_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridmenu_opcion_Class, "") != 0 )
               {
                  subGridmenu_opcion_Linesclass = subGridmenu_opcion_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_4_" + sGXsfl_55_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_55_idx + "',55)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmenu_opcionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOpcionId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11OpcionId), 9, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A11OpcionId), "ZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(56);\"",(String)"",(String)"",(String)"",(String)"",(String)edtOpcionId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtOpcionId_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)55,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_4_" + sGXsfl_55_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_55_idx + "',55)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmenu_opcionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOpcionDescripcion_Internalname,StringUtil.RTrim( A12OpcionDescripcion),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(57);\"",(String)"",(String)"",(String)"",(String)"",(String)edtOpcionDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtOpcionDescripcion_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)55,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_4_" + sGXsfl_55_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_55_idx + "',55)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridmenu_opcionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOpcionObjeto_Internalname,StringUtil.RTrim( A13OpcionObjeto),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"",(String)"",(String)"",(String)"",(String)"",(String)edtOpcionObjeto_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtOpcionObjeto_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)1000,(short)0,(short)0,(short)55,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         ClassString = "Attribute" ;
         StyleString = "" ;
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_4_" + sGXsfl_55_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_55_idx + "',55)\"" ;
         if ( ( nGXsfl_55_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "OPCIONESTADO_" + sGXsfl_55_idx ;
            cmbOpcionEstado.Name = GXCCtl ;
            cmbOpcionEstado.WebTags = "" ;
            cmbOpcionEstado.addItem("0", "De baja", 0);
            cmbOpcionEstado.addItem("1", "Activo", 0);
            if ( ( cmbOpcionEstado.ItemCount > 0 ) && (0==A14OpcionEstado) )
            {
               A14OpcionEstado = (short)(NumberUtil.Val( cmbOpcionEstado.getItemValue(1), ".")) ;
            }
         }
         /* ComboBox */
         Gridmenu_opcionRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbOpcionEstado,(String)cmbOpcionEstado_Internalname,StringUtil.Str( (decimal)(A14OpcionEstado), 1, 0),(short)1,(String)cmbOpcionEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,cmbOpcionEstado.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(59);\"",(String)"",(bool)true});
         cmbOpcionEstado.CurrentValue = StringUtil.Str( (decimal)(A14OpcionEstado), 1, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOpcionEstado_Internalname, "Values", (String)(cmbOpcionEstado.ToJavascriptSource()));
         context.httpAjaxContext.ajax_sending_grid_row(Gridmenu_opcionRow);
         GXCCtl = "Z11OpcionId_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11OpcionId), 9, 0, ".", "")));
         GXCCtl = "Z12OpcionDescripcion_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z12OpcionDescripcion));
         GXCCtl = "Z13OpcionObjeto_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z13OpcionObjeto));
         GXCCtl = "Z14OpcionEstado_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14OpcionEstado), 1, 0, ".", "")));
         GXCCtl = "nRcdDeleted_4_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_4), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_4_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_4), 4, 0, ".", "")));
         GXCCtl = "nIsMod_4_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_4), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OPCIONID_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OPCIONDESCRIPCION_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionDescripcion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OPCIONOBJETO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionObjeto_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OPCIONESTADO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbOpcionEstado.Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridmenu_opcionContainer.AddRow(Gridmenu_opcionRow);
      }

      protected void ReadRow034( )
      {
         nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_55_idx ;
         edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_55_idx ;
         edtOpcionObjeto_Internalname = "OPCIONOBJETO_"+sGXsfl_55_idx ;
         cmbOpcionEstado_Internalname = "OPCIONESTADO_"+sGXsfl_55_idx ;
         edtOpcionId_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONID_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
         edtOpcionDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONDESCRIPCION_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
         edtOpcionObjeto_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONOBJETO_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
         cmbOpcionEstado.Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONESTADO_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtOpcionId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOpcionId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "OPCIONID");
            AnyError = 1 ;
            GX_FocusControl = edtOpcionId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A11OpcionId = 0 ;
         }
         else
         {
            A11OpcionId = (int)(context.localUtil.CToN( cgiGet( edtOpcionId_Internalname), ".", ",")) ;
         }
         A12OpcionDescripcion = cgiGet( edtOpcionDescripcion_Internalname) ;
         A13OpcionObjeto = cgiGet( edtOpcionObjeto_Internalname) ;
         cmbOpcionEstado.Name = cmbOpcionEstado_Internalname ;
         cmbOpcionEstado.CurrentValue = cgiGet( cmbOpcionEstado_Internalname) ;
         A14OpcionEstado = (short)(NumberUtil.Val( cgiGet( cmbOpcionEstado_Internalname), ".")) ;
         GXCCtl = "Z11OpcionId_" + sGXsfl_55_idx ;
         Z11OpcionId = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z12OpcionDescripcion_" + sGXsfl_55_idx ;
         Z12OpcionDescripcion = cgiGet( GXCCtl) ;
         GXCCtl = "Z13OpcionObjeto_" + sGXsfl_55_idx ;
         Z13OpcionObjeto = cgiGet( GXCCtl) ;
         GXCCtl = "Z14OpcionEstado_" + sGXsfl_55_idx ;
         Z14OpcionEstado = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdDeleted_4_" + sGXsfl_55_idx ;
         nRcdDeleted_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_4_" + sGXsfl_55_idx ;
         nRcdExists_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_4_" + sGXsfl_55_idx ;
         nIsMod_4 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtOpcionId_Enabled = edtOpcionId_Enabled ;
      }

      protected void ConfirmValues030( )
      {
         nGXsfl_55_idx = 0 ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_55_idx ;
         edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_55_idx ;
         edtOpcionObjeto_Internalname = "OPCIONOBJETO_"+sGXsfl_55_idx ;
         cmbOpcionEstado_Internalname = "OPCIONESTADO_"+sGXsfl_55_idx ;
         while ( nGXsfl_55_idx < nRC_Gridmenu_opcion )
         {
            nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
            sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
            edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_55_idx ;
            edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_55_idx ;
            edtOpcionObjeto_Internalname = "OPCIONOBJETO_"+sGXsfl_55_idx ;
            cmbOpcionEstado_Internalname = "OPCIONESTADO_"+sGXsfl_55_idx ;
            ChangePostValue( "Z11OpcionId_"+sGXsfl_55_idx, cgiGet( "ZT_"+"Z11OpcionId_"+sGXsfl_55_idx)) ;
            DeletePostValue( "ZT_"+"Z11OpcionId_"+sGXsfl_55_idx) ;
            ChangePostValue( "Z12OpcionDescripcion_"+sGXsfl_55_idx, cgiGet( "ZT_"+"Z12OpcionDescripcion_"+sGXsfl_55_idx)) ;
            DeletePostValue( "ZT_"+"Z12OpcionDescripcion_"+sGXsfl_55_idx) ;
            ChangePostValue( "Z13OpcionObjeto_"+sGXsfl_55_idx, cgiGet( "ZT_"+"Z13OpcionObjeto_"+sGXsfl_55_idx)) ;
            DeletePostValue( "ZT_"+"Z13OpcionObjeto_"+sGXsfl_55_idx) ;
            ChangePostValue( "Z14OpcionEstado_"+sGXsfl_55_idx, cgiGet( "ZT_"+"Z14OpcionEstado_"+sGXsfl_55_idx)) ;
            DeletePostValue( "ZT_"+"Z14OpcionEstado_"+sGXsfl_55_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("menu.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z8MenuId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8MenuId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z9MenuDescripcion", StringUtil.RTrim( Z9MenuDescripcion));
         GxWebStd.gx_hidden_field( context, "Z10MenuEstado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10MenuEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridmenu_opcion", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_55_idx), 4, 0, ".", "")));
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
         return "Menu" ;
      }

      public override String GetPgmdesc( )
      {
         return "Menús y opciones" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("menu.aspx")  ;
      }

      protected void InitializeNonKey033( )
      {
         A9MenuDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
         A10MenuEstado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10MenuEstado", StringUtil.Str( (decimal)(A10MenuEstado), 1, 0));
      }

      protected void InitAll033( )
      {
         A8MenuId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
         InitializeNonKey033( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey034( )
      {
         A12OpcionDescripcion = "" ;
         A13OpcionObjeto = "" ;
         A14OpcionEstado = 0 ;
      }

      protected void InitAll034( )
      {
         A11OpcionId = 0 ;
         InitializeNonKey034( ) ;
      }

      protected void StandaloneModalInsert034( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1541271");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("menu.js", "?1541271");
         /* End function include_jscripts */
      }

      protected void init_level_properties4( )
      {
         edtOpcionId_Enabled = defedtOpcionId_Enabled ;
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
         lblTextblockmenuid_Internalname = "TEXTBLOCKMENUID" ;
         edtMenuId_Internalname = "MENUID" ;
         lblTextblockmenudescripcion_Internalname = "TEXTBLOCKMENUDESCRIPCION" ;
         edtMenuDescripcion_Internalname = "MENUDESCRIPCION" ;
         lblTextblockmenuestado_Internalname = "TEXTBLOCKMENUESTADO" ;
         cmbMenuEstado_Internalname = "MENUESTADO" ;
         lblTitleopcion_Internalname = "TITLEOPCION" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         subGridmenu_opcion_Internalname = "GRIDMENU_OPCION" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Menús y opciones" ;
         cmbOpcionEstado_Jsonclick = "" ;
         edtOpcionObjeto_Jsonclick = "" ;
         edtOpcionDescripcion_Jsonclick = "" ;
         edtOpcionId_Jsonclick = "" ;
         subGridmenu_opcion_Class = "Grid" ;
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
         subGridmenu_opcion_Allowcollapsing = 0 ;
         cmbOpcionEstado.Enabled = 1 ;
         edtOpcionObjeto_Enabled = 1 ;
         edtOpcionDescripcion_Enabled = 1 ;
         edtOpcionId_Enabled = 1 ;
         subGridmenu_opcion_Backcolorstyle = 2 ;
         cmbMenuEstado_Jsonclick = "" ;
         cmbMenuEstado.Enabled = 1 ;
         edtMenuDescripcion_Jsonclick = "" ;
         edtMenuDescripcion_Enabled = 1 ;
         edtMenuId_Jsonclick = "" ;
         edtMenuId_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridmenu_opcion_newrow( short nRC_Gridmenu_opcion ,
                                                 short nGXsfl_55_idx ,
                                                 String sGXsfl_55_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_55_idx ;
         edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_55_idx ;
         edtOpcionObjeto_Internalname = "OPCIONOBJETO_"+sGXsfl_55_idx ;
         cmbOpcionEstado_Internalname = "OPCIONESTADO_"+sGXsfl_55_idx ;
         while ( nGXsfl_55_idx <= nRC_Gridmenu_opcion )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal034( ) ;
            standaloneModal034( ) ;
            cmbMenuEstado.Name = "MENUESTADO" ;
            cmbMenuEstado.WebTags = "" ;
            cmbMenuEstado.addItem("0", "De baja", 0);
            cmbMenuEstado.addItem("1", "Activo", 0);
            if ( ( cmbMenuEstado.ItemCount > 0 ) && (0==A10MenuEstado) )
            {
               A10MenuEstado = (short)(NumberUtil.Val( cmbMenuEstado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10MenuEstado", StringUtil.Str( (decimal)(A10MenuEstado), 1, 0));
            }
            GXCCtl = "OPCIONESTADO_" + sGXsfl_55_idx ;
            cmbOpcionEstado.Name = GXCCtl ;
            cmbOpcionEstado.WebTags = "" ;
            cmbOpcionEstado.addItem("0", "De baja", 0);
            cmbOpcionEstado.addItem("1", "Activo", 0);
            if ( ( cmbOpcionEstado.ItemCount > 0 ) && (0==A14OpcionEstado) )
            {
               A14OpcionEstado = (short)(NumberUtil.Val( cmbOpcionEstado.getItemValue(1), ".")) ;
            }
            dynload_actions( ) ;
            SendRow034( ) ;
            nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
            sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
            edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_55_idx ;
            edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_55_idx ;
            edtOpcionObjeto_Internalname = "OPCIONOBJETO_"+sGXsfl_55_idx ;
            cmbOpcionEstado_Internalname = "OPCIONESTADO_"+sGXsfl_55_idx ;
         }
         context.GX_webresponse.AddString(Gridmenu_opcionContainer.ToJavascriptSource());
         /* End function gxnrGridmenu_opcion_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtMenuDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Menuid( int GX_Parm1 ,
                                String GX_Parm2 ,
                                GXCombobox cmbGX_Parm3 )
      {
         A8MenuId = GX_Parm1 ;
         A9MenuDescripcion = GX_Parm2 ;
         cmbMenuEstado = cmbGX_Parm3 ;
         A10MenuEstado = (short)(NumberUtil.Val( cmbMenuEstado.CurrentValue, ".")) ;
         cmbMenuEstado.CurrentValue = StringUtil.Str( (decimal)(A10MenuEstado), 1, 0) ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A9MenuDescripcion)));
         cmbMenuEstado.CurrentValue = StringUtil.Str( (decimal)(A10MenuEstado), 1, 0) ;
         isValidOutput.Add((Object)(cmbMenuEstado));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8MenuId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z9MenuDescripcion)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10MenuEstado), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(Gridmenu_opcionContainer));
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
         pr_default.close(14);
         pr_default.close(7);
         pr_default.close(6);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXKey = "" ;
         GXCCtl = "" ;
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
         lblTextblockmenuid_Jsonclick = "" ;
         lblTextblockmenudescripcion_Jsonclick = "" ;
         A9MenuDescripcion = "" ;
         lblTextblockmenuestado_Jsonclick = "" ;
         Gridmenu_opcionContainer = new GXWebGrid( context);
         Gridmenu_opcionColumn = new GXWebColumn();
         A12OpcionDescripcion = "" ;
         A13OpcionObjeto = "" ;
         Gx_mode = "" ;
         sMode4 = "" ;
         edtOpcionId_Internalname = "" ;
         lblTitleopcion_Jsonclick = "" ;
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
         Z9MenuDescripcion = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtOpcionDescripcion_Internalname = "" ;
         edtOpcionObjeto_Internalname = "" ;
         cmbOpcionEstado_Internalname = "" ;
         Z12OpcionDescripcion = "" ;
         Z13OpcionObjeto = "" ;
         T00036_A8MenuId = new int[1] ;
         T00036_A9MenuDescripcion = new String[] {""} ;
         T00036_A10MenuEstado = new short[1] ;
         T00037_A8MenuId = new int[1] ;
         T00035_A8MenuId = new int[1] ;
         T00035_A9MenuDescripcion = new String[] {""} ;
         T00035_A10MenuEstado = new short[1] ;
         sMode3 = "" ;
         T00038_A8MenuId = new int[1] ;
         T00039_A8MenuId = new int[1] ;
         T000310_A8MenuId = new int[1] ;
         T000310_A9MenuDescripcion = new String[] {""} ;
         T000310_A10MenuEstado = new short[1] ;
         T000314_A1GrupoCodigo = new String[] {""} ;
         T000314_A8MenuId = new int[1] ;
         T000315_A8MenuId = new int[1] ;
         T000315_A11OpcionId = new int[1] ;
         T000316_A8MenuId = new int[1] ;
         T000317_A8MenuId = new int[1] ;
         T000317_A11OpcionId = new int[1] ;
         T000317_A12OpcionDescripcion = new String[] {""} ;
         T000317_A13OpcionObjeto = new String[] {""} ;
         T000317_A14OpcionEstado = new short[1] ;
         T000318_A8MenuId = new int[1] ;
         T000318_A11OpcionId = new int[1] ;
         T00033_A8MenuId = new int[1] ;
         T00033_A11OpcionId = new int[1] ;
         T00033_A12OpcionDescripcion = new String[] {""} ;
         T00033_A13OpcionObjeto = new String[] {""} ;
         T00033_A14OpcionEstado = new short[1] ;
         T00032_A8MenuId = new int[1] ;
         T00032_A11OpcionId = new int[1] ;
         T00032_A12OpcionDescripcion = new String[] {""} ;
         T00032_A13OpcionObjeto = new String[] {""} ;
         T00032_A14OpcionEstado = new short[1] ;
         T000322_A1GrupoCodigo = new String[] {""} ;
         T000322_A8MenuId = new int[1] ;
         T000322_A11OpcionId = new int[1] ;
         T000323_A8MenuId = new int[1] ;
         T000323_A11OpcionId = new int[1] ;
         Gridmenu_opcionRow = new GXWebRow();
         subGridmenu_opcion_Linesclass = "" ;
         ROClassString = "" ;
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
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.menu__default(),
            new Object[][] {
                new Object[] {
               T00032_A8MenuId, T00032_A11OpcionId, T00032_A12OpcionDescripcion, T00032_A13OpcionObjeto, T00032_A14OpcionEstado
               }
               , new Object[] {
               T00033_A8MenuId, T00033_A11OpcionId, T00033_A12OpcionDescripcion, T00033_A13OpcionObjeto, T00033_A14OpcionEstado
               }
               , new Object[] {
               T00034_A8MenuId, T00034_A9MenuDescripcion, T00034_A10MenuEstado
               }
               , new Object[] {
               T00035_A8MenuId, T00035_A9MenuDescripcion, T00035_A10MenuEstado
               }
               , new Object[] {
               T00036_A8MenuId, T00036_A9MenuDescripcion, T00036_A10MenuEstado
               }
               , new Object[] {
               T00037_A8MenuId
               }
               , new Object[] {
               T00038_A8MenuId
               }
               , new Object[] {
               T00039_A8MenuId
               }
               , new Object[] {
               T000310_A8MenuId, T000310_A9MenuDescripcion, T000310_A10MenuEstado
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000314_A1GrupoCodigo, T000314_A8MenuId
               }
               , new Object[] {
               T000315_A8MenuId, T000315_A11OpcionId
               }
               , new Object[] {
               T000316_A8MenuId
               }
               , new Object[] {
               T000317_A8MenuId, T000317_A11OpcionId, T000317_A12OpcionDescripcion, T000317_A13OpcionObjeto, T000317_A14OpcionEstado
               }
               , new Object[] {
               T000318_A8MenuId, T000318_A11OpcionId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000322_A1GrupoCodigo, T000322_A8MenuId, T000322_A11OpcionId
               }
               , new Object[] {
               T000323_A8MenuId, T000323_A11OpcionId
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridmenu_opcion ;
      private short nGXsfl_55_idx=1 ;
      private short gxcookieaux ;
      private short A10MenuEstado ;
      private short A14OpcionEstado ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridmenu_opcion_Backcolorstyle ;
      private short subGridmenu_opcion_Allowcollapsing ;
      private short subGridmenu_opcion_Collapsed ;
      private short nBlankRcdCount4 ;
      private short nRcdExists_4 ;
      private short RcdFound4 ;
      private short nIsMod_4 ;
      private short nBlankRcdUsr4 ;
      private short Z10MenuEstado ;
      private short nRcdDeleted_4 ;
      private short Z14OpcionEstado ;
      private short GX_JID ;
      private short RcdFound3 ;
      private short Gx_BScreen ;
      private short subGridmenu_opcion_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int A8MenuId ;
      private int edtMenuId_Enabled ;
      private int edtMenuDescripcion_Enabled ;
      private int A11OpcionId ;
      private int edtOpcionId_Enabled ;
      private int edtOpcionDescripcion_Enabled ;
      private int edtOpcionObjeto_Enabled ;
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
      private int Z8MenuId ;
      private int GRIDMENU_OPCION_nFirstRecordOnPage ;
      private int Z11OpcionId ;
      private int subGridmenu_opcion_Backcolor ;
      private int subGridmenu_opcion_Allbackcolor ;
      private int defedtOpcionId_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_55_idx="0001" ;
      private String GXKey ;
      private String GXCCtl ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtMenuId_Internalname ;
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
      private String lblTextblockmenuid_Internalname ;
      private String lblTextblockmenuid_Jsonclick ;
      private String edtMenuId_Jsonclick ;
      private String lblTextblockmenudescripcion_Internalname ;
      private String lblTextblockmenudescripcion_Jsonclick ;
      private String edtMenuDescripcion_Internalname ;
      private String edtMenuDescripcion_Jsonclick ;
      private String lblTextblockmenuestado_Internalname ;
      private String lblTextblockmenuestado_Jsonclick ;
      private String cmbMenuEstado_Internalname ;
      private String cmbMenuEstado_Jsonclick ;
      private String Gx_mode ;
      private String sMode4 ;
      private String edtOpcionId_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitleopcion_Internalname ;
      private String lblTitleopcion_Jsonclick ;
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
      private String edtOpcionDescripcion_Internalname ;
      private String edtOpcionObjeto_Internalname ;
      private String cmbOpcionEstado_Internalname ;
      private String sMode3 ;
      private String subGridmenu_opcion_Class ;
      private String subGridmenu_opcion_Linesclass ;
      private String ROClassString ;
      private String edtOpcionId_Jsonclick ;
      private String edtOpcionDescripcion_Jsonclick ;
      private String edtOpcionObjeto_Jsonclick ;
      private String cmbOpcionEstado_Jsonclick ;
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
      private String subGridmenu_opcion_Internalname ;
      private String GXt_char13 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A9MenuDescripcion ;
      private String A12OpcionDescripcion ;
      private String A13OpcionObjeto ;
      private String Z9MenuDescripcion ;
      private String Z12OpcionDescripcion ;
      private String Z13OpcionObjeto ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridmenu_opcionContainer ;
      private GXWebRow Gridmenu_opcionRow ;
      private GXWebColumn Gridmenu_opcionColumn ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbMenuEstado ;
      private GXCombobox cmbOpcionEstado ;
      private IDataStoreProvider pr_default ;
      private int[] T00036_A8MenuId ;
      private String[] T00036_A9MenuDescripcion ;
      private short[] T00036_A10MenuEstado ;
      private int[] T00037_A8MenuId ;
      private int[] T00035_A8MenuId ;
      private String[] T00035_A9MenuDescripcion ;
      private short[] T00035_A10MenuEstado ;
      private int[] T00038_A8MenuId ;
      private int[] T00039_A8MenuId ;
      private int[] T000310_A8MenuId ;
      private String[] T000310_A9MenuDescripcion ;
      private short[] T000310_A10MenuEstado ;
      private String[] T000314_A1GrupoCodigo ;
      private int[] T000314_A8MenuId ;
      private int[] T000315_A8MenuId ;
      private int[] T000315_A11OpcionId ;
      private int[] T000316_A8MenuId ;
      private int[] T000317_A8MenuId ;
      private int[] T000317_A11OpcionId ;
      private String[] T000317_A12OpcionDescripcion ;
      private String[] T000317_A13OpcionObjeto ;
      private short[] T000317_A14OpcionEstado ;
      private int[] T000318_A8MenuId ;
      private int[] T000318_A11OpcionId ;
      private int[] T00033_A8MenuId ;
      private int[] T00033_A11OpcionId ;
      private String[] T00033_A12OpcionDescripcion ;
      private String[] T00033_A13OpcionObjeto ;
      private short[] T00033_A14OpcionEstado ;
      private int[] T00032_A8MenuId ;
      private int[] T00032_A11OpcionId ;
      private String[] T00032_A12OpcionDescripcion ;
      private String[] T00032_A13OpcionObjeto ;
      private short[] T00032_A14OpcionEstado ;
      private String[] T000322_A1GrupoCodigo ;
      private int[] T000322_A8MenuId ;
      private int[] T000322_A11OpcionId ;
      private int[] T000323_A8MenuId ;
      private int[] T000323_A11OpcionId ;
      private int[] T00034_A8MenuId ;
      private String[] T00034_A9MenuDescripcion ;
      private short[] T00034_A10MenuEstado ;
      private GXWebForm Form ;
   }

   public class menu__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00034 ;
          prmT00034 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00036 ;
          prmT00036 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00037 ;
          prmT00037 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00035 ;
          prmT00035 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00038 ;
          prmT00038 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00039 ;
          prmT00039 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000310 ;
          prmT000310 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000311 ;
          prmT000311 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@MenuDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@MenuEstado",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmT000312 ;
          prmT000312 = new Object[] {
          new Object[] {"@MenuDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@MenuEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000313 ;
          prmT000313 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000314 ;
          prmT000314 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000315 ;
          prmT000315 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000316 ;
          prmT000316 = new Object[] {
          } ;
          Object[] prmT000317 ;
          prmT000317 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000318 ;
          prmT000318 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00033 ;
          prmT00033 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00032 ;
          prmT00032 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000319 ;
          prmT000319 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@OpcionObjeto",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@OpcionEstado",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmT000320 ;
          prmT000320 = new Object[] {
          new Object[] {"@OpcionDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@OpcionObjeto",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@OpcionEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000321 ;
          prmT000321 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000322 ;
          prmT000322 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000323 ;
          prmT000323 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00032", "SELECT [MenuId], [OpcionId], [OpcionDescripcion], [OpcionObjeto], [OpcionEstado] FROM [Opcion] WITH (UPDLOCK) WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00032,1,0,true,false )
             ,new CursorDef("T00033", "SELECT [MenuId], [OpcionId], [OpcionDescripcion], [OpcionObjeto], [OpcionEstado] FROM [Opcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00033,1,0,true,false )
             ,new CursorDef("T00034", "SELECT [MenuId], [MenuDescripcion], [MenuEstado] FROM [Menu] WITH (UPDLOCK) WHERE [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00034,1,0,true,false )
             ,new CursorDef("T00035", "SELECT [MenuId], [MenuDescripcion], [MenuEstado] FROM [Menu] WITH (NOLOCK) WHERE [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00035,1,0,true,false )
             ,new CursorDef("T00036", "SELECT TM1.[MenuId], TM1.[MenuDescripcion], TM1.[MenuEstado] FROM [Menu] TM1 WITH (NOLOCK) WHERE TM1.[MenuId] = @MenuId ORDER BY TM1.[MenuId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00036,100,0,true,false )
             ,new CursorDef("T00037", "SELECT [MenuId] FROM [Menu] WITH (NOLOCK) WHERE [MenuId] = @MenuId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00037,1,0,true,false )
             ,new CursorDef("T00038", "SELECT TOP 1 [MenuId] FROM [Menu] WITH (NOLOCK) WHERE ( [MenuId] > @MenuId) ORDER BY [MenuId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00038,1,0,true,true )
             ,new CursorDef("T00039", "SELECT TOP 1 [MenuId] FROM [Menu] WITH (NOLOCK) WHERE ( [MenuId] < @MenuId) ORDER BY [MenuId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00039,1,0,true,true )
             ,new CursorDef("T000310", "SELECT [MenuId], [MenuDescripcion], [MenuEstado] FROM [Menu] WITH (UPDLOCK) WHERE [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000310,1,0,true,false )
             ,new CursorDef("T000311", "INSERT INTO [Menu] ([MenuId], [MenuDescripcion], [MenuEstado]) VALUES (@MenuId, @MenuDescripcion, @MenuEstado)", GxErrorMask.GX_NOMASK,prmT000311)
             ,new CursorDef("T000312", "UPDATE [Menu] SET [MenuDescripcion]=@MenuDescripcion, [MenuEstado]=@MenuEstado  WHERE [MenuId] = @MenuId", GxErrorMask.GX_NOMASK,prmT000312)
             ,new CursorDef("T000313", "DELETE FROM [Menu]  WHERE [MenuId] = @MenuId", GxErrorMask.GX_NOMASK,prmT000313)
             ,new CursorDef("T000314", "SELECT TOP 1 [GrupoCodigo], [MenuId] FROM [AccesoMenu] WITH (NOLOCK) WHERE [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000314,1,0,true,true )
             ,new CursorDef("T000315", "SELECT TOP 1 [MenuId], [OpcionId] FROM [Opcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000315,1,0,true,true )
             ,new CursorDef("T000316", "SELECT [MenuId] FROM [Menu] WITH (NOLOCK) ORDER BY [MenuId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000316,100,0,true,false )
             ,new CursorDef("T000317", "SELECT [MenuId], [OpcionId], [OpcionDescripcion], [OpcionObjeto], [OpcionEstado] FROM [Opcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId and [OpcionId] = @OpcionId ORDER BY [MenuId], [OpcionId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000317,11,0,true,false )
             ,new CursorDef("T000318", "SELECT [MenuId], [OpcionId] FROM [Opcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000318,1,0,true,false )
             ,new CursorDef("T000319", "INSERT INTO [Opcion] ([MenuId], [OpcionId], [OpcionDescripcion], [OpcionObjeto], [OpcionEstado]) VALUES (@MenuId, @OpcionId, @OpcionDescripcion, @OpcionObjeto, @OpcionEstado)", GxErrorMask.GX_NOMASK,prmT000319)
             ,new CursorDef("T000320", "UPDATE [Opcion] SET [OpcionDescripcion]=@OpcionDescripcion, [OpcionObjeto]=@OpcionObjeto, [OpcionEstado]=@OpcionEstado  WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId", GxErrorMask.GX_NOMASK,prmT000320)
             ,new CursorDef("T000321", "DELETE FROM [Opcion]  WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId", GxErrorMask.GX_NOMASK,prmT000321)
             ,new CursorDef("T000322", "SELECT TOP 1 [GrupoCodigo], [MenuId], [OpcionId] FROM [AccesoOpcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000322,1,0,true,true )
             ,new CursorDef("T000323", "SELECT [MenuId], [OpcionId] FROM [Opcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId ORDER BY [MenuId], [OpcionId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000323,11,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 16 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 21 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 17 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
             case 19 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 20 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 21 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
