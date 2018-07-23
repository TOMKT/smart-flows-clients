/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModelProperty;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * GeneratedDocumentCharts
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class GeneratedDocumentCharts {
  @SerializedName("title")
  private String title = null;

  @SerializedName("categories")
  private List<ChartValue> categories = null;

  @SerializedName("series")
  private List<GeneratedDocumentSeries> series = null;

  public GeneratedDocumentCharts title(String title) {
    this.title = title;
    return this;
  }

   /**
   * Get title
   * @return title
  **/
  @ApiModelProperty(value = "")
  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public GeneratedDocumentCharts categories(List<ChartValue> categories) {
    this.categories = categories;
    return this;
  }

  public GeneratedDocumentCharts addCategoriesItem(ChartValue categoriesItem) {
    if (this.categories == null) {
      this.categories = new ArrayList<ChartValue>();
    }
    this.categories.add(categoriesItem);
    return this;
  }

   /**
   * Get categories
   * @return categories
  **/
  @ApiModelProperty(value = "")
  public List<ChartValue> getCategories() {
    return categories;
  }

  public void setCategories(List<ChartValue> categories) {
    this.categories = categories;
  }

  public GeneratedDocumentCharts series(List<GeneratedDocumentSeries> series) {
    this.series = series;
    return this;
  }

  public GeneratedDocumentCharts addSeriesItem(GeneratedDocumentSeries seriesItem) {
    if (this.series == null) {
      this.series = new ArrayList<GeneratedDocumentSeries>();
    }
    this.series.add(seriesItem);
    return this;
  }

   /**
   * Get series
   * @return series
  **/
  @ApiModelProperty(value = "")
  public List<GeneratedDocumentSeries> getSeries() {
    return series;
  }

  public void setSeries(List<GeneratedDocumentSeries> series) {
    this.series = series;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GeneratedDocumentCharts generatedDocumentCharts = (GeneratedDocumentCharts) o;
    return Objects.equals(this.title, generatedDocumentCharts.title) &&
        Objects.equals(this.categories, generatedDocumentCharts.categories) &&
        Objects.equals(this.series, generatedDocumentCharts.series);
  }

  @Override
  public int hashCode() {
    return Objects.hash(title, categories, series);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GeneratedDocumentCharts {\n");
    
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    categories: ").append(toIndentedString(categories)).append("\n");
    sb.append("    series: ").append(toIndentedString(series)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

