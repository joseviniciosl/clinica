/*
               File: Departamento
        Description: Departamentos
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:33.43
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
   public class departamento : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A35PaisCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_2( A35PaisCodigo) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Griddepartamento_municipio") == 0 )
         {
            nRC_Griddepartamento_municipio = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_55_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_55_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGriddepartamento_municipio_newrow( nRC_Griddepartamento_municipio, nGXsfl_55_idx, sGXsfl_55_idx) ;
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
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Departamentos", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPaisCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Fantastic");
      }

      public departamento( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public departamento( IGxContext context )
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
            wb_table1_2_0A14( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0A14e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0A14( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0A14( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0A14e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Departamentos"+"</legend>") ;
            wb_table3_27_0A14( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0A14e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0A14e( true) ;
         }
         else
         {
            wb_table1_2_0A14e( false) ;
         }
      }

      protected void wb_table3_27_0A14( bool wbgen )
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
            wb_table4_33_0A14( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0A14e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Departamento.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Departamento.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Departamento.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0A14e( true) ;
         }
         else
         {
            wb_table3_27_0A14e( false) ;
         }
      }

      protected void wb_table4_33_0A14( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockpaiscodigo_Internalname, "País", "", "", lblTextblockpaiscodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Departamento.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPaisCodigo_Internalname, StringUtil.RTrim( A35PaisCodigo), StringUtil.RTrim( context.localUtil.Format( A35PaisCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtPaisCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtPaisCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Departamento.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_35_Internalname, "prompt.gif", imgprompt_35_Link, "", "", "Fantastic", imgprompt_35_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Departamento.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdepcodigo_Internalname, "Departamento", "", "", lblTextblockdepcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Departamento.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtDepCodigo_Internalname, StringUtil.RTrim( A37DepCodigo), StringUtil.RTrim( context.localUtil.Format( A37DepCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtDepCodigo_Jsonclick, 0, ClassString, StyleString, "", 1, edtDepCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Departamento.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdepnombre_Internalname, "Nombre", "", "", lblTextblockdepnombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Departamento.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38DepNombre", A38DepNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtDepNombre_Internalname, StringUtil.RTrim( A38DepNombre), StringUtil.RTrim( context.localUtil.Format( A38DepNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtDepNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtDepNombre_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Departamento.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_51_0A14( true) ;
         }
         return  ;
      }

      protected void wb_table5_51_0A14e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Griddepartamento_municipioContainer.AddObjectProperty("GridName", "Griddepartamento_municipio");
            Griddepartamento_municipioContainer.AddObjectProperty("Class", "Grid");
            Griddepartamento_municipioContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Griddepartamento_municipioContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Griddepartamento_municipioContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddepartamento_municipio_Backcolorstyle), 1, 0, ".", "")));
            Griddepartamento_municipioContainer.AddObjectProperty("CmpContext", "");
            Griddepartamento_municipioContainer.AddObjectProperty("InMasterPage", "false");
            Griddepartamento_municipioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Griddepartamento_municipioColumn.AddObjectProperty("Value", StringUtil.RTrim( A39MunCodigo));
            Griddepartamento_municipioColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMunCodigo_Enabled), 5, 0, ".", "")));
            Griddepartamento_municipioContainer.AddColumnProperties(Griddepartamento_municipioColumn);
            Griddepartamento_municipioColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Griddepartamento_municipioColumn.AddObjectProperty("Value", StringUtil.RTrim( A40MunNombre));
            Griddepartamento_municipioColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMunNombre_Enabled), 5, 0, ".", "")));
            Griddepartamento_municipioContainer.AddColumnProperties(Griddepartamento_municipioColumn);
            Griddepartamento_municipioContainer.AddObjectProperty("Allowselection", "false");
            Griddepartamento_municipioContainer.AddObjectProperty("Allowcollapsing", ((subGriddepartamento_municipio_Allowcollapsing==1) ? "true" : "false"));
            Griddepartamento_municipioContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriddepartamento_municipio_Collapsed), 9, 0, ".", "")));
            nGXsfl_55_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount15 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_15 = 1 ;
                  ScanStart0A15( ) ;
                  while ( RcdFound15 != 0 )
                  {
                     init_level_properties15( ) ;
                     getByPrimaryKey0A15( ) ;
                     AddRow0A15( ) ;
                     ScanNext0A15( ) ;
                  }
                  ScanEnd0A15( ) ;
                  nBlankRcdCount15 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0A15( ) ;
               standaloneModal0A15( ) ;
               sMode15 = Gx_mode ;
               while ( nGXsfl_55_idx < nRC_Griddepartamento_municipio )
               {
                  ReadRow0A15( ) ;
                  edtMunCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "MUNCODIGO_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
                  edtMunNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "MUNNOMBRE_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_15 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0A15( ) ;
                  }
                  SendRow0A15( ) ;
               }
               Gx_mode = sMode15 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount15 = 5 ;
               nRcdExists_15 = 1 ;
               ScanStart0A15( ) ;
               while ( RcdFound15 != 0 )
               {
                  init_level_properties15( ) ;
                  getByPrimaryKey0A15( ) ;
                  standaloneNotModal0A15( ) ;
                  standaloneModal0A15( ) ;
                  AddRow0A15( ) ;
                  ScanNext0A15( ) ;
               }
               ScanEnd0A15( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode15 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0A15( ) ;
            init_level_properties15( ) ;
            standaloneNotModal0A15( ) ;
            standaloneModal0A15( ) ;
            nRcdExists_15 = 0 ;
            nIsMod_15 = 0 ;
            nBlankRcdCount15 = (short)(nBlankRcdUsr15+nBlankRcdCount15) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount15 > 0 )
            {
               AddRow0A15( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtMunCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount15 = (short)(nBlankRcdCount15-1) ;
            }
            Gx_mode = sMode15 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Griddepartamento_municipioContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Griddepartamento_municipio", (Object)(Griddepartamento_municipioContainer));
            GxWebStd.gx_hidden_field( context, "Griddepartamento_municipioContainerData", Griddepartamento_municipioContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Griddepartamento_municipioContainerData"+"V", Griddepartamento_municipioContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Griddepartamento_municipioContainerData"+"V"+"\" value='"+Griddepartamento_municipioContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0A14e( true) ;
         }
         else
         {
            wb_table4_33_0A14e( false) ;
         }
      }

      protected void wb_table5_51_0A14( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlemunicipio_Internalname, "Municipios", "", "", lblTitlemunicipio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Departamento.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_51_0A14e( true) ;
         }
         else
         {
            wb_table5_51_0A14e( false) ;
         }
      }

      protected void wb_table2_5_0A14( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PAISCODIGO"+"'), id:'"+"PAISCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"DEPCODIGO"+"'), id:'"+"DEPCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PAISCODIGO"+"'), id:'"+"PAISCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"DEPCODIGO"+"'), id:'"+"DEPCODIGO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Departamento.htm");
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
            wb_table2_5_0A14e( true) ;
         }
         else
         {
            wb_table2_5_0A14e( false) ;
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
               A35PaisCodigo = cgiGet( edtPaisCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
               A37DepCodigo = cgiGet( edtDepCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
               A38DepNombre = cgiGet( edtDepNombre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38DepNombre", A38DepNombre);
               /* Read saved values. */
               Z35PaisCodigo = cgiGet( "Z35PaisCodigo") ;
               Z37DepCodigo = cgiGet( "Z37DepCodigo") ;
               Z38DepNombre = cgiGet( "Z38DepNombre") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Griddepartamento_municipio = (short)(context.localUtil.CToN( cgiGet( "nRC_Griddepartamento_municipio"), ".", ",")) ;
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
                  A35PaisCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
                  A37DepCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
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
               InitAll0A14( ) ;
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
         DisableAttributes0A14( ) ;
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

      protected void CONFIRM_0A15( )
      {
         nGXsfl_55_idx = 0 ;
         while ( nGXsfl_55_idx < nRC_Griddepartamento_municipio )
         {
            ReadRow0A15( ) ;
            if ( ( nRcdExists_15 != 0 ) || ( nIsMod_15 != 0 ) )
            {
               GetKey0A15( ) ;
               if ( ( nRcdExists_15 == 0 ) && ( nRcdDeleted_15 == 0 ) )
               {
                  if ( RcdFound15 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0A15( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0A15( ) ;
                        CloseExtendedTableCursors0A15( ) ;
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
                     GX_FocusControl = edtMunCodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound15 != 0 )
                  {
                     if ( nRcdDeleted_15 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0A15( ) ;
                        Load0A15( ) ;
                        BeforeValidate0A15( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0A15( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_15 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0A15( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0A15( ) ;
                              CloseExtendedTableCursors0A15( ) ;
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
                     if ( nRcdDeleted_15 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtMunCodigo_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtMunCodigo_Internalname, StringUtil.RTrim( A39MunCodigo)) ;
            ChangePostValue( edtMunNombre_Internalname, StringUtil.RTrim( A40MunNombre)) ;
            ChangePostValue( "ZT_"+"Z39MunCodigo_"+sGXsfl_55_idx, StringUtil.RTrim( Z39MunCodigo)) ;
            ChangePostValue( "ZT_"+"Z40MunNombre_"+sGXsfl_55_idx, StringUtil.RTrim( Z40MunNombre)) ;
            ChangePostValue( "nRcdDeleted_15_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_15_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_15_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ".", ""))) ;
            if ( nIsMod_15 != 0 )
            {
               ChangePostValue( "MUNCODIGO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMunCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MUNNOMBRE_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMunNombre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0A0( )
      {
      }

      protected void ZM0A14( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z38DepNombre = T000A5_A38DepNombre[0] ;
            }
            else
            {
               Z38DepNombre = A38DepNombre ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z37DepCodigo = A37DepCodigo ;
            Z38DepNombre = A38DepNombre ;
            Z35PaisCodigo = A35PaisCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_35_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00d0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PAISCODIGO"+"'), id:'"+"PAISCODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
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

      protected void Load0A14( )
      {
         /* Using cursor T000A7 */
         pr_default.execute(5, new Object[] {A35PaisCodigo, A37DepCodigo});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound14 = 1 ;
            A38DepNombre = T000A7_A38DepNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38DepNombre", A38DepNombre);
            ZM0A14( -1) ;
         }
         pr_default.close(5);
         OnLoadActions0A14( ) ;
      }

      protected void OnLoadActions0A14( )
      {
      }

      protected void CheckExtendedTable0A14( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000A6 */
         pr_default.execute(4, new Object[] {A35PaisCodigo});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError35 = 1 ;
            GX_msglist.addItem("No existe 'Países'.", "ForeignKeyNotFound", 1, "PAISCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError35 == 0 )
         {
         }
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors0A14( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( String A35PaisCodigo )
      {
         /* Using cursor T000A8 */
         pr_default.execute(6, new Object[] {A35PaisCodigo});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError35 = 1 ;
            GX_msglist.addItem("No existe 'Países'.", "ForeignKeyNotFound", 1, "PAISCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError35 == 0 )
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

      protected void GetKey0A14( )
      {
         /* Using cursor T000A9 */
         pr_default.execute(7, new Object[] {A35PaisCodigo, A37DepCodigo});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound14 = 1 ;
         }
         else
         {
            RcdFound14 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000A5 */
         pr_default.execute(3, new Object[] {A35PaisCodigo, A37DepCodigo});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0A14( 1) ;
            RcdFound14 = 1 ;
            A37DepCodigo = T000A5_A37DepCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
            A38DepNombre = T000A5_A38DepNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38DepNombre", A38DepNombre);
            A35PaisCodigo = T000A5_A35PaisCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            Z35PaisCodigo = A35PaisCodigo ;
            Z37DepCodigo = A37DepCodigo ;
            sMode14 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0A14( ) ;
            Gx_mode = sMode14 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound14 = 0 ;
            InitializeNonKey0A14( ) ;
            sMode14 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode14 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A14( ) ;
         if ( RcdFound14 == 0 )
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
         RcdFound14 = 0 ;
         /* Using cursor T000A10 */
         pr_default.execute(8, new Object[] {A35PaisCodigo, A37DepCodigo});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000A10_A35PaisCodigo[0], A35PaisCodigo) < 0 ) || ( StringUtil.StrCmp(T000A10_A35PaisCodigo[0], A35PaisCodigo) == 0 ) && ( StringUtil.StrCmp(T000A10_A37DepCodigo[0], A37DepCodigo) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000A10_A35PaisCodigo[0], A35PaisCodigo) > 0 ) || ( StringUtil.StrCmp(T000A10_A35PaisCodigo[0], A35PaisCodigo) == 0 ) && ( StringUtil.StrCmp(T000A10_A37DepCodigo[0], A37DepCodigo) > 0 ) ) )
            {
               A35PaisCodigo = T000A10_A35PaisCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
               A37DepCodigo = T000A10_A37DepCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
               RcdFound14 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound14 = 0 ;
         /* Using cursor T000A11 */
         pr_default.execute(9, new Object[] {A35PaisCodigo, A37DepCodigo});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000A11_A35PaisCodigo[0], A35PaisCodigo) > 0 ) || ( StringUtil.StrCmp(T000A11_A35PaisCodigo[0], A35PaisCodigo) == 0 ) && ( StringUtil.StrCmp(T000A11_A37DepCodigo[0], A37DepCodigo) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000A11_A35PaisCodigo[0], A35PaisCodigo) < 0 ) || ( StringUtil.StrCmp(T000A11_A35PaisCodigo[0], A35PaisCodigo) == 0 ) && ( StringUtil.StrCmp(T000A11_A37DepCodigo[0], A37DepCodigo) < 0 ) ) )
            {
               A35PaisCodigo = T000A11_A35PaisCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
               A37DepCodigo = T000A11_A37DepCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
               RcdFound14 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0A14( ) ;
         if ( RcdFound14 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "PAISCODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtPaisCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A35PaisCodigo, Z35PaisCodigo) != 0 ) || ( StringUtil.StrCmp(A37DepCodigo, Z37DepCodigo) != 0 ) )
            {
               A35PaisCodigo = Z35PaisCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
               A37DepCodigo = Z37DepCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PAISCODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtPaisCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtPaisCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update0A14( ) ;
               GX_FocusControl = edtPaisCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A35PaisCodigo, Z35PaisCodigo) != 0 ) || ( StringUtil.StrCmp(A37DepCodigo, Z37DepCodigo) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtPaisCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0A14( ) ;
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
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PAISCODIGO");
                  AnyError = 1 ;
                  GX_FocusControl = edtPaisCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtPaisCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0A14( ) ;
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
         if ( ( StringUtil.StrCmp(A35PaisCodigo, Z35PaisCodigo) != 0 ) || ( StringUtil.StrCmp(A37DepCodigo, Z37DepCodigo) != 0 ) )
         {
            A35PaisCodigo = Z35PaisCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            A37DepCodigo = Z37DepCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PAISCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
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
         if ( RcdFound14 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "PAISCODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtDepNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0A14( ) ;
         if ( RcdFound14 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDepNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A14( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound14 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDepNombre_Internalname ;
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
         if ( RcdFound14 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDepNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0A14( ) ;
         if ( RcdFound14 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound14 != 0 )
            {
               ScanNext0A14( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDepNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A14( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0A14( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000A12 */
            pr_default.execute(10, new Object[] {A35PaisCodigo, A37DepCodigo});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Departamento"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z38DepNombre, T000A12_A38DepNombre[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Departamento"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0A14( )
      {
         BeforeValidate0A14( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A14( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A14( 0) ;
            CheckOptimisticConcurrency0A14( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A14( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A14( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A13 */
                     pr_default.execute(11, new Object[] {A37DepCodigo, A38DepNombre, A35PaisCodigo});
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
                           ProcessLevel0A14( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption0A0( ) ;
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
               Load0A14( ) ;
            }
            EndLevel0A14( ) ;
         }
         CloseExtendedTableCursors0A14( ) ;
      }

      protected void Update0A14( )
      {
         BeforeValidate0A14( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A14( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A14( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A14( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A14( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A14 */
                     pr_default.execute(12, new Object[] {A38DepNombre, A35PaisCodigo, A37DepCodigo});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Departamento"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0A14( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0A14( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption0A0( ) ;
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
            EndLevel0A14( ) ;
         }
         CloseExtendedTableCursors0A14( ) ;
      }

      protected void DeferredUpdate0A14( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0A14( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A14( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A14( ) ;
            AfterConfirm0A14( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A14( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000A15 */
                  pr_default.execute(13, new Object[] {A35PaisCodigo, A37DepCodigo});
                  pr_default.close(13);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound14 == 0 )
                        {
                           InitAll0A14( ) ;
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
                        ResetCaption0A0( ) ;
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
         sMode14 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0A14( ) ;
         Gx_mode = sMode14 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0A14( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000A16 */
            pr_default.execute(14, new Object[] {A35PaisCodigo, A37DepCodigo});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Municipios"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel0A15( )
      {
         nGXsfl_55_idx = 0 ;
         while ( nGXsfl_55_idx < nRC_Griddepartamento_municipio )
         {
            ReadRow0A15( ) ;
            if ( ( nRcdExists_15 != 0 ) || ( nIsMod_15 != 0 ) )
            {
               standaloneNotModal0A15( ) ;
               GetKey0A15( ) ;
               if ( ( nRcdExists_15 == 0 ) && ( nRcdDeleted_15 == 0 ) )
               {
                  if ( RcdFound15 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0A15( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtMunCodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound15 != 0 )
                  {
                     if ( ( nRcdDeleted_15 != 0 ) && ( nRcdExists_15 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0A15( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_15 != 0 ) && ( nRcdExists_15 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0A15( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_15 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtMunCodigo_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtMunCodigo_Internalname, StringUtil.RTrim( A39MunCodigo)) ;
            ChangePostValue( edtMunNombre_Internalname, StringUtil.RTrim( A40MunNombre)) ;
            ChangePostValue( "ZT_"+"Z39MunCodigo_"+sGXsfl_55_idx, StringUtil.RTrim( Z39MunCodigo)) ;
            ChangePostValue( "ZT_"+"Z40MunNombre_"+sGXsfl_55_idx, StringUtil.RTrim( Z40MunNombre)) ;
            ChangePostValue( "nRcdDeleted_15_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_15_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_15_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ".", ""))) ;
            if ( nIsMod_15 != 0 )
            {
               ChangePostValue( "MUNCODIGO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMunCodigo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "MUNNOMBRE_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMunNombre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0A15( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_15 = 0 ;
         nIsMod_15 = 0 ;
         nRcdDeleted_15 = 0 ;
      }

      protected void ProcessLevel0A14( )
      {
         /* Save parent mode. */
         sMode14 = Gx_mode ;
         ProcessNestedLevel0A15( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode14 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0A14( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A14( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("Departamento");
            if ( AnyError == 0 )
            {
               ConfirmValues0A0( ) ;
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
            context.RollbackDataStores("Departamento");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0A14( )
      {
         /* Using cursor T000A17 */
         pr_default.execute(15);
         RcdFound14 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound14 = 1 ;
            A35PaisCodigo = T000A17_A35PaisCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            A37DepCodigo = T000A17_A37DepCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A14( )
      {
         pr_default.readNext(15);
         RcdFound14 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound14 = 1 ;
            A35PaisCodigo = T000A17_A35PaisCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
            A37DepCodigo = T000A17_A37DepCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
         }
      }

      protected void ScanEnd0A14( )
      {
      }

      protected void AfterConfirm0A14( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A14( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A14( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A14( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A14( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A14( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A14( )
      {
         edtPaisCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPaisCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPaisCodigo_Enabled), 5, 0)));
         edtDepCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepCodigo_Enabled), 5, 0)));
         edtDepNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDepNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDepNombre_Enabled), 5, 0)));
      }

      protected void ZM0A15( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z40MunNombre = T000A3_A40MunNombre[0] ;
            }
            else
            {
               Z40MunNombre = A40MunNombre ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z35PaisCodigo = A35PaisCodigo ;
            Z37DepCodigo = A37DepCodigo ;
            Z39MunCodigo = A39MunCodigo ;
            Z40MunNombre = A40MunNombre ;
         }
      }

      protected void standaloneNotModal0A15( )
      {
      }

      protected void standaloneModal0A15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtMunCodigo_Enabled = 0 ;
         }
         else
         {
            edtMunCodigo_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode15, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode15, "DLT") == 0 ) )
         {
            DisableAttributes0A15( ) ;
         }
      }

      protected void Load0A15( )
      {
         /* Using cursor T000A18 */
         pr_default.execute(16, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound15 = 1 ;
            A40MunNombre = T000A18_A40MunNombre[0] ;
            ZM0A15( -3) ;
         }
         pr_default.close(16);
         OnLoadActions0A15( ) ;
      }

      protected void OnLoadActions0A15( )
      {
      }

      protected void CheckExtendedTable0A15( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0A15( ) ;
      }

      protected void CloseExtendedTableCursors0A15( )
      {
      }

      protected void enableDisable0A15( )
      {
      }

      protected void GetKey0A15( )
      {
         /* Using cursor T000A19 */
         pr_default.execute(17, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound15 = 1 ;
         }
         else
         {
            RcdFound15 = 0 ;
         }
         pr_default.close(17);
      }

      protected void getByPrimaryKey0A15( )
      {
         /* Using cursor T000A3 */
         pr_default.execute(1, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A15( 3) ;
            RcdFound15 = 1 ;
            InitializeNonKey0A15( ) ;
            A39MunCodigo = T000A3_A39MunCodigo[0] ;
            A40MunNombre = T000A3_A40MunNombre[0] ;
            Z35PaisCodigo = A35PaisCodigo ;
            Z37DepCodigo = A37DepCodigo ;
            Z39MunCodigo = A39MunCodigo ;
            sMode15 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0A15( ) ;
            Load0A15( ) ;
            Gx_mode = sMode15 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound15 = 0 ;
            InitializeNonKey0A15( ) ;
            sMode15 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0A15( ) ;
            Gx_mode = sMode15 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0A15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000A2 */
            pr_default.execute(0, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Municipio"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z40MunNombre, T000A2_A40MunNombre[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Municipio"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0A15( )
      {
         BeforeValidate0A15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A15( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A15( 0) ;
            CheckOptimisticConcurrency0A15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A20 */
                     pr_default.execute(18, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo, A40MunNombre});
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
               Load0A15( ) ;
            }
            EndLevel0A15( ) ;
         }
         CloseExtendedTableCursors0A15( ) ;
      }

      protected void Update0A15( )
      {
         BeforeValidate0A15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A15( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A21 */
                     pr_default.execute(19, new Object[] {A40MunNombre, A35PaisCodigo, A37DepCodigo, A39MunCodigo});
                     pr_default.close(19);
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Municipio"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0A15( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0A15( ) ;
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
            EndLevel0A15( ) ;
         }
         CloseExtendedTableCursors0A15( ) ;
      }

      protected void DeferredUpdate0A15( )
      {
      }

      protected void Delete0A15( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0A15( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A15( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A15( ) ;
            AfterConfirm0A15( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A15( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000A22 */
                  pr_default.execute(20, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
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
         sMode15 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0A15( ) ;
         Gx_mode = sMode15 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0A15( )
      {
         standaloneModal0A15( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000A23 */
            pr_default.execute(21, new Object[] {A35PaisCodigo, A37DepCodigo, A39MunCodigo});
            if ( (pr_default.getStatus(21) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Clínica Médica"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(21);
         }
      }

      protected void EndLevel0A15( )
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

      protected void ScanStart0A15( )
      {
         /* Using cursor T000A24 */
         pr_default.execute(22, new Object[] {A35PaisCodigo, A37DepCodigo});
         RcdFound15 = 0 ;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound15 = 1 ;
            A39MunCodigo = T000A24_A39MunCodigo[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A15( )
      {
         pr_default.readNext(22);
         RcdFound15 = 0 ;
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound15 = 1 ;
            A39MunCodigo = T000A24_A39MunCodigo[0] ;
         }
      }

      protected void ScanEnd0A15( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0A15( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A15( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0A15( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0A15( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A15( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A15( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A15( )
      {
         edtMunCodigo_Enabled = 0 ;
         edtMunNombre_Enabled = 0 ;
      }

      protected void AddRow0A15( )
      {
         nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtMunCodigo_Internalname = "MUNCODIGO_"+sGXsfl_55_idx ;
         edtMunNombre_Internalname = "MUNNOMBRE_"+sGXsfl_55_idx ;
         SendRow0A15( ) ;
      }

      protected void SendRow0A15( )
      {
         Griddepartamento_municipioRow = GXWebRow.GetNew(context) ;
         if ( subGriddepartamento_municipio_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGriddepartamento_municipio_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGriddepartamento_municipio_Class, "") != 0 )
            {
               subGriddepartamento_municipio_Linesclass = subGriddepartamento_municipio_Class+"Odd" ;
            }
         }
         else if ( subGriddepartamento_municipio_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGriddepartamento_municipio_Backstyle = 0 ;
            subGriddepartamento_municipio_Backcolor = subGriddepartamento_municipio_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Griddepartamento_municipioContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGriddepartamento_municipio_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGriddepartamento_municipio_Class, "") != 0 )
            {
               subGriddepartamento_municipio_Linesclass = subGriddepartamento_municipio_Class+"Uniform" ;
            }
         }
         else if ( subGriddepartamento_municipio_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGriddepartamento_municipio_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGriddepartamento_municipio_Class, "") != 0 )
            {
               subGriddepartamento_municipio_Linesclass = subGriddepartamento_municipio_Class+"Odd" ;
            }
            subGriddepartamento_municipio_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Griddepartamento_municipioContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGriddepartamento_municipio_Backcolor), 9, 0)));
         }
         else if ( subGriddepartamento_municipio_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGriddepartamento_municipio_Backstyle = 1 ;
            if ( ((int)(nGXsfl_55_idx) % (2)) == 0 )
            {
               subGriddepartamento_municipio_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Griddepartamento_municipioContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGriddepartamento_municipio_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGriddepartamento_municipio_Class, "") != 0 )
               {
                  subGriddepartamento_municipio_Linesclass = subGriddepartamento_municipio_Class+"Even" ;
               }
            }
            else
            {
               subGriddepartamento_municipio_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Griddepartamento_municipioContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGriddepartamento_municipio_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGriddepartamento_municipio_Class, "") != 0 )
               {
                  subGriddepartamento_municipio_Linesclass = subGriddepartamento_municipio_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_55_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_55_idx + "',55)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Griddepartamento_municipioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMunCodigo_Internalname,StringUtil.RTrim( A39MunCodigo),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(56);\"",(String)"",(String)"",(String)"",(String)"",(String)edtMunCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtMunCodigo_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)55,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_55_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_55_idx + "',55)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Griddepartamento_municipioRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMunNombre_Internalname,StringUtil.RTrim( A40MunNombre),(String)"",TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(57);\"",(String)"",(String)"",(String)"",(String)"",(String)edtMunNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtMunNombre_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)55,(short)1,(short)-1,(bool)true,(String)"left"});
         context.httpAjaxContext.ajax_sending_grid_row(Griddepartamento_municipioRow);
         GXCCtl = "Z39MunCodigo_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z39MunCodigo));
         GXCCtl = "Z40MunNombre_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z40MunNombre));
         GXCCtl = "nRcdDeleted_15_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_15_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ".", "")));
         GXCCtl = "nIsMod_15_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MUNCODIGO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMunCodigo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "MUNNOMBRE_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtMunNombre_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Griddepartamento_municipioContainer.AddRow(Griddepartamento_municipioRow);
      }

      protected void ReadRow0A15( )
      {
         nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtMunCodigo_Internalname = "MUNCODIGO_"+sGXsfl_55_idx ;
         edtMunNombre_Internalname = "MUNNOMBRE_"+sGXsfl_55_idx ;
         edtMunCodigo_Enabled = (int)(context.localUtil.CToN( cgiGet( "MUNCODIGO_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
         edtMunNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "MUNNOMBRE_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
         A39MunCodigo = cgiGet( edtMunCodigo_Internalname) ;
         A40MunNombre = cgiGet( edtMunNombre_Internalname) ;
         GXCCtl = "Z39MunCodigo_" + sGXsfl_55_idx ;
         Z39MunCodigo = cgiGet( GXCCtl) ;
         GXCCtl = "Z40MunNombre_" + sGXsfl_55_idx ;
         Z40MunNombre = cgiGet( GXCCtl) ;
         GXCCtl = "nRcdDeleted_15_" + sGXsfl_55_idx ;
         nRcdDeleted_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_15_" + sGXsfl_55_idx ;
         nRcdExists_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_15_" + sGXsfl_55_idx ;
         nIsMod_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtMunCodigo_Enabled = edtMunCodigo_Enabled ;
      }

      protected void ConfirmValues0A0( )
      {
         nGXsfl_55_idx = 0 ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtMunCodigo_Internalname = "MUNCODIGO_"+sGXsfl_55_idx ;
         edtMunNombre_Internalname = "MUNNOMBRE_"+sGXsfl_55_idx ;
         while ( nGXsfl_55_idx < nRC_Griddepartamento_municipio )
         {
            nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
            sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
            edtMunCodigo_Internalname = "MUNCODIGO_"+sGXsfl_55_idx ;
            edtMunNombre_Internalname = "MUNNOMBRE_"+sGXsfl_55_idx ;
            ChangePostValue( "Z39MunCodigo_"+sGXsfl_55_idx, cgiGet( "ZT_"+"Z39MunCodigo_"+sGXsfl_55_idx)) ;
            DeletePostValue( "ZT_"+"Z39MunCodigo_"+sGXsfl_55_idx) ;
            ChangePostValue( "Z40MunNombre_"+sGXsfl_55_idx, cgiGet( "ZT_"+"Z40MunNombre_"+sGXsfl_55_idx)) ;
            DeletePostValue( "ZT_"+"Z40MunNombre_"+sGXsfl_55_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("departamento.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z35PaisCodigo", StringUtil.RTrim( Z35PaisCodigo));
         GxWebStd.gx_hidden_field( context, "Z37DepCodigo", StringUtil.RTrim( Z37DepCodigo));
         GxWebStd.gx_hidden_field( context, "Z38DepNombre", StringUtil.RTrim( Z38DepNombre));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Griddepartamento_municipio", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_55_idx), 4, 0, ".", "")));
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
         return "Departamento" ;
      }

      public override String GetPgmdesc( )
      {
         return "Departamentos" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("departamento.aspx")  ;
      }

      protected void InitializeNonKey0A14( )
      {
         A38DepNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38DepNombre", A38DepNombre);
      }

      protected void InitAll0A14( )
      {
         A35PaisCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35PaisCodigo", A35PaisCodigo);
         A37DepCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37DepCodigo", A37DepCodigo);
         InitializeNonKey0A14( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0A15( )
      {
         A40MunNombre = "" ;
      }

      protected void InitAll0A15( )
      {
         A39MunCodigo = "" ;
         InitializeNonKey0A15( ) ;
      }

      protected void StandaloneModalInsert0A15( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1543527");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("departamento.js", "?1543527");
         /* End function include_jscripts */
      }

      protected void init_level_properties15( )
      {
         edtMunCodigo_Enabled = defedtMunCodigo_Enabled ;
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
         lblTextblockpaiscodigo_Internalname = "TEXTBLOCKPAISCODIGO" ;
         edtPaisCodigo_Internalname = "PAISCODIGO" ;
         lblTextblockdepcodigo_Internalname = "TEXTBLOCKDEPCODIGO" ;
         edtDepCodigo_Internalname = "DEPCODIGO" ;
         lblTextblockdepnombre_Internalname = "TEXTBLOCKDEPNOMBRE" ;
         edtDepNombre_Internalname = "DEPNOMBRE" ;
         lblTitlemunicipio_Internalname = "TITLEMUNICIPIO" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_35_Internalname = "PROMPT_35" ;
         subGriddepartamento_municipio_Internalname = "GRIDDEPARTAMENTO_MUNICIPIO" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Departamentos" ;
         edtMunNombre_Jsonclick = "" ;
         edtMunCodigo_Jsonclick = "" ;
         subGriddepartamento_municipio_Class = "Grid" ;
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
         subGriddepartamento_municipio_Allowcollapsing = 0 ;
         edtMunNombre_Enabled = 1 ;
         edtMunCodigo_Enabled = 1 ;
         subGriddepartamento_municipio_Backcolorstyle = 2 ;
         edtDepNombre_Jsonclick = "" ;
         edtDepNombre_Enabled = 1 ;
         edtDepCodigo_Jsonclick = "" ;
         edtDepCodigo_Enabled = 1 ;
         imgprompt_35_Visible = 1 ;
         imgprompt_35_Link = "" ;
         edtPaisCodigo_Jsonclick = "" ;
         edtPaisCodigo_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGriddepartamento_municipio_newrow( short nRC_Griddepartamento_municipio ,
                                                            short nGXsfl_55_idx ,
                                                            String sGXsfl_55_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtMunCodigo_Internalname = "MUNCODIGO_"+sGXsfl_55_idx ;
         edtMunNombre_Internalname = "MUNNOMBRE_"+sGXsfl_55_idx ;
         while ( nGXsfl_55_idx <= nRC_Griddepartamento_municipio )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0A15( ) ;
            standaloneModal0A15( ) ;
            dynload_actions( ) ;
            SendRow0A15( ) ;
            nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
            sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
            edtMunCodigo_Internalname = "MUNCODIGO_"+sGXsfl_55_idx ;
            edtMunNombre_Internalname = "MUNNOMBRE_"+sGXsfl_55_idx ;
         }
         context.GX_webresponse.AddString(Griddepartamento_municipioContainer.ToJavascriptSource());
         /* End function gxnrGriddepartamento_municipio_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000A25 */
         pr_default.execute(23, new Object[] {A35PaisCodigo});
         if ( (pr_default.getStatus(23) == 101) )
         {
            AnyError35 = 1 ;
            GX_msglist.addItem("No existe 'Países'.", "ForeignKeyNotFound", 1, "PAISCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError35 == 0 )
         {
         }
         pr_default.close(23);
         GX_FocusControl = edtDepNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Paiscodigo( String GX_Parm1 )
      {
         A35PaisCodigo = GX_Parm1 ;
         /* Using cursor T000A25 */
         pr_default.execute(23, new Object[] {A35PaisCodigo});
         if ( (pr_default.getStatus(23) == 101) )
         {
            AnyError35 = 1 ;
            GX_msglist.addItem("No existe 'Países'.", "ForeignKeyNotFound", 1, "PAISCODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtPaisCodigo_Internalname ;
         }
         if ( AnyError35 == 0 )
         {
         }
         pr_default.close(23);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Depcodigo( String GX_Parm1 ,
                                   String GX_Parm2 ,
                                   String GX_Parm3 )
      {
         A35PaisCodigo = GX_Parm1 ;
         A37DepCodigo = GX_Parm2 ;
         A38DepNombre = GX_Parm3 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A38DepNombre)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z35PaisCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z37DepCodigo)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z38DepNombre)));
         isValidOutput.Add((Object)(Griddepartamento_municipioContainer));
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
         A35PaisCodigo = "" ;
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
         lblTextblockpaiscodigo_Jsonclick = "" ;
         lblTextblockdepcodigo_Jsonclick = "" ;
         A37DepCodigo = "" ;
         lblTextblockdepnombre_Jsonclick = "" ;
         A38DepNombre = "" ;
         Griddepartamento_municipioContainer = new GXWebGrid( context);
         Griddepartamento_municipioColumn = new GXWebColumn();
         A39MunCodigo = "" ;
         A40MunNombre = "" ;
         Gx_mode = "" ;
         sMode15 = "" ;
         edtMunCodigo_Internalname = "" ;
         lblTitlemunicipio_Jsonclick = "" ;
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
         Z35PaisCodigo = "" ;
         Z37DepCodigo = "" ;
         Z38DepNombre = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtMunNombre_Internalname = "" ;
         Z39MunCodigo = "" ;
         Z40MunNombre = "" ;
         T000A7_A37DepCodigo = new String[] {""} ;
         T000A7_A38DepNombre = new String[] {""} ;
         T000A7_A35PaisCodigo = new String[] {""} ;
         T000A6_A35PaisCodigo = new String[] {""} ;
         T000A8_A35PaisCodigo = new String[] {""} ;
         T000A9_A35PaisCodigo = new String[] {""} ;
         T000A9_A37DepCodigo = new String[] {""} ;
         T000A5_A37DepCodigo = new String[] {""} ;
         T000A5_A38DepNombre = new String[] {""} ;
         T000A5_A35PaisCodigo = new String[] {""} ;
         sMode14 = "" ;
         T000A10_A35PaisCodigo = new String[] {""} ;
         T000A10_A37DepCodigo = new String[] {""} ;
         T000A11_A35PaisCodigo = new String[] {""} ;
         T000A11_A37DepCodigo = new String[] {""} ;
         T000A12_A37DepCodigo = new String[] {""} ;
         T000A12_A38DepNombre = new String[] {""} ;
         T000A12_A35PaisCodigo = new String[] {""} ;
         T000A16_A35PaisCodigo = new String[] {""} ;
         T000A16_A37DepCodigo = new String[] {""} ;
         T000A16_A39MunCodigo = new String[] {""} ;
         T000A17_A35PaisCodigo = new String[] {""} ;
         T000A17_A37DepCodigo = new String[] {""} ;
         T000A18_A35PaisCodigo = new String[] {""} ;
         T000A18_A37DepCodigo = new String[] {""} ;
         T000A18_A39MunCodigo = new String[] {""} ;
         T000A18_A40MunNombre = new String[] {""} ;
         T000A19_A35PaisCodigo = new String[] {""} ;
         T000A19_A37DepCodigo = new String[] {""} ;
         T000A19_A39MunCodigo = new String[] {""} ;
         T000A3_A35PaisCodigo = new String[] {""} ;
         T000A3_A37DepCodigo = new String[] {""} ;
         T000A3_A39MunCodigo = new String[] {""} ;
         T000A3_A40MunNombre = new String[] {""} ;
         T000A2_A35PaisCodigo = new String[] {""} ;
         T000A2_A37DepCodigo = new String[] {""} ;
         T000A2_A39MunCodigo = new String[] {""} ;
         T000A2_A40MunNombre = new String[] {""} ;
         T000A23_A41ClinicaCodigo = new String[] {""} ;
         T000A24_A35PaisCodigo = new String[] {""} ;
         T000A24_A37DepCodigo = new String[] {""} ;
         T000A24_A39MunCodigo = new String[] {""} ;
         Griddepartamento_municipioRow = new GXWebRow();
         subGriddepartamento_municipio_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char7 = "" ;
         T000A25_A35PaisCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.departamento__default(),
            new Object[][] {
                new Object[] {
               T000A2_A35PaisCodigo, T000A2_A37DepCodigo, T000A2_A39MunCodigo, T000A2_A40MunNombre
               }
               , new Object[] {
               T000A3_A35PaisCodigo, T000A3_A37DepCodigo, T000A3_A39MunCodigo, T000A3_A40MunNombre
               }
               , new Object[] {
               T000A4_A37DepCodigo, T000A4_A38DepNombre, T000A4_A35PaisCodigo
               }
               , new Object[] {
               T000A5_A37DepCodigo, T000A5_A38DepNombre, T000A5_A35PaisCodigo
               }
               , new Object[] {
               T000A6_A35PaisCodigo
               }
               , new Object[] {
               T000A7_A37DepCodigo, T000A7_A38DepNombre, T000A7_A35PaisCodigo
               }
               , new Object[] {
               T000A8_A35PaisCodigo
               }
               , new Object[] {
               T000A9_A35PaisCodigo, T000A9_A37DepCodigo
               }
               , new Object[] {
               T000A10_A35PaisCodigo, T000A10_A37DepCodigo
               }
               , new Object[] {
               T000A11_A35PaisCodigo, T000A11_A37DepCodigo
               }
               , new Object[] {
               T000A12_A37DepCodigo, T000A12_A38DepNombre, T000A12_A35PaisCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A16_A35PaisCodigo, T000A16_A37DepCodigo, T000A16_A39MunCodigo
               }
               , new Object[] {
               T000A17_A35PaisCodigo, T000A17_A37DepCodigo
               }
               , new Object[] {
               T000A18_A35PaisCodigo, T000A18_A37DepCodigo, T000A18_A39MunCodigo, T000A18_A40MunNombre
               }
               , new Object[] {
               T000A19_A35PaisCodigo, T000A19_A37DepCodigo, T000A19_A39MunCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A23_A41ClinicaCodigo
               }
               , new Object[] {
               T000A24_A35PaisCodigo, T000A24_A37DepCodigo, T000A24_A39MunCodigo
               }
               , new Object[] {
               T000A25_A35PaisCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Griddepartamento_municipio ;
      private short nGXsfl_55_idx=1 ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGriddepartamento_municipio_Backcolorstyle ;
      private short subGriddepartamento_municipio_Allowcollapsing ;
      private short subGriddepartamento_municipio_Collapsed ;
      private short nBlankRcdCount15 ;
      private short nRcdExists_15 ;
      private short RcdFound15 ;
      private short nIsMod_15 ;
      private short nBlankRcdUsr15 ;
      private short nRcdDeleted_15 ;
      private short GX_JID ;
      private short RcdFound14 ;
      private short Gx_BScreen ;
      private short subGriddepartamento_municipio_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtPaisCodigo_Enabled ;
      private int imgprompt_35_Visible ;
      private int edtDepCodigo_Enabled ;
      private int edtDepNombre_Enabled ;
      private int edtMunCodigo_Enabled ;
      private int edtMunNombre_Enabled ;
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
      private int GRIDDEPARTAMENTO_MUNICIPIO_nFirstRecordOnPage ;
      private int AnyError35 ;
      private int subGriddepartamento_municipio_Backcolor ;
      private int subGriddepartamento_municipio_Allbackcolor ;
      private int defedtMunCodigo_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_55_idx="0001" ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPaisCodigo_Internalname ;
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
      private String lblTextblockpaiscodigo_Internalname ;
      private String lblTextblockpaiscodigo_Jsonclick ;
      private String edtPaisCodigo_Jsonclick ;
      private String imgprompt_35_Internalname ;
      private String imgprompt_35_Link ;
      private String lblTextblockdepcodigo_Internalname ;
      private String lblTextblockdepcodigo_Jsonclick ;
      private String edtDepCodigo_Internalname ;
      private String edtDepCodigo_Jsonclick ;
      private String lblTextblockdepnombre_Internalname ;
      private String lblTextblockdepnombre_Jsonclick ;
      private String edtDepNombre_Internalname ;
      private String edtDepNombre_Jsonclick ;
      private String Gx_mode ;
      private String sMode15 ;
      private String edtMunCodigo_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlemunicipio_Internalname ;
      private String lblTitlemunicipio_Jsonclick ;
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
      private String edtMunNombre_Internalname ;
      private String sMode14 ;
      private String subGriddepartamento_municipio_Class ;
      private String subGriddepartamento_municipio_Linesclass ;
      private String ROClassString ;
      private String edtMunCodigo_Jsonclick ;
      private String edtMunNombre_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String subGriddepartamento_municipio_Internalname ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A35PaisCodigo ;
      private String A37DepCodigo ;
      private String A38DepNombre ;
      private String A39MunCodigo ;
      private String A40MunNombre ;
      private String Z35PaisCodigo ;
      private String Z37DepCodigo ;
      private String Z38DepNombre ;
      private String Z39MunCodigo ;
      private String Z40MunNombre ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Griddepartamento_municipioContainer ;
      private GXWebRow Griddepartamento_municipioRow ;
      private GXWebColumn Griddepartamento_municipioColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000A7_A37DepCodigo ;
      private String[] T000A7_A38DepNombre ;
      private String[] T000A7_A35PaisCodigo ;
      private String[] T000A6_A35PaisCodigo ;
      private String[] T000A8_A35PaisCodigo ;
      private String[] T000A9_A35PaisCodigo ;
      private String[] T000A9_A37DepCodigo ;
      private String[] T000A5_A37DepCodigo ;
      private String[] T000A5_A38DepNombre ;
      private String[] T000A5_A35PaisCodigo ;
      private String[] T000A10_A35PaisCodigo ;
      private String[] T000A10_A37DepCodigo ;
      private String[] T000A11_A35PaisCodigo ;
      private String[] T000A11_A37DepCodigo ;
      private String[] T000A12_A37DepCodigo ;
      private String[] T000A12_A38DepNombre ;
      private String[] T000A12_A35PaisCodigo ;
      private String[] T000A16_A35PaisCodigo ;
      private String[] T000A16_A37DepCodigo ;
      private String[] T000A16_A39MunCodigo ;
      private String[] T000A17_A35PaisCodigo ;
      private String[] T000A17_A37DepCodigo ;
      private String[] T000A18_A35PaisCodigo ;
      private String[] T000A18_A37DepCodigo ;
      private String[] T000A18_A39MunCodigo ;
      private String[] T000A18_A40MunNombre ;
      private String[] T000A19_A35PaisCodigo ;
      private String[] T000A19_A37DepCodigo ;
      private String[] T000A19_A39MunCodigo ;
      private String[] T000A3_A35PaisCodigo ;
      private String[] T000A3_A37DepCodigo ;
      private String[] T000A3_A39MunCodigo ;
      private String[] T000A3_A40MunNombre ;
      private String[] T000A2_A35PaisCodigo ;
      private String[] T000A2_A37DepCodigo ;
      private String[] T000A2_A39MunCodigo ;
      private String[] T000A2_A40MunNombre ;
      private String[] T000A23_A41ClinicaCodigo ;
      private String[] T000A24_A35PaisCodigo ;
      private String[] T000A24_A37DepCodigo ;
      private String[] T000A24_A39MunCodigo ;
      private String[] T000A25_A35PaisCodigo ;
      private String[] T000A4_A37DepCodigo ;
      private String[] T000A4_A38DepNombre ;
      private String[] T000A4_A35PaisCodigo ;
      private GXWebForm Form ;
   }

   public class departamento__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000A4 ;
          prmT000A4 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A7 ;
          prmT000A7 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A6 ;
          prmT000A6 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A8 ;
          prmT000A8 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A9 ;
          prmT000A9 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A5 ;
          prmT000A5 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A10 ;
          prmT000A10 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A11 ;
          prmT000A11 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A12 ;
          prmT000A12 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A13 ;
          prmT000A13 = new Object[] {
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A14 ;
          prmT000A14 = new Object[] {
          new Object[] {"@DepNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A15 ;
          prmT000A15 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A16 ;
          prmT000A16 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A17 ;
          prmT000A17 = new Object[] {
          } ;
          Object[] prmT000A18 ;
          prmT000A18 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A19 ;
          prmT000A19 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A3 ;
          prmT000A3 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A2 ;
          prmT000A2 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A20 ;
          prmT000A20 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunNombre",SqlDbType.VarChar,70,0}
          } ;
          Object[] prmT000A21 ;
          prmT000A21 = new Object[] {
          new Object[] {"@MunNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A22 ;
          prmT000A22 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A23 ;
          prmT000A23 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MunCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A24 ;
          prmT000A24 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@DepCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000A25 ;
          prmT000A25 = new Object[] {
          new Object[] {"@PaisCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000A2", "SELECT [PaisCodigo], [DepCodigo], [MunCodigo], [MunNombre] FROM [Municipio] WITH (UPDLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A2,1,0,true,false )
             ,new CursorDef("T000A3", "SELECT [PaisCodigo], [DepCodigo], [MunCodigo], [MunNombre] FROM [Municipio] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A3,1,0,true,false )
             ,new CursorDef("T000A4", "SELECT [DepCodigo], [DepNombre], [PaisCodigo] FROM [Departamento] WITH (UPDLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A4,1,0,true,false )
             ,new CursorDef("T000A5", "SELECT [DepCodigo], [DepNombre], [PaisCodigo] FROM [Departamento] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A5,1,0,true,false )
             ,new CursorDef("T000A6", "SELECT [PaisCodigo] FROM [Pais] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A6,1,0,true,false )
             ,new CursorDef("T000A7", "SELECT TM1.[DepCodigo], TM1.[DepNombre], TM1.[PaisCodigo] FROM [Departamento] TM1 WITH (NOLOCK) WHERE TM1.[PaisCodigo] = @PaisCodigo and TM1.[DepCodigo] = @DepCodigo ORDER BY TM1.[PaisCodigo], TM1.[DepCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A7,100,0,true,false )
             ,new CursorDef("T000A8", "SELECT [PaisCodigo] FROM [Pais] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A8,1,0,true,false )
             ,new CursorDef("T000A9", "SELECT [PaisCodigo], [DepCodigo] FROM [Departamento] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A9,1,0,true,false )
             ,new CursorDef("T000A10", "SELECT TOP 1 [PaisCodigo], [DepCodigo] FROM [Departamento] WITH (NOLOCK) WHERE ( [PaisCodigo] > @PaisCodigo or [PaisCodigo] = @PaisCodigo and [DepCodigo] > @DepCodigo) ORDER BY [PaisCodigo], [DepCodigo]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A10,1,0,true,true )
             ,new CursorDef("T000A11", "SELECT TOP 1 [PaisCodigo], [DepCodigo] FROM [Departamento] WITH (NOLOCK) WHERE ( [PaisCodigo] < @PaisCodigo or [PaisCodigo] = @PaisCodigo and [DepCodigo] < @DepCodigo) ORDER BY [PaisCodigo] DESC, [DepCodigo] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A11,1,0,true,true )
             ,new CursorDef("T000A12", "SELECT [DepCodigo], [DepNombre], [PaisCodigo] FROM [Departamento] WITH (UPDLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A12,1,0,true,false )
             ,new CursorDef("T000A13", "INSERT INTO [Departamento] ([DepCodigo], [DepNombre], [PaisCodigo]) VALUES (@DepCodigo, @DepNombre, @PaisCodigo)", GxErrorMask.GX_NOMASK,prmT000A13)
             ,new CursorDef("T000A14", "UPDATE [Departamento] SET [DepNombre]=@DepNombre  WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo", GxErrorMask.GX_NOMASK,prmT000A14)
             ,new CursorDef("T000A15", "DELETE FROM [Departamento]  WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo", GxErrorMask.GX_NOMASK,prmT000A15)
             ,new CursorDef("T000A16", "SELECT TOP 1 [PaisCodigo], [DepCodigo], [MunCodigo] FROM [Municipio] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A16,1,0,true,true )
             ,new CursorDef("T000A17", "SELECT [PaisCodigo], [DepCodigo] FROM [Departamento] WITH (NOLOCK) ORDER BY [PaisCodigo], [DepCodigo]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A17,100,0,true,false )
             ,new CursorDef("T000A18", "SELECT [PaisCodigo], [DepCodigo], [MunCodigo], [MunNombre] FROM [Municipio] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo and [DepCodigo] = @DepCodigo and [MunCodigo] = @MunCodigo ORDER BY [PaisCodigo], [DepCodigo], [MunCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A18,11,0,true,false )
             ,new CursorDef("T000A19", "SELECT [PaisCodigo], [DepCodigo], [MunCodigo] FROM [Municipio] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A19,1,0,true,false )
             ,new CursorDef("T000A20", "INSERT INTO [Municipio] ([PaisCodigo], [DepCodigo], [MunCodigo], [MunNombre]) VALUES (@PaisCodigo, @DepCodigo, @MunCodigo, @MunNombre)", GxErrorMask.GX_NOMASK,prmT000A20)
             ,new CursorDef("T000A21", "UPDATE [Municipio] SET [MunNombre]=@MunNombre  WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo", GxErrorMask.GX_NOMASK,prmT000A21)
             ,new CursorDef("T000A22", "DELETE FROM [Municipio]  WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo", GxErrorMask.GX_NOMASK,prmT000A22)
             ,new CursorDef("T000A23", "SELECT TOP 1 [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo AND [DepCodigo] = @DepCodigo AND [MunCodigo] = @MunCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A23,1,0,true,true )
             ,new CursorDef("T000A24", "SELECT [PaisCodigo], [DepCodigo], [MunCodigo] FROM [Municipio] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo and [DepCodigo] = @DepCodigo ORDER BY [PaisCodigo], [DepCodigo], [MunCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A24,11,0,true,false )
             ,new CursorDef("T000A25", "SELECT [PaisCodigo] FROM [Pais] WITH (NOLOCK) WHERE [PaisCodigo] = @PaisCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A25,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
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
