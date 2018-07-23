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
 * DocGenSettingsTemplateStandard
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class DocGenSettingsTemplateStandard {
  @SerializedName("content")
  private byte[] content = null;

  @SerializedName("datasets")
  private List<String> datasets = null;

  @SerializedName("schemas")
  private List<SchemaContent> schemas = null;

  public DocGenSettingsTemplateStandard content(byte[] content) {
    this.content = content;
    return this;
  }

   /**
   * Get content
   * @return content
  **/
  @ApiModelProperty(value = "")
  public byte[] getContent() {
    return content;
  }

  public void setContent(byte[] content) {
    this.content = content;
  }

  public DocGenSettingsTemplateStandard datasets(List<String> datasets) {
    this.datasets = datasets;
    return this;
  }

  public DocGenSettingsTemplateStandard addDatasetsItem(String datasetsItem) {
    if (this.datasets == null) {
      this.datasets = new ArrayList<String>();
    }
    this.datasets.add(datasetsItem);
    return this;
  }

   /**
   * Get datasets
   * @return datasets
  **/
  @ApiModelProperty(value = "")
  public List<String> getDatasets() {
    return datasets;
  }

  public void setDatasets(List<String> datasets) {
    this.datasets = datasets;
  }

  public DocGenSettingsTemplateStandard schemas(List<SchemaContent> schemas) {
    this.schemas = schemas;
    return this;
  }

  public DocGenSettingsTemplateStandard addSchemasItem(SchemaContent schemasItem) {
    if (this.schemas == null) {
      this.schemas = new ArrayList<SchemaContent>();
    }
    this.schemas.add(schemasItem);
    return this;
  }

   /**
   * Get schemas
   * @return schemas
  **/
  @ApiModelProperty(value = "")
  public List<SchemaContent> getSchemas() {
    return schemas;
  }

  public void setSchemas(List<SchemaContent> schemas) {
    this.schemas = schemas;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocGenSettingsTemplateStandard docGenSettingsTemplateStandard = (DocGenSettingsTemplateStandard) o;
    return Objects.equals(this.content, docGenSettingsTemplateStandard.content) &&
        Objects.equals(this.datasets, docGenSettingsTemplateStandard.datasets) &&
        Objects.equals(this.schemas, docGenSettingsTemplateStandard.schemas);
  }

  @Override
  public int hashCode() {
    return Objects.hash(content, datasets, schemas);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocGenSettingsTemplateStandard {\n");
    
    sb.append("    content: ").append(toIndentedString(content)).append("\n");
    sb.append("    datasets: ").append(toIndentedString(datasets)).append("\n");
    sb.append("    schemas: ").append(toIndentedString(schemas)).append("\n");
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

