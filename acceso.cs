/*
               File: Acceso
        Description: Accesos al sistema
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:14.0
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
   public class acceso : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A1GrupoCodigo = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_2( A1GrupoCodigo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A8MenuId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A8MenuId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A8MenuId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
            A11OpcionId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A8MenuId, A11OpcionId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridacceso_opcion") == 0 )
         {
            nRC_Gridacceso_opcion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_56_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_56_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridacceso_opcion_newrow( nRC_Gridacceso_opcion, nGXsfl_56_idx, sGXsfl_56_idx) ;
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
         dynGrupoCodigo.Name = "GRUPOCODIGO" ;
         dynGrupoCodigo.WebTags = "" ;
         dynGrupoCodigo.removeAllItems();
         /* Using cursor T00049 */
         pr_default.execute(7);
         while ( (pr_default.getStatus(7) != 101) )
         {
            dynGrupoCodigo.addItem(T00049_A1GrupoCodigo[0], T00049_A2GrupoDescripcion[0], 0);
            pr_default.readNext(7);
         }
         pr_default.close(7);
         if ( ( dynGrupoCodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A1GrupoCodigo)) )
         {
            A1GrupoCodigo = dynGrupoCodigo.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
         }
         cmbMenuAcceso.Name = "MENUACCESO" ;
         cmbMenuAcceso.WebTags = "" ;
         cmbMenuAcceso.addItem("0", "No", 0);
         cmbMenuAcceso.addItem("1", "Si", 0);
         if ( ( cmbMenuAcceso.ItemCount > 0 ) && (0==A15MenuAcceso) )
         {
            A15MenuAcceso = (short)(NumberUtil.Val( cmbMenuAcceso.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15MenuAcceso", StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0));
         }
         GXCCtl = "OPCIONACCESO_" + sGXsfl_56_idx ;
         cmbOpcionAcceso.Name = GXCCtl ;
         cmbOpcionAcceso.WebTags = "" ;
         cmbOpcionAcceso.addItem("0", "No", 0);
         cmbOpcionAcceso.addItem("1", "Si", 0);
         if ( ( cmbOpcionAcceso.ItemCount > 0 ) && (0==A16OpcionAcceso) )
         {
            A16OpcionAcceso = (short)(NumberUtil.Val( cmbOpcionAcceso.getItemValue(1), ".")) ;
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Accesos al sistema", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = dynGrupoCodigo_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Fantastic");
      }

      public acceso( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public acceso( IGxContext context )
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
         cmbMenuAcceso = new GXCombobox();
         cmbOpcionAcceso = new GXCombobox();
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
            wb_table1_2_045( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_045e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_045( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_045( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_045e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Accesos al sistema"+"</legend>") ;
            wb_table3_27_045( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_045e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_045e( true) ;
         }
         else
         {
            wb_table1_2_045e( false) ;
         }
      }

      protected void wb_table3_27_045( bool wbgen )
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
            wb_table4_33_045( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_045e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "standard", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Acceso.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Acceso.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "standard", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Acceso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_045e( true) ;
         }
         else
         {
            wb_table3_27_045e( false) ;
         }
      }

      protected void wb_table4_33_045( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupocodigo_Internalname, "Grupo", "", "", lblTextblockgrupocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Acceso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynGrupoCodigo, dynGrupoCodigo_Internalname, A1GrupoCodigo, 1, dynGrupoCodigo_Jsonclick, 0, "", "svchar", "", 1, dynGrupoCodigo.Enabled, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", true, "HLP_Acceso.htm");
            dynGrupoCodigo.CurrentValue = A1GrupoCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGrupoCodigo_Internalname, "Values", (String)(dynGrupoCodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmenuid_Internalname, "Id", "", "", lblTextblockmenuid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Acceso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMenuId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8MenuId), 9, 0, ".", "")), ((edtMenuId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A8MenuId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A8MenuId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(43);\"", "", "", "", "", edtMenuId_Jsonclick, 0, ClassString, StyleString, "", 1, edtMenuId_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Acceso.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_8_Internalname, "prompt.gif", imgprompt_8_Link, "", "", "Fantastic", imgprompt_8_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Acceso.htm");
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMenuDescripcion_Internalname, StringUtil.RTrim( A9MenuDescripcion), StringUtil.RTrim( context.localUtil.Format( A9MenuDescripcion, "")), "", "", "", "", "", edtMenuDescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, edtMenuDescripcion_Enabled, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_Acceso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmenuacceso_Internalname, "Acceso", "", "", lblTextblockmenuacceso_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Acceso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15MenuAcceso", StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbMenuAcceso, cmbMenuAcceso_Internalname, StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0), 1, cmbMenuAcceso_Jsonclick, 0, "", "int", "", 1, cmbMenuAcceso.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(49);\"", "", true, "HLP_Acceso.htm");
            cmbMenuAcceso.CurrentValue = StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMenuAcceso_Internalname, "Values", (String)(cmbMenuAcceso.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_52_045( true) ;
         }
         return  ;
      }

      protected void wb_table5_52_045e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridacceso_opcionContainer.AddObjectProperty("GridName", "Gridacceso_opcion");
            Gridacceso_opcionContainer.AddObjectProperty("Class", "Grid");
            Gridacceso_opcionContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridacceso_opcionContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridacceso_opcionContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridacceso_opcion_Backcolorstyle), 1, 0, ".", "")));
            Gridacceso_opcionContainer.AddObjectProperty("CmpContext", "");
            Gridacceso_opcionContainer.AddObjectProperty("InMasterPage", "false");
            Gridacceso_opcionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridacceso_opcionColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11OpcionId), 9, 0, ".", "")));
            Gridacceso_opcionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionId_Enabled), 5, 0, ".", "")));
            Gridacceso_opcionContainer.AddColumnProperties(Gridacceso_opcionColumn);
            Gridacceso_opcionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridacceso_opcionContainer.AddColumnProperties(Gridacceso_opcionColumn);
            Gridacceso_opcionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridacceso_opcionColumn.AddObjectProperty("Value", StringUtil.RTrim( A12OpcionDescripcion));
            Gridacceso_opcionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionDescripcion_Enabled), 5, 0, ".", "")));
            Gridacceso_opcionContainer.AddColumnProperties(Gridacceso_opcionColumn);
            Gridacceso_opcionColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridacceso_opcionColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16OpcionAcceso), 1, 0, ".", "")));
            Gridacceso_opcionColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbOpcionAcceso.Enabled), 5, 0, ".", "")));
            Gridacceso_opcionContainer.AddColumnProperties(Gridacceso_opcionColumn);
            Gridacceso_opcionContainer.AddObjectProperty("Allowselection", "false");
            Gridacceso_opcionContainer.AddObjectProperty("Allowcollapsing", ((subGridacceso_opcion_Allowcollapsing==1) ? "true" : "false"));
            Gridacceso_opcionContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridacceso_opcion_Collapsed), 9, 0, ".", "")));
            nGXsfl_56_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount6 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_6 = 1 ;
                  ScanStart046( ) ;
                  while ( RcdFound6 != 0 )
                  {
                     init_level_properties6( ) ;
                     getByPrimaryKey046( ) ;
                     AddRow046( ) ;
                     ScanNext046( ) ;
                  }
                  ScanEnd046( ) ;
                  nBlankRcdCount6 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal046( ) ;
               standaloneModal046( ) ;
               sMode6 = Gx_mode ;
               while ( nGXsfl_56_idx < nRC_Gridacceso_opcion )
               {
                  ReadRow046( ) ;
                  edtOpcionId_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONID_"+sGXsfl_56_idx+"Enabled"), ".", ",")) ;
                  edtOpcionDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONDESCRIPCION_"+sGXsfl_56_idx+"Enabled"), ".", ",")) ;
                  cmbOpcionAcceso.Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONACCESO_"+sGXsfl_56_idx+"Enabled"), ".", ",")) ;
                  imgprompt_8_Link = cgiGet( "PROMPT_11_"+sGXsfl_56_idx+"Link") ;
                  if ( ( nRcdExists_6 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal046( ) ;
                  }
                  SendRow046( ) ;
               }
               Gx_mode = sMode6 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount6 = 5 ;
               nRcdExists_6 = 1 ;
               ScanStart046( ) ;
               while ( RcdFound6 != 0 )
               {
                  init_level_properties6( ) ;
                  getByPrimaryKey046( ) ;
                  standaloneNotModal046( ) ;
                  standaloneModal046( ) ;
                  AddRow046( ) ;
                  ScanNext046( ) ;
               }
               ScanEnd046( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode6 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll046( ) ;
            init_level_properties6( ) ;
            standaloneNotModal046( ) ;
            standaloneModal046( ) ;
            nRcdExists_6 = 0 ;
            nIsMod_6 = 0 ;
            nBlankRcdCount6 = (short)(nBlankRcdUsr6+nBlankRcdCount6) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount6 > 0 )
            {
               AddRow046( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtOpcionId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount6 = (short)(nBlankRcdCount6-1) ;
            }
            Gx_mode = sMode6 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridacceso_opcionContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridacceso_opcion", (Object)(Gridacceso_opcionContainer));
            GxWebStd.gx_hidden_field( context, "Gridacceso_opcionContainerData", Gridacceso_opcionContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridacceso_opcionContainerData"+"V", Gridacceso_opcionContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridacceso_opcionContainerData"+"V"+"\" value='"+Gridacceso_opcionContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_045e( true) ;
         }
         else
         {
            wb_table4_33_045e( false) ;
         }
      }

      protected void wb_table5_52_045( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTitleopcion_Internalname, "Opcion", "", "", lblTitleopcion_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Acceso.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_52_045e( true) ;
         }
         else
         {
            wb_table5_52_045e( false) ;
         }
      }

      protected void wb_table2_5_045( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GRUPOCODIGO"+"'), id:'"+"GRUPOCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MENUID"+"'), id:'"+"MENUID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GRUPOCODIGO"+"'), id:'"+"GRUPOCODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"MENUID"+"'), id:'"+"MENUID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Fantastic"), "", "", "", "Fantastic", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Acceso.htm");
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
            wb_table2_5_045e( true) ;
         }
         else
         {
            wb_table2_5_045e( false) ;
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
               dynGrupoCodigo.Name = dynGrupoCodigo_Internalname ;
               dynGrupoCodigo.CurrentValue = cgiGet( dynGrupoCodigo_Internalname) ;
               A1GrupoCodigo = cgiGet( dynGrupoCodigo_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
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
               cmbMenuAcceso.Name = cmbMenuAcceso_Internalname ;
               cmbMenuAcceso.CurrentValue = cgiGet( cmbMenuAcceso_Internalname) ;
               A15MenuAcceso = (short)(NumberUtil.Val( cgiGet( cmbMenuAcceso_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15MenuAcceso", StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0));
               /* Read saved values. */
               Z1GrupoCodigo = cgiGet( "Z1GrupoCodigo") ;
               Z8MenuId = (int)(context.localUtil.CToN( cgiGet( "Z8MenuId"), ".", ",")) ;
               Z15MenuAcceso = (short)(context.localUtil.CToN( cgiGet( "Z15MenuAcceso"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridacceso_opcion = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridacceso_opcion"), ".", ",")) ;
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
                  A1GrupoCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
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
               InitAll045( ) ;
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
         DisableAttributes045( ) ;
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

      protected void CONFIRM_046( )
      {
         nGXsfl_56_idx = 0 ;
         while ( nGXsfl_56_idx < nRC_Gridacceso_opcion )
         {
            ReadRow046( ) ;
            if ( ( nRcdExists_6 != 0 ) || ( nIsMod_6 != 0 ) )
            {
               GetKey046( ) ;
               if ( ( nRcdExists_6 == 0 ) && ( nRcdDeleted_6 == 0 ) )
               {
                  if ( RcdFound6 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate046( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable046( ) ;
                        CloseExtendedTableCursors046( ) ;
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
                  if ( RcdFound6 != 0 )
                  {
                     if ( nRcdDeleted_6 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey046( ) ;
                        Load046( ) ;
                        BeforeValidate046( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls046( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_6 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate046( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable046( ) ;
                              CloseExtendedTableCursors046( ) ;
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
                     if ( nRcdDeleted_6 == 0 )
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
            ChangePostValue( cmbOpcionAcceso_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16OpcionAcceso), 1, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11OpcionId_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11OpcionId), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z16OpcionAcceso_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16OpcionAcceso), 1, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_6_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_6_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_6_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", ""))) ;
            if ( nIsMod_6 != 0 )
            {
               ChangePostValue( "OPCIONID_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONDESCRIPCION_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionDescripcion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONACCESO_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbOpcionAcceso.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void ZM045( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z15MenuAcceso = T00046_A15MenuAcceso[0] ;
            }
            else
            {
               Z15MenuAcceso = A15MenuAcceso ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z15MenuAcceso = A15MenuAcceso ;
            Z1GrupoCodigo = A1GrupoCodigo ;
            Z8MenuId = A8MenuId ;
            Z9MenuDescripcion = A9MenuDescripcion ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_8_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MENUID"+"'), id:'"+"MENUID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");") ;
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

      protected void Load045( )
      {
         /* Using cursor T000410 */
         pr_default.execute(8, new Object[] {A1GrupoCodigo, A8MenuId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound5 = 1 ;
            A9MenuDescripcion = T000410_A9MenuDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
            A15MenuAcceso = T000410_A15MenuAcceso[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15MenuAcceso", StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0));
            ZM045( -1) ;
         }
         pr_default.close(8);
         OnLoadActions045( ) ;
      }

      protected void OnLoadActions045( )
      {
      }

      protected void CheckExtendedTable045( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A1GrupoCodigo});
         if ( (pr_default.getStatus(5) == 101) )
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
         pr_default.close(5);
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            AnyError8 = 1 ;
            GX_msglist.addItem("No existe 'Menús y opciones'.", "ForeignKeyNotFound", 1, "MENUID");
            AnyError = 1 ;
            GX_FocusControl = edtMenuId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError8 == 0 )
         {
            A9MenuDescripcion = T00048_A9MenuDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
         }
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors045( )
      {
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( String A1GrupoCodigo )
      {
         /* Using cursor T000411 */
         pr_default.execute(9, new Object[] {A1GrupoCodigo});
         if ( (pr_default.getStatus(9) == 101) )
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
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(9);
      }

      protected void gxLoad_3( int A8MenuId )
      {
         /* Using cursor T000412 */
         pr_default.execute(10, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(10) == 101) )
         {
            AnyError8 = 1 ;
            GX_msglist.addItem("No existe 'Menús y opciones'.", "ForeignKeyNotFound", 1, "MENUID");
            AnyError = 1 ;
            GX_FocusControl = edtMenuId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError8 == 0 )
         {
            A9MenuDescripcion = T000412_A9MenuDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A9MenuDescripcion))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(10);
      }

      protected void GetKey045( )
      {
         /* Using cursor T000413 */
         pr_default.execute(11, new Object[] {A1GrupoCodigo, A8MenuId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound5 = 1 ;
         }
         else
         {
            RcdFound5 = 0 ;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A1GrupoCodigo, A8MenuId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM045( 1) ;
            RcdFound5 = 1 ;
            A15MenuAcceso = T00046_A15MenuAcceso[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15MenuAcceso", StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0));
            A1GrupoCodigo = T00046_A1GrupoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            A8MenuId = T00046_A8MenuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
            Z1GrupoCodigo = A1GrupoCodigo ;
            Z8MenuId = A8MenuId ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load045( ) ;
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0 ;
            InitializeNonKey045( ) ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey045( ) ;
         if ( RcdFound5 == 0 )
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
         RcdFound5 = 0 ;
         /* Using cursor T000414 */
         pr_default.execute(12, new Object[] {A1GrupoCodigo, A8MenuId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( StringUtil.StrCmp(T000414_A1GrupoCodigo[0], A1GrupoCodigo) < 0 ) || ( StringUtil.StrCmp(T000414_A1GrupoCodigo[0], A1GrupoCodigo) == 0 ) && ( T000414_A8MenuId[0] < A8MenuId ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( StringUtil.StrCmp(T000414_A1GrupoCodigo[0], A1GrupoCodigo) > 0 ) || ( StringUtil.StrCmp(T000414_A1GrupoCodigo[0], A1GrupoCodigo) == 0 ) && ( T000414_A8MenuId[0] > A8MenuId ) ) )
            {
               A1GrupoCodigo = T000414_A1GrupoCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
               A8MenuId = T000414_A8MenuId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
               RcdFound5 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0 ;
         /* Using cursor T000415 */
         pr_default.execute(13, new Object[] {A1GrupoCodigo, A8MenuId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( StringUtil.StrCmp(T000415_A1GrupoCodigo[0], A1GrupoCodigo) > 0 ) || ( StringUtil.StrCmp(T000415_A1GrupoCodigo[0], A1GrupoCodigo) == 0 ) && ( T000415_A8MenuId[0] > A8MenuId ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( StringUtil.StrCmp(T000415_A1GrupoCodigo[0], A1GrupoCodigo) < 0 ) || ( StringUtil.StrCmp(T000415_A1GrupoCodigo[0], A1GrupoCodigo) == 0 ) && ( T000415_A8MenuId[0] < A8MenuId ) ) )
            {
               A1GrupoCodigo = T000415_A1GrupoCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
               A8MenuId = T000415_A8MenuId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
               RcdFound5 = 1 ;
            }
         }
         pr_default.close(3);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey045( ) ;
         if ( RcdFound5 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "GRUPOCODIGO");
               AnyError = 1 ;
               GX_FocusControl = dynGrupoCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A1GrupoCodigo, Z1GrupoCodigo) != 0 ) || ( A8MenuId != Z8MenuId ) )
            {
               A1GrupoCodigo = Z1GrupoCodigo ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
               A8MenuId = Z8MenuId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "GRUPOCODIGO");
               AnyError = 1 ;
               GX_FocusControl = dynGrupoCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = dynGrupoCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update045( ) ;
               GX_FocusControl = dynGrupoCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A1GrupoCodigo, Z1GrupoCodigo) != 0 ) || ( A8MenuId != Z8MenuId ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = dynGrupoCodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert045( ) ;
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
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "GRUPOCODIGO");
                  AnyError = 1 ;
                  GX_FocusControl = dynGrupoCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = dynGrupoCodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert045( ) ;
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
         if ( ( StringUtil.StrCmp(A1GrupoCodigo, Z1GrupoCodigo) != 0 ) || ( A8MenuId != Z8MenuId ) )
         {
            A1GrupoCodigo = Z1GrupoCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            A8MenuId = Z8MenuId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "GRUPOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = dynGrupoCodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = dynGrupoCodigo_Internalname ;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "GRUPOCODIGO");
            AnyError = 1 ;
         }
         GX_FocusControl = cmbMenuAcceso_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart045( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbMenuAcceso_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd045( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbMenuAcceso_Internalname ;
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
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbMenuAcceso_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart045( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "");
         }
         else
         {
            while ( RcdFound5 != 0 )
            {
               ScanNext045( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbMenuAcceso_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd045( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency045( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000416 */
            pr_default.execute(14, new Object[] {A1GrupoCodigo, A8MenuId});
            if ( (pr_default.getStatus(14) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AccesoMenu"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(14) == 101) || ( Z15MenuAcceso != T000416_A15MenuAcceso[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"AccesoMenu"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM045( 0) ;
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000417 */
                     pr_default.execute(15, new Object[] {A15MenuAcceso, A1GrupoCodigo, A8MenuId});
                     pr_default.close(15);
                     if ( (pr_default.getStatus(15) == 1) )
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
                           ProcessLevel045( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                              ResetCaption040( ) ;
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
               Load045( ) ;
            }
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void Update045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000418 */
                     pr_default.execute(16, new Object[] {A15MenuAcceso, A1GrupoCodigo, A8MenuId});
                     pr_default.close(16);
                     if ( (pr_default.getStatus(16) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AccesoMenu"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate045( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel045( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                              ResetCaption040( ) ;
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
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void DeferredUpdate045( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls045( ) ;
            AfterConfirm045( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete045( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart046( ) ;
                  while ( RcdFound6 != 0 )
                  {
                     getByPrimaryKey046( ) ;
                     Delete046( ) ;
                     ScanNext046( ) ;
                  }
                  ScanEnd046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000419 */
                     pr_default.execute(17, new Object[] {A1GrupoCodigo, A8MenuId});
                     pr_default.close(17);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound5 == 0 )
                           {
                              InitAll045( ) ;
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
                           ResetCaption040( ) ;
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
         sMode5 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel045( ) ;
         Gx_mode = sMode5 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls045( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000420 */
            pr_default.execute(18, new Object[] {A8MenuId});
            A9MenuDescripcion = T000420_A9MenuDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
            pr_default.close(18);
         }
      }

      protected void ProcessNestedLevel046( )
      {
         nGXsfl_56_idx = 0 ;
         while ( nGXsfl_56_idx < nRC_Gridacceso_opcion )
         {
            ReadRow046( ) ;
            if ( ( nRcdExists_6 != 0 ) || ( nIsMod_6 != 0 ) )
            {
               standaloneNotModal046( ) ;
               GetKey046( ) ;
               if ( ( nRcdExists_6 == 0 ) && ( nRcdDeleted_6 == 0 ) )
               {
                  if ( RcdFound6 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert046( ) ;
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
                  if ( RcdFound6 != 0 )
                  {
                     if ( ( nRcdDeleted_6 != 0 ) && ( nRcdExists_6 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete046( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_6 != 0 ) && ( nRcdExists_6 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update046( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_6 == 0 )
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
            ChangePostValue( cmbOpcionAcceso_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16OpcionAcceso), 1, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11OpcionId_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11OpcionId), 9, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z16OpcionAcceso_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16OpcionAcceso), 1, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_6_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_6_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_6_"+sGXsfl_56_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", ""))) ;
            if ( nIsMod_6 != 0 )
            {
               ChangePostValue( "OPCIONID_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONDESCRIPCION_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionDescripcion_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OPCIONACCESO_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbOpcionAcceso.Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll046( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_6 = 0 ;
         nIsMod_6 = 0 ;
         nRcdDeleted_6 = 0 ;
      }

      protected void ProcessLevel045( )
      {
         /* Save parent mode. */
         sMode5 = Gx_mode ;
         ProcessNestedLevel046( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode5 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel045( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(14);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete045( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(13);
            pr_default.close(12);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(18);
            pr_default.close(2);
            context.CommitDataStores("Acceso");
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(13);
            pr_default.close(12);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(18);
            pr_default.close(2);
            context.RollbackDataStores("Acceso");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart045( )
      {
         /* Using cursor T000421 */
         pr_default.execute(19);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound5 = 1 ;
            A1GrupoCodigo = T000421_A1GrupoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            A8MenuId = T000421_A8MenuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext045( )
      {
         pr_default.readNext(19);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound5 = 1 ;
            A1GrupoCodigo = T000421_A1GrupoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            A8MenuId = T000421_A8MenuId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
         }
      }

      protected void ScanEnd045( )
      {
      }

      protected void AfterConfirm045( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert045( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate045( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete045( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete045( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate045( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes045( )
      {
         dynGrupoCodigo.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynGrupoCodigo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynGrupoCodigo.Enabled), 5, 0)));
         edtMenuId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenuId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenuId_Enabled), 5, 0)));
         edtMenuDescripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMenuDescripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMenuDescripcion_Enabled), 5, 0)));
         cmbMenuAcceso.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMenuAcceso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbMenuAcceso.Enabled), 5, 0)));
      }

      protected void ZM046( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z16OpcionAcceso = T00043_A16OpcionAcceso[0] ;
            }
            else
            {
               Z16OpcionAcceso = A16OpcionAcceso ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z1GrupoCodigo = A1GrupoCodigo ;
            Z16OpcionAcceso = A16OpcionAcceso ;
            Z8MenuId = A8MenuId ;
            Z11OpcionId = A11OpcionId ;
            Z12OpcionDescripcion = A12OpcionDescripcion ;
         }
      }

      protected void standaloneNotModal046( )
      {
      }

      protected void standaloneModal046( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtOpcionId_Enabled = 0 ;
         }
         else
         {
            edtOpcionId_Enabled = 1 ;
         }
         if ( ( StringUtil.StrCmp(sMode6, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode6, "DLT") == 0 ) )
         {
            DisableAttributes046( ) ;
         }
      }

      protected void Load046( )
      {
         /* Using cursor T000422 */
         pr_default.execute(20, new Object[] {A1GrupoCodigo, A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(20) != 101) )
         {
            RcdFound6 = 1 ;
            A12OpcionDescripcion = T000422_A12OpcionDescripcion[0] ;
            A16OpcionAcceso = T000422_A16OpcionAcceso[0] ;
            ZM046( -4) ;
         }
         pr_default.close(20);
         OnLoadActions046( ) ;
      }

      protected void OnLoadActions046( )
      {
      }

      protected void CheckExtendedTable046( )
      {
         Gx_BScreen = 1 ;
         standaloneModal046( ) ;
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError8 = 1 ;
            AnyError11 = 1 ;
            GX_msglist.addItem("No existe 'Opciones'.", "ForeignKeyNotFound", 1, "OPCIONID");
            AnyError = 1 ;
            GX_FocusControl = edtOpcionId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError8 == 0 ) && ( AnyError11 == 0 ) )
         {
            A12OpcionDescripcion = T00044_A12OpcionDescripcion[0] ;
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors046( )
      {
         pr_default.close(2);
      }

      protected void enableDisable046( )
      {
      }

      protected void gxLoad_5( int A8MenuId ,
                               int A11OpcionId )
      {
         /* Using cursor T000423 */
         pr_default.execute(21, new Object[] {A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(21) == 101) )
         {
            AnyError8 = 1 ;
            AnyError11 = 1 ;
            GX_msglist.addItem("No existe 'Opciones'.", "ForeignKeyNotFound", 1, "OPCIONID");
            AnyError = 1 ;
            GX_FocusControl = edtOpcionId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( AnyError8 == 0 ) && ( AnyError11 == 0 ) )
         {
            A12OpcionDescripcion = T000423_A12OpcionDescripcion[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A12OpcionDescripcion))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(21) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(21);
      }

      protected void GetKey046( )
      {
         /* Using cursor T000424 */
         pr_default.execute(22, new Object[] {A1GrupoCodigo, A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound6 = 1 ;
         }
         else
         {
            RcdFound6 = 0 ;
         }
         pr_default.close(22);
      }

      protected void getByPrimaryKey046( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A1GrupoCodigo, A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM046( 4) ;
            RcdFound6 = 1 ;
            InitializeNonKey046( ) ;
            A16OpcionAcceso = T00043_A16OpcionAcceso[0] ;
            A11OpcionId = T00043_A11OpcionId[0] ;
            Z1GrupoCodigo = A1GrupoCodigo ;
            Z8MenuId = A8MenuId ;
            Z11OpcionId = A11OpcionId ;
            sMode6 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal046( ) ;
            Load046( ) ;
            Gx_mode = sMode6 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound6 = 0 ;
            InitializeNonKey046( ) ;
            sMode6 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal046( ) ;
            Gx_mode = sMode6 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency046( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A1GrupoCodigo, A8MenuId, A11OpcionId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AccesoOpcion"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z16OpcionAcceso != T00042_A16OpcionAcceso[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"AccesoOpcion"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert046( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable046( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM046( 0) ;
            CheckOptimisticConcurrency046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000425 */
                     pr_default.execute(23, new Object[] {A1GrupoCodigo, A16OpcionAcceso, A8MenuId, A11OpcionId});
                     pr_default.close(23);
                     if ( (pr_default.getStatus(23) == 1) )
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
               Load046( ) ;
            }
            EndLevel046( ) ;
         }
         CloseExtendedTableCursors046( ) ;
      }

      protected void Update046( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable046( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000426 */
                     pr_default.execute(24, new Object[] {A16OpcionAcceso, A1GrupoCodigo, A8MenuId, A11OpcionId});
                     pr_default.close(24);
                     if ( (pr_default.getStatus(24) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"AccesoOpcion"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate046( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey046( ) ;
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
            EndLevel046( ) ;
         }
         CloseExtendedTableCursors046( ) ;
      }

      protected void DeferredUpdate046( )
      {
      }

      protected void Delete046( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency046( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls046( ) ;
            AfterConfirm046( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete046( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000427 */
                  pr_default.execute(25, new Object[] {A1GrupoCodigo, A8MenuId, A11OpcionId});
                  pr_default.close(25);
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
         sMode6 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel046( ) ;
         Gx_mode = sMode6 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls046( )
      {
         standaloneModal046( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000428 */
            pr_default.execute(26, new Object[] {A8MenuId, A11OpcionId});
            A12OpcionDescripcion = T000428_A12OpcionDescripcion[0] ;
            pr_default.close(26);
         }
      }

      protected void EndLevel046( )
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

      protected void ScanStart046( )
      {
         /* Using cursor T000429 */
         pr_default.execute(27, new Object[] {A1GrupoCodigo, A8MenuId});
         RcdFound6 = 0 ;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound6 = 1 ;
            A11OpcionId = T000429_A11OpcionId[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext046( )
      {
         pr_default.readNext(27);
         RcdFound6 = 0 ;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound6 = 1 ;
            A11OpcionId = T000429_A11OpcionId[0] ;
         }
      }

      protected void ScanEnd046( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm046( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert046( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate046( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete046( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete046( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate046( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes046( )
      {
         edtOpcionId_Enabled = 0 ;
         edtOpcionDescripcion_Enabled = 0 ;
         cmbOpcionAcceso.Enabled = 0 ;
      }

      protected void AddRow046( )
      {
         nGXsfl_56_idx = (short)(nGXsfl_56_idx+1) ;
         sGXsfl_56_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_56_idx), 4, 0)), 4, "0") ;
         edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_56_idx ;
         imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_56_idx ;
         edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_56_idx ;
         cmbOpcionAcceso_Internalname = "OPCIONACCESO_"+sGXsfl_56_idx ;
         SendRow046( ) ;
      }

      protected void SendRow046( )
      {
         Gridacceso_opcionRow = GXWebRow.GetNew(context) ;
         if ( subGridacceso_opcion_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridacceso_opcion_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridacceso_opcion_Class, "") != 0 )
            {
               subGridacceso_opcion_Linesclass = subGridacceso_opcion_Class+"Odd" ;
            }
         }
         else if ( subGridacceso_opcion_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridacceso_opcion_Backstyle = 0 ;
            subGridacceso_opcion_Backcolor = subGridacceso_opcion_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridacceso_opcionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridacceso_opcion_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridacceso_opcion_Class, "") != 0 )
            {
               subGridacceso_opcion_Linesclass = subGridacceso_opcion_Class+"Uniform" ;
            }
         }
         else if ( subGridacceso_opcion_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridacceso_opcion_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridacceso_opcion_Class, "") != 0 )
            {
               subGridacceso_opcion_Linesclass = subGridacceso_opcion_Class+"Odd" ;
            }
            subGridacceso_opcion_Backcolor = (int)(0xFFFFFF) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridacceso_opcionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridacceso_opcion_Backcolor), 9, 0)));
         }
         else if ( subGridacceso_opcion_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridacceso_opcion_Backstyle = 1 ;
            if ( ((int)(nGXsfl_56_idx) % (2)) == 0 )
            {
               subGridacceso_opcion_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridacceso_opcionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridacceso_opcion_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridacceso_opcion_Class, "") != 0 )
               {
                  subGridacceso_opcion_Linesclass = subGridacceso_opcion_Class+"Even" ;
               }
            }
            else
            {
               subGridacceso_opcion_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridacceso_opcionContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridacceso_opcion_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridacceso_opcion_Class, "") != 0 )
               {
                  subGridacceso_opcion_Linesclass = subGridacceso_opcion_Class+"Odd" ;
               }
            }
         }
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0)||(StringUtil.StrCmp(Gx_mode, "UPD")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0041.aspx"+"',["+"{Ctrl:gx.dom.el('"+"MENUID"+"'), id:'"+"MENUID"+"'"+",isOut:false,isKey:true,isLastKey:true}"+","+"{Ctrl:gx.dom.el('"+"OPCIONID_"+sGXsfl_56_idx+"'), id:'"+"OPCIONID_"+sGXsfl_56_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_6_"+sGXsfl_56_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_56_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_56_idx + "',56)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridacceso_opcionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOpcionId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11OpcionId), 9, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A11OpcionId), "ZZZZZZZZ9")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(57);\"",(String)"",(String)"",(String)"",(String)"",(String)edtOpcionId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtOpcionId_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)56,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridacceso_opcionRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_11_Internalname,"prompt.gif",(String)imgprompt_11_Link,(String)"",(String)"",(String)"Fantastic",(int)imgprompt_11_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridacceso_opcionRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOpcionDescripcion_Internalname,StringUtil.RTrim( A12OpcionDescripcion),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtOpcionDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtOpcionDescripcion_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)56,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         ClassString = "Attribute" ;
         StyleString = "" ;
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_56_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_56_idx + "',56)\"" ;
         if ( ( nGXsfl_56_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "OPCIONACCESO_" + sGXsfl_56_idx ;
            cmbOpcionAcceso.Name = GXCCtl ;
            cmbOpcionAcceso.WebTags = "" ;
            cmbOpcionAcceso.addItem("0", "No", 0);
            cmbOpcionAcceso.addItem("1", "Si", 0);
            if ( ( cmbOpcionAcceso.ItemCount > 0 ) && (0==A16OpcionAcceso) )
            {
               A16OpcionAcceso = (short)(NumberUtil.Val( cmbOpcionAcceso.getItemValue(1), ".")) ;
            }
         }
         /* ComboBox */
         Gridacceso_opcionRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbOpcionAcceso,(String)cmbOpcionAcceso_Internalname,StringUtil.Str( (decimal)(A16OpcionAcceso), 1, 0),(short)1,(String)cmbOpcionAcceso_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,cmbOpcionAcceso.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(59);\"",(String)"",(bool)true});
         cmbOpcionAcceso.CurrentValue = StringUtil.Str( (decimal)(A16OpcionAcceso), 1, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOpcionAcceso_Internalname, "Values", (String)(cmbOpcionAcceso.ToJavascriptSource()));
         context.httpAjaxContext.ajax_sending_grid_row(Gridacceso_opcionRow);
         GXCCtl = "Z11OpcionId_" + sGXsfl_56_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11OpcionId), 9, 0, ".", "")));
         GXCCtl = "Z16OpcionAcceso_" + sGXsfl_56_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16OpcionAcceso), 1, 0, ".", "")));
         GXCCtl = "nRcdDeleted_6_" + sGXsfl_56_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_6_" + sGXsfl_56_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", "")));
         GXCCtl = "nIsMod_6_" + sGXsfl_56_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OPCIONID_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OPCIONDESCRIPCION_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOpcionDescripcion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OPCIONACCESO_"+sGXsfl_56_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbOpcionAcceso.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_11_"+sGXsfl_56_idx+"Link", StringUtil.RTrim( imgprompt_11_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridacceso_opcionContainer.AddRow(Gridacceso_opcionRow);
      }

      protected void ReadRow046( )
      {
         nGXsfl_56_idx = (short)(nGXsfl_56_idx+1) ;
         sGXsfl_56_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_56_idx), 4, 0)), 4, "0") ;
         edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_56_idx ;
         imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_56_idx ;
         edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_56_idx ;
         cmbOpcionAcceso_Internalname = "OPCIONACCESO_"+sGXsfl_56_idx ;
         edtOpcionId_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONID_"+sGXsfl_56_idx+"Enabled"), ".", ",")) ;
         edtOpcionDescripcion_Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONDESCRIPCION_"+sGXsfl_56_idx+"Enabled"), ".", ",")) ;
         cmbOpcionAcceso.Enabled = (int)(context.localUtil.CToN( cgiGet( "OPCIONACCESO_"+sGXsfl_56_idx+"Enabled"), ".", ",")) ;
         imgprompt_8_Link = cgiGet( "PROMPT_11_"+sGXsfl_56_idx+"Link") ;
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
         cmbOpcionAcceso.Name = cmbOpcionAcceso_Internalname ;
         cmbOpcionAcceso.CurrentValue = cgiGet( cmbOpcionAcceso_Internalname) ;
         A16OpcionAcceso = (short)(NumberUtil.Val( cgiGet( cmbOpcionAcceso_Internalname), ".")) ;
         GXCCtl = "Z11OpcionId_" + sGXsfl_56_idx ;
         Z11OpcionId = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z16OpcionAcceso_" + sGXsfl_56_idx ;
         Z16OpcionAcceso = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdDeleted_6_" + sGXsfl_56_idx ;
         nRcdDeleted_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_6_" + sGXsfl_56_idx ;
         nRcdExists_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_6_" + sGXsfl_56_idx ;
         nIsMod_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtOpcionId_Enabled = edtOpcionId_Enabled ;
      }

      protected void ConfirmValues040( )
      {
         nGXsfl_56_idx = 0 ;
         sGXsfl_56_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_56_idx), 4, 0)), 4, "0") ;
         edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_56_idx ;
         imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_56_idx ;
         edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_56_idx ;
         cmbOpcionAcceso_Internalname = "OPCIONACCESO_"+sGXsfl_56_idx ;
         while ( nGXsfl_56_idx < nRC_Gridacceso_opcion )
         {
            nGXsfl_56_idx = (short)(nGXsfl_56_idx+1) ;
            sGXsfl_56_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_56_idx), 4, 0)), 4, "0") ;
            edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_56_idx ;
            imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_56_idx ;
            edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_56_idx ;
            cmbOpcionAcceso_Internalname = "OPCIONACCESO_"+sGXsfl_56_idx ;
            ChangePostValue( "Z11OpcionId_"+sGXsfl_56_idx, cgiGet( "ZT_"+"Z11OpcionId_"+sGXsfl_56_idx)) ;
            DeletePostValue( "ZT_"+"Z11OpcionId_"+sGXsfl_56_idx) ;
            ChangePostValue( "Z16OpcionAcceso_"+sGXsfl_56_idx, cgiGet( "ZT_"+"Z16OpcionAcceso_"+sGXsfl_56_idx)) ;
            DeletePostValue( "ZT_"+"Z16OpcionAcceso_"+sGXsfl_56_idx) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("acceso.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z1GrupoCodigo", StringUtil.RTrim( Z1GrupoCodigo));
         GxWebStd.gx_hidden_field( context, "Z8MenuId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8MenuId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z15MenuAcceso", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15MenuAcceso), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridacceso_opcion", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_56_idx), 4, 0, ".", "")));
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
         return "Acceso" ;
      }

      public override String GetPgmdesc( )
      {
         return "Accesos al sistema" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("acceso.aspx")  ;
      }

      protected void InitializeNonKey045( )
      {
         A9MenuDescripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
         A15MenuAcceso = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15MenuAcceso", StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0));
      }

      protected void InitAll045( )
      {
         A1GrupoCodigo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
         A8MenuId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8MenuId", StringUtil.LTrim( StringUtil.Str( (decimal)(A8MenuId), 9, 0)));
         InitializeNonKey045( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey046( )
      {
         A12OpcionDescripcion = "" ;
         A16OpcionAcceso = 0 ;
      }

      protected void InitAll046( )
      {
         A11OpcionId = 0 ;
         InitializeNonKey046( ) ;
      }

      protected void StandaloneModalInsert046( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1541635");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("acceso.js", "?1541636");
         /* End function include_jscripts */
      }

      protected void init_level_properties6( )
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
         lblTextblockgrupocodigo_Internalname = "TEXTBLOCKGRUPOCODIGO" ;
         dynGrupoCodigo_Internalname = "GRUPOCODIGO" ;
         lblTextblockmenuid_Internalname = "TEXTBLOCKMENUID" ;
         edtMenuId_Internalname = "MENUID" ;
         edtMenuDescripcion_Internalname = "MENUDESCRIPCION" ;
         lblTextblockmenuacceso_Internalname = "TEXTBLOCKMENUACCESO" ;
         cmbMenuAcceso_Internalname = "MENUACCESO" ;
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
         imgprompt_8_Internalname = "PROMPT_8" ;
         subGridacceso_opcion_Internalname = "GRIDACCESO_OPCION" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Accesos al sistema" ;
         cmbOpcionAcceso_Jsonclick = "" ;
         edtOpcionDescripcion_Jsonclick = "" ;
         imgprompt_11_Visible = 1 ;
         imgprompt_11_Link = "" ;
         imgprompt_8_Visible = 1 ;
         edtOpcionId_Jsonclick = "" ;
         subGridacceso_opcion_Class = "Grid" ;
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
         subGridacceso_opcion_Allowcollapsing = 0 ;
         cmbOpcionAcceso.Enabled = 1 ;
         edtOpcionDescripcion_Enabled = 0 ;
         edtOpcionId_Enabled = 1 ;
         subGridacceso_opcion_Backcolorstyle = 2 ;
         cmbMenuAcceso_Jsonclick = "" ;
         cmbMenuAcceso.Enabled = 1 ;
         edtMenuDescripcion_Jsonclick = "" ;
         edtMenuDescripcion_Enabled = 0 ;
         imgprompt_8_Visible = 1 ;
         imgprompt_8_Link = "" ;
         edtMenuId_Jsonclick = "" ;
         edtMenuId_Enabled = 1 ;
         dynGrupoCodigo_Jsonclick = "" ;
         dynGrupoCodigo.Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridacceso_opcion_newrow( short nRC_Gridacceso_opcion ,
                                                   short nGXsfl_56_idx ,
                                                   String sGXsfl_56_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_56_idx ;
         imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_56_idx ;
         edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_56_idx ;
         cmbOpcionAcceso_Internalname = "OPCIONACCESO_"+sGXsfl_56_idx ;
         while ( nGXsfl_56_idx <= nRC_Gridacceso_opcion )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal046( ) ;
            standaloneModal046( ) ;
            dynGrupoCodigo.Name = "GRUPOCODIGO" ;
            dynGrupoCodigo.WebTags = "" ;
            dynGrupoCodigo.removeAllItems();
            /* Using cursor T000430 */
            pr_default.execute(28);
            while ( (pr_default.getStatus(28) != 101) )
            {
               dynGrupoCodigo.addItem(T000430_A1GrupoCodigo[0], T000430_A2GrupoDescripcion[0], 0);
               pr_default.readNext(28);
            }
            pr_default.close(28);
            if ( ( dynGrupoCodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A1GrupoCodigo)) )
            {
               A1GrupoCodigo = dynGrupoCodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1GrupoCodigo", A1GrupoCodigo);
            }
            cmbMenuAcceso.Name = "MENUACCESO" ;
            cmbMenuAcceso.WebTags = "" ;
            cmbMenuAcceso.addItem("0", "No", 0);
            cmbMenuAcceso.addItem("1", "Si", 0);
            if ( ( cmbMenuAcceso.ItemCount > 0 ) && (0==A15MenuAcceso) )
            {
               A15MenuAcceso = (short)(NumberUtil.Val( cmbMenuAcceso.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15MenuAcceso", StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0));
            }
            GXCCtl = "OPCIONACCESO_" + sGXsfl_56_idx ;
            cmbOpcionAcceso.Name = GXCCtl ;
            cmbOpcionAcceso.WebTags = "" ;
            cmbOpcionAcceso.addItem("0", "No", 0);
            cmbOpcionAcceso.addItem("1", "Si", 0);
            if ( ( cmbOpcionAcceso.ItemCount > 0 ) && (0==A16OpcionAcceso) )
            {
               A16OpcionAcceso = (short)(NumberUtil.Val( cmbOpcionAcceso.getItemValue(1), ".")) ;
            }
            dynload_actions( ) ;
            SendRow046( ) ;
            nGXsfl_56_idx = (short)(nGXsfl_56_idx+1) ;
            sGXsfl_56_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_56_idx), 4, 0)), 4, "0") ;
            edtOpcionId_Internalname = "OPCIONID_"+sGXsfl_56_idx ;
            imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_56_idx ;
            edtOpcionDescripcion_Internalname = "OPCIONDESCRIPCION_"+sGXsfl_56_idx ;
            cmbOpcionAcceso_Internalname = "OPCIONACCESO_"+sGXsfl_56_idx ;
         }
         context.GX_webresponse.AddString(Gridacceso_opcionContainer.ToJavascriptSource());
         /* End function gxnrGridacceso_opcion_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         /* Using cursor T000431 */
         pr_default.execute(29, new Object[] {A1GrupoCodigo});
         if ( (pr_default.getStatus(29) == 101) )
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
         pr_default.close(29);
         /* Using cursor T000420 */
         pr_default.execute(18, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            AnyError8 = 1 ;
            GX_msglist.addItem("No existe 'Menús y opciones'.", "ForeignKeyNotFound", 1, "MENUID");
            AnyError = 1 ;
            GX_FocusControl = edtMenuId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError8 == 0 )
         {
            A9MenuDescripcion = T000420_A9MenuDescripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9MenuDescripcion", A9MenuDescripcion);
         }
         pr_default.close(18);
         GX_FocusControl = cmbMenuAcceso_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Grupocodigo( GXCombobox dynGX_Parm1 )
      {
         dynGrupoCodigo = dynGX_Parm1 ;
         A1GrupoCodigo = dynGrupoCodigo.CurrentValue ;
         /* Using cursor T000431 */
         pr_default.execute(29, new Object[] {A1GrupoCodigo});
         if ( (pr_default.getStatus(29) == 101) )
         {
            AnyError1 = 1 ;
            GX_msglist.addItem("No existe 'Grupos de usuarios'.", "ForeignKeyNotFound", 1, "GRUPOCODIGO");
            AnyError = 1 ;
            GX_FocusControl = dynGrupoCodigo_Internalname ;
         }
         if ( AnyError1 == 0 )
         {
         }
         pr_default.close(29);
         dynload_actions( ) ;
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Menuid( GXCombobox dynGX_Parm1 ,
                                int GX_Parm2 ,
                                GXCombobox cmbGX_Parm3 ,
                                String GX_Parm4 )
      {
         dynGrupoCodigo = dynGX_Parm1 ;
         A1GrupoCodigo = dynGrupoCodigo.CurrentValue ;
         A8MenuId = GX_Parm2 ;
         cmbMenuAcceso = cmbGX_Parm3 ;
         A15MenuAcceso = (short)(NumberUtil.Val( cmbMenuAcceso.CurrentValue, ".")) ;
         cmbMenuAcceso.CurrentValue = StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0) ;
         A9MenuDescripcion = GX_Parm4 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         /* Using cursor T000420 */
         pr_default.execute(18, new Object[] {A8MenuId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            AnyError8 = 1 ;
            GX_msglist.addItem("No existe 'Menús y opciones'.", "ForeignKeyNotFound", 1, "MENUID");
            AnyError = 1 ;
            GX_FocusControl = edtMenuId_Internalname ;
         }
         if ( AnyError8 == 0 )
         {
            A9MenuDescripcion = T000420_A9MenuDescripcion[0] ;
         }
         pr_default.close(18);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A9MenuDescripcion = "" ;
         }
         cmbMenuAcceso.CurrentValue = StringUtil.Str( (decimal)(A15MenuAcceso), 1, 0) ;
         isValidOutput.Add((Object)(cmbMenuAcceso));
         isValidOutput.Add((Object)(StringUtil.RTrim( A9MenuDescripcion)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z1GrupoCodigo)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8MenuId), 9, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15MenuAcceso), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z9MenuDescripcion)));
         isValidOutput.Add((Object)(Gridacceso_opcionContainer));
         isValidOutput.Add((Object)(imgBtn_delete2_Enabled));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Opcionid( int GX_Parm1 ,
                                  int GX_Parm2 ,
                                  String GX_Parm3 )
      {
         A8MenuId = GX_Parm1 ;
         A11OpcionId = GX_Parm2 ;
         A12OpcionDescripcion = GX_Parm3 ;
         /* Using cursor T000428 */
         pr_default.execute(26, new Object[] {A8MenuId, A11OpcionId});
         if ( (pr_default.getStatus(26) == 101) )
         {
            AnyError8 = 1 ;
            AnyError11 = 1 ;
            GX_msglist.addItem("No existe 'Opciones'.", "ForeignKeyNotFound", 1, "OPCIONID");
            AnyError = 1 ;
            GX_FocusControl = edtOpcionId_Internalname ;
         }
         if ( ( AnyError8 == 0 ) && ( AnyError11 == 0 ) )
         {
            A12OpcionDescripcion = T000428_A12OpcionDescripcion[0] ;
         }
         pr_default.close(26);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A12OpcionDescripcion = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A12OpcionDescripcion)));
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
         pr_default.close(27);
         pr_default.close(26);
         pr_default.close(19);
         pr_default.close(13);
         pr_default.close(12);
         pr_default.close(29);
         pr_default.close(18);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A1GrupoCodigo = "" ;
         GXKey = "" ;
         T00049_A1GrupoCodigo = new String[] {""} ;
         T00049_A2GrupoDescripcion = new String[] {""} ;
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
         lblTextblockgrupocodigo_Jsonclick = "" ;
         lblTextblockmenuid_Jsonclick = "" ;
         A9MenuDescripcion = "" ;
         lblTextblockmenuacceso_Jsonclick = "" ;
         Gridacceso_opcionContainer = new GXWebGrid( context);
         Gridacceso_opcionColumn = new GXWebColumn();
         A12OpcionDescripcion = "" ;
         Gx_mode = "" ;
         sMode6 = "" ;
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
         Z1GrupoCodigo = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtOpcionDescripcion_Internalname = "" ;
         cmbOpcionAcceso_Internalname = "" ;
         Z9MenuDescripcion = "" ;
         T000410_A9MenuDescripcion = new String[] {""} ;
         T000410_A15MenuAcceso = new short[1] ;
         T000410_A1GrupoCodigo = new String[] {""} ;
         T000410_A8MenuId = new int[1] ;
         T00047_A1GrupoCodigo = new String[] {""} ;
         T00048_A9MenuDescripcion = new String[] {""} ;
         T000411_A1GrupoCodigo = new String[] {""} ;
         T000412_A9MenuDescripcion = new String[] {""} ;
         T000413_A1GrupoCodigo = new String[] {""} ;
         T000413_A8MenuId = new int[1] ;
         T00046_A15MenuAcceso = new short[1] ;
         T00046_A1GrupoCodigo = new String[] {""} ;
         T00046_A8MenuId = new int[1] ;
         sMode5 = "" ;
         T000414_A1GrupoCodigo = new String[] {""} ;
         T000414_A8MenuId = new int[1] ;
         T000415_A1GrupoCodigo = new String[] {""} ;
         T000415_A8MenuId = new int[1] ;
         T000416_A15MenuAcceso = new short[1] ;
         T000416_A1GrupoCodigo = new String[] {""} ;
         T000416_A8MenuId = new int[1] ;
         T000420_A9MenuDescripcion = new String[] {""} ;
         T000421_A1GrupoCodigo = new String[] {""} ;
         T000421_A8MenuId = new int[1] ;
         Z12OpcionDescripcion = "" ;
         T000422_A1GrupoCodigo = new String[] {""} ;
         T000422_A12OpcionDescripcion = new String[] {""} ;
         T000422_A16OpcionAcceso = new short[1] ;
         T000422_A8MenuId = new int[1] ;
         T000422_A11OpcionId = new int[1] ;
         T00044_A12OpcionDescripcion = new String[] {""} ;
         T000423_A12OpcionDescripcion = new String[] {""} ;
         T000424_A1GrupoCodigo = new String[] {""} ;
         T000424_A8MenuId = new int[1] ;
         T000424_A11OpcionId = new int[1] ;
         T00043_A1GrupoCodigo = new String[] {""} ;
         T00043_A16OpcionAcceso = new short[1] ;
         T00043_A8MenuId = new int[1] ;
         T00043_A11OpcionId = new int[1] ;
         T00042_A1GrupoCodigo = new String[] {""} ;
         T00042_A16OpcionAcceso = new short[1] ;
         T00042_A8MenuId = new int[1] ;
         T00042_A11OpcionId = new int[1] ;
         T000428_A12OpcionDescripcion = new String[] {""} ;
         T000429_A1GrupoCodigo = new String[] {""} ;
         T000429_A8MenuId = new int[1] ;
         T000429_A11OpcionId = new int[1] ;
         imgprompt_11_Internalname = "" ;
         Gridacceso_opcionRow = new GXWebRow();
         subGridacceso_opcion_Linesclass = "" ;
         ROClassString = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         T000430_A1GrupoCodigo = new String[] {""} ;
         T000430_A2GrupoDescripcion = new String[] {""} ;
         GXt_char7 = "" ;
         T000431_A1GrupoCodigo = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.acceso__default(),
            new Object[][] {
                new Object[] {
               T00042_A1GrupoCodigo, T00042_A16OpcionAcceso, T00042_A8MenuId, T00042_A11OpcionId
               }
               , new Object[] {
               T00043_A1GrupoCodigo, T00043_A16OpcionAcceso, T00043_A8MenuId, T00043_A11OpcionId
               }
               , new Object[] {
               T00044_A12OpcionDescripcion
               }
               , new Object[] {
               T00045_A15MenuAcceso, T00045_A1GrupoCodigo, T00045_A8MenuId
               }
               , new Object[] {
               T00046_A15MenuAcceso, T00046_A1GrupoCodigo, T00046_A8MenuId
               }
               , new Object[] {
               T00047_A1GrupoCodigo
               }
               , new Object[] {
               T00048_A9MenuDescripcion
               }
               , new Object[] {
               T00049_A1GrupoCodigo, T00049_A2GrupoDescripcion
               }
               , new Object[] {
               T000410_A9MenuDescripcion, T000410_A15MenuAcceso, T000410_A1GrupoCodigo, T000410_A8MenuId
               }
               , new Object[] {
               T000411_A1GrupoCodigo
               }
               , new Object[] {
               T000412_A9MenuDescripcion
               }
               , new Object[] {
               T000413_A1GrupoCodigo, T000413_A8MenuId
               }
               , new Object[] {
               T000414_A1GrupoCodigo, T000414_A8MenuId
               }
               , new Object[] {
               T000415_A1GrupoCodigo, T000415_A8MenuId
               }
               , new Object[] {
               T000416_A15MenuAcceso, T000416_A1GrupoCodigo, T000416_A8MenuId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000420_A9MenuDescripcion
               }
               , new Object[] {
               T000421_A1GrupoCodigo, T000421_A8MenuId
               }
               , new Object[] {
               T000422_A1GrupoCodigo, T000422_A12OpcionDescripcion, T000422_A16OpcionAcceso, T000422_A8MenuId, T000422_A11OpcionId
               }
               , new Object[] {
               T000423_A12OpcionDescripcion
               }
               , new Object[] {
               T000424_A1GrupoCodigo, T000424_A8MenuId, T000424_A11OpcionId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000428_A12OpcionDescripcion
               }
               , new Object[] {
               T000429_A1GrupoCodigo, T000429_A8MenuId, T000429_A11OpcionId
               }
               , new Object[] {
               T000430_A1GrupoCodigo, T000430_A2GrupoDescripcion
               }
               , new Object[] {
               T000431_A1GrupoCodigo
               }
            }
         );
      }

      private short nIsMod_6 ;
      private short GxWebError ;
      private short nRC_Gridacceso_opcion ;
      private short nGXsfl_56_idx=1 ;
      private short gxcookieaux ;
      private short A15MenuAcceso ;
      private short A16OpcionAcceso ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridacceso_opcion_Backcolorstyle ;
      private short subGridacceso_opcion_Allowcollapsing ;
      private short subGridacceso_opcion_Collapsed ;
      private short nBlankRcdCount6 ;
      private short nRcdExists_6 ;
      private short RcdFound6 ;
      private short nBlankRcdUsr6 ;
      private short Z15MenuAcceso ;
      private short nRcdDeleted_6 ;
      private short Z16OpcionAcceso ;
      private short GX_JID ;
      private short RcdFound5 ;
      private short Gx_BScreen ;
      private short subGridacceso_opcion_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int A8MenuId ;
      private int A11OpcionId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtMenuId_Enabled ;
      private int imgprompt_8_Visible ;
      private int edtMenuDescripcion_Enabled ;
      private int edtOpcionId_Enabled ;
      private int edtOpcionDescripcion_Enabled ;
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
      private int GRIDACCESO_OPCION_nFirstRecordOnPage ;
      private int Z11OpcionId ;
      private int AnyError1 ;
      private int AnyError8 ;
      private int AnyError11 ;
      private int subGridacceso_opcion_Backcolor ;
      private int subGridacceso_opcion_Allbackcolor ;
      private int imgprompt_11_Visible ;
      private int defedtOpcionId_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String sGXsfl_56_idx="0001" ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String GXCCtl ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String dynGrupoCodigo_Internalname ;
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
      private String lblTextblockgrupocodigo_Internalname ;
      private String lblTextblockgrupocodigo_Jsonclick ;
      private String dynGrupoCodigo_Jsonclick ;
      private String lblTextblockmenuid_Internalname ;
      private String lblTextblockmenuid_Jsonclick ;
      private String edtMenuId_Internalname ;
      private String edtMenuId_Jsonclick ;
      private String imgprompt_8_Internalname ;
      private String imgprompt_8_Link ;
      private String edtMenuDescripcion_Internalname ;
      private String edtMenuDescripcion_Jsonclick ;
      private String lblTextblockmenuacceso_Internalname ;
      private String lblTextblockmenuacceso_Jsonclick ;
      private String cmbMenuAcceso_Internalname ;
      private String cmbMenuAcceso_Jsonclick ;
      private String Gx_mode ;
      private String sMode6 ;
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
      private String cmbOpcionAcceso_Internalname ;
      private String sMode5 ;
      private String imgprompt_11_Internalname ;
      private String subGridacceso_opcion_Class ;
      private String subGridacceso_opcion_Linesclass ;
      private String imgprompt_11_Link ;
      private String ROClassString ;
      private String edtOpcionId_Jsonclick ;
      private String edtOpcionDescripcion_Jsonclick ;
      private String cmbOpcionAcceso_Jsonclick ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String subGridacceso_opcion_Internalname ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A1GrupoCodigo ;
      private String A9MenuDescripcion ;
      private String A12OpcionDescripcion ;
      private String Z1GrupoCodigo ;
      private String Z9MenuDescripcion ;
      private String Z12OpcionDescripcion ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridacceso_opcionContainer ;
      private GXWebRow Gridacceso_opcionRow ;
      private GXWebColumn Gridacceso_opcionColumn ;
      private IDataStoreProvider pr_default ;
      private String[] T00049_A1GrupoCodigo ;
      private String[] T00049_A2GrupoDescripcion ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynGrupoCodigo ;
      private GXCombobox cmbMenuAcceso ;
      private GXCombobox cmbOpcionAcceso ;
      private String[] T000410_A9MenuDescripcion ;
      private short[] T000410_A15MenuAcceso ;
      private String[] T000410_A1GrupoCodigo ;
      private int[] T000410_A8MenuId ;
      private String[] T00047_A1GrupoCodigo ;
      private String[] T00048_A9MenuDescripcion ;
      private String[] T000411_A1GrupoCodigo ;
      private String[] T000412_A9MenuDescripcion ;
      private String[] T000413_A1GrupoCodigo ;
      private int[] T000413_A8MenuId ;
      private short[] T00046_A15MenuAcceso ;
      private String[] T00046_A1GrupoCodigo ;
      private int[] T00046_A8MenuId ;
      private String[] T000414_A1GrupoCodigo ;
      private int[] T000414_A8MenuId ;
      private String[] T000415_A1GrupoCodigo ;
      private int[] T000415_A8MenuId ;
      private short[] T000416_A15MenuAcceso ;
      private String[] T000416_A1GrupoCodigo ;
      private int[] T000416_A8MenuId ;
      private String[] T000420_A9MenuDescripcion ;
      private String[] T000421_A1GrupoCodigo ;
      private int[] T000421_A8MenuId ;
      private String[] T000422_A1GrupoCodigo ;
      private String[] T000422_A12OpcionDescripcion ;
      private short[] T000422_A16OpcionAcceso ;
      private int[] T000422_A8MenuId ;
      private int[] T000422_A11OpcionId ;
      private String[] T00044_A12OpcionDescripcion ;
      private String[] T000423_A12OpcionDescripcion ;
      private String[] T000424_A1GrupoCodigo ;
      private int[] T000424_A8MenuId ;
      private int[] T000424_A11OpcionId ;
      private String[] T00043_A1GrupoCodigo ;
      private short[] T00043_A16OpcionAcceso ;
      private int[] T00043_A8MenuId ;
      private int[] T00043_A11OpcionId ;
      private String[] T00042_A1GrupoCodigo ;
      private short[] T00042_A16OpcionAcceso ;
      private int[] T00042_A8MenuId ;
      private int[] T00042_A11OpcionId ;
      private String[] T000428_A12OpcionDescripcion ;
      private String[] T000429_A1GrupoCodigo ;
      private int[] T000429_A8MenuId ;
      private int[] T000429_A11OpcionId ;
      private String[] T000430_A1GrupoCodigo ;
      private String[] T000430_A2GrupoDescripcion ;
      private String[] T000431_A1GrupoCodigo ;
      private short[] T00045_A15MenuAcceso ;
      private String[] T00045_A1GrupoCodigo ;
      private int[] T00045_A8MenuId ;
      private GXWebForm Form ;
   }

   public class acceso__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000415 ;
          prmT000415 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000416 ;
          prmT000416 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000417 ;
          prmT000417 = new Object[] {
          new Object[] {"@MenuAcceso",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000418 ;
          prmT000418 = new Object[] {
          new Object[] {"@MenuAcceso",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000419 ;
          prmT000419 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000421 ;
          prmT000421 = new Object[] {
          } ;
          Object[] prmT000422 ;
          prmT000422 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000423 ;
          prmT000423 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000424 ;
          prmT000424 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000425 ;
          prmT000425 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@OpcionAcceso",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000426 ;
          prmT000426 = new Object[] {
          new Object[] {"@OpcionAcceso",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000427 ;
          prmT000427 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000429 ;
          prmT000429 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000430 ;
          prmT000430 = new Object[] {
          } ;
          Object[] prmT000431 ;
          prmT000431 = new Object[] {
          new Object[] {"@GrupoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmT000420 ;
          prmT000420 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000428 ;
          prmT000428 = new Object[] {
          new Object[] {"@MenuId",SqlDbType.Int,9,0} ,
          new Object[] {"@OpcionId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [GrupoCodigo], [OpcionAcceso], [MenuId], [OpcionId] FROM [AccesoOpcion] WITH (UPDLOCK) WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
             ,new CursorDef("T00043", "SELECT [GrupoCodigo], [OpcionAcceso], [MenuId], [OpcionId] FROM [AccesoOpcion] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
             ,new CursorDef("T00044", "SELECT [OpcionDescripcion] FROM [Opcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1,0,true,false )
             ,new CursorDef("T00045", "SELECT [MenuAcceso], [GrupoCodigo], [MenuId] FROM [AccesoMenu] WITH (UPDLOCK) WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
             ,new CursorDef("T00046", "SELECT [MenuAcceso], [GrupoCodigo], [MenuId] FROM [AccesoMenu] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1,0,true,false )
             ,new CursorDef("T00047", "SELECT [GrupoCodigo] FROM [GrupoUsuario] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1,0,true,false )
             ,new CursorDef("T00048", "SELECT [MenuDescripcion] FROM [Menu] WITH (NOLOCK) WHERE [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1,0,true,false )
             ,new CursorDef("T00049", "SELECT [GrupoCodigo], [GrupoDescripcion] FROM [GrupoUsuario] WITH (NOLOCK) ORDER BY [GrupoDescripcion] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,0,0,true,false )
             ,new CursorDef("T000410", "SELECT T2.[MenuDescripcion], TM1.[MenuAcceso], TM1.[GrupoCodigo], TM1.[MenuId] FROM ([AccesoMenu] TM1 WITH (NOLOCK) INNER JOIN [Menu] T2 WITH (NOLOCK) ON T2.[MenuId] = TM1.[MenuId]) WHERE TM1.[GrupoCodigo] = @GrupoCodigo and TM1.[MenuId] = @MenuId ORDER BY TM1.[GrupoCodigo], TM1.[MenuId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,100,0,true,false )
             ,new CursorDef("T000411", "SELECT [GrupoCodigo] FROM [GrupoUsuario] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000411,1,0,true,false )
             ,new CursorDef("T000412", "SELECT [MenuDescripcion] FROM [Menu] WITH (NOLOCK) WHERE [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000412,1,0,true,false )
             ,new CursorDef("T000413", "SELECT [GrupoCodigo], [MenuId] FROM [AccesoMenu] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000413,1,0,true,false )
             ,new CursorDef("T000414", "SELECT TOP 1 [GrupoCodigo], [MenuId] FROM [AccesoMenu] WITH (NOLOCK) WHERE ( [GrupoCodigo] > @GrupoCodigo or [GrupoCodigo] = @GrupoCodigo and [MenuId] > @MenuId) ORDER BY [GrupoCodigo], [MenuId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000414,1,0,true,true )
             ,new CursorDef("T000415", "SELECT TOP 1 [GrupoCodigo], [MenuId] FROM [AccesoMenu] WITH (NOLOCK) WHERE ( [GrupoCodigo] < @GrupoCodigo or [GrupoCodigo] = @GrupoCodigo and [MenuId] < @MenuId) ORDER BY [GrupoCodigo] DESC, [MenuId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000415,1,0,true,true )
             ,new CursorDef("T000416", "SELECT [MenuAcceso], [GrupoCodigo], [MenuId] FROM [AccesoMenu] WITH (UPDLOCK) WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000416,1,0,true,false )
             ,new CursorDef("T000417", "INSERT INTO [AccesoMenu] ([MenuAcceso], [GrupoCodigo], [MenuId]) VALUES (@MenuAcceso, @GrupoCodigo, @MenuId)", GxErrorMask.GX_NOMASK,prmT000417)
             ,new CursorDef("T000418", "UPDATE [AccesoMenu] SET [MenuAcceso]=@MenuAcceso  WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId", GxErrorMask.GX_NOMASK,prmT000418)
             ,new CursorDef("T000419", "DELETE FROM [AccesoMenu]  WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId", GxErrorMask.GX_NOMASK,prmT000419)
             ,new CursorDef("T000420", "SELECT [MenuDescripcion] FROM [Menu] WITH (NOLOCK) WHERE [MenuId] = @MenuId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000420,1,0,true,false )
             ,new CursorDef("T000421", "SELECT [GrupoCodigo], [MenuId] FROM [AccesoMenu] WITH (NOLOCK) ORDER BY [GrupoCodigo], [MenuId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000421,100,0,true,false )
             ,new CursorDef("T000422", "SELECT T1.[GrupoCodigo], T2.[OpcionDescripcion], T1.[OpcionAcceso], T1.[MenuId], T1.[OpcionId] FROM ([AccesoOpcion] T1 WITH (NOLOCK) INNER JOIN [Opcion] T2 WITH (NOLOCK) ON T2.[MenuId] = T1.[MenuId] AND T2.[OpcionId] = T1.[OpcionId]) WHERE T1.[GrupoCodigo] = @GrupoCodigo and T1.[MenuId] = @MenuId and T1.[OpcionId] = @OpcionId ORDER BY T1.[GrupoCodigo], T1.[MenuId], T1.[OpcionId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000422,11,0,true,false )
             ,new CursorDef("T000423", "SELECT [OpcionDescripcion] FROM [Opcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000423,1,0,true,false )
             ,new CursorDef("T000424", "SELECT [GrupoCodigo], [MenuId], [OpcionId] FROM [AccesoOpcion] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000424,1,0,true,false )
             ,new CursorDef("T000425", "INSERT INTO [AccesoOpcion] ([GrupoCodigo], [OpcionAcceso], [MenuId], [OpcionId]) VALUES (@GrupoCodigo, @OpcionAcceso, @MenuId, @OpcionId)", GxErrorMask.GX_NOMASK,prmT000425)
             ,new CursorDef("T000426", "UPDATE [AccesoOpcion] SET [OpcionAcceso]=@OpcionAcceso  WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId AND [OpcionId] = @OpcionId", GxErrorMask.GX_NOMASK,prmT000426)
             ,new CursorDef("T000427", "DELETE FROM [AccesoOpcion]  WHERE [GrupoCodigo] = @GrupoCodigo AND [MenuId] = @MenuId AND [OpcionId] = @OpcionId", GxErrorMask.GX_NOMASK,prmT000427)
             ,new CursorDef("T000428", "SELECT [OpcionDescripcion] FROM [Opcion] WITH (NOLOCK) WHERE [MenuId] = @MenuId AND [OpcionId] = @OpcionId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000428,1,0,true,false )
             ,new CursorDef("T000429", "SELECT [GrupoCodigo], [MenuId], [OpcionId] FROM [AccesoOpcion] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo and [MenuId] = @MenuId ORDER BY [GrupoCodigo], [MenuId], [OpcionId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000429,11,0,true,false )
             ,new CursorDef("T000430", "SELECT [GrupoCodigo], [GrupoDescripcion] FROM [GrupoUsuario] WITH (NOLOCK) ORDER BY [GrupoDescripcion] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000430,0,0,true,false )
             ,new CursorDef("T000431", "SELECT [GrupoCodigo] FROM [GrupoUsuario] WITH (NOLOCK) WHERE [GrupoCodigo] = @GrupoCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000431,1,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 29 :
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 18 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 21 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 25 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 26 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 27 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 29 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
