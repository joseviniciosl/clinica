/*
               File: pRegistraPartidaDet
        Description: Registra Detalle de Partida
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:55.30
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
   public class pregistrapartidadet : GXProcedure
   {
      public pregistrapartidadet( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistrapartidadet( IGxContext context )
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
                           ref decimal aP3_PartidaDebe ,
                           ref decimal aP4_PartidaHaber ,
                           ref String aP5_CtaContableCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV11PartidaDebe = aP3_PartidaDebe;
         this.AV12PartidaHaber = aP4_PartidaHaber;
         this.AV14CtaContableCodigo = aP5_CtaContableCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaDebe=this.AV11PartidaDebe;
         aP4_PartidaHaber=this.AV12PartidaHaber;
         aP5_CtaContableCodigo=this.AV14CtaContableCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref String aP1_TipoParCodigo ,
                                ref int aP2_PartidaId ,
                                ref decimal aP3_PartidaDebe ,
                                ref decimal aP4_PartidaHaber )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV11PartidaDebe = aP3_PartidaDebe;
         this.AV12PartidaHaber = aP4_PartidaHaber;
         this.AV14CtaContableCodigo = aP5_CtaContableCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaDebe=this.AV11PartidaDebe;
         aP4_PartidaHaber=this.AV12PartidaHaber;
         aP5_CtaContableCodigo=this.AV14CtaContableCodigo;
         return AV14CtaContableCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId ,
                                 ref decimal aP3_PartidaDebe ,
                                 ref decimal aP4_PartidaHaber ,
                                 ref String aP5_CtaContableCodigo )
      {
         pregistrapartidadet objpregistrapartidadet;
         objpregistrapartidadet = new pregistrapartidadet();
         objpregistrapartidadet.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistrapartidadet.A199TipoParCodigo = aP1_TipoParCodigo;
         objpregistrapartidadet.A207PartidaId = aP2_PartidaId;
         objpregistrapartidadet.AV11PartidaDebe = aP3_PartidaDebe;
         objpregistrapartidadet.AV12PartidaHaber = aP4_PartidaHaber;
         objpregistrapartidadet.AV14CtaContableCodigo = aP5_CtaContableCodigo;
         objpregistrapartidadet.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistrapartidadet);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaDebe=this.AV11PartidaDebe;
         aP4_PartidaHaber=this.AV12PartidaHaber;
         aP5_CtaContableCodigo=this.AV14CtaContableCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistrapartidadet)stateInfo).executePrivate();
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
         AV17GXLvl3 = 0 ;
         /* Using cursor P00152 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A214PartidaLinea = P00152_A214PartidaLinea[0] ;
            AV17GXLvl3 = 1 ;
            AV13PartidaLinea = A214PartidaLinea ;
            AV13PartidaLinea = (short)(AV13PartidaLinea+1) ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV17GXLvl3 == 0 )
         {
            AV13PartidaLinea = 1 ;
         }
         /*
            INSERT RECORD ON TABLE PartidaDet

         */
         A214PartidaLinea = AV13PartidaLinea ;
         A215PartidaDebe = AV11PartidaDebe ;
         A216PartidaHaber = AV12PartidaHaber ;
         A193CtaContableCodigo = AV14CtaContableCodigo ;
         /* Using cursor P00153 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId, A214PartidaLinea, A215PartidaDebe, A216PartidaHaber, A193CtaContableCodigo});
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
         context.CommitDataStores("pRegistraPartidaDet");
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
         P00152_A41ClinicaCodigo = new String[] {""} ;
         P00152_A199TipoParCodigo = new String[] {""} ;
         P00152_A207PartidaId = new int[1] ;
         P00152_A214PartidaLinea = new short[1] ;
         A193CtaContableCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistrapartidadet__default(),
            new Object[][] {
                new Object[] {
               P00152_A41ClinicaCodigo, P00152_A199TipoParCodigo, P00152_A207PartidaId, P00152_A214PartidaLinea
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV17GXLvl3 ;
      private short A214PartidaLinea ;
      private short AV13PartidaLinea ;
      private int A207PartidaId ;
      private int GX_INS54 ;
      private decimal AV11PartidaDebe ;
      private decimal AV12PartidaHaber ;
      private decimal A215PartidaDebe ;
      private decimal A216PartidaHaber ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String AV14CtaContableCodigo ;
      private String A193CtaContableCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_PartidaId ;
      private decimal aP3_PartidaDebe ;
      private decimal aP4_PartidaHaber ;
      private String aP5_CtaContableCodigo ;
      private IDataStoreProvider pr_default ;
      private String[] P00152_A41ClinicaCodigo ;
      private String[] P00152_A199TipoParCodigo ;
      private int[] P00152_A207PartidaId ;
      private short[] P00152_A214PartidaLinea ;
   }

   public class pregistrapartidadet__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00152 ;
          prmP00152 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP00153 ;
          prmP00153 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0} ,
          new Object[] {"@PartidaLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PartidaDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@PartidaHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00152", "SELECT TOP 1 [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea] FROM [PartidaDet] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([TipoParCodigo] = @TipoParCodigo) AND ([PartidaId] = @PartidaId) ORDER BY [PartidaLinea] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00152,1,0,false,true )
             ,new CursorDef("P00153", "INSERT INTO [PartidaDet] ([ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaLinea], [PartidaDebe], [PartidaHaber], [CtaContableCodigo]) VALUES (@ClinicaCodigo, @TipoParCodigo, @PartidaId, @PartidaLinea, @PartidaDebe, @PartidaHaber, @CtaContableCodigo)", GxErrorMask.GX_NOMASK,prmP00153)
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
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
