/*
               File: oObtieneArticuloCosto
        Description: Obtiene Costo de Articulo
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:50.75
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
   public class oobtienearticulocosto : GXProcedure
   {
      public oobtienearticulocosto( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienearticulocosto( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_ArticuloCodigo ,
                           ref String aP2_ArticuloDescripcion ,
                           ref decimal aP3_ArticuloCosto )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A30ArticuloCodigo = aP1_ArticuloCodigo;
         this.AV9ArticuloDescripcion = aP2_ArticuloDescripcion;
         this.AV8ArticuloCosto = aP3_ArticuloCosto;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ArticuloCodigo=this.A30ArticuloCodigo;
         aP2_ArticuloDescripcion=this.AV9ArticuloDescripcion;
         aP3_ArticuloCosto=this.AV8ArticuloCosto;
      }

      public decimal executeUdp( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_ArticuloCodigo ,
                                 ref String aP2_ArticuloDescripcion )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A30ArticuloCodigo = aP1_ArticuloCodigo;
         this.AV9ArticuloDescripcion = aP2_ArticuloDescripcion;
         this.AV8ArticuloCosto = aP3_ArticuloCosto;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ArticuloCodigo=this.A30ArticuloCodigo;
         aP2_ArticuloDescripcion=this.AV9ArticuloDescripcion;
         aP3_ArticuloCosto=this.AV8ArticuloCosto;
         return AV8ArticuloCosto ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_ArticuloCodigo ,
                                 ref String aP2_ArticuloDescripcion ,
                                 ref decimal aP3_ArticuloCosto )
      {
         oobtienearticulocosto objoobtienearticulocosto;
         objoobtienearticulocosto = new oobtienearticulocosto();
         objoobtienearticulocosto.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienearticulocosto.A30ArticuloCodigo = aP1_ArticuloCodigo;
         objoobtienearticulocosto.AV9ArticuloDescripcion = aP2_ArticuloDescripcion;
         objoobtienearticulocosto.AV8ArticuloCosto = aP3_ArticuloCosto;
         objoobtienearticulocosto.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienearticulocosto);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ArticuloCodigo=this.A30ArticuloCodigo;
         aP2_ArticuloDescripcion=this.AV9ArticuloDescripcion;
         aP3_ArticuloCosto=this.AV8ArticuloCosto;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienearticulocosto)stateInfo).executePrivate();
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
         /* Using cursor P000X2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A31ArticuloDescripcion = P000X2_A31ArticuloDescripcion[0] ;
            A60ArticuloCosto = P000X2_A60ArticuloCosto[0] ;
            AV9ArticuloDescripcion = A31ArticuloDescripcion ;
            AV8ArticuloCosto = A60ArticuloCosto ;
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
         P000X2_A41ClinicaCodigo = new String[] {""} ;
         P000X2_A30ArticuloCodigo = new String[] {""} ;
         P000X2_A31ArticuloDescripcion = new String[] {""} ;
         P000X2_A60ArticuloCosto = new decimal[1] ;
         A31ArticuloDescripcion = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienearticulocosto__default(),
            new Object[][] {
                new Object[] {
               P000X2_A41ClinicaCodigo, P000X2_A30ArticuloCodigo, P000X2_A31ArticuloDescripcion, P000X2_A60ArticuloCosto
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private decimal AV8ArticuloCosto ;
      private decimal A60ArticuloCosto ;
      private String scmdbuf ;
      private String A41ClinicaCodigo ;
      private String A30ArticuloCodigo ;
      private String AV9ArticuloDescripcion ;
      private String A31ArticuloDescripcion ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_ArticuloCodigo ;
      private String aP2_ArticuloDescripcion ;
      private decimal aP3_ArticuloCosto ;
      private IDataStoreProvider pr_default ;
      private String[] P000X2_A41ClinicaCodigo ;
      private String[] P000X2_A30ArticuloCodigo ;
      private String[] P000X2_A31ArticuloDescripcion ;
      private decimal[] P000X2_A60ArticuloCosto ;
   }

   public class oobtienearticulocosto__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000X2 ;
          prmP000X2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000X2", "SELECT [ClinicaCodigo], [ArticuloCodigo], [ArticuloDescripcion], [ArticuloCosto] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ArticuloCodigo] = @ArticuloCodigo ORDER BY [ClinicaCodigo], [ArticuloCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000X2,1,0,false,true )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
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
       }
    }

 }

}
