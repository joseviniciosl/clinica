/*
               File: oObtieneCorrelativoSAT
        Description: Obtiene correlativo de facturas
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:45.35
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
   public class oobtienecorrelativosat : GXProcedure
   {
      public oobtienecorrelativosat( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienecorrelativosat( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_CajaCodigo ,
                           ref int aP2_ResolucionSiguiente ,
                           ref String aP3_ResolucionSerie ,
                           ref short aP4_Flag )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A132CajaCodigo = aP1_CajaCodigo;
         this.AV9ResolucionSiguiente = aP2_ResolucionSiguiente;
         this.AV11ResolucionSerie = aP3_ResolucionSerie;
         this.AV13Flag = aP4_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CajaCodigo=this.A132CajaCodigo;
         aP2_ResolucionSiguiente=this.AV9ResolucionSiguiente;
         aP3_ResolucionSerie=this.AV11ResolucionSerie;
         aP4_Flag=this.AV13Flag;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref String aP1_CajaCodigo ,
                               ref int aP2_ResolucionSiguiente ,
                               ref String aP3_ResolucionSerie )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A132CajaCodigo = aP1_CajaCodigo;
         this.AV9ResolucionSiguiente = aP2_ResolucionSiguiente;
         this.AV11ResolucionSerie = aP3_ResolucionSerie;
         this.AV13Flag = aP4_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CajaCodigo=this.A132CajaCodigo;
         aP2_ResolucionSiguiente=this.AV9ResolucionSiguiente;
         aP3_ResolucionSerie=this.AV11ResolucionSerie;
         aP4_Flag=this.AV13Flag;
         return AV13Flag ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_CajaCodigo ,
                                 ref int aP2_ResolucionSiguiente ,
                                 ref String aP3_ResolucionSerie ,
                                 ref short aP4_Flag )
      {
         oobtienecorrelativosat objoobtienecorrelativosat;
         objoobtienecorrelativosat = new oobtienecorrelativosat();
         objoobtienecorrelativosat.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienecorrelativosat.A132CajaCodigo = aP1_CajaCodigo;
         objoobtienecorrelativosat.AV9ResolucionSiguiente = aP2_ResolucionSiguiente;
         objoobtienecorrelativosat.AV11ResolucionSerie = aP3_ResolucionSerie;
         objoobtienecorrelativosat.AV13Flag = aP4_Flag;
         objoobtienecorrelativosat.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienecorrelativosat);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CajaCodigo=this.A132CajaCodigo;
         aP2_ResolucionSiguiente=this.AV9ResolucionSiguiente;
         aP3_ResolucionSerie=this.AV11ResolucionSerie;
         aP4_Flag=this.AV13Flag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienecorrelativosat)stateInfo).executePrivate();
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
         AV13Flag = 1 ;
         /* Using cursor P000P2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A132CajaCodigo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A134CajaEstado = P000P2_A134CajaEstado[0] ;
            A252ResolucionCodigo = P000P2_A252ResolucionCodigo[0] ;
            AV12ResolucionCodigo = A252ResolucionCodigo ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         /* Using cursor P000P3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, AV12ResolucionCodigo});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A252ResolucionCodigo = P000P3_A252ResolucionCodigo[0] ;
            A254ResolucionVencimiento = P000P3_A254ResolucionVencimiento[0] ;
            A257ResolucionFinal = P000P3_A257ResolucionFinal[0] ;
            A258ResolucionSiguiente = P000P3_A258ResolucionSiguiente[0] ;
            A255ResolucionSerie = P000P3_A255ResolucionSerie[0] ;
            if ( Gx_date > A254ResolucionVencimiento )
            {
               AV13Flag = 0 ;
               GX_msglist.addItem("Fecha de resolución SAT está vencida.");
            }
            else
            {
               if ( A258ResolucionSiguiente > A257ResolucionFinal )
               {
                  AV13Flag = 0 ;
                  GX_msglist.addItem("El rango autorizado de la resolución SAT está consumida en su totalidad.");
               }
               else
               {
                  AV11ResolucionSerie = A255ResolucionSerie ;
                  AV9ResolucionSiguiente = A258ResolucionSiguiente ;
                  A258ResolucionSiguiente = (int)(A258ResolucionSiguiente+1) ;
               }
            }
            /* Using cursor P000P4 */
            pr_default.execute(2, new Object[] {A258ResolucionSiguiente, A41ClinicaCodigo, A252ResolucionCodigo});
            pr_default.close(2);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("oObtieneCorrelativoSAT");
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
         P000P2_A41ClinicaCodigo = new String[] {""} ;
         P000P2_A132CajaCodigo = new String[] {""} ;
         P000P2_A134CajaEstado = new short[1] ;
         P000P2_A252ResolucionCodigo = new String[] {""} ;
         A252ResolucionCodigo = "" ;
         AV12ResolucionCodigo = "" ;
         P000P3_A41ClinicaCodigo = new String[] {""} ;
         P000P3_A252ResolucionCodigo = new String[] {""} ;
         P000P3_A254ResolucionVencimiento = new DateTime[] {DateTime.MinValue} ;
         P000P3_A257ResolucionFinal = new int[1] ;
         P000P3_A258ResolucionSiguiente = new int[1] ;
         P000P3_A255ResolucionSerie = new String[] {""} ;
         A254ResolucionVencimiento = DateTime.MinValue ;
         A255ResolucionSerie = "" ;
         Gx_date = DateTime.MinValue ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienecorrelativosat__default(),
            new Object[][] {
                new Object[] {
               P000P2_A41ClinicaCodigo, P000P2_A132CajaCodigo, P000P2_A134CajaEstado, P000P2_A252ResolucionCodigo
               }
               , new Object[] {
               P000P3_A41ClinicaCodigo, P000P3_A252ResolucionCodigo, P000P3_A254ResolucionVencimiento, P000P3_A257ResolucionFinal, P000P3_A258ResolucionSiguiente, P000P3_A255ResolucionSerie
               }
               , new Object[] {
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV13Flag ;
      private short A134CajaEstado ;
      private int AV9ResolucionSiguiente ;
      private int A257ResolucionFinal ;
      private int A258ResolucionSiguiente ;
      private String scmdbuf ;
      private DateTime A254ResolucionVencimiento ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String A132CajaCodigo ;
      private String AV11ResolucionSerie ;
      private String A252ResolucionCodigo ;
      private String AV12ResolucionCodigo ;
      private String A255ResolucionSerie ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_CajaCodigo ;
      private int aP2_ResolucionSiguiente ;
      private String aP3_ResolucionSerie ;
      private short aP4_Flag ;
      private IDataStoreProvider pr_default ;
      private String[] P000P2_A41ClinicaCodigo ;
      private String[] P000P2_A132CajaCodigo ;
      private short[] P000P2_A134CajaEstado ;
      private String[] P000P2_A252ResolucionCodigo ;
      private String[] P000P3_A41ClinicaCodigo ;
      private String[] P000P3_A252ResolucionCodigo ;
      private DateTime[] P000P3_A254ResolucionVencimiento ;
      private int[] P000P3_A257ResolucionFinal ;
      private int[] P000P3_A258ResolucionSiguiente ;
      private String[] P000P3_A255ResolucionSerie ;
   }

   public class oobtienecorrelativosat__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000P2 ;
          prmP000P2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP000P3 ;
          prmP000P3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV12ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmP000P4 ;
          prmP000P4 = new Object[] {
          new Object[] {"@ResolucionSiguiente",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ResolucionCodigo",SqlDbType.VarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000P2", "SELECT [ClinicaCodigo], [CajaCodigo], [CajaEstado], [ResolucionCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] = @CajaCodigo ORDER BY [ClinicaCodigo], [CajaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P2,1,0,false,true )
             ,new CursorDef("P000P3", "SELECT [ClinicaCodigo], [ResolucionCodigo], [ResolucionVencimiento], [ResolucionFinal], [ResolucionSiguiente], [ResolucionSerie] FROM [ResolucionSAT] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ResolucionCodigo] = @AV12ResolucionCodigo ORDER BY [ClinicaCodigo], [ResolucionCodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P3,1,0,true,true )
             ,new CursorDef("P000P4", "UPDATE [ResolucionSAT] SET [ResolucionSiguiente]=@ResolucionSiguiente  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ResolucionCodigo] = @ResolucionCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000P4)
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
       }
    }

 }

}
