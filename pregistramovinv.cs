/*
               File: pRegistraMovInv
        Description: Registra Movimiento de Inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:51.22
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
   public class pregistramovinv : GXProcedure
   {
      public pregistramovinv( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistramovinv( IGxContext context )
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
                           ref int aP2_MovimientoId ,
                           ref DateTime aP3_MovimientoFecha ,
                           ref String aP4_MovimientoHora ,
                           ref String aP5_BodegaCodigo ,
                           ref String aP6_MovimientoReferencia ,
                           ref String aP7_MovimientoObs ,
                           ref String aP8_UsuarioCodigo ,
                           ref short aP9_MovimientoEstado )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.A267MovimientoId = aP2_MovimientoId;
         this.AV8MovimientoFecha = aP3_MovimientoFecha;
         this.AV9MovimientoHora = aP4_MovimientoHora;
         this.AV10BodegaCodigo = aP5_BodegaCodigo;
         this.AV11MovimientoReferencia = aP6_MovimientoReferencia;
         this.AV12MovimientoObs = aP7_MovimientoObs;
         this.AV13UsuarioCodigo = aP8_UsuarioCodigo;
         this.AV14MovimientoEstado = aP9_MovimientoEstado;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
         aP3_MovimientoFecha=this.AV8MovimientoFecha;
         aP4_MovimientoHora=this.AV9MovimientoHora;
         aP5_BodegaCodigo=this.AV10BodegaCodigo;
         aP6_MovimientoReferencia=this.AV11MovimientoReferencia;
         aP7_MovimientoObs=this.AV12MovimientoObs;
         aP8_UsuarioCodigo=this.AV13UsuarioCodigo;
         aP9_MovimientoEstado=this.AV14MovimientoEstado;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref String aP1_TipoMICodigo ,
                               ref int aP2_MovimientoId ,
                               ref DateTime aP3_MovimientoFecha ,
                               ref String aP4_MovimientoHora ,
                               ref String aP5_BodegaCodigo ,
                               ref String aP6_MovimientoReferencia ,
                               ref String aP7_MovimientoObs ,
                               ref String aP8_UsuarioCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.A267MovimientoId = aP2_MovimientoId;
         this.AV8MovimientoFecha = aP3_MovimientoFecha;
         this.AV9MovimientoHora = aP4_MovimientoHora;
         this.AV10BodegaCodigo = aP5_BodegaCodigo;
         this.AV11MovimientoReferencia = aP6_MovimientoReferencia;
         this.AV12MovimientoObs = aP7_MovimientoObs;
         this.AV13UsuarioCodigo = aP8_UsuarioCodigo;
         this.AV14MovimientoEstado = aP9_MovimientoEstado;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
         aP3_MovimientoFecha=this.AV8MovimientoFecha;
         aP4_MovimientoHora=this.AV9MovimientoHora;
         aP5_BodegaCodigo=this.AV10BodegaCodigo;
         aP6_MovimientoReferencia=this.AV11MovimientoReferencia;
         aP7_MovimientoObs=this.AV12MovimientoObs;
         aP8_UsuarioCodigo=this.AV13UsuarioCodigo;
         aP9_MovimientoEstado=this.AV14MovimientoEstado;
         return AV14MovimientoEstado ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoMICodigo ,
                                 ref int aP2_MovimientoId ,
                                 ref DateTime aP3_MovimientoFecha ,
                                 ref String aP4_MovimientoHora ,
                                 ref String aP5_BodegaCodigo ,
                                 ref String aP6_MovimientoReferencia ,
                                 ref String aP7_MovimientoObs ,
                                 ref String aP8_UsuarioCodigo ,
                                 ref short aP9_MovimientoEstado )
      {
         pregistramovinv objpregistramovinv;
         objpregistramovinv = new pregistramovinv();
         objpregistramovinv.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistramovinv.A114TipoMICodigo = aP1_TipoMICodigo;
         objpregistramovinv.A267MovimientoId = aP2_MovimientoId;
         objpregistramovinv.AV8MovimientoFecha = aP3_MovimientoFecha;
         objpregistramovinv.AV9MovimientoHora = aP4_MovimientoHora;
         objpregistramovinv.AV10BodegaCodigo = aP5_BodegaCodigo;
         objpregistramovinv.AV11MovimientoReferencia = aP6_MovimientoReferencia;
         objpregistramovinv.AV12MovimientoObs = aP7_MovimientoObs;
         objpregistramovinv.AV13UsuarioCodigo = aP8_UsuarioCodigo;
         objpregistramovinv.AV14MovimientoEstado = aP9_MovimientoEstado;
         objpregistramovinv.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistramovinv);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
         aP3_MovimientoFecha=this.AV8MovimientoFecha;
         aP4_MovimientoHora=this.AV9MovimientoHora;
         aP5_BodegaCodigo=this.AV10BodegaCodigo;
         aP6_MovimientoReferencia=this.AV11MovimientoReferencia;
         aP7_MovimientoObs=this.AV12MovimientoObs;
         aP8_UsuarioCodigo=this.AV13UsuarioCodigo;
         aP9_MovimientoEstado=this.AV14MovimientoEstado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistramovinv)stateInfo).executePrivate();
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
            INSERT RECORD ON TABLE MovimientoInv

         */
         A268MovimientoFecha = AV8MovimientoFecha ;
         A121BodegaCodigo = AV10BodegaCodigo ;
         A269MovimientoReferencia = AV11MovimientoReferencia ;
         A270MovimientoObs = AV12MovimientoObs ;
         A271MovimientoEstado = AV14MovimientoEstado ;
         A4UsuarioCodigo = AV13UsuarioCodigo ;
         A288MovimientoHora = AV9MovimientoHora ;
         /* Using cursor P000Y2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A268MovimientoFecha, A121BodegaCodigo, A269MovimientoReferencia, A270MovimientoObs, A271MovimientoEstado, A4UsuarioCodigo, A288MovimientoHora});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
            /* Optimized UPDATE. */
            /* Using cursor P000Y3 */
            pr_default.execute(1, new Object[] {AV11MovimientoReferencia, AV12MovimientoObs, AV14MovimientoEstado, A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
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
         context.CommitDataStores("pRegistraMovInv");
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
         A268MovimientoFecha = DateTime.MinValue ;
         A121BodegaCodigo = "" ;
         A269MovimientoReferencia = "" ;
         A270MovimientoObs = "" ;
         A4UsuarioCodigo = "" ;
         A288MovimientoHora = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistramovinv__default(),
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

      private short AV14MovimientoEstado ;
      private short A271MovimientoEstado ;
      private int A267MovimientoId ;
      private int GX_INS65 ;
      private String AV9MovimientoHora ;
      private String A288MovimientoHora ;
      private String Gx_emsg ;
      private DateTime AV8MovimientoFecha ;
      private DateTime A268MovimientoFecha ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private String AV10BodegaCodigo ;
      private String AV11MovimientoReferencia ;
      private String AV12MovimientoObs ;
      private String AV13UsuarioCodigo ;
      private String A121BodegaCodigo ;
      private String A269MovimientoReferencia ;
      private String A270MovimientoObs ;
      private String A4UsuarioCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoMICodigo ;
      private int aP2_MovimientoId ;
      private DateTime aP3_MovimientoFecha ;
      private String aP4_MovimientoHora ;
      private String aP5_BodegaCodigo ;
      private String aP6_MovimientoReferencia ;
      private String aP7_MovimientoObs ;
      private String aP8_UsuarioCodigo ;
      private short aP9_MovimientoEstado ;
      private IDataStoreProvider pr_default ;
   }

   public class pregistramovinv__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000Y2 ;
          prmP000Y2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@MovimientoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovimientoEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoHora",SqlDbType.Char,8,0}
          } ;
          Object[] prmP000Y3 ;
          prmP000Y3 = new Object[] {
          new Object[] {"@MovimientoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@MovimientoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovimientoEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Y2", "INSERT INTO [MovimientoInv] ([ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoFecha], [BodegaCodigo], [MovimientoReferencia], [MovimientoObs], [MovimientoEstado], [UsuarioCodigo], [MovimientoHora]) VALUES (@ClinicaCodigo, @TipoMICodigo, @MovimientoId, @MovimientoFecha, @BodegaCodigo, @MovimientoReferencia, @MovimientoObs, @MovimientoEstado, @UsuarioCodigo, @MovimientoHora)", GxErrorMask.GX_NOMASK,prmP000Y2)
             ,new CursorDef("P000Y3", "UPDATE [MovimientoInv] SET [MovimientoReferencia]=@MovimientoReferencia, [MovimientoObs]=@MovimientoObs, [MovimientoEstado]=@MovimientoEstado  WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoMICodigo] = @TipoMICodigo and [MovimientoId] = @MovimientoId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000Y3)
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
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                break;
       }
    }

 }

}
