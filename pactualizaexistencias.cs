/*
               File: pActualizaExistencias
        Description: Actualiza Existencias y Costos de Movimiento de Inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:53.0
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pactualizaexistencias : GXProcedure
   {
      public pactualizaexistencias( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pactualizaexistencias( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_TipoMICodigo ,
                           ref int aP2_MovimientoId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.A267MovimientoId = aP2_MovimientoId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
      }

      public int executeUdp( ref String aP0_ClinicaCodigo ,
                             ref String aP1_TipoMICodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.A267MovimientoId = aP2_MovimientoId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
         return A267MovimientoId ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoMICodigo ,
                                 ref int aP2_MovimientoId )
      {
         pactualizaexistencias objpactualizaexistencias;
         objpactualizaexistencias = new pactualizaexistencias();
         objpactualizaexistencias.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpactualizaexistencias.A114TipoMICodigo = aP1_TipoMICodigo;
         objpactualizaexistencias.A267MovimientoId = aP2_MovimientoId;
         objpactualizaexistencias.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpactualizaexistencias);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pactualizaexistencias)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor P00112 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A114TipoMICodigo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A117TipoMIAfectaCosto = P00112_A117TipoMIAfectaCosto[0] ;
            A116TipoMIOperacion = P00112_A116TipoMIOperacion[0] ;
            AV8TipoMIAfectaCosto = A117TipoMIAfectaCosto ;
            AV11TipoMIOperacion = A116TipoMIOperacion ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV8TipoMIAfectaCosto == 1 )
         {
            /* Using cursor P00113 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               BRK113 = false ;
               A274MovimientoCosto = P00113_A274MovimientoCosto[0] ;
               A121BodegaCodigo = P00113_A121BodegaCodigo[0] ;
               A30ArticuloCodigo = P00113_A30ArticuloCodigo[0] ;
               A273MovimientoCantidad = P00113_A273MovimientoCantidad[0] ;
               A272MovimientoLinea = P00113_A272MovimientoLinea[0] ;
               A121BodegaCodigo = P00113_A121BodegaCodigo[0] ;
               /* Using cursor P00114 */
               pr_default.execute(2, new Object[] {A41ClinicaCodigo, A121BodegaCodigo, A30ArticuloCodigo});
               A276InventarioExistencia = P00114_A276InventarioExistencia[0] ;
               AV14ArticuloCodigo = A30ArticuloCodigo ;
               AV9BodegaCodigo = A121BodegaCodigo ;
               /* Execute user subroutine: S1278 */
               S1278 ();
               if ( returnInSub )
               {
                  pr_default.close(1);
                  pr_default.close(2);
                  this.cleanup();
                  if (true) return;
               }
               AV12InventarioExistencia = (decimal)(AV12InventarioExistencia+A273MovimientoCantidad) ;
               AV15InventarioCostoNuevo = (decimal)(AV13InventarioCosto+A274MovimientoCosto) ;
               AV15InventarioCostoNuevo = NumberUtil.Round( AV12InventarioExistencia/ (decimal)(AV15InventarioCostoNuevo), 2) ;
               /* Execute user subroutine: S1165 */
               S1165 ();
               if ( returnInSub )
               {
                  pr_default.close(1);
                  pr_default.close(2);
                  this.cleanup();
                  if (true) return;
               }
               if ( AV11TipoMIOperacion == 0 )
               {
                  A273MovimientoCantidad = (decimal)(A273MovimientoCantidad*-1) ;
               }
               AV20GXLvl26 = 0 ;
               while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P00113_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(P00113_A114TipoMICodigo[0], A114TipoMICodigo) == 0 ) && ( P00113_A267MovimientoId[0] == A267MovimientoId ) )
               {
                  BRK113 = false ;
                  A121BodegaCodigo = P00113_A121BodegaCodigo[0] ;
                  A30ArticuloCodigo = P00113_A30ArticuloCodigo[0] ;
                  A273MovimientoCantidad = P00113_A273MovimientoCantidad[0] ;
                  A272MovimientoLinea = P00113_A272MovimientoLinea[0] ;
                  A121BodegaCodigo = P00113_A121BodegaCodigo[0] ;
                  if ( StringUtil.StrCmp(A121BodegaCodigo, AV9BodegaCodigo) == 0 )
                  {
                     if ( StringUtil.StrCmp(A30ArticuloCodigo, AV14ArticuloCodigo) == 0 )
                     {
                        /* Using cursor P00114 */
                        pr_default.execute(2, new Object[] {A41ClinicaCodigo, A121BodegaCodigo, A30ArticuloCodigo});
                        A276InventarioExistencia = P00114_A276InventarioExistencia[0] ;
                        AV20GXLvl26 = 1 ;
                        A276InventarioExistencia = (decimal)(A276InventarioExistencia+A273MovimientoCantidad) ;
                        /* Using cursor P00115 */
                        pr_default.execute(3, new Object[] {A276InventarioExistencia, A41ClinicaCodigo, A121BodegaCodigo, A30ArticuloCodigo});
                        pr_default.close(3);
                     }
                  }
                  BRK113 = true ;
                  pr_default.readNext(1);
               }
               if ( AV20GXLvl26 == 0 )
               {
                  /*
                     INSERT RECORD ON TABLE Inventario

                  */
                  W121BodegaCodigo = A121BodegaCodigo ;
                  W30ArticuloCodigo = A30ArticuloCodigo ;
                  W276InventarioExistencia = A276InventarioExistencia ;
                  W277InventarioCosto = A277InventarioCosto ;
                  A121BodegaCodigo = AV9BodegaCodigo ;
                  A30ArticuloCodigo = AV14ArticuloCodigo ;
                  A276InventarioExistencia = A273MovimientoCantidad ;
                  A277InventarioCosto = A274MovimientoCosto ;
                  /* Using cursor P00116 */
                  pr_default.execute(4, new Object[] {A41ClinicaCodigo, A121BodegaCodigo, A30ArticuloCodigo, A276InventarioExistencia, A277InventarioCosto});
                  pr_default.close(4);
                  if ( (pr_default.getStatus(4) == 1) )
                  {
                     context.Gx_err = 1 ;
                     Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
                  }
                  else
                  {
                     context.Gx_err = 0 ;
                     Gx_emsg = "" ;
                  }
                  A121BodegaCodigo = W121BodegaCodigo ;
                  A30ArticuloCodigo = W30ArticuloCodigo ;
                  A276InventarioExistencia = W276InventarioExistencia ;
                  A277InventarioCosto = W277InventarioCosto ;
                  /* End Insert */
               }
               /* Using cursor P00117 */
               pr_default.execute(5, new Object[] {A273MovimientoCantidad, A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea});
               pr_default.close(5);
               if ( ! BRK113 )
               {
                  BRK113 = true ;
                  pr_default.readNext(1);
               }
            }
            pr_default.close(1);
            pr_default.close(2);
         }
         else
         {
            /* Using cursor P00118 */
            pr_default.execute(6, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
            while ( (pr_default.getStatus(6) != 101) )
            {
               BRK116 = false ;
               A274MovimientoCosto = P00118_A274MovimientoCosto[0] ;
               A121BodegaCodigo = P00118_A121BodegaCodigo[0] ;
               A30ArticuloCodigo = P00118_A30ArticuloCodigo[0] ;
               A273MovimientoCantidad = P00118_A273MovimientoCantidad[0] ;
               A272MovimientoLinea = P00118_A272MovimientoLinea[0] ;
               A121BodegaCodigo = P00118_A121BodegaCodigo[0] ;
               /* Using cursor P00119 */
               pr_default.execute(7, new Object[] {A41ClinicaCodigo, A121BodegaCodigo, A30ArticuloCodigo});
               A276InventarioExistencia = P00119_A276InventarioExistencia[0] ;
               AV14ArticuloCodigo = A30ArticuloCodigo ;
               AV9BodegaCodigo = A121BodegaCodigo ;
               if ( AV11TipoMIOperacion == 0 )
               {
                  A273MovimientoCantidad = (decimal)(A273MovimientoCantidad*-1) ;
               }
               AV22GXLvl49 = 0 ;
               while ( (pr_default.getStatus(6) != 101) && ( StringUtil.StrCmp(P00118_A41ClinicaCodigo[0], A41ClinicaCodigo) == 0 ) && ( StringUtil.StrCmp(P00118_A114TipoMICodigo[0], A114TipoMICodigo) == 0 ) && ( P00118_A267MovimientoId[0] == A267MovimientoId ) )
               {
                  BRK116 = false ;
                  A121BodegaCodigo = P00118_A121BodegaCodigo[0] ;
                  A30ArticuloCodigo = P00118_A30ArticuloCodigo[0] ;
                  A273MovimientoCantidad = P00118_A273MovimientoCantidad[0] ;
                  A272MovimientoLinea = P00118_A272MovimientoLinea[0] ;
                  A121BodegaCodigo = P00118_A121BodegaCodigo[0] ;
                  if ( StringUtil.StrCmp(A121BodegaCodigo, AV9BodegaCodigo) == 0 )
                  {
                     if ( StringUtil.StrCmp(A30ArticuloCodigo, AV14ArticuloCodigo) == 0 )
                     {
                        /* Using cursor P00119 */
                        pr_default.execute(7, new Object[] {A41ClinicaCodigo, A121BodegaCodigo, A30ArticuloCodigo});
                        A276InventarioExistencia = P00119_A276InventarioExistencia[0] ;
                        AV22GXLvl49 = 1 ;
                        A276InventarioExistencia = (decimal)(A276InventarioExistencia+A273MovimientoCantidad) ;
                        /* Using cursor P001110 */
                        pr_default.execute(8, new Object[] {A276InventarioExistencia, A41ClinicaCodigo, A121BodegaCodigo, A30ArticuloCodigo});
                        pr_default.close(8);
                     }
                  }
                  BRK116 = true ;
                  pr_default.readNext(6);
               }
               if ( AV22GXLvl49 == 0 )
               {
                  /*
                     INSERT RECORD ON TABLE Inventario

                  */
                  W121BodegaCodigo = A121BodegaCodigo ;
                  W30ArticuloCodigo = A30ArticuloCodigo ;
                  W276InventarioExistencia = A276InventarioExistencia ;
                  W277InventarioCosto = A277InventarioCosto ;
                  A121BodegaCodigo = AV9BodegaCodigo ;
                  A30ArticuloCodigo = AV14ArticuloCodigo ;
                  A276InventarioExistencia = A273MovimientoCantidad ;
                  A277InventarioCosto = A274MovimientoCosto ;
                  /* Using cursor P001111 */
                  pr_default.execute(9, new Object[] {A41ClinicaCodigo, A121BodegaCodigo, A30ArticuloCodigo, A276InventarioExistencia, A277InventarioCosto});
                  pr_default.close(9);
                  if ( (pr_default.getStatus(9) == 1) )
                  {
                     context.Gx_err = 1 ;
                     Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
                  }
                  else
                  {
                     context.Gx_err = 0 ;
                     Gx_emsg = "" ;
                  }
                  A121BodegaCodigo = W121BodegaCodigo ;
                  A30ArticuloCodigo = W30ArticuloCodigo ;
                  A276InventarioExistencia = W276InventarioExistencia ;
                  A277InventarioCosto = W277InventarioCosto ;
                  /* End Insert */
               }
               /* Using cursor P001112 */
               pr_default.execute(10, new Object[] {A273MovimientoCantidad, A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea});
               pr_default.close(10);
               if ( ! BRK116 )
               {
                  BRK116 = true ;
                  pr_default.readNext(6);
               }
            }
            pr_default.close(6);
            pr_default.close(7);
         }
         this.cleanup();
      }

      protected void S1165( )
      {
         /* 'ACTUALIZA COSTOS' Routine */
         /* Optimized UPDATE. */
         /* Using cursor P001113 */
         pr_default.execute(11, new Object[] {AV15InventarioCostoNuevo, A41ClinicaCodigo, AV14ArticuloCodigo});
         pr_default.close(11);
         /* End optimized UPDATE. */
         /* Optimized UPDATE. */
         /* Using cursor P001114 */
         pr_default.execute(12, new Object[] {AV15InventarioCostoNuevo, A41ClinicaCodigo, AV14ArticuloCodigo});
         pr_default.close(12);
         /* End optimized UPDATE. */
      }

      protected void S1278( )
      {
         /* 'EXISTENCIAS ACTUALES' Routine */
         AV12InventarioExistencia = 0 ;
         AV13InventarioCosto = 0 ;
         /* Optimized group. */
         /* Using cursor P001115 */
         pr_default.execute(13, new Object[] {A41ClinicaCodigo, AV14ArticuloCodigo});
         c276InventarioExistencia = P001115_A276InventarioExistencia[0] ;
         c277InventarioCosto = P001115_A277InventarioCosto[0] ;
         pr_default.close(13);
         AV12InventarioExistencia = (decimal)(AV12InventarioExistencia+c276InventarioExistencia) ;
         AV13InventarioCosto = (decimal)(AV13InventarioCosto+c277InventarioCosto) ;
         /* End optimized group. */
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pActualizaExistencias");
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         P00112_A41ClinicaCodigo = new String[] {""} ;
         P00112_A114TipoMICodigo = new String[] {""} ;
         P00112_A117TipoMIAfectaCosto = new short[1] ;
         P00112_A116TipoMIOperacion = new short[1] ;
         P00113_A41ClinicaCodigo = new String[] {""} ;
         P00113_A114TipoMICodigo = new String[] {""} ;
         P00113_A267MovimientoId = new int[1] ;
         P00113_A274MovimientoCosto = new decimal[1] ;
         P00113_A121BodegaCodigo = new String[] {""} ;
         P00113_A30ArticuloCodigo = new String[] {""} ;
         P00113_A273MovimientoCantidad = new decimal[1] ;
         P00113_A272MovimientoLinea = new short[1] ;
         A121BodegaCodigo = "" ;
         A30ArticuloCodigo = "" ;
         P00114_A276InventarioExistencia = new decimal[1] ;
         AV14ArticuloCodigo = "" ;
         AV9BodegaCodigo = "" ;
         W121BodegaCodigo = "" ;
         W30ArticuloCodigo = "" ;
         Gx_emsg = "" ;
         P00118_A41ClinicaCodigo = new String[] {""} ;
         P00118_A114TipoMICodigo = new String[] {""} ;
         P00118_A267MovimientoId = new int[1] ;
         P00118_A274MovimientoCosto = new decimal[1] ;
         P00118_A121BodegaCodigo = new String[] {""} ;
         P00118_A30ArticuloCodigo = new String[] {""} ;
         P00118_A273MovimientoCantidad = new decimal[1] ;
         P00118_A272MovimientoLinea = new short[1] ;
         P00119_A276InventarioExistencia = new decimal[1] ;
         P001115_A276InventarioExistencia = new decimal[1] ;
         P001115_A277InventarioCosto = new decimal[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pactualizaexistencias__default(),
            new Object[][] {
                new Object[] {
               P00112_A41ClinicaCodigo, P00112_A114TipoMICodigo, P00112_A117TipoMIAfectaCosto, P00112_A116TipoMIOperacion
               }
               , new Object[] {
               P00113_A41ClinicaCodigo, P00113_A114TipoMICodigo, P00113_A267MovimientoId, P00113_A274MovimientoCosto, P00113_A121BodegaCodigo, P00113_A30ArticuloCodigo, P00113_A273MovimientoCantidad, P00113_A272MovimientoLinea
               }
               , new Object[] {
               P00114_A276InventarioExistencia
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P00118_A41ClinicaCodigo, P00118_A114TipoMICodigo, P00118_A267MovimientoId, P00118_A274MovimientoCosto, P00118_A121BodegaCodigo, P00118_A30ArticuloCodigo, P00118_A273MovimientoCantidad, P00118_A272MovimientoLinea
               }
               , new Object[] {
               P00119_A276InventarioExistencia
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
               }
               , new Object[] {
               P001115_A276InventarioExistencia, P001115_A277InventarioCosto
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A117TipoMIAfectaCosto ;
      private short A116TipoMIOperacion ;
      private short AV8TipoMIAfectaCosto ;
      private short AV11TipoMIOperacion ;
      private short A272MovimientoLinea ;
      private short AV20GXLvl26 ;
      private short AV22GXLvl49 ;
      private int A267MovimientoId ;
      private int GX_INS67 ;
      private decimal A274MovimientoCosto ;
      private decimal A273MovimientoCantidad ;
      private decimal A276InventarioExistencia ;
      private decimal AV12InventarioExistencia ;
      private decimal AV15InventarioCostoNuevo ;
      private decimal AV13InventarioCosto ;
      private decimal W276InventarioExistencia ;
      private decimal W277InventarioCosto ;
      private decimal A277InventarioCosto ;
      private decimal A60ArticuloCosto ;
      private decimal c276InventarioExistencia ;
      private decimal c277InventarioCosto ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private bool BRK113 ;
      private bool returnInSub ;
      private bool BRK116 ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private String A121BodegaCodigo ;
      private String A30ArticuloCodigo ;
      private String AV14ArticuloCodigo ;
      private String AV9BodegaCodigo ;
      private String W121BodegaCodigo ;
      private String W30ArticuloCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoMICodigo ;
      private int aP2_MovimientoId ;
      private IDataStoreProvider pr_default ;
      private String[] P00112_A41ClinicaCodigo ;
      private String[] P00112_A114TipoMICodigo ;
      private short[] P00112_A117TipoMIAfectaCosto ;
      private short[] P00112_A116TipoMIOperacion ;
      private String[] P00113_A41ClinicaCodigo ;
      private String[] P00113_A114TipoMICodigo ;
      private int[] P00113_A267MovimientoId ;
      private decimal[] P00113_A274MovimientoCosto ;
      private String[] P00113_A121BodegaCodigo ;
      private String[] P00113_A30ArticuloCodigo ;
      private decimal[] P00113_A273MovimientoCantidad ;
      private short[] P00113_A272MovimientoLinea ;
      private decimal[] P00114_A276InventarioExistencia ;
      private String[] P00118_A41ClinicaCodigo ;
      private String[] P00118_A114TipoMICodigo ;
      private int[] P00118_A267MovimientoId ;
      private decimal[] P00118_A274MovimientoCosto ;
      private String[] P00118_A121BodegaCodigo ;
      private String[] P00118_A30ArticuloCodigo ;
      private decimal[] P00118_A273MovimientoCantidad ;
      private short[] P00118_A272MovimientoLinea ;
      private decimal[] P00119_A276InventarioExistencia ;
      private decimal[] P001115_A276InventarioExistencia ;
      private decimal[] P001115_A277InventarioCosto ;
   }

   public class pactualizaexistencias__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new UpdateCursor(def[4])
         ,new UpdateCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00112 ;
          prmP00112 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP00113 ;
          prmP00113 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP00114 ;
          prmP00114 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP00115 ;
          prmP00115 = new Object[] {
          new Object[] {"@InventarioExistencia",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP00116 ;
          prmP00116 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@InventarioExistencia",SqlDbType.Decimal,17,2} ,
          new Object[] {"@InventarioCosto",SqlDbType.Decimal,17,2}
          } ;
          Object[] prmP00117 ;
          prmP00117 = new Object[] {
          new Object[] {"@MovimientoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00118 ;
          prmP00118 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP00119 ;
          prmP00119 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP001110 ;
          prmP001110 = new Object[] {
          new Object[] {"@InventarioExistencia",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP001111 ;
          prmP001111 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@InventarioExistencia",SqlDbType.Decimal,17,2} ,
          new Object[] {"@InventarioCosto",SqlDbType.Decimal,17,2}
          } ;
          Object[] prmP001112 ;
          prmP001112 = new Object[] {
          new Object[] {"@MovimientoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001113 ;
          prmP001113 = new Object[] {
          new Object[] {"@InventarioCosto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV14ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP001114 ;
          prmP001114 = new Object[] {
          new Object[] {"@ArticuloCosto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV14ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP001115 ;
          prmP001115 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV14ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00112", "SELECT [ClinicaCodigo], [TipoMICodigo], [TipoMIAfectaCosto], [TipoMIOperacion] FROM [TipoMovInventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] = @TipoMICodigo ORDER BY [ClinicaCodigo], [TipoMICodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00112,1,0,false,true )
             ,new CursorDef("P00113", "SELECT T1.[ClinicaCodigo], T1.[TipoMICodigo], T1.[MovimientoId], T1.[MovimientoCosto], T2.[BodegaCodigo], T1.[ArticuloCodigo], T1.[MovimientoCantidad], T1.[MovimientoLinea] FROM ([MovimientoInvDetalle] T1 WITH (UPDLOCK) INNER JOIN [MovimientoInv] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[TipoMICodigo] = T1.[TipoMICodigo] AND T2.[MovimientoId] = T1.[MovimientoId]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[TipoMICodigo] = @TipoMICodigo and T1.[MovimientoId] = @MovimientoId ORDER BY T1.[ClinicaCodigo], T1.[TipoMICodigo], T1.[MovimientoId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00113,1,0,true,false )
             ,new CursorDef("P00114", "SELECT [InventarioExistencia] FROM [Inventario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00114,1,0,true,false )
             ,new CursorDef("P00115", "UPDATE [Inventario] SET [InventarioExistencia]=@InventarioExistencia  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo AND [ArticuloCodigo] = @ArticuloCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00115)
             ,new CursorDef("P00116", "INSERT INTO [Inventario] ([ClinicaCodigo], [BodegaCodigo], [ArticuloCodigo], [InventarioExistencia], [InventarioCosto]) VALUES (@ClinicaCodigo, @BodegaCodigo, @ArticuloCodigo, @InventarioExistencia, @InventarioCosto)", GxErrorMask.GX_NOMASK,prmP00116)
             ,new CursorDef("P00117", "UPDATE [MovimientoInvDetalle] SET [MovimientoCantidad]=@MovimientoCantidad  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId AND [MovimientoLinea] = @MovimientoLinea", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00117)
             ,new CursorDef("P00118", "SELECT T1.[ClinicaCodigo], T1.[TipoMICodigo], T1.[MovimientoId], T1.[MovimientoCosto], T2.[BodegaCodigo], T1.[ArticuloCodigo], T1.[MovimientoCantidad], T1.[MovimientoLinea] FROM ([MovimientoInvDetalle] T1 WITH (UPDLOCK) INNER JOIN [MovimientoInv] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[TipoMICodigo] = T1.[TipoMICodigo] AND T2.[MovimientoId] = T1.[MovimientoId]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[TipoMICodigo] = @TipoMICodigo and T1.[MovimientoId] = @MovimientoId ORDER BY T1.[ClinicaCodigo], T1.[TipoMICodigo], T1.[MovimientoId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00118,1,0,true,false )
             ,new CursorDef("P00119", "SELECT [InventarioExistencia] FROM [Inventario] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo AND [ArticuloCodigo] = @ArticuloCodigo ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00119,1,0,true,false )
             ,new CursorDef("P001110", "UPDATE [Inventario] SET [InventarioExistencia]=@InventarioExistencia  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [BodegaCodigo] = @BodegaCodigo AND [ArticuloCodigo] = @ArticuloCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001110)
             ,new CursorDef("P001111", "INSERT INTO [Inventario] ([ClinicaCodigo], [BodegaCodigo], [ArticuloCodigo], [InventarioExistencia], [InventarioCosto]) VALUES (@ClinicaCodigo, @BodegaCodigo, @ArticuloCodigo, @InventarioExistencia, @InventarioCosto)", GxErrorMask.GX_NOMASK,prmP001111)
             ,new CursorDef("P001112", "UPDATE [MovimientoInvDetalle] SET [MovimientoCantidad]=@MovimientoCantidad  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoMICodigo] = @TipoMICodigo AND [MovimientoId] = @MovimientoId AND [MovimientoLinea] = @MovimientoLinea", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001112)
             ,new CursorDef("P001113", "UPDATE [Inventario] SET [InventarioCosto]=@InventarioCosto  WHERE [ClinicaCodigo] = @ClinicaCodigo and [ArticuloCodigo] = @AV14ArticuloCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001113)
             ,new CursorDef("P001114", "UPDATE [Articulo] SET [ArticuloCosto]=@ArticuloCosto  WHERE [ClinicaCodigo] = @ClinicaCodigo and [ArticuloCodigo] = @AV14ArticuloCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001114)
             ,new CursorDef("P001115", "SELECT SUM([InventarioExistencia]), SUM([InventarioCosto]) FROM [Inventario] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ArticuloCodigo] = @AV14ArticuloCodigo ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001115,1,0,true,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                break;
             case 2 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                break;
             case 7 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                break;
             case 13 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
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
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 3 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                break;
             case 5 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 8 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                break;
             case 10 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                break;
             case 11 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 12 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
