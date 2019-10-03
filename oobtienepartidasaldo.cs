/*
               File: oObtienePartidaSaldo
        Description: Obtiene Saldo de la Partida
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:57.0
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
   public class oobtienepartidasaldo : GXProcedure
   {
      public oobtienepartidasaldo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienepartidasaldo( IGxContext context )
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
                           ref decimal aP4_PartidaHaber )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV8PartidaDebe = aP3_PartidaDebe;
         this.AV9PartidaHaber = aP4_PartidaHaber;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaDebe=this.AV8PartidaDebe;
         aP4_PartidaHaber=this.AV9PartidaHaber;
      }

      public decimal executeUdp( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId ,
                                 ref decimal aP3_PartidaDebe )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         this.AV8PartidaDebe = aP3_PartidaDebe;
         this.AV9PartidaHaber = aP4_PartidaHaber;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaDebe=this.AV8PartidaDebe;
         aP4_PartidaHaber=this.AV9PartidaHaber;
         return AV9PartidaHaber ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId ,
                                 ref decimal aP3_PartidaDebe ,
                                 ref decimal aP4_PartidaHaber )
      {
         oobtienepartidasaldo objoobtienepartidasaldo;
         objoobtienepartidasaldo = new oobtienepartidasaldo();
         objoobtienepartidasaldo.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienepartidasaldo.A199TipoParCodigo = aP1_TipoParCodigo;
         objoobtienepartidasaldo.A207PartidaId = aP2_PartidaId;
         objoobtienepartidasaldo.AV8PartidaDebe = aP3_PartidaDebe;
         objoobtienepartidasaldo.AV9PartidaHaber = aP4_PartidaHaber;
         objoobtienepartidasaldo.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienepartidasaldo);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         aP3_PartidaDebe=this.AV8PartidaDebe;
         aP4_PartidaHaber=this.AV9PartidaHaber;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienepartidasaldo)stateInfo).executePrivate();
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
         AV8PartidaDebe = 0 ;
         AV9PartidaHaber = 0 ;
         /* Optimized group. */
         /* Using cursor P00182 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
         c215PartidaDebe = P00182_A215PartidaDebe[0] ;
         c216PartidaHaber = P00182_A216PartidaHaber[0] ;
         pr_default.close(0);
         AV8PartidaDebe = (decimal)(AV8PartidaDebe+c215PartidaDebe) ;
         AV9PartidaHaber = (decimal)(AV9PartidaHaber+c216PartidaHaber) ;
         /* End optimized group. */
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
         P00182_A215PartidaDebe = new decimal[1] ;
         P00182_A216PartidaHaber = new decimal[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienepartidasaldo__default(),
            new Object[][] {
                new Object[] {
               P00182_A215PartidaDebe, P00182_A216PartidaHaber
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A207PartidaId ;
      private decimal AV8PartidaDebe ;
      private decimal AV9PartidaHaber ;
      private decimal c215PartidaDebe ;
      private decimal c216PartidaHaber ;
      private String scmdbuf ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_PartidaId ;
      private decimal aP3_PartidaDebe ;
      private decimal aP4_PartidaHaber ;
      private IDataStoreProvider pr_default ;
      private decimal[] P00182_A215PartidaDebe ;
      private decimal[] P00182_A216PartidaHaber ;
   }

   public class oobtienepartidasaldo__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00182 ;
          prmP00182 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00182", "SELECT SUM([PartidaDebe]), SUM([PartidaHaber]) FROM [PartidaDet] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @PartidaId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00182,1,0,true,false )
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
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
