/*
               File: pRegistraPartidaEnc
        Description: Registra Encabezado de Partida
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:54.88
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
   public class pregistrapartidaenc : GXProcedure
   {
      public pregistrapartidaenc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistrapartidaenc( IGxContext context )
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
                           ref DateTime aP3_PartidaFecha ,
                           ref String aP4_PartidaHora ,
                           ref String aP5_PartidaObs ,
                           ref short aP6_PartidaMayorizada ,
                           ref String aP7_PartidaReferencia ,
                           ref String aP8_UsuarioCodigo ,
                           ref short aP9_PartidaEstado )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV8PartidaFecha = aP3_PartidaFecha;
         this.AV9PartidaHora = aP4_PartidaHora;
         this.AV10PartidaObs = aP5_PartidaObs;
         this.AV12PartidaMayorizada = aP6_PartidaMayorizada;
         this.AV11PartidaReferencia = aP7_PartidaReferencia;
         this.AV14UsuarioCodigo = aP8_UsuarioCodigo;
         this.AV13PartidaEstado = aP9_PartidaEstado;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaFecha=this.AV8PartidaFecha;
         aP4_PartidaHora=this.AV9PartidaHora;
         aP5_PartidaObs=this.AV10PartidaObs;
         aP6_PartidaMayorizada=this.AV12PartidaMayorizada;
         aP7_PartidaReferencia=this.AV11PartidaReferencia;
         aP8_UsuarioCodigo=this.AV14UsuarioCodigo;
         aP9_PartidaEstado=this.AV13PartidaEstado;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref String aP1_TipoParCodigo ,
                               ref int aP2_PartidaId ,
                               ref DateTime aP3_PartidaFecha ,
                               ref String aP4_PartidaHora ,
                               ref String aP5_PartidaObs ,
                               ref short aP6_PartidaMayorizada ,
                               ref String aP7_PartidaReferencia ,
                               ref String aP8_UsuarioCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV8PartidaFecha = aP3_PartidaFecha;
         this.AV9PartidaHora = aP4_PartidaHora;
         this.AV10PartidaObs = aP5_PartidaObs;
         this.AV12PartidaMayorizada = aP6_PartidaMayorizada;
         this.AV11PartidaReferencia = aP7_PartidaReferencia;
         this.AV14UsuarioCodigo = aP8_UsuarioCodigo;
         this.AV13PartidaEstado = aP9_PartidaEstado;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaFecha=this.AV8PartidaFecha;
         aP4_PartidaHora=this.AV9PartidaHora;
         aP5_PartidaObs=this.AV10PartidaObs;
         aP6_PartidaMayorizada=this.AV12PartidaMayorizada;
         aP7_PartidaReferencia=this.AV11PartidaReferencia;
         aP8_UsuarioCodigo=this.AV14UsuarioCodigo;
         aP9_PartidaEstado=this.AV13PartidaEstado;
         return AV13PartidaEstado ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId ,
                                 ref DateTime aP3_PartidaFecha ,
                                 ref String aP4_PartidaHora ,
                                 ref String aP5_PartidaObs ,
                                 ref short aP6_PartidaMayorizada ,
                                 ref String aP7_PartidaReferencia ,
                                 ref String aP8_UsuarioCodigo ,
                                 ref short aP9_PartidaEstado )
      {
         pregistrapartidaenc objpregistrapartidaenc;
         objpregistrapartidaenc = new pregistrapartidaenc();
         objpregistrapartidaenc.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistrapartidaenc.A199TipoParCodigo = aP1_TipoParCodigo;
         objpregistrapartidaenc.A207PartidaId = aP2_PartidaId;
         objpregistrapartidaenc.AV8PartidaFecha = aP3_PartidaFecha;
         objpregistrapartidaenc.AV9PartidaHora = aP4_PartidaHora;
         objpregistrapartidaenc.AV10PartidaObs = aP5_PartidaObs;
         objpregistrapartidaenc.AV12PartidaMayorizada = aP6_PartidaMayorizada;
         objpregistrapartidaenc.AV11PartidaReferencia = aP7_PartidaReferencia;
         objpregistrapartidaenc.AV14UsuarioCodigo = aP8_UsuarioCodigo;
         objpregistrapartidaenc.AV13PartidaEstado = aP9_PartidaEstado;
         objpregistrapartidaenc.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistrapartidaenc);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaFecha=this.AV8PartidaFecha;
         aP4_PartidaHora=this.AV9PartidaHora;
         aP5_PartidaObs=this.AV10PartidaObs;
         aP6_PartidaMayorizada=this.AV12PartidaMayorizada;
         aP7_PartidaReferencia=this.AV11PartidaReferencia;
         aP8_UsuarioCodigo=this.AV14UsuarioCodigo;
         aP9_PartidaEstado=this.AV13PartidaEstado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistrapartidaenc)stateInfo).executePrivate();
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
         /*
            INSERT RECORD ON TABLE PartidaEnc

         */
         A208PartidaFecha = AV8PartidaFecha ;
         A209PartidaHora = AV9PartidaHora ;
         A210PartidaObs = AV10PartidaObs ;
         A211PartidaMayorizada = AV12PartidaMayorizada ;
         A212PartidaReferencia = AV11PartidaReferencia ;
         A4UsuarioCodigo = AV14UsuarioCodigo ;
         A289PartidaEstado = AV13PartidaEstado ;
         /* Using cursor P00142 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, A208PartidaFecha, A209PartidaHora, A210PartidaObs, A211PartidaMayorizada, A212PartidaReferencia, A4UsuarioCodigo, A289PartidaEstado});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
            /* Optimized UPDATE. */
            /* Using cursor P00143 */
            pr_default.execute(1, new Object[] {AV10PartidaObs, AV11PartidaReferencia, A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            pr_default.close(1);
            /* End optimized UPDATE. */
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pRegistraPartidaEnc");
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
         A208PartidaFecha = DateTime.MinValue ;
         A209PartidaHora = "" ;
         A210PartidaObs = "" ;
         A212PartidaReferencia = "" ;
         A4UsuarioCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistrapartidaenc__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV12PartidaMayorizada ;
      private short AV13PartidaEstado ;
      private short A211PartidaMayorizada ;
      private short A289PartidaEstado ;
      private int A207PartidaId ;
      private int GX_INS53 ;
      private String AV9PartidaHora ;
      private String A209PartidaHora ;
      private String Gx_emsg ;
      private DateTime AV8PartidaFecha ;
      private DateTime A208PartidaFecha ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String AV10PartidaObs ;
      private String AV11PartidaReferencia ;
      private String AV14UsuarioCodigo ;
      private String A210PartidaObs ;
      private String A212PartidaReferencia ;
      private String A4UsuarioCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_PartidaId ;
      private DateTime aP3_PartidaFecha ;
      private String aP4_PartidaHora ;
      private String aP5_PartidaObs ;
      private short aP6_PartidaMayorizada ;
      private String aP7_PartidaReferencia ;
      private String aP8_UsuarioCodigo ;
      private short aP9_PartidaEstado ;
      private IDataStoreProvider pr_default ;
   }

   public class pregistrapartidaenc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00142 ;
          prmP00142 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PartidaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@PartidaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@PartidaMayorizada",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PartidaReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaEstado",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmP00143 ;
          prmP00143 = new Object[] {
          new Object[] {"@PartidaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@PartidaReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00142", "INSERT INTO [PartidaEnc] ([ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaFecha], [PartidaHora], [PartidaObs], [PartidaMayorizada], [PartidaReferencia], [UsuarioCodigo], [PartidaEstado]) VALUES (@ClinicaCodigo, @TipoParCodigo, @PartidaId, @PartidaFecha, @PartidaHora, @PartidaObs, @PartidaMayorizada, @PartidaReferencia, @UsuarioCodigo, @PartidaEstado)", GxErrorMask.GX_NOMASK,prmP00142)
             ,new CursorDef("P00143", "UPDATE [PartidaEnc] SET [PartidaObs]=@PartidaObs, [PartidaReferencia]=@PartidaReferencia  WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @PartidaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00143)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
       }
    }

 }

}
