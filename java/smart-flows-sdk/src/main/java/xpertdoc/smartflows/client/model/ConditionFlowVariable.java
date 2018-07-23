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

import java.util.Objects;

/**
 * ConditionFlowVariable
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class ConditionFlowVariable {
  @SerializedName("blockId")
  private String blockId = null;

  @SerializedName("outputId")
  private String outputId = null;

  @SerializedName("parameter")
  private String parameter = null;

  @SerializedName("dataPath")
  private String dataPath = null;

  public ConditionFlowVariable blockId(String blockId) {
    this.blockId = blockId;
    return this;
  }

   /**
   * Get blockId
   * @return blockId
  **/
  @ApiModelProperty(value = "")
  public String getBlockId() {
    return blockId;
  }

  public void setBlockId(String blockId) {
    this.blockId = blockId;
  }

  public ConditionFlowVariable outputId(String outputId) {
    this.outputId = outputId;
    return this;
  }

   /**
   * Get outputId
   * @return outputId
  **/
  @ApiModelProperty(value = "")
  public String getOutputId() {
    return outputId;
  }

  public void setOutputId(String outputId) {
    this.outputId = outputId;
  }

  public ConditionFlowVariable parameter(String parameter) {
    this.parameter = parameter;
    return this;
  }

   /**
   * Get parameter
   * @return parameter
  **/
  @ApiModelProperty(value = "")
  public String getParameter() {
    return parameter;
  }

  public void setParameter(String parameter) {
    this.parameter = parameter;
  }

  public ConditionFlowVariable dataPath(String dataPath) {
    this.dataPath = dataPath;
    return this;
  }

   /**
   * Get dataPath
   * @return dataPath
  **/
  @ApiModelProperty(value = "")
  public String getDataPath() {
    return dataPath;
  }

  public void setDataPath(String dataPath) {
    this.dataPath = dataPath;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ConditionFlowVariable conditionFlowVariable = (ConditionFlowVariable) o;
    return Objects.equals(this.blockId, conditionFlowVariable.blockId) &&
        Objects.equals(this.outputId, conditionFlowVariable.outputId) &&
        Objects.equals(this.parameter, conditionFlowVariable.parameter) &&
        Objects.equals(this.dataPath, conditionFlowVariable.dataPath);
  }

  @Override
  public int hashCode() {
    return Objects.hash(blockId, outputId, parameter, dataPath);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ConditionFlowVariable {\n");
    
    sb.append("    blockId: ").append(toIndentedString(blockId)).append("\n");
    sb.append("    outputId: ").append(toIndentedString(outputId)).append("\n");
    sb.append("    parameter: ").append(toIndentedString(parameter)).append("\n");
    sb.append("    dataPath: ").append(toIndentedString(dataPath)).append("\n");
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

