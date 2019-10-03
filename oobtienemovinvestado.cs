/*
               File: oObtieneMovInvEstado
        Description: Obtiene Estado del Movimiento de Inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:51.94
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
   public class oobtienemovinvestado : GXProcedure
   {
      public oobtienemovinvestado( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienemovinvestado( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_ClinicaCodigo ,
                           String aP1_TipoMICodigo ,
                           int aP2_MovimientoId ,
                           out short aP3_MovimientoEstado )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.A267MovimientoId = aP2_MovimientoId;
         this.AV8MovimientoEstado = 0 ;
         initialize();
         executePrivate();
         aP3_MovimientoEstado=this.AV8MovimientoEstado;
      }

      public short executeUdp( String aP0_ClinicaCodigo ,
                               String aP1_TipoMICodigo ,
                               int aP2_MovimientoId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.A267MovimientoId = aP2_MovimientoId;
         this.AV8MovimientoEstado = 0 ;
         initialize();
         executePrivate();
         aP3_MovimientoEstado=this.AV8MovimientoEstado;
         return AV8MovimientoEstado ;
      }

      public void executeSubmit( String aP0_ClinicaCodigo ,
                                 String aP1_TipoMICodigo ,
                                 int aP2_MovimientoId ,
                                 out short aP3_MovimientoEstado )
      {
         oobtienemovinvestado objoobtienemovinvestado;
         objoobtienemovinvestado = new oobtienemovinvestado();
         objoobtienemovinvestado.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienemovinvestado.A114TipoMICodigo = aP1_TipoMICodigo;
         objoobtienemovinvestado.A267MovimientoId = aP2_MovimientoId;
         objoobtienemovinvestado.AV8MovimientoEstado = 0 ;
         objoobtienemovinvestado.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienemovinvestado);
         aP3_MovimientoEstado=this.AV8MovimientoEstado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienemovinvestado)stateInfo).executePrivate();
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
         /* Using cursor P00102 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A271MovimientoEstado = P00102_A271MovimientoEstado[0] ;
            AV8MovimientoEstado = A271MovimientoEstado ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
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
         P00102_A41ClinicaCodigo = new String[] {""} ;
         P00102_A114TipoMICodigo = new String[] {""} ;
         P00102_A267MovimientoId = new int[1] ;
         P00102_A271MovimientoEstado = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienemovinvestado__default(),
            new Object[][] {
                new Object[] {
               P00102_A41ClinicaCodigo, P00102_A114TipoMICodigo, P00102_A267MovimientoId, P00102_A271MovimientoEstado
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8MovimientoEstado ;
      private short A271MovimientoEstado ;
      private int A267MovimientoId ;
      private String scmdbuf ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00102_A41ClinicaCodigo ;
      private String[] P00102_A114TipoMICodigo ;
      private int[] P00102_A267MovimientoId ;
      private short[] P00102_A271MovimientoEstado ;
      private short aP3_MovimientoEstado ;
   }

   public class oobtienemovinvestado__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00102 ;
          prmP00102 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00102", "SELECT [ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoEstado] FROM [MovimientoInv] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] = @TipoMICodigo and [MovimientoId] = @MovimientoId ORDER BY [ClinicaCodigo], [TipoMICodigo], [MovimientoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00102,1,0,false,true )
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
