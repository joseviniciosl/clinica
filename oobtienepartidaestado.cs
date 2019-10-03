/*
               File: oObtienePartidaEstado
        Description: Obtiene Estado de la Partida
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:55.65
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
   public class oobtienepartidaestado : GXProcedure
   {
      public oobtienepartidaestado( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienepartidaestado( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_TipoParCodigo ,
                           ref int aP2_PartidaId ,
                           ref short aP3_PartidaEstado ,
                           ref short aP4_PartidaMayorizada ,
                           ref short aP5_Flag )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV8PartidaEstado = aP3_PartidaEstado;
         this.AV9PartidaMayorizada = aP4_PartidaMayorizada;
         this.AV10Flag = aP5_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaEstado=this.AV8PartidaEstado;
         aP4_PartidaMayorizada=this.AV9PartidaMayorizada;
         aP5_Flag=this.AV10Flag;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref String aP1_TipoParCodigo ,
                               ref int aP2_PartidaId ,
                               ref short aP3_PartidaEstado ,
                               ref short aP4_PartidaMayorizada )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV8PartidaEstado = aP3_PartidaEstado;
         this.AV9PartidaMayorizada = aP4_PartidaMayorizada;
         this.AV10Flag = aP5_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaEstado=this.AV8PartidaEstado;
         aP4_PartidaMayorizada=this.AV9PartidaMayorizada;
         aP5_Flag=this.AV10Flag;
         return AV10Flag ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId ,
                                 ref short aP3_PartidaEstado ,
                                 ref short aP4_PartidaMayorizada ,
                                 ref short aP5_Flag )
      {
         oobtienepartidaestado objoobtienepartidaestado;
         objoobtienepartidaestado = new oobtienepartidaestado();
         objoobtienepartidaestado.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienepartidaestado.A199TipoParCodigo = aP1_TipoParCodigo;
         objoobtienepartidaestado.A207PartidaId = aP2_PartidaId;
         objoobtienepartidaestado.AV8PartidaEstado = aP3_PartidaEstado;
         objoobtienepartidaestado.AV9PartidaMayorizada = aP4_PartidaMayorizada;
         objoobtienepartidaestado.AV10Flag = aP5_Flag;
         objoobtienepartidaestado.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienepartidaestado);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaEstado=this.AV8PartidaEstado;
         aP4_PartidaMayorizada=this.AV9PartidaMayorizada;
         aP5_Flag=this.AV10Flag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienepartidaestado)stateInfo).executePrivate();
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
         if ( AV10Flag == 1 )
         {
            /* Using cursor P00162 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A289PartidaEstado = P00162_A289PartidaEstado[0] ;
               A211PartidaMayorizada = P00162_A211PartidaMayorizada[0] ;
               AV8PartidaEstado = A289PartidaEstado ;
               AV9PartidaMayorizada = A211PartidaMayorizada ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
         }
         else
         {
            /* Optimized UPDATE. */
            /* Using cursor P00163 */
            pr_default.execute(1, new Object[] {AV8PartidaEstado, A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            pr_default.close(1);
            /* End optimized UPDATE. */
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("oObtienePartidaEstado");
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
         P00162_A41ClinicaCodigo = new String[] {""} ;
         P00162_A199TipoParCodigo = new String[] {""} ;
         P00162_A207PartidaId = new int[1] ;
         P00162_A289PartidaEstado = new short[1] ;
         P00162_A211PartidaMayorizada = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienepartidaestado__default(),
            new Object[][] {
                new Object[] {
               P00162_A41ClinicaCodigo, P00162_A199TipoParCodigo, P00162_A207PartidaId, P00162_A289PartidaEstado, P00162_A211PartidaMayorizada
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV8PartidaEstado ;
      private short AV9PartidaMayorizada ;
      private short AV10Flag ;
      private short A289PartidaEstado ;
      private short A211PartidaMayorizada ;
      private int A207PartidaId ;
      private String scmdbuf ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_PartidaId ;
      private short aP3_PartidaEstado ;
      private short aP4_PartidaMayorizada ;
      private short aP5_Flag ;
      private IDataStoreProvider pr_default ;
      private String[] P00162_A41ClinicaCodigo ;
      private String[] P00162_A199TipoParCodigo ;
      private int[] P00162_A207PartidaId ;
      private short[] P00162_A289PartidaEstado ;
      private short[] P00162_A211PartidaMayorizada ;
   }

   public class oobtienepartidaestado__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00162 ;
          prmP00162 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP00163 ;
          prmP00163 = new Object[] {
          new Object[] {"@PartidaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00162", "SELECT [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaEstado], [PartidaMayorizada] FROM [PartidaEnc] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @PartidaId ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00162,1,0,false,true )
             ,new CursorDef("P00163", "UPDATE [PartidaEnc] SET [PartidaEstado]=@PartidaEstado  WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @PartidaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00163)
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
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
