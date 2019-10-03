/*
               File: pRegistraMovInvDetalle
        Description: Registra Detalle del Movimiento de Inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:51.64
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
   public class pregistramovinvdetalle : GXProcedure
   {
      public pregistramovinvdetalle( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistramovinvdetalle( IGxContext context )
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
                           ref String aP3_ArticuloCodigo ,
                           ref decimal aP4_MovimientoCantidad ,
                           ref decimal aP5_MovimientoCosto )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.A267MovimientoId = aP2_MovimientoId;
         this.AV9ArticuloCodigo = aP3_ArticuloCodigo;
         this.AV10MovimientoCantidad = aP4_MovimientoCantidad;
         this.AV11MovimientoCosto = aP5_MovimientoCosto;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
         aP3_ArticuloCodigo=this.AV9ArticuloCodigo;
         aP4_MovimientoCantidad=this.AV10MovimientoCantidad;
         aP5_MovimientoCosto=this.AV11MovimientoCosto;
      }

      public decimal executeUdp( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoMICodigo ,
                                 ref int aP2_MovimientoId ,
                                 ref String aP3_ArticuloCodigo ,
                                 ref decimal aP4_MovimientoCantidad )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A114TipoMICodigo = aP1_TipoMICodigo;
         this.A267MovimientoId = aP2_MovimientoId;
         this.AV9ArticuloCodigo = aP3_ArticuloCodigo;
         this.AV10MovimientoCantidad = aP4_MovimientoCantidad;
         this.AV11MovimientoCosto = aP5_MovimientoCosto;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
         aP3_ArticuloCodigo=this.AV9ArticuloCodigo;
         aP4_MovimientoCantidad=this.AV10MovimientoCantidad;
         aP5_MovimientoCosto=this.AV11MovimientoCosto;
         return AV11MovimientoCosto ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoMICodigo ,
                                 ref int aP2_MovimientoId ,
                                 ref String aP3_ArticuloCodigo ,
                                 ref decimal aP4_MovimientoCantidad ,
                                 ref decimal aP5_MovimientoCosto )
      {
         pregistramovinvdetalle objpregistramovinvdetalle;
         objpregistramovinvdetalle = new pregistramovinvdetalle();
         objpregistramovinvdetalle.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistramovinvdetalle.A114TipoMICodigo = aP1_TipoMICodigo;
         objpregistramovinvdetalle.A267MovimientoId = aP2_MovimientoId;
         objpregistramovinvdetalle.AV9ArticuloCodigo = aP3_ArticuloCodigo;
         objpregistramovinvdetalle.AV10MovimientoCantidad = aP4_MovimientoCantidad;
         objpregistramovinvdetalle.AV11MovimientoCosto = aP5_MovimientoCosto;
         objpregistramovinvdetalle.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistramovinvdetalle);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoMICodigo=this.A114TipoMICodigo;
         aP2_MovimientoId=this.A267MovimientoId;
         aP3_ArticuloCodigo=this.AV9ArticuloCodigo;
         aP4_MovimientoCantidad=this.AV10MovimientoCantidad;
         aP5_MovimientoCosto=this.AV11MovimientoCosto;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistramovinvdetalle)stateInfo).executePrivate();
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
         AV14GXLvl4 = 0 ;
         /* Using cursor P000Z2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A272MovimientoLinea = P000Z2_A272MovimientoLinea[0] ;
            AV14GXLvl4 = 1 ;
            AV8MovimientoLinea = A272MovimientoLinea ;
            AV8MovimientoLinea = (short)(AV8MovimientoLinea+1) ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV14GXLvl4 == 0 )
         {
            AV8MovimientoLinea = 1 ;
         }
         /*
            INSERT RECORD ON TABLE MovimientoInvDetalle

         */
         A272MovimientoLinea = AV8MovimientoLinea ;
         A30ArticuloCodigo = AV9ArticuloCodigo ;
         A273MovimientoCantidad = AV10MovimientoCantidad ;
         A274MovimientoCosto = AV11MovimientoCosto ;
         /* Using cursor P000Z3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A114TipoMICodigo, A267MovimientoId, A272MovimientoLinea, A30ArticuloCodigo, A273MovimientoCantidad, A274MovimientoCosto});
         pr_default.close(1);
         if ( (pr_default.getStatus(1) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
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
         context.CommitDataStores("pRegistraMovInvDetalle");
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
         P000Z2_A41ClinicaCodigo = new String[] {""} ;
         P000Z2_A114TipoMICodigo = new String[] {""} ;
         P000Z2_A267MovimientoId = new int[1] ;
         P000Z2_A272MovimientoLinea = new short[1] ;
         A30ArticuloCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistramovinvdetalle__default(),
            new Object[][] {
                new Object[] {
               P000Z2_A41ClinicaCodigo, P000Z2_A114TipoMICodigo, P000Z2_A267MovimientoId, P000Z2_A272MovimientoLinea
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV14GXLvl4 ;
      private short A272MovimientoLinea ;
      private short AV8MovimientoLinea ;
      private int A267MovimientoId ;
      private int GX_INS66 ;
      private decimal AV10MovimientoCantidad ;
      private decimal AV11MovimientoCosto ;
      private decimal A273MovimientoCantidad ;
      private decimal A274MovimientoCosto ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private String AV9ArticuloCodigo ;
      private String A30ArticuloCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoMICodigo ;
      private int aP2_MovimientoId ;
      private String aP3_ArticuloCodigo ;
      private decimal aP4_MovimientoCantidad ;
      private decimal aP5_MovimientoCosto ;
      private IDataStoreProvider pr_default ;
      private String[] P000Z2_A41ClinicaCodigo ;
      private String[] P000Z2_A114TipoMICodigo ;
      private int[] P000Z2_A267MovimientoId ;
      private short[] P000Z2_A272MovimientoLinea ;
   }

   public class pregistramovinvdetalle__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000Z2 ;
          prmP000Z2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000Z3 ;
          prmP000Z3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovimientoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovimientoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovimientoCosto",SqlDbType.Decimal,17,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Z2", "SELECT TOP 1 [ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoLinea] FROM [MovimientoInvDetalle] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([TipoMICodigo] = @TipoMICodigo) AND ([MovimientoId] = @MovimientoId) ORDER BY [MovimientoLinea] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Z2,1,0,false,true )
             ,new CursorDef("P000Z3", "INSERT INTO [MovimientoInvDetalle] ([ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoLinea], [ArticuloCodigo], [MovimientoCantidad], [MovimientoCosto]) VALUES (@ClinicaCodigo, @TipoMICodigo, @MovimientoId, @MovimientoLinea, @ArticuloCodigo, @MovimientoCantidad, @MovimientoCosto)", GxErrorMask.GX_NOMASK,prmP000Z3)
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                break;
       }
    }

 }

}
