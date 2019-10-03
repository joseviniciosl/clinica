/*
               File: Agenda_BC
        Description: Agenda
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:6:35.95
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
   public class agenda_bc : GXHttpHandler, IGxSilentTrn
   {
      public agenda_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public agenda_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void INITTRN( )
      {
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
               Z41ClinicaCodigo = A41ClinicaCodigo ;
               Z56AgendaId = A56AgendaId ;
               SetMode( "UPD") ;
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

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_180( )
      {
         BeforeValidate1857( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1857( ) ;
            }
            else
            {
               CheckExtendedTable1857( ) ;
               if ( AnyError == 0 )
               {
                  ZM1857( 4) ;
               }
               CloseExtendedTableCursors1857( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ZM1857( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z246AgendaNombre = A246AgendaNombre ;
            Z230AgendaInicial = A230AgendaInicial ;
            Z231AgendaFinal = A231AgendaFinal ;
            Z232AgendaObs = A232AgendaObs ;
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -3 )
         {
            Z56AgendaId = A56AgendaId ;
            Z246AgendaNombre = A246AgendaNombre ;
            Z230AgendaInicial = A230AgendaInicial ;
            Z231AgendaFinal = A231AgendaFinal ;
            Z232AgendaObs = A232AgendaObs ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1857( )
      {
         /* Using cursor BC00185 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A56AgendaId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound57 = 1 ;
            A246AgendaNombre = BC00185_A246AgendaNombre[0] ;
            A230AgendaInicial = BC00185_A230AgendaInicial[0] ;
            A231AgendaFinal = BC00185_A231AgendaFinal[0] ;
            A232AgendaObs = BC00185_A232AgendaObs[0] ;
            ZM1857( -3) ;
         }
         pr_default.close(3);
         OnLoadActions1857( ) ;
      }

      protected void OnLoadActions1857( )
      {
      }

      protected void CheckExtendedTable1857( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00184 */
         pr_default.execute(2, new Object[] {A41ClinicaCodigo});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError41 = 1 ;
            GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
            AnyError = 1 ;
         }
         if ( AnyError41 == 0 )
         {
         }
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A230AgendaInicial) || ( A230AgendaInicial >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Inicia fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A231AgendaFinal) || ( A231AgendaFinal >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Finaliza fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1857( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1857( )
      {
         /* Using cursor BC00186 */
         pr_default.execute(4, new Object[] {A41ClinicaCodigo, A56AgendaId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound57 = 1 ;
         }
         else
         {
            RcdFound57 = 0 ;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00183 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A56AgendaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1857( 3) ;
            RcdFound57 = 1 ;
            A56AgendaId = BC00183_A56AgendaId[0] ;
            A246AgendaNombre = BC00183_A246AgendaNombre[0] ;
            A230AgendaInicial = BC00183_A230AgendaInicial[0] ;
            A231AgendaFinal = BC00183_A231AgendaFinal[0] ;
            A232AgendaObs = BC00183_A232AgendaObs[0] ;
            A41ClinicaCodigo = BC00183_A41ClinicaCodigo[0] ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z56AgendaId = A56AgendaId ;
            sMode57 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Load1857( ) ;
            Gx_mode = sMode57 ;
         }
         else
         {
            RcdFound57 = 0 ;
            InitializeNonKey1857( ) ;
            sMode57 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode57 ;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1857( ) ;
         if ( RcdFound57 == 0 )
         {
            Gx_mode = "INS" ;
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_180( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency1857( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00182 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A56AgendaId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Agenda"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z246AgendaNombre, BC00182_A246AgendaNombre[0]) != 0 ) || ( Z230AgendaInicial != BC00182_A230AgendaInicial[0] ) || ( Z231AgendaFinal != BC00182_A231AgendaFinal[0] ) || ( StringUtil.StrCmp(Z232AgendaObs, BC00182_A232AgendaObs[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Agenda"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1857( )
      {
         BeforeValidate1857( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1857( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1857( 0) ;
            CheckOptimisticConcurrency1857( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1857( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1857( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00187 */
                     pr_default.execute(5, new Object[] {A56AgendaId, A246AgendaNombre, A230AgendaInicial, A231AgendaFinal, A232AgendaObs, A41ClinicaCodigo});
                     pr_default.close(5);
                     if ( (pr_default.getStatus(5) == 1) )
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
               Load1857( ) ;
            }
            EndLevel1857( ) ;
         }
         CloseExtendedTableCursors1857( ) ;
      }

      protected void Update1857( )
      {
         BeforeValidate1857( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1857( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1857( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1857( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1857( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00188 */
                     pr_default.execute(6, new Object[] {A246AgendaNombre, A230AgendaInicial, A231AgendaFinal, A232AgendaObs, A41ClinicaCodigo, A56AgendaId});
                     pr_default.close(6);
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Agenda"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1857( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
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
            EndLevel1857( ) ;
         }
         CloseExtendedTableCursors1857( ) ;
      }

      protected void DeferredUpdate1857( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate1857( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1857( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1857( ) ;
            AfterConfirm1857( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1857( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00189 */
                  pr_default.execute(7, new Object[] {A41ClinicaCodigo, A56AgendaId});
                  pr_default.close(7);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), 0, "");
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
         sMode57 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel1857( ) ;
         Gx_mode = sMode57 ;
      }

      protected void OnDeleteControls1857( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1857( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1857( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanKeyStart1857( )
      {
         /* Using cursor BC001810 */
         pr_default.execute(8, new Object[] {A41ClinicaCodigo, A56AgendaId});
         RcdFound57 = 0 ;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound57 = 1 ;
            A56AgendaId = BC001810_A56AgendaId[0] ;
            A246AgendaNombre = BC001810_A246AgendaNombre[0] ;
            A230AgendaInicial = BC001810_A230AgendaInicial[0] ;
            A231AgendaFinal = BC001810_A231AgendaFinal[0] ;
            A232AgendaObs = BC001810_A232AgendaObs[0] ;
            A41ClinicaCodigo = BC001810_A41ClinicaCodigo[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1857( )
      {
         pr_default.readNext(8);
         RcdFound57 = 0 ;
         ScanKeyLoad1857( ) ;
      }

      protected void ScanKeyLoad1857( )
      {
         sMode57 = Gx_mode ;
         Gx_mode = "DSP" ;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound57 = 1 ;
            A56AgendaId = BC001810_A56AgendaId[0] ;
            A246AgendaNombre = BC001810_A246AgendaNombre[0] ;
            A230AgendaInicial = BC001810_A230AgendaInicial[0] ;
            A231AgendaFinal = BC001810_A231AgendaFinal[0] ;
            A232AgendaObs = BC001810_A232AgendaObs[0] ;
            A41ClinicaCodigo = BC001810_A41ClinicaCodigo[0] ;
         }
         Gx_mode = sMode57 ;
      }

      protected void ScanKeyEnd1857( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm1857( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1857( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1857( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1857( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1857( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1857( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1857( )
      {
      }

      protected void AddRow1857( )
      {
         VarsToRow57( bcAgenda) ;
      }

      protected void ReadRow1857( )
      {
         RowToVars57( bcAgenda, 1) ;
      }

      protected void InitializeNonKey1857( )
      {
         A246AgendaNombre = "" ;
         A230AgendaInicial = (DateTime)(DateTime.MinValue) ;
         A231AgendaFinal = (DateTime)(DateTime.MinValue) ;
         A232AgendaObs = "" ;
      }

      protected void InitAll1857( )
      {
         A41ClinicaCodigo = "" ;
         A56AgendaId = "" ;
         InitializeNonKey1857( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow57( SdtAgenda obj57 )
      {
         obj57.gxTpr_Mode = Gx_mode ;
         obj57.gxTpr_Agendanombre = A246AgendaNombre ;
         obj57.gxTpr_Agendainicial = A230AgendaInicial ;
         obj57.gxTpr_Agendafinal = A231AgendaFinal ;
         obj57.gxTpr_Agendaobs = A232AgendaObs ;
         obj57.gxTpr_Clinicacodigo = A41ClinicaCodigo ;
         obj57.gxTpr_Agendaid = A56AgendaId ;
         obj57.gxTpr_Clinicacodigo_Z = Z41ClinicaCodigo ;
         obj57.gxTpr_Agendaid_Z = Z56AgendaId ;
         obj57.gxTpr_Agendanombre_Z = Z246AgendaNombre ;
         obj57.gxTpr_Agendainicial_Z = Z230AgendaInicial ;
         obj57.gxTpr_Agendafinal_Z = Z231AgendaFinal ;
         obj57.gxTpr_Agendaobs_Z = Z232AgendaObs ;
         obj57.gxTpr_Mode = Gx_mode ;
         return  ;
      }

      public void RowToVars57( SdtAgenda obj57 ,
                               int forceLoad )
      {
         Gx_mode = obj57.gxTpr_Mode ;
         A246AgendaNombre = obj57.gxTpr_Agendanombre ;
         A230AgendaInicial = obj57.gxTpr_Agendainicial ;
         A231AgendaFinal = obj57.gxTpr_Agendafinal ;
         A232AgendaObs = obj57.gxTpr_Agendaobs ;
         A41ClinicaCodigo = obj57.gxTpr_Clinicacodigo ;
         A56AgendaId = obj57.gxTpr_Agendaid ;
         Z41ClinicaCodigo = obj57.gxTpr_Clinicacodigo_Z ;
         Z56AgendaId = obj57.gxTpr_Agendaid_Z ;
         Z246AgendaNombre = obj57.gxTpr_Agendanombre_Z ;
         Z230AgendaInicial = obj57.gxTpr_Agendainicial_Z ;
         Z231AgendaFinal = obj57.gxTpr_Agendafinal_Z ;
         Z232AgendaObs = obj57.gxTpr_Agendaobs_Z ;
         Gx_mode = obj57.gxTpr_Mode ;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         A41ClinicaCodigo = (String)getParm(obj,0) ;
         A56AgendaId = (String)getParm(obj,1) ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1857( ) ;
         ScanKeyStart1857( ) ;
         if ( RcdFound57 == 0 )
         {
            Gx_mode = "INS" ;
            /* Using cursor BC001811 */
            pr_default.execute(9, new Object[] {A41ClinicaCodigo});
            if ( (pr_default.getStatus(9) == 101) )
            {
               AnyError41 = 1 ;
               GX_msglist.addItem("No existe 'Clínica Médica'.", "ForeignKeyNotFound", 1, "CLINICACODIGO");
               AnyError = 1 ;
            }
            if ( AnyError41 == 0 )
            {
            }
            pr_default.close(9);
         }
         else
         {
            Gx_mode = "UPD" ;
            Z41ClinicaCodigo = A41ClinicaCodigo ;
            Z56AgendaId = A56AgendaId ;
         }
         ZM1857( -3) ;
         sMode57 = Gx_mode ;
         Gx_mode = "DSP" ;
         OnLoadActions1857( ) ;
         Gx_mode = sMode57 ;
         AddRow1857( ) ;
         ScanKeyEnd1857( ) ;
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         context.GX_msglist = BackMsgLst ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1 ;
         RowToVars57( bcAgenda, 0) ;
         nKeyPressed = 1 ;
         GetKey1857( ) ;
         if ( RcdFound57 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A56AgendaId, Z56AgendaId) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               A56AgendaId = Z56AgendaId ;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
            }
            else
            {
               Gx_mode = "UPD" ;
               /* Update record */
               Update1857( ) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
               AnyError = 1 ;
            }
            else
            {
               if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A56AgendaId, Z56AgendaId) != 0 ) )
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                  }
                  else
                  {
                     Gx_mode = "INS" ;
                     /* Insert record */
                     Insert1857( ) ;
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                     AnyError = 1 ;
                  }
                  else
                  {
                     Gx_mode = "INS" ;
                     /* Insert record */
                     Insert1857( ) ;
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow57( bcAgenda) ;
         context.GX_msglist = BackMsgLst ;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         RowToVars57( bcAgenda, 0) ;
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey1857( ) ;
         if ( RcdFound57 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A56AgendaId, Z56AgendaId) != 0 ) )
            {
               A41ClinicaCodigo = Z41ClinicaCodigo ;
               A56AgendaId = Z56AgendaId ;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD" ;
               update_Check( ) ;
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A41ClinicaCodigo, Z41ClinicaCodigo) != 0 ) || ( StringUtil.StrCmp(A56AgendaId, Z56AgendaId) != 0 ) )
            {
               Gx_mode = "INS" ;
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1 ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(9);
         context.RollbackDataStores("Agenda_BC");
         VarsToRow57( bcAgenda) ;
         context.GX_msglist = BackMsgLst ;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcAgenda.gxTpr_Mode ;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode ;
         bcAgenda.gxTpr_Mode = Gx_mode ;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcAgenda )
         {
            bcAgenda = (SdtAgenda)(sdt) ;
            if ( StringUtil.StrCmp(bcAgenda.gxTpr_Mode, "") == 0 )
            {
               bcAgenda.gxTpr_Mode = "INS" ;
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow57( bcAgenda) ;
            }
            else
            {
               RowToVars57( bcAgenda, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcAgenda.gxTpr_Mode, "") == 0 )
            {
               bcAgenda.gxTpr_Mode = "INS" ;
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars57( bcAgenda, 1) ;
         return  ;
      }

      public SdtAgenda Agenda_BC
      {
         get {
            return bcAgenda ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
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
         pr_default.close(1);
         pr_default.close(9);
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Gx_mode = "" ;
         Z41ClinicaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         Z56AgendaId = "" ;
         A56AgendaId = "" ;
         Z246AgendaNombre = "" ;
         A246AgendaNombre = "" ;
         Z230AgendaInicial = (DateTime)(DateTime.MinValue) ;
         A230AgendaInicial = (DateTime)(DateTime.MinValue) ;
         Z231AgendaFinal = (DateTime)(DateTime.MinValue) ;
         A231AgendaFinal = (DateTime)(DateTime.MinValue) ;
         Z232AgendaObs = "" ;
         A232AgendaObs = "" ;
         BC00185_A56AgendaId = new String[] {""} ;
         BC00185_A246AgendaNombre = new String[] {""} ;
         BC00185_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         BC00185_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         BC00185_A232AgendaObs = new String[] {""} ;
         BC00185_A41ClinicaCodigo = new String[] {""} ;
         BC00184_A41ClinicaCodigo = new String[] {""} ;
         BC00186_A41ClinicaCodigo = new String[] {""} ;
         BC00186_A56AgendaId = new String[] {""} ;
         BC00183_A56AgendaId = new String[] {""} ;
         BC00183_A246AgendaNombre = new String[] {""} ;
         BC00183_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         BC00183_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         BC00183_A232AgendaObs = new String[] {""} ;
         BC00183_A41ClinicaCodigo = new String[] {""} ;
         sMode57 = "" ;
         BC00182_A56AgendaId = new String[] {""} ;
         BC00182_A246AgendaNombre = new String[] {""} ;
         BC00182_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         BC00182_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         BC00182_A232AgendaObs = new String[] {""} ;
         BC00182_A41ClinicaCodigo = new String[] {""} ;
         BC001810_A56AgendaId = new String[] {""} ;
         BC001810_A246AgendaNombre = new String[] {""} ;
         BC001810_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         BC001810_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         BC001810_A232AgendaObs = new String[] {""} ;
         BC001810_A41ClinicaCodigo = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         BC001811_A41ClinicaCodigo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.agenda_bc__default(),
            new Object[][] {
                new Object[] {
               BC00182_A56AgendaId, BC00182_A246AgendaNombre, BC00182_A230AgendaInicial, BC00182_A231AgendaFinal, BC00182_A232AgendaObs, BC00182_A41ClinicaCodigo
               }
               , new Object[] {
               BC00183_A56AgendaId, BC00183_A246AgendaNombre, BC00183_A230AgendaInicial, BC00183_A231AgendaFinal, BC00183_A232AgendaObs, BC00183_A41ClinicaCodigo
               }
               , new Object[] {
               BC00184_A41ClinicaCodigo
               }
               , new Object[] {
               BC00185_A56AgendaId, BC00185_A246AgendaNombre, BC00185_A230AgendaInicial, BC00185_A231AgendaFinal, BC00185_A232AgendaObs, BC00185_A41ClinicaCodigo
               }
               , new Object[] {
               BC00186_A41ClinicaCodigo, BC00186_A56AgendaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001810_A56AgendaId, BC001810_A246AgendaNombre, BC001810_A230AgendaInicial, BC001810_A231AgendaFinal, BC001810_A232AgendaObs, BC001810_A41ClinicaCodigo
               }
               , new Object[] {
               BC001811_A41ClinicaCodigo
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound57 ;
      private int trnEnded ;
      private int AnyError41 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode57 ;
      private DateTime Z230AgendaInicial ;
      private DateTime A230AgendaInicial ;
      private DateTime Z231AgendaFinal ;
      private DateTime A231AgendaFinal ;
      private String Z41ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String Z56AgendaId ;
      private String A56AgendaId ;
      private String Z246AgendaNombre ;
      private String A246AgendaNombre ;
      private String Z232AgendaObs ;
      private String A232AgendaObs ;
      private SdtAgenda bcAgenda ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC00185_A56AgendaId ;
      private String[] BC00185_A246AgendaNombre ;
      private DateTime[] BC00185_A230AgendaInicial ;
      private DateTime[] BC00185_A231AgendaFinal ;
      private String[] BC00185_A232AgendaObs ;
      private String[] BC00185_A41ClinicaCodigo ;
      private String[] BC00184_A41ClinicaCodigo ;
      private String[] BC00186_A41ClinicaCodigo ;
      private String[] BC00186_A56AgendaId ;
      private String[] BC00183_A56AgendaId ;
      private String[] BC00183_A246AgendaNombre ;
      private DateTime[] BC00183_A230AgendaInicial ;
      private DateTime[] BC00183_A231AgendaFinal ;
      private String[] BC00183_A232AgendaObs ;
      private String[] BC00183_A41ClinicaCodigo ;
      private String[] BC00182_A56AgendaId ;
      private String[] BC00182_A246AgendaNombre ;
      private DateTime[] BC00182_A230AgendaInicial ;
      private DateTime[] BC00182_A231AgendaFinal ;
      private String[] BC00182_A232AgendaObs ;
      private String[] BC00182_A41ClinicaCodigo ;
      private String[] BC001810_A56AgendaId ;
      private String[] BC001810_A246AgendaNombre ;
      private DateTime[] BC001810_A230AgendaInicial ;
      private DateTime[] BC001810_A231AgendaFinal ;
      private String[] BC001810_A232AgendaObs ;
      private String[] BC001810_A41ClinicaCodigo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String[] BC001811_A41ClinicaCodigo ;
   }

   public class agenda_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00185 ;
          prmBC00185 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00184 ;
          prmBC00184 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00186 ;
          prmBC00186 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00183 ;
          prmBC00183 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00182 ;
          prmBC00182 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00187 ;
          prmBC00187 = new Object[] {
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AgendaInicial",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AgendaFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AgendaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00188 ;
          prmBC00188 = new Object[] {
          new Object[] {"@AgendaNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AgendaInicial",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AgendaFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AgendaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC00189 ;
          prmBC00189 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001810 ;
          prmBC001810 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AgendaId",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001811 ;
          prmBC001811 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00182", "SELECT [AgendaId], [AgendaNombre], [AgendaInicial], [AgendaFinal], [AgendaObs], [ClinicaCodigo] FROM [Agenda] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00182,1,0,true,false )
             ,new CursorDef("BC00183", "SELECT [AgendaId], [AgendaNombre], [AgendaInicial], [AgendaFinal], [AgendaObs], [ClinicaCodigo] FROM [Agenda] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00183,1,0,true,false )
             ,new CursorDef("BC00184", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00184,1,0,true,false )
             ,new CursorDef("BC00185", "SELECT TM1.[AgendaId], TM1.[AgendaNombre], TM1.[AgendaInicial], TM1.[AgendaFinal], TM1.[AgendaObs], TM1.[ClinicaCodigo] FROM [Agenda] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[AgendaId] = @AgendaId ORDER BY TM1.[ClinicaCodigo], TM1.[AgendaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00185,100,0,true,false )
             ,new CursorDef("BC00186", "SELECT [ClinicaCodigo], [AgendaId] FROM [Agenda] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00186,1,0,true,false )
             ,new CursorDef("BC00187", "INSERT INTO [Agenda] ([AgendaId], [AgendaNombre], [AgendaInicial], [AgendaFinal], [AgendaObs], [ClinicaCodigo]) VALUES (@AgendaId, @AgendaNombre, @AgendaInicial, @AgendaFinal, @AgendaObs, @ClinicaCodigo)", GxErrorMask.GX_NOMASK,prmBC00187)
             ,new CursorDef("BC00188", "UPDATE [Agenda] SET [AgendaNombre]=@AgendaNombre, [AgendaInicial]=@AgendaInicial, [AgendaFinal]=@AgendaFinal, [AgendaObs]=@AgendaObs  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId", GxErrorMask.GX_NOMASK,prmBC00188)
             ,new CursorDef("BC00189", "DELETE FROM [Agenda]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [AgendaId] = @AgendaId", GxErrorMask.GX_NOMASK,prmBC00189)
             ,new CursorDef("BC001810", "SELECT TM1.[AgendaId], TM1.[AgendaNombre], TM1.[AgendaInicial], TM1.[AgendaFinal], TM1.[AgendaObs], TM1.[ClinicaCodigo] FROM [Agenda] TM1 WITH (NOLOCK) WHERE TM1.[ClinicaCodigo] = @ClinicaCodigo and TM1.[AgendaId] = @AgendaId ORDER BY TM1.[ClinicaCodigo], TM1.[AgendaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001810,100,0,true,false )
             ,new CursorDef("BC001811", "SELECT [ClinicaCodigo] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001811,1,0,true,false )
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 9 :
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
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
                break;
       }
    }

 }

}
