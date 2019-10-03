/*
               File: Correlativo
        Description: Correlativos del sistema
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:49.40
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
   public class correlativo : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcorrelativo_correlativodet") == 0 )
         {
            nRC_Gridcorrelativo_correlativodet = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_55_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_55_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridcorrelativo_correlativodet_newrow( nRC_Gridcorrelativo_correlativodet, nGXsfl_55_idx, sGXsfl_55_idx) ;
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
         Form.Meta.addItem("Description", "Correlativos del sistema", 0) ;
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

      public correlativo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public correlativo( IGxContext context )
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
            wb_table1_2_0F20( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0F20e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0F20( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0F20( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0F20e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Correlativos del sistema"+"</legend>") ;
            wb_table3_27_0F20( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0F20e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0F20e( true) ;
         }
         else
         {
            wb_table1_2_0F20e( false) ;
         }
      }

      protected void wb_table3_27_0F20( bool wbgen )
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
            wb_table4_33_0F20( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0F20e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Correlativo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Correlativo.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Correlativo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0F20e( true) ;
         }
         else
         {
            wb_table3_27_0F20e( false) ;
         }
      }

      protected void wb_table4_33_0F20( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", lblTextblockclinicacodigo_Visible, 1, 0, "HLP_Correlativo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtClinicaCodigo_Internalname, StringUtil.RTrim( A41ClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtClinicaCodigo_Jsonclick, 0, ClassString, StyleString, "", edtClinicaCodigo_Visible, edtClinicaCodigo_Enabled, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Correlativo.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_41_Internalname, "prompt.gif", imgprompt_41_Link, "", "", "Fantastic", imgprompt_41_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Correlativo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcorrelativoid_Internalname, "Correlativo", "", "", lblTextblockcorrelativoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Correlativo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCorrelativoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A61CorrelativoId), 9, 0, ".", "")), ((edtCorrelativoId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A61CorrelativoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A61CorrelativoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtCorrelativoId_Jsonclick, 0, ClassString, StyleString, "", 1, edtCorrelativoId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Correlativo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcorrelativodescripcion_Internalname, "Descripción", "", "", lblTextblockcorrelativodescripcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Correlativo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62CorrelativoDescripcion", A62CorrelativoDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCorrelativoDescripcion_Internalname, StringUtil.RTrim( A62CorrelativoDescripcion), StringUtil.RTrim( context.localUtil.Format( A62CorrelativoDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", "", "", "", "", edtCorrelativoDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtCorrelativoDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Correlativo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_51_0F20( true) ;
         }
         return  ;
      }

      protected void wb_table5_51_0F20e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("GridName", "Gridcorrelativo_correlativodet");
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("Class", "Grid");
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcorrelativo_correlativodet_Backcolorstyle), 1, 0, ".", "")));
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("CmpContext", "");
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("InMasterPage", "false");
            Gridcorrelativo_correlativodetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcorrelativo_correlativodetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A63CorrelativoAnio), 4, 0, ".", "")));
            Gridcorrelativo_correlativodetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorrelativoAnio_Enabled), 5, 0, ".", "")));
            Gridcorrelativo_correlativodetContainer.AddColumnProperties(Gridcorrelativo_correlativodetColumn);
            Gridcorrelativo_correlativodetColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcorrelativo_correlativodetColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A64CorrelativoSiguiente), 9, 0, ".", "")));
            Gridcorrelativo_correlativodetColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorrelativoSiguiente_Enabled), 5, 0, ".", "")));
            Gridcorrelativo_correlativodetContainer.AddColumnProperties(Gridcorrelativo_correlativodetColumn);
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("Allowselection", "false");
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("Allowcollapsing", ((subGridcorrelativo_correlativodet_Allowcollapsing==1) ? "true" : "false"));
            Gridcorrelativo_correlativodetContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcorrelativo_correlativodet_Collapsed), 9, 0, ".", "")));
            nGXsfl_55_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount21 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_21 = 1 ;
                  ScanStart0F21( ) ;
                  while ( RcdFound21 != 0 )
                  {
                     init_level_properties21( ) ;
                     getByPrimaryKey0F21( ) ;
                     AddRow0F21( ) ;
                     ScanNext0F21( ) ;
                  }
                  ScanEnd0F21( ) ;
                  nBlankRcdCount21 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0F21( ) ;
               standaloneModal0F21( ) ;
               sMode21 = Gx_mode ;
               while ( nGXsfl_55_idx < nRC_Gridcorrelativo_correlativodet )
               {
                  ReadRow0F21( ) ;
                  edtCorrelativoAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "CORRELATIVOANIO_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
                  edtCorrelativoSiguiente_Enabled = (int)(context.localUtil.CToN( cgiGet( "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
                  if ( ( nRcdExists_21 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0F21( ) ;
                  }
                  SendRow0F21( ) ;
               }
               Gx_mode = sMode21 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount21 = 5 ;
               nRcdExists_21 = 1 ;
               ScanStart0F21( ) ;
               while ( RcdFound21 != 0 )
               {
                  init_level_properties21( ) ;
                  getByPrimaryKey0F21( ) ;
                  standaloneNotModal0F21( ) ;
                  standaloneModal0F21( ) ;
                  AddRow0F21( ) ;
                  ScanNext0F21( ) ;
               }
               ScanEnd0F21( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode21 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0F21( ) ;
            init_level_properties21( ) ;
            standaloneNotModal0F21( ) ;
            standaloneModal0F21( ) ;
            nRcdExists_21 = 0 ;
            nIsMod_21 = 0 ;
            nBlankRcdCount21 = (short)(nBlankRcdUsr21+nBlankRcdCount21) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount21 > 0 )
            {
               AddRow0F21( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtCorrelativoAnio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount21 = (short)(nBlankRcdCount21-1) ;
            }
            Gx_mode = sMode21 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridcorrelativo_correlativodetContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcorrelativo_correlativodet", (Object)(Gridcorrelativo_correlativodetContainer));
            GxWebStd.gx_hidden_field( context, "Gridcorrelativo_correlativodetContainerData", Gridcorrelativo_correlativodetContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridcorrelativo_correlativodetContainerData"+"V", Gridcorrelativo_correlativodetContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcorrelativo_correlativodetContainerData"+"V"+"\" value='"+Gridcorrelativo_correlativodetContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0F20e( true) ;
         }
         else
         {
            wb_table4_33_0F20e( false) ;
         }
      }

      protected void wb_table5_51_0F20( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitlecorrelativodet_Internalname, "Detalle de correlativos", "", "", lblTitlecorrelativodet_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Correlativo.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_51_0F20e( true) ;
         }
         else
         {
            wb_table5_51_0F20e( false) ;
         }
      }

      protected void wb_table2_5_0F20( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00k0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CORRELATIVOID"+"'), id:'"+"CORRELATIVOID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00k0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CLINICACODIGO"+"'), id:'"+"CLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"CORRELATIVOID"+"'), id:'"+"CORRELATIVOID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Correlativo.htm");
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
            wb_table2_5_0F20e( true) ;
         }
         else
         {
            wb_table2_5_0F20e( false) ;
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
         /* Execute user event: E110F2 */
         E110F2 ();
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtCorrelativoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCorrelativoId_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CORRELATIVOID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCorrelativoId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A61CorrelativoId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
               }
               else
               {
                  A61CorrelativoId = (int)(context.localUtil.CToN( cgiGet( edtCorrelativoId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
               }
               A62CorrelativoDescripcion = cgiGet( edtCorrelativoDescripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62CorrelativoDescripcion", A62CorrelativoDescripcion);
               /* Read saved values. */
               Z41ClinicaCodigo = cgiGet( "Z41ClinicaCodigo") ;
               Z61CorrelativoId = (int)(context.localUtil.CToN( cgiGet( "Z61CorrelativoId"), ".", ",")) ;
               Z62CorrelativoDescripcion = cgiGet( "Z62CorrelativoDescripcion") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridcorrelativo_correlativodet = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridcorrelativo_correlativodet"), ".", ",")) ;
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
                  A61CorrelativoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
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
                           /* Execute user event: E110F2 */
                           E110F2 ();
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
               InitAll0F20( ) ;
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
         DisableAttributes0F20( ) ;
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

      protected void CONFIRM_0F21( )
      {
         nGXsfl_55_idx = 0 ;
         while ( nGXsfl_55_idx < nRC_Gridcorrelativo_correlativodet )
         {
            ReadRow0F21( ) ;
            if ( ( nRcdExists_21 != 0 ) || ( nIsMod_21 != 0 ) )
            {
               GetKey0F21( ) ;
               if ( ( nRcdExists_21 == 0 ) && ( nRcdDeleted_21 == 0 ) )
               {
                  if ( RcdFound21 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0F21( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0F21( ) ;
                        CloseExtendedTableCursors0F21( ) ;
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
                     GX_FocusControl = edtCorrelativoAnio_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound21 != 0 )
                  {
                     if ( nRcdDeleted_21 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0F21( ) ;
                        Load0F21( ) ;
                        BeforeValidate0F21( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0F21( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_21 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0F21( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0F21( ) ;
                              CloseExtendedTableCursors0F21( ) ;
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
                     if ( nRcdDeleted_21 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtCorrelativoAnio_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCorrelativoAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A63CorrelativoAnio), 4, 0, ".", ""))) ;
            ChangePostValue( edtCorrelativoSiguiente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A64CorrelativoSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z63CorrelativoAnio_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z63CorrelativoAnio), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z64CorrelativoSiguiente_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z64CorrelativoSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_21_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_21), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_21_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_21), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_21_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_21), 4, 0, ".", ""))) ;
            if ( nIsMod_21 != 0 )
            {
               ChangePostValue( "CORRELATIVOANIO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorrelativoAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorrelativoSiguiente_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0F0( )
      {
      }

      protected void E110F2( )
      {
         /* Start Routine */
         GXt_SdtParametros6 = AV7Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros6) ;
         AV7Parametros = GXt_SdtParametros6 ;
         AV8ClinicaCodigo = AV7Parametros.gxTpr_Pclinicacodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8ClinicaCodigo", AV8ClinicaCodigo);
      }

      protected void ZM0F20( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z62CorrelativoDescripcion = T000F5_A62CorrelativoDescripcion[0] ;
            }
            else
            {
               Z62CorrelativoDescripcion = A62CorrelativoDescripcion ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z61CorrelativoId = A61CorrelativoId ;
            Z62CorrelativoDescripcion = A62CorrelativoDescripcion ;
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

      protected void Load0F20( )
      {
         /* Using cursor T000F7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, A61CorrelativoId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound20 = 1 ;
            A62CorrelativoDescripcion = T000F7_A62CorrelativoDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62CorrelativoDescripcion", A62CorrelativoDescripcion);
            ZM0F20( -4) ;
         }
         pr_default.close(5);
         OnLoadActions0F20( ) ;
      }

      protected void OnLoadActions0F20( )
      {
      }

      protected void CheckExtendedTable0F20( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000F6 */
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

      protected void CloseExtendedTableCursors0F20( )
      {
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_5( String A41ClinicaCodigo )
      {
         /* Using cursor T000F8 */
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

      protected void GetKey0F20( )
      {
         /* Using cursor T000F9 */
         pr_default.execute(7, new Object[] {A41ClinicaCodigo, A61CorrelativoId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound20 = 1 ;
         }
         else
         {
            RcdFound20 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000F5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A61CorrelativoId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0F20( 4) ;
            RcdFound20 = 1 ;
            A61CorrelativoId = T000F5_A61CorrelativoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
            A62CorrelativoDescripcion = T000F5_A62CorrelativoDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62CorrelativoDescripcion", A62CorrelativoDescripcion);
            A41ClinicaCodigo = T000F5_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z61CorrelativoId = A61CorrelativoId ;
            sMode20 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0F20( ) ;
            Gx_mode = sMode20 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound20 = 0 ;
            InitializeNonKey0F20( ) ;
            sMode20 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode20 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey0F20( ) ;
         if ( RcdFound20 == 0 )
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
         RcdFound20 = 0 ;
         /* Using cursor T000F10 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A61CorrelativoId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000F10_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000F10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000F10_A61CorrelativoId[0] < A61CorrelativoId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T000F10_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000F10_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000F10_A61CorrelativoId[0] > A61CorrelativoId ) ) )
            {
               A41ClinicaCodigo = T000F10_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A61CorrelativoId = T000F10_A61CorrelativoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
               RcdFound20 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void move_previous( )
      {
         RcdFound20 = 0 ;
         /* Using cursor T000F11 */
         pr_default.execute(9, new Object[] {A41ClinicaCodigo, A61CorrelativoId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000F11_A41ClinicaCodigo[0], A41ClinicaCodigo) > 0 ) || ( StringUtil.StrCmp(T000F11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000F11_A61CorrelativoId[0] > A61CorrelativoId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T000F11_A41ClinicaCodigo[0], A41ClinicaCodigo) < 0 ) || ( StringUtil.StrCmp(T000F11_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( T000F11_A61CorrelativoId[0] < A61CorrelativoId ) ) )
            {
               A41ClinicaCodigo = T000F11_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A61CorrelativoId = T000F11_A61CorrelativoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
               RcdFound20 = 1 ;
            }
         }
         pr_default.close(2);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0F20( ) ;
         if ( RcdFound20 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "CLINICACODIGO");
               AnyError = 1 ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A61CorrelativoId != Z61CorrelativoId ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A61CorrelativoId = Z61CorrelativoId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
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
               Update0F20( ) ;
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A61CorrelativoId != Z61CorrelativoId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtClinicaCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0F20( ) ;
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
                  Insert0F20( ) ;
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
         if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( A61CorrelativoId != Z61CorrelativoId ) )
         {
            A41ClinicaCodigo = Z41ClinicaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A61CorrelativoId = Z61CorrelativoId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
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
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCorrelativoDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0F20( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCorrelativoDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0F20( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCorrelativoDescripcion_Internalname ;
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
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCorrelativoDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0F20( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound20 != 0 )
            {
               ScanNext0F20( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCorrelativoDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0F20( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0F20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000F12 */
            pr_default.execute(10, new Object[] {A41ClinicaCodigo, A61CorrelativoId});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Correlativo"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z62CorrelativoDescripcion, T000F12_A62CorrelativoDescripcion[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Correlativo"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0F20( )
      {
         BeforeValidate0F20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F20( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0F20( 0) ;
            CheckOptimisticConcurrency0F20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0F20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F13 */
                     pr_default.execute(11, new Object[] {A61CorrelativoId, A62CorrelativoDescripcion, A41ClinicaCodigo});
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
                           ProcessLevel0F20( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption0F0( ) ;
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
               Load0F20( ) ;
            }
            EndLevel0F20( ) ;
         }
         CloseExtendedTableCursors0F20( ) ;
      }

      protected void Update0F20( )
      {
         BeforeValidate0F20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F20( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0F20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F14 */
                     pr_default.execute(12, new Object[] {A62CorrelativoDescripcion, A41ClinicaCodigo, A61CorrelativoId});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Correlativo"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0F20( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0F20( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption0F0( ) ;
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
            EndLevel0F20( ) ;
         }
         CloseExtendedTableCursors0F20( ) ;
      }

      protected void DeferredUpdate0F20( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0F20( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F20( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0F20( ) ;
            AfterConfirm0F20( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0F20( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0F21( ) ;
                  while ( RcdFound21 != 0 )
                  {
                     getByPrimaryKey0F21( ) ;
                     Delete0F21( ) ;
                     ScanNext0F21( ) ;
                  }
                  ScanEnd0F21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F15 */
                     pr_default.execute(13, new Object[] {A41ClinicaCodigo, A61CorrelativoId});
                     pr_default.close(13);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound20 == 0 )
                           {
                              InitAll0F20( ) ;
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
                           ResetCaption0F0( ) ;
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
         sMode20 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0F20( ) ;
         Gx_mode = sMode20 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0F20( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel0F21( )
      {
         nGXsfl_55_idx = 0 ;
         while ( nGXsfl_55_idx < nRC_Gridcorrelativo_correlativodet )
         {
            ReadRow0F21( ) ;
            if ( ( nRcdExists_21 != 0 ) || ( nIsMod_21 != 0 ) )
            {
               standaloneNotModal0F21( ) ;
               GetKey0F21( ) ;
               if ( ( nRcdExists_21 == 0 ) && ( nRcdDeleted_21 == 0 ) )
               {
                  if ( RcdFound21 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0F21( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtCorrelativoAnio_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound21 != 0 )
                  {
                     if ( ( nRcdDeleted_21 != 0 ) && ( nRcdExists_21 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0F21( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_21 != 0 ) && ( nRcdExists_21 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0F21( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_21 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtCorrelativoAnio_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCorrelativoAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A63CorrelativoAnio), 4, 0, ".", ""))) ;
            ChangePostValue( edtCorrelativoSiguiente_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A64CorrelativoSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z63CorrelativoAnio_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z63CorrelativoAnio), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z64CorrelativoSiguiente_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z64CorrelativoSiguiente), 9, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_21_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_21), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_21_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_21), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_21_"+sGXsfl_55_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_21), 4, 0, ".", ""))) ;
            if ( nIsMod_21 != 0 )
            {
               ChangePostValue( "CORRELATIVOANIO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorrelativoAnio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorrelativoSiguiente_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0F21( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_21 = 0 ;
         nIsMod_21 = 0 ;
         nRcdDeleted_21 = 0 ;
      }

      protected void ProcessLevel0F20( )
      {
         /* Save parent mode. */
         sMode20 = Gx_mode ;
         ProcessNestedLevel0F21( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode20 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel0F20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0F20( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("Correlativo");
            if ( AnyError == 0 )
            {
               ConfirmValues0F0( ) ;
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
            context.RollbackDataStores("Correlativo");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0F20( )
      {
         /* Using cursor T000F16 */
         pr_default.execute(14);
         RcdFound20 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound20 = 1 ;
            A41ClinicaCodigo = T000F16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A61CorrelativoId = T000F16_A61CorrelativoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0F20( )
      {
         pr_default.readNext(14);
         RcdFound20 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound20 = 1 ;
            A41ClinicaCodigo = T000F16_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A61CorrelativoId = T000F16_A61CorrelativoId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
         }
      }

      protected void ScanEnd0F20( )
      {
      }

      protected void AfterConfirm0F20( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0F20( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0F20( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0F20( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0F20( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0F20( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0F20( )
      {
         edtClinicaCodigo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtClinicaCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtClinicaCodigo_Enabled), 5, 0)));
         edtCorrelativoId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCorrelativoId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCorrelativoId_Enabled), 5, 0)));
         edtCorrelativoDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCorrelativoDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCorrelativoDescripcion_Enabled), 5, 0)));
      }

      protected void ZM0F21( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z64CorrelativoSiguiente = T000F3_A64CorrelativoSiguiente[0] ;
            }
            else
            {
               Z64CorrelativoSiguiente = A64CorrelativoSiguiente ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z61CorrelativoId = A61CorrelativoId ;
            Z63CorrelativoAnio = A63CorrelativoAnio ;
            Z64CorrelativoSiguiente = A64CorrelativoSiguiente ;
         }
      }

      protected void standaloneNotModal0F21( )
      {
      }

      protected void standaloneModal0F21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtCorrelativoAnio_Enabled = 0 ;
         }
         else
         {
            edtCorrelativoAnio_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode21, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode21, "DLT") == 0 ) )
         {
            DisableAttributes0F21( ) ;
         }
      }

      protected void Load0F21( )
      {
         /* Using cursor T000F17 */
         pr_default.execute(15, new Object[] {A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio});
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound21 = 1 ;
            A64CorrelativoSiguiente = T000F17_A64CorrelativoSiguiente[0] ;
            ZM0F21( -6) ;
         }
         pr_default.close(15);
         OnLoadActions0F21( ) ;
      }

      protected void OnLoadActions0F21( )
      {
      }

      protected void CheckExtendedTable0F21( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0F21( ) ;
      }

      protected void CloseExtendedTableCursors0F21( )
      {
      }

      protected void enableDisable0F21( )
      {
      }

      protected void GetKey0F21( )
      {
         /* Using cursor T000F18 */
         pr_default.execute(16, new Object[] {A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound21 = 1 ;
         }
         else
         {
            RcdFound21 = 0 ;
         }
         pr_default.close(16);
      }

      protected void getByPrimaryKey0F21( )
      {
         /* Using cursor T000F3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0F21( 6) ;
            RcdFound21 = 1 ;
            InitializeNonKey0F21( ) ;
            A63CorrelativoAnio = T000F3_A63CorrelativoAnio[0] ;
            A64CorrelativoSiguiente = T000F3_A64CorrelativoSiguiente[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z61CorrelativoId = A61CorrelativoId ;
            Z63CorrelativoAnio = A63CorrelativoAnio ;
            sMode21 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0F21( ) ;
            Load0F21( ) ;
            Gx_mode = sMode21 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound21 = 0 ;
            InitializeNonKey0F21( ) ;
            sMode21 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0F21( ) ;
            Gx_mode = sMode21 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0F21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000F2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CorrelativoDet"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z64CorrelativoSiguiente != T000F2_A64CorrelativoSiguiente[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CorrelativoDet"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0F21( )
      {
         BeforeValidate0F21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F21( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0F21( 0) ;
            CheckOptimisticConcurrency0F21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0F21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F19 */
                     pr_default.execute(17, new Object[] {A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio, A64CorrelativoSiguiente});
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
               Load0F21( ) ;
            }
            EndLevel0F21( ) ;
         }
         CloseExtendedTableCursors0F21( ) ;
      }

      protected void Update0F21( )
      {
         BeforeValidate0F21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F21( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0F21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000F20 */
                     pr_default.execute(18, new Object[] {A64CorrelativoSiguiente, A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio});
                     pr_default.close(18);
                     if ( (pr_default.getStatus(18) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CorrelativoDet"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0F21( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0F21( ) ;
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
            EndLevel0F21( ) ;
         }
         CloseExtendedTableCursors0F21( ) ;
      }

      protected void DeferredUpdate0F21( )
      {
      }

      protected void Delete0F21( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0F21( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F21( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0F21( ) ;
            AfterConfirm0F21( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0F21( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000F21 */
                  pr_default.execute(19, new Object[] {A41ClinicaCodigo, A61CorrelativoId, A63CorrelativoAnio});
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
         sMode21 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0F21( ) ;
         Gx_mode = sMode21 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0F21( )
      {
         standaloneModal0F21( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0F21( )
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

      protected void ScanStart0F21( )
      {
         /* Using cursor T000F22 */
         pr_default.execute(20, new Object[] {A41ClinicaCodigo, A61CorrelativoId});
         RcdFound21 = 0 ;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound21 = 1 ;
            A63CorrelativoAnio = T000F22_A63CorrelativoAnio[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0F21( )
      {
         pr_default.readNext(20);
         RcdFound21 = 0 ;
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound21 = 1 ;
            A63CorrelativoAnio = T000F22_A63CorrelativoAnio[0] ;
         }
      }

      protected void ScanEnd0F21( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0F21( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0F21( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0F21( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0F21( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0F21( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0F21( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0F21( )
      {
         edtCorrelativoAnio_Enabled = 0 ;
         edtCorrelativoSiguiente_Enabled = 0 ;
      }

      protected void AddRow0F21( )
      {
         nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtCorrelativoAnio_Internalname = "CORRELATIVOANIO_"+sGXsfl_55_idx ;
         edtCorrelativoSiguiente_Internalname = "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx ;
         SendRow0F21( ) ;
      }

      protected void SendRow0F21( )
      {
         Gridcorrelativo_correlativodetRow = GXWebRow.GetNew(context) ;
         if ( subGridcorrelativo_correlativodet_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcorrelativo_correlativodet_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridcorrelativo_correlativodet_Class, "") != 0 )
            {
               subGridcorrelativo_correlativodet_Linesclass = subGridcorrelativo_correlativodet_Class+"Odd" ;
            }
         }
         else if ( subGridcorrelativo_correlativodet_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcorrelativo_correlativodet_Backstyle = 0 ;
            subGridcorrelativo_correlativodet_Backcolor = subGridcorrelativo_correlativodet_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcorrelativo_correlativodetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcorrelativo_correlativodet_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridcorrelativo_correlativodet_Class, "") != 0 )
            {
               subGridcorrelativo_correlativodet_Linesclass = subGridcorrelativo_correlativodet_Class+"Uniform" ;
            }
         }
         else if ( subGridcorrelativo_correlativodet_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcorrelativo_correlativodet_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridcorrelativo_correlativodet_Class, "") != 0 )
            {
               subGridcorrelativo_correlativodet_Linesclass = subGridcorrelativo_correlativodet_Class+"Odd" ;
            }
            subGridcorrelativo_correlativodet_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcorrelativo_correlativodetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcorrelativo_correlativodet_Backcolor), 9, 0)));
         }
         else if ( subGridcorrelativo_correlativodet_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcorrelativo_correlativodet_Backstyle = 1 ;
            if ( ((int)(nGXsfl_55_idx) % (2)) == 0 )
            {
               subGridcorrelativo_correlativodet_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcorrelativo_correlativodetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcorrelativo_correlativodet_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcorrelativo_correlativodet_Class, "") != 0 )
               {
                  subGridcorrelativo_correlativodet_Linesclass = subGridcorrelativo_correlativodet_Class+"Even" ;
               }
            }
            else
            {
               subGridcorrelativo_correlativodet_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcorrelativo_correlativodetContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcorrelativo_correlativodet_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcorrelativo_correlativodet_Class, "") != 0 )
               {
                  subGridcorrelativo_correlativodet_Linesclass = subGridcorrelativo_correlativodet_Class+"Odd" ;
               }
            }
         }
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_21_" + sGXsfl_55_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_55_idx + "',55)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcorrelativo_correlativodetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCorrelativoAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A63CorrelativoAnio), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A63CorrelativoAnio), "ZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(56);\"",(String)"",(String)"",(String)"",(String)"",(String)edtCorrelativoAnio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtCorrelativoAnio_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)55,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_21_" + sGXsfl_55_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_55_idx + "',55)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcorrelativo_correlativodetRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCorrelativoSiguiente_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A64CorrelativoSiguiente), 9, 0, ".", "")),((edtCorrelativoSiguiente_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A64CorrelativoSiguiente), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A64CorrelativoSiguiente), "ZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(57);\"",(String)"",(String)"",(String)"",(String)"",(String)edtCorrelativoSiguiente_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtCorrelativoSiguiente_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)55,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcorrelativo_correlativodetRow);
         GXCCtl = "Z63CorrelativoAnio_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z63CorrelativoAnio), 4, 0, ".", "")));
         GXCCtl = "Z64CorrelativoSiguiente_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z64CorrelativoSiguiente), 9, 0, ".", "")));
         GXCCtl = "nRcdDeleted_21_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_21), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_21_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_21), 4, 0, ".", "")));
         GXCCtl = "nIsMod_21_" + sGXsfl_55_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_21), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CORRELATIVOANIO_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorrelativoAnio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCorrelativoSiguiente_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcorrelativo_correlativodetContainer.AddRow(Gridcorrelativo_correlativodetRow);
      }

      protected void ReadRow0F21( )
      {
         nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtCorrelativoAnio_Internalname = "CORRELATIVOANIO_"+sGXsfl_55_idx ;
         edtCorrelativoSiguiente_Internalname = "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx ;
         edtCorrelativoAnio_Enabled = (int)(context.localUtil.CToN( cgiGet( "CORRELATIVOANIO_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
         edtCorrelativoSiguiente_Enabled = (int)(context.localUtil.CToN( cgiGet( "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx+"Enabled"), ".", ",")) ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtCorrelativoAnio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCorrelativoAnio_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CORRELATIVOANIO");
            AnyError = 1 ;
            GX_FocusControl = edtCorrelativoAnio_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A63CorrelativoAnio = 0 ;
         }
         else
         {
            A63CorrelativoAnio = (short)(context.localUtil.CToN( cgiGet( edtCorrelativoAnio_Internalname), ".", ",")) ;
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtCorrelativoSiguiente_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCorrelativoSiguiente_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CORRELATIVOSIGUIENTE");
            AnyError = 1 ;
            GX_FocusControl = edtCorrelativoSiguiente_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A64CorrelativoSiguiente = 0 ;
         }
         else
         {
            A64CorrelativoSiguiente = (int)(context.localUtil.CToN( cgiGet( edtCorrelativoSiguiente_Internalname), ".", ",")) ;
         }
         GXCCtl = "Z63CorrelativoAnio_" + sGXsfl_55_idx ;
         Z63CorrelativoAnio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z64CorrelativoSiguiente_" + sGXsfl_55_idx ;
         Z64CorrelativoSiguiente = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdDeleted_21_" + sGXsfl_55_idx ;
         nRcdDeleted_21 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_21_" + sGXsfl_55_idx ;
         nRcdExists_21 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_21_" + sGXsfl_55_idx ;
         nIsMod_21 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtCorrelativoAnio_Enabled = edtCorrelativoAnio_Enabled ;
      }

      protected void ConfirmValues0F0( )
      {
         nGXsfl_55_idx = 0 ;
         sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
         edtCorrelativoAnio_Internalname = "CORRELATIVOANIO_"+sGXsfl_55_idx ;
         edtCorrelativoSiguiente_Internalname = "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx ;
         while ( nGXsfl_55_idx < nRC_Gridcorrelativo_correlativodet )
         {
            nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
            sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
            edtCorrelativoAnio_Internalname = "CORRELATIVOANIO_"+sGXsfl_55_idx ;
            edtCorrelativoSiguiente_Internalname = "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx ;
            ChangePostValue( "Z63CorrelativoAnio_"+sGXsfl_55_idx, cgiGet( "ZT_"+"Z63CorrelativoAnio_"+sGXsfl_55_idx)) ;
            DeletePostValue( "ZT_"+"Z63CorrelativoAnio_"+sGXsfl_55_idx) ;
            ChangePostValue( "Z64CorrelativoSiguiente_"+sGXsfl_55_idx, cgiGet( "ZT_"+"Z64CorrelativoSiguiente_"+sGXsfl_55_idx)) ;
            DeletePostValue( "ZT_"+"Z64CorrelativoSiguiente_"+sGXsfl_55_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("correlativo.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z41ClinicaCodigo", StringUtil.RTrim( Z41ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "Z61CorrelativoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z61CorrelativoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z62CorrelativoDescripcion", StringUtil.RTrim( Z62CorrelativoDescripcion));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridcorrelativo_correlativodet", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_55_idx), 4, 0, ".", "")));
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
         return "Correlativo" ;
      }

      public override String GetPgmdesc( )
      {
         return "Correlativos del sistema" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("correlativo.aspx")  ;
      }

      protected void InitializeNonKey0F20( )
      {
         A62CorrelativoDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62CorrelativoDescripcion", A62CorrelativoDescripcion);
      }

      protected void InitAll0F20( )
      {
         A41ClinicaCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
         A61CorrelativoId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61CorrelativoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A61CorrelativoId), 9, 0)));
         InitializeNonKey0F20( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0F21( )
      {
         A64CorrelativoSiguiente = 0 ;
      }

      protected void InitAll0F21( )
      {
         A63CorrelativoAnio = 0 ;
         InitializeNonKey0F21( ) ;
      }

      protected void StandaloneModalInsert0F21( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1545137");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("correlativo.js", "?1545137");
         /* End function include_jscripts */
      }

      protected void init_level_properties21( )
      {
         edtCorrelativoAnio_Enabled = defedtCorrelativoAnio_Enabled ;
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
         lblTextblockcorrelativoid_Internalname = "TEXTBLOCKCORRELATIVOID" ;
         edtCorrelativoId_Internalname = "CORRELATIVOID" ;
         lblTextblockcorrelativodescripcion_Internalname = "TEXTBLOCKCORRELATIVODESCRIPCION" ;
         edtCorrelativoDescripcion_Internalname = "CORRELATIVODESCRIPCION" ;
         lblTitlecorrelativodet_Internalname = "TITLECORRELATIVODET" ;
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
         subGridcorrelativo_correlativodet_Internalname = "GRIDCORRELATIVO_CORRELATIVODET" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Correlativos del sistema" ;
         edtCorrelativoSiguiente_Jsonclick = "" ;
         edtCorrelativoAnio_Jsonclick = "" ;
         subGridcorrelativo_correlativodet_Class = "Grid" ;
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
         subGridcorrelativo_correlativodet_Allowcollapsing = 0 ;
         edtCorrelativoSiguiente_Enabled = 1 ;
         edtCorrelativoAnio_Enabled = 1 ;
         subGridcorrelativo_correlativodet_Backcolorstyle = 2 ;
         edtCorrelativoDescripcion_Jsonclick = "" ;
         edtCorrelativoDescripcion_Enabled = 1 ;
         edtCorrelativoId_Jsonclick = "" ;
         edtCorrelativoId_Enabled = 1 ;
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

      protected void gxnrGridcorrelativo_correlativodet_newrow( short nRC_Gridcorrelativo_correlativodet ,
                                                                short nGXsfl_55_idx ,
                                                                String sGXsfl_55_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtCorrelativoAnio_Internalname = "CORRELATIVOANIO_"+sGXsfl_55_idx ;
         edtCorrelativoSiguiente_Internalname = "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx ;
         while ( nGXsfl_55_idx <= nRC_Gridcorrelativo_correlativodet )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0F21( ) ;
            standaloneModal0F21( ) ;
            dynload_actions( ) ;
            SendRow0F21( ) ;
            nGXsfl_55_idx = (short)(nGXsfl_55_idx+1) ;
            sGXsfl_55_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_55_idx), 4, 0)), 4, "0") ;
            edtCorrelativoAnio_Internalname = "CORRELATIVOANIO_"+sGXsfl_55_idx ;
            edtCorrelativoSiguiente_Internalname = "CORRELATIVOSIGUIENTE_"+sGXsfl_55_idx ;
         }
         context.GX_webresponse.AddString(Gridcorrelativo_correlativodetContainer.ToJavascriptSource());
         /* End function gxnrGridcorrelativo_correlativodet_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000F23 */
         pr_default.execute(21, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(21) == 101) )
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
         pr_default.close(21);
         GX_FocusControl = edtCorrelativoDescripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Clinicacodigo( String GX_Parm1 )
      {
         A41ClinicaCodigo = GX_Parm1 ;
         /* Using cursor T000F23 */
         pr_default.execute(21, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(21) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
            GX_FocusControl = edtClinicaCodigo_Internalname ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(21);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Correlativoid( String GX_Parm1 ,
                                       String GX_Parm2 ,
                                       int GX_Parm3 ,
                                       String GX_Parm4 )
      {
         AV8ClinicaCodigo = GX_Parm1 ;
         A41ClinicaCodigo = GX_Parm2 ;
         A61CorrelativoId = GX_Parm3 ;
         A62CorrelativoDescripcion = GX_Parm4 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A62CorrelativoDescripcion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z41ClinicaCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z61CorrelativoId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z62CorrelativoDescripcion)));
         isValidOutput.Add((Object)(Gridcorrelativo_correlativodetContainer));
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
         pr_default.close(20);
         pr_default.close(14);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(21);
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
         lblTextblockcorrelativoid_Jsonclick = "" ;
         lblTextblockcorrelativodescripcion_Jsonclick = "" ;
         A62CorrelativoDescripcion = "" ;
         Gridcorrelativo_correlativodetContainer = new GXWebGrid( context);
         Gridcorrelativo_correlativodetColumn = new GXWebColumn();
         Gx_mode = "" ;
         sMode21 = "" ;
         edtCorrelativoAnio_Internalname = "" ;
         lblTitlecorrelativodet_Jsonclick = "" ;
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
         Z62CorrelativoDescripcion = "" ;
         AV8ClinicaCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtCorrelativoSiguiente_Internalname = "" ;
         AV7Parametros = new SdtParametros(context);
         GXt_SdtParametros6 = new SdtParametros(context);
         T000F7_A61CorrelativoId = new int[1] ;
         T000F7_A62CorrelativoDescripcion = new String[] {""} ;
         T000F7_A41ClinicaCodigo = new String[] {""} ;
         T000F6_A41ClinicaCodigo = new String[] {""} ;
         T000F8_A41ClinicaCodigo = new String[] {""} ;
         T000F9_A41ClinicaCodigo = new String[] {""} ;
         T000F9_A61CorrelativoId = new int[1] ;
         T000F5_A61CorrelativoId = new int[1] ;
         T000F5_A62CorrelativoDescripcion = new String[] {""} ;
         T000F5_A41ClinicaCodigo = new String[] {""} ;
         sMode20 = "" ;
         T000F10_A41ClinicaCodigo = new String[] {""} ;
         T000F10_A61CorrelativoId = new int[1] ;
         T000F11_A41ClinicaCodigo = new String[] {""} ;
         T000F11_A61CorrelativoId = new int[1] ;
         T000F12_A61CorrelativoId = new int[1] ;
         T000F12_A62CorrelativoDescripcion = new String[] {""} ;
         T000F12_A41ClinicaCodigo = new String[] {""} ;
         T000F16_A41ClinicaCodigo = new String[] {""} ;
         T000F16_A61CorrelativoId = new int[1] ;
         T000F17_A41ClinicaCodigo = new String[] {""} ;
         T000F17_A61CorrelativoId = new int[1] ;
         T000F17_A63CorrelativoAnio = new short[1] ;
         T000F17_A64CorrelativoSiguiente = new int[1] ;
         T000F18_A41ClinicaCodigo = new String[] {""} ;
         T000F18_A61CorrelativoId = new int[1] ;
         T000F18_A63CorrelativoAnio = new short[1] ;
         T000F3_A41ClinicaCodigo = new String[] {""} ;
         T000F3_A61CorrelativoId = new int[1] ;
         T000F3_A63CorrelativoAnio = new short[1] ;
         T000F3_A64CorrelativoSiguiente = new int[1] ;
         T000F2_A41ClinicaCodigo = new String[] {""} ;
         T000F2_A61CorrelativoId = new int[1] ;
         T000F2_A63CorrelativoAnio = new short[1] ;
         T000F2_A64CorrelativoSiguiente = new int[1] ;
         T000F22_A41ClinicaCodigo = new String[] {""} ;
         T000F22_A61CorrelativoId = new int[1] ;
         T000F22_A63CorrelativoAnio = new short[1] ;
         Gridcorrelativo_correlativodetRow = new GXWebRow();
         subGridcorrelativo_correlativodet_Linesclass = "" ;
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
         T000F23_A41ClinicaCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.correlativo__default(),
            new Object[][] {
                new Object[] {
               T000F2_A41ClinicaCodigo, T000F2_A61CorrelativoId, T000F2_A63CorrelativoAnio, T000F2_A64CorrelativoSiguiente
               }
               , new Object[] {
               T000F3_A41ClinicaCodigo, T000F3_A61CorrelativoId, T000F3_A63CorrelativoAnio, T000F3_A64CorrelativoSiguiente
               }
               , new Object[] {
               T000F4_A61CorrelativoId, T000F4_A62CorrelativoDescripcion, T000F4_A41ClinicaCodigo
               }
               , new Object[] {
               T000F5_A61CorrelativoId, T000F5_A62CorrelativoDescripcion, T000F5_A41ClinicaCodigo
               }
               , new Object[] {
               T000F6_A41ClinicaCodigo
               }
               , new Object[] {
               T000F7_A61CorrelativoId, T000F7_A62CorrelativoDescripcion, T000F7_A41ClinicaCodigo
               }
               , new Object[] {
               T000F8_A41ClinicaCodigo
               }
               , new Object[] {
               T000F9_A41ClinicaCodigo, T000F9_A61CorrelativoId
               }
               , new Object[] {
               T000F10_A41ClinicaCodigo, T000F10_A61CorrelativoId
               }
               , new Object[] {
               T000F11_A41ClinicaCodigo, T000F11_A61CorrelativoId
               }
               , new Object[] {
               T000F12_A61CorrelativoId, T000F12_A62CorrelativoDescripcion, T000F12_A41ClinicaCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000F16_A41ClinicaCodigo, T000F16_A61CorrelativoId
               }
               , new Object[] {
               T000F17_A41ClinicaCodigo, T000F17_A61CorrelativoId, T000F17_A63CorrelativoAnio, T000F17_A64CorrelativoSiguiente
               }
               , new Object[] {
               T000F18_A41ClinicaCodigo, T000F18_A61CorrelativoId, T000F18_A63CorrelativoAnio
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000F22_A41ClinicaCodigo, T000F22_A61CorrelativoId, T000F22_A63CorrelativoAnio
               }
               , new Object[] {
               T000F23_A41ClinicaCodigo
               }
            }
         );
      }

      private short GxWebError ;
      private short nRC_Gridcorrelativo_correlativodet ;
      private short nGXsfl_55_idx=1 ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridcorrelativo_correlativodet_Backcolorstyle ;
      private short A63CorrelativoAnio ;
      private short subGridcorrelativo_correlativodet_Allowcollapsing ;
      private short subGridcorrelativo_correlativodet_Collapsed ;
      private short nBlankRcdCount21 ;
      private short nRcdExists_21 ;
      private short RcdFound21 ;
      private short nIsMod_21 ;
      private short nBlankRcdUsr21 ;
      private short nRcdDeleted_21 ;
      private short Z63CorrelativoAnio ;
      private short GX_JID ;
      private short RcdFound20 ;
      private short Gx_BScreen ;
      private short subGridcorrelativo_correlativodet_Backstyle ;
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
      private int A61CorrelativoId ;
      private int edtCorrelativoId_Enabled ;
      private int edtCorrelativoDescripcion_Enabled ;
      private int edtCorrelativoAnio_Enabled ;
      private int A64CorrelativoSiguiente ;
      private int edtCorrelativoSiguiente_Enabled ;
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
      private int Z61CorrelativoId ;
      private int GRIDCORRELATIVO_CORRELATIVODET_nFirstRecordOnPage ;
      private int Z64CorrelativoSiguiente ;
      private int AnyError41 ;
      private int subGridcorrelativo_correlativodet_Backcolor ;
      private int subGridcorrelativo_correlativodet_Allbackcolor ;
      private int defedtCorrelativoAnio_Enabled ;
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
      private String lblTextblockcorrelativoid_Internalname ;
      private String lblTextblockcorrelativoid_Jsonclick ;
      private String edtCorrelativoId_Internalname ;
      private String edtCorrelativoId_Jsonclick ;
      private String lblTextblockcorrelativodescripcion_Internalname ;
      private String lblTextblockcorrelativodescripcion_Jsonclick ;
      private String edtCorrelativoDescripcion_Internalname ;
      private String edtCorrelativoDescripcion_Jsonclick ;
      private String Gx_mode ;
      private String sMode21 ;
      private String edtCorrelativoAnio_Internalname ;
      private String tblTable3_Internalname ;
      private String lblTitlecorrelativodet_Internalname ;
      private String lblTitlecorrelativodet_Jsonclick ;
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
      private String edtCorrelativoSiguiente_Internalname ;
      private String sMode20 ;
      private String subGridcorrelativo_correlativodet_Class ;
      private String subGridcorrelativo_correlativodet_Linesclass ;
      private String ROClassString ;
      private String edtCorrelativoAnio_Jsonclick ;
      private String edtCorrelativoSiguiente_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char7 ;
      private String GXt_char5 ;
      private String subGridcorrelativo_correlativodet_Internalname ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A62CorrelativoDescripcion ;
      private String Z41ClinicaCodigo ;
      private String Z62CorrelativoDescripcion ;
      private String AV8ClinicaCodigo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridcorrelativo_correlativodetContainer ;
      private GXWebRow Gridcorrelativo_correlativodetRow ;
      private GXWebColumn Gridcorrelativo_correlativodetColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000F7_A61CorrelativoId ;
      private String[] T000F7_A62CorrelativoDescripcion ;
      private String[] T000F7_A41ClinicaCodigo ;
      private String[] T000F6_A41ClinicaCodigo ;
      private String[] T000F8_A41ClinicaCodigo ;
      private String[] T000F9_A41ClinicaCodigo ;
      private int[] T000F9_A61CorrelativoId ;
      private int[] T000F5_A61CorrelativoId ;
      private String[] T000F5_A62CorrelativoDescripcion ;
      private String[] T000F5_A41ClinicaCodigo ;
      private String[] T000F10_A41ClinicaCodigo ;
      private int[] T000F10_A61CorrelativoId ;
      private String[] T000F11_A41ClinicaCodigo ;
      private int[] T000F11_A61CorrelativoId ;
      private int[] T000F12_A61CorrelativoId ;
      private String[] T000F12_A62CorrelativoDescripcion ;
      private String[] T000F12_A41ClinicaCodigo ;
      private String[] T000F16_A41ClinicaCodigo ;
      private int[] T000F16_A61CorrelativoId ;
      private String[] T000F17_A41ClinicaCodigo ;
      private int[] T000F17_A61CorrelativoId ;
      private short[] T000F17_A63CorrelativoAnio ;
      private int[] T000F17_A64CorrelativoSiguiente ;
      private String[] T000F18_A41ClinicaCodigo ;
      private int[] T000F18_A61CorrelativoId ;
      private short[] T000F18_A63CorrelativoAnio ;
      private String[] T000F3_A41ClinicaCodigo ;
      private int[] T000F3_A61CorrelativoId ;
      private short[] T000F3_A63CorrelativoAnio ;
      private int[] T000F3_A64CorrelativoSiguiente ;
      private String[] T000F2_A41ClinicaCodigo ;
      private int[] T000F2_A61CorrelativoId ;
      private short[] T000F2_A63CorrelativoAnio ;
      private int[] T000F2_A64CorrelativoSiguiente ;
      private String[] T000F22_A41ClinicaCodigo ;
      private int[] T000F22_A61CorrelativoId ;
      private short[] T000F22_A63CorrelativoAnio ;
      private String[] T000F23_A41ClinicaCodigo ;
      private int[] T000F4_A61CorrelativoId ;
      private String[] T000F4_A62CorrelativoDescripcion ;
      private String[] T000F4_A41ClinicaCodigo ;
      private GXWebForm Form ;
      private SdtParametros AV7Parametros ;
      private SdtParametros GXt_SdtParametros6 ;
   }

   public class correlativo__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000F4 ;
          prmT000F4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F7 ;
          prmT000F7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F6 ;
          prmT000F6 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000F8 ;
          prmT000F8 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000F9 ;
          prmT000F9 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F5 ;
          prmT000F5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F10 ;
          prmT000F10 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F11 ;
          prmT000F11 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F12 ;
          prmT000F12 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F13 ;
          prmT000F13 = new Object[] {
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000F14 ;
          prmT000F14 = new Object[] {
          new Object[] {"@CorrelativoDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F15 ;
          prmT000F15 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F16 ;
          prmT000F16 = new Object[] {
          } ;
          Object[] prmT000F17 ;
          prmT000F17 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F18 ;
          prmT000F18 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F3 ;
          prmT000F3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F2 ;
          prmT000F2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F19 ;
          prmT000F19 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CorrelativoSiguiente",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F20 ;
          prmT000F20 = new Object[] {
          new Object[] {"@CorrelativoSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F21 ;
          prmT000F21 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@CorrelativoAnio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000F22 ;
          prmT000F22 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorrelativoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000F23 ;
          prmT000F23 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000F2", "SELECT [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio], [CorrelativoSiguiente] FROM [CorrelativoDet] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId AND [CorrelativoAnio] = @CorrelativoAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F2,1,0,true,false )
             ,new CursorDef("T000F3", "SELECT [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio], [CorrelativoSiguiente] FROM [CorrelativoDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId AND [CorrelativoAnio] = @CorrelativoAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F3,1,0,true,false )
             ,new CursorDef("T000F4", "SELECT [CorrelativoId], [CorrelativoDescripcion], [ClinicaCodigo] FROM [Correlativo] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F4,1,0,true,false )
             ,new CursorDef("T000F5", "SELECT [CorrelativoId], [CorrelativoDescripcion], [ClinicaCodigo] FROM [Correlativo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F5,1,0,true,false )
             ,new CursorDef("T000F6", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F6,1,0,true,false )
             ,new CursorDef("T000F7", "SELECT TM1.[CorrelativoId], TM1.[CorrelativoDescripcion], TM1.[ClinicaCodigo] FROM [Correlativo] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[CorrelativoId] = @CorrelativoId ORDER BY TM1.[ClinicaCodigo], TM1.[CorrelativoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F7,100,0,true,false )
             ,new CursorDef("T000F8", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F8,1,0,true,false )
             ,new CursorDef("T000F9", "SELECT [ClinicaCodigo], [CorrelativoId] FROM [Correlativo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F9,1,0,true,false )
             ,new CursorDef("T000F10", "SELECT TOP 1 [ClinicaCodigo], [CorrelativoId] FROM [Correlativo] WITH (NOLOCK) WHERE ( [ClinicaCodigo] > @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CorrelativoId] > @CorrelativoId) ORDER BY [ClinicaCodigo], [CorrelativoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F10,1,0,true,true )
             ,new CursorDef("T000F11", "SELECT TOP 1 [ClinicaCodigo], [CorrelativoId] FROM [Correlativo] WITH (NOLOCK) WHERE ( [ClinicaCodigo] < @ClinicaCodigo or [ClinicaCodigo] = @ClinicaCodigo and [CorrelativoId] < @CorrelativoId) ORDER BY [ClinicaCodigo] DESC, [CorrelativoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F11,1,0,true,true )
             ,new CursorDef("T000F12", "SELECT [CorrelativoId], [CorrelativoDescripcion], [ClinicaCodigo] FROM [Correlativo] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F12,1,0,true,false )
             ,new CursorDef("T000F13", "INSERT INTO [Correlativo] ([CorrelativoId], [CorrelativoDescripcion], [ClinicaCodigo]) VALUES (@CorrelativoId, @CorrelativoDescripcion, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmT000F13)
             ,new CursorDef("T000F14", "UPDATE [Correlativo] SET [CorrelativoDescripcion]=@CorrelativoDescripcion  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId", GxErrorMask.GX_NOMASK,prmT000F14)
             ,new CursorDef("T000F15", "DELETE FROM [Correlativo]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId", GxErrorMask.GX_NOMASK,prmT000F15)
             ,new CursorDef("T000F16", "SELECT [ClinicaCodigo], [CorrelativoId] FROM [Correlativo] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CorrelativoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000F16,100,0,true,false )
             ,new CursorDef("T000F17", "SELECT [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio], [CorrelativoSiguiente] FROM [CorrelativoDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CorrelativoId] = @CorrelativoId and [CorrelativoAnio] = @CorrelativoAnio ORDER BY [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F17,11,0,true,false )
             ,new CursorDef("T000F18", "SELECT [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio] FROM [CorrelativoDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId AND [CorrelativoAnio] = @CorrelativoAnio ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F18,1,0,true,false )
             ,new CursorDef("T000F19", "INSERT INTO [CorrelativoDet] ([ClinicaCodigo], [CorrelativoId], [CorrelativoAnio], [CorrelativoSiguiente]) VALUES (@ClinicaCodigo, @CorrelativoId, @CorrelativoAnio, @CorrelativoSiguiente)", GxErrorMask.GX_NOMASK,prmT000F19)
             ,new CursorDef("T000F20", "UPDATE [CorrelativoDet] SET [CorrelativoSiguiente]=@CorrelativoSiguiente  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId AND [CorrelativoAnio] = @CorrelativoAnio", GxErrorMask.GX_NOMASK,prmT000F20)
             ,new CursorDef("T000F21", "DELETE FROM [CorrelativoDet]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CorrelativoId] = @CorrelativoId AND [CorrelativoAnio] = @CorrelativoAnio", GxErrorMask.GX_NOMASK,prmT000F21)
             ,new CursorDef("T000F22", "SELECT [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio] FROM [CorrelativoDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CorrelativoId] = @CorrelativoId ORDER BY [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F22,11,0,true,false )
             ,new CursorDef("T000F23", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000F23,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 21 :
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
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 18 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
