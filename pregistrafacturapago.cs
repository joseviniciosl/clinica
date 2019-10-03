/*
               File: pRegistraFacturaPago
        Description: Registra Pago de Factura de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:46.76
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
   public class pregistrafacturapago : GXProcedure
   {
      public pregistrafacturapago( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistrafacturapago( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_FacturaId ,
                           ref String aP2_FacturaPDetalle ,
                           ref String aP3_FacturaPDocto ,
                           ref decimal aP4_FacturaPMonto ,
                           ref String aP5_FormaPagoCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A185FacturaId = aP1_FacturaId;
         this.AV9FacturaPDetalle = aP2_FacturaPDetalle;
         this.AV10FacturaPDocto = aP3_FacturaPDocto;
         this.AV11FacturaPMonto = aP4_FacturaPMonto;
         this.AV12FormaPagoCodigo = aP5_FormaPagoCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_FacturaPDetalle=this.AV9FacturaPDetalle;
         aP3_FacturaPDocto=this.AV10FacturaPDocto;
         aP4_FacturaPMonto=this.AV11FacturaPMonto;
         aP5_FormaPagoCodigo=this.AV12FormaPagoCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref int aP1_FacturaId ,
                                ref String aP2_FacturaPDetalle ,
                                ref String aP3_FacturaPDocto ,
                                ref decimal aP4_FacturaPMonto )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A185FacturaId = aP1_FacturaId;
         this.AV9FacturaPDetalle = aP2_FacturaPDetalle;
         this.AV10FacturaPDocto = aP3_FacturaPDocto;
         this.AV11FacturaPMonto = aP4_FacturaPMonto;
         this.AV12FormaPagoCodigo = aP5_FormaPagoCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_FacturaPDetalle=this.AV9FacturaPDetalle;
         aP3_FacturaPDocto=this.AV10FacturaPDocto;
         aP4_FacturaPMonto=this.AV11FacturaPMonto;
         aP5_FormaPagoCodigo=this.AV12FormaPagoCodigo;
         return AV12FormaPagoCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_FacturaId ,
                                 ref String aP2_FacturaPDetalle ,
                                 ref String aP3_FacturaPDocto ,
                                 ref decimal aP4_FacturaPMonto ,
                                 ref String aP5_FormaPagoCodigo )
      {
         pregistrafacturapago objpregistrafacturapago;
         objpregistrafacturapago = new pregistrafacturapago();
         objpregistrafacturapago.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistrafacturapago.A185FacturaId = aP1_FacturaId;
         objpregistrafacturapago.AV9FacturaPDetalle = aP2_FacturaPDetalle;
         objpregistrafacturapago.AV10FacturaPDocto = aP3_FacturaPDocto;
         objpregistrafacturapago.AV11FacturaPMonto = aP4_FacturaPMonto;
         objpregistrafacturapago.AV12FormaPagoCodigo = aP5_FormaPagoCodigo;
         objpregistrafacturapago.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistrafacturapago);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         aP2_FacturaPDetalle=this.AV9FacturaPDetalle;
         aP3_FacturaPDocto=this.AV10FacturaPDocto;
         aP4_FacturaPMonto=this.AV11FacturaPMonto;
         aP5_FormaPagoCodigo=this.AV12FormaPagoCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistrafacturapago)stateInfo).executePrivate();
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
         AV15GXLvl3 = 0 ;
         /* Using cursor P000R2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A185FacturaId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A260FacturaPId = P000R2_A260FacturaPId[0] ;
            AV15GXLvl3 = 1 ;
            AV8FacturaPId = A260FacturaPId ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV15GXLvl3 == 0 )
         {
            AV8FacturaPId = 0 ;
         }
         AV8FacturaPId = (int)(AV8FacturaPId+1) ;
         /*
            INSERT RECORD ON TABLE FacturaPago

         */
         A260FacturaPId = AV8FacturaPId ;
         A65FormaPagoCodigo = AV12FormaPagoCodigo ;
         A261FacturaPMonto = AV11FacturaPMonto ;
         A262FacturaPDocto = AV10FacturaPDocto ;
         A264FacturaPDetalle = AV9FacturaPDetalle ;
         /* Using cursor P000R3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A185FacturaId, A260FacturaPId, A65FormaPagoCodigo, A261FacturaPMonto, A262FacturaPDocto, A264FacturaPDetalle});
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
         context.CommitDataStores("pRegistraFacturaPago");
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
         P000R2_A41ClinicaCodigo = new String[] {""} ;
         P000R2_A185FacturaId = new int[1] ;
         P000R2_A260FacturaPId = new int[1] ;
         A65FormaPagoCodigo = "" ;
         A262FacturaPDocto = "" ;
         A264FacturaPDetalle = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistrafacturapago__default(),
            new Object[][] {
                new Object[] {
               P000R2_A41ClinicaCodigo, P000R2_A185FacturaId, P000R2_A260FacturaPId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV15GXLvl3 ;
      private int A185FacturaId ;
      private int A260FacturaPId ;
      private int AV8FacturaPId ;
      private int GX_INS63 ;
      private decimal AV11FacturaPMonto ;
      private decimal A261FacturaPMonto ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A41ClinicaCodigo ;
      private String AV9FacturaPDetalle ;
      private String AV10FacturaPDocto ;
      private String AV12FormaPagoCodigo ;
      private String A65FormaPagoCodigo ;
      private String A262FacturaPDocto ;
      private String A264FacturaPDetalle ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_FacturaId ;
      private String aP2_FacturaPDetalle ;
      private String aP3_FacturaPDocto ;
      private decimal aP4_FacturaPMonto ;
      private String aP5_FormaPagoCodigo ;
      private IDataStoreProvider pr_default ;
      private String[] P000R2_A41ClinicaCodigo ;
      private int[] P000R2_A185FacturaId ;
      private int[] P000R2_A260FacturaPId ;
   }

   public class pregistrafacturapago__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000R2 ;
          prmP000R2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000R3 ;
          prmP000R3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaPId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaPMonto",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaPDocto",SqlDbType.VarChar,60,0} ,
          new Object[] {"@FacturaPDetalle",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000R2", "SELECT TOP 1 [ClinicaCodigo], [FacturaId], [FacturaPId] FROM [FacturaPago] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([FacturaId] = @FacturaId) ORDER BY [FacturaPId] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000R2,1,0,false,true )
             ,new CursorDef("P000R3", "INSERT INTO [FacturaPago] ([ClinicaCodigo], [FacturaId], [FacturaPId], [FormaPagoCodigo], [FacturaPMonto], [FacturaPDocto], [FacturaPDetalle]) VALUES (@ClinicaCodigo, @FacturaId, @FacturaPId, @FormaPagoCodigo, @FacturaPMonto, @FacturaPDocto, @FacturaPDetalle)", GxErrorMask.GX_NOMASK,prmP000R3)
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
