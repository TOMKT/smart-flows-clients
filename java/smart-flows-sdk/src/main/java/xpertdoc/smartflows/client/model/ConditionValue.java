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
 * ConditionValue
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class ConditionValue {
  @SerializedName("displayName")
  private String displayName = null;

  @SerializedName("type")
  private ConditionValueType type = null;

  @SerializedName("docPropName")
  private String docPropName = null;

  @SerializedName("constant")
  private String constant = null;

  @SerializedName("field")
  private String field = null;

  @SerializedName("expression")
  private String expression = null;

  @SerializedName("flowVariable")
  private ConditionFlowVariable flowVariable = null;

  public ConditionValue displayName(String displayName) {
    this.displayName = displayName;
    return this;
  }

   /**
   * Get displayName
   * @return displayName
  **/
  @ApiModelProperty(value = "")
  public String getDisplayName() {
    return displayName;
  }

  public void setDisplayName(String displayName) {
    this.displayName = displayName;
  }

  public ConditionValue type(ConditionValueType type) {
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @ApiModelProperty(value = "")
  public ConditionValueType getType() {
    return type;
  }

  public void setType(ConditionValueType type) {
    this.type = type;
  }

  public ConditionValue docPropName(String docPropName) {
    this.docPropName = docPropName;
    return this;
  }

   /**
   * Get docPropName
   * @return docPropName
  **/
  @ApiModelProperty(value = "")
  public String getDocPropName() {
    return docPropName;
  }

  public void setDocPropName(String docPropName) {
    this.docPropName = docPropName;
  }

  public ConditionValue constant(String constant) {
    this.constant = constant;
    return this;
  }

   /**
   * Get constant
   * @return constant
  **/
  @ApiModelProperty(value = "")
  public String getConstant() {
    return constant;
  }

  public void setConstant(String constant) {
    this.constant = constant;
  }

  public ConditionValue field(String field) {
    this.field = field;
    return this;
  }

   /**
   * Get field
   * @return field
  **/
  @ApiModelProperty(value = "")
  public String getField() {
    return field;
  }

  public void setField(String field) {
    this.field = field;
  }

  public ConditionValue expression(String expression) {
    this.expression = expression;
    return this;
  }

   /**
   * Get expression
   * @return expression
  **/
  @ApiModelProperty(value = "")
  public String getExpression() {
    return expression;
  }

  public void setExpression(String expression) {
    this.expression = expression;
  }

  public ConditionValue flowVariable(ConditionFlowVariable flowVariable) {
    this.flowVariable = flowVariable;
    return this;
  }

   /**
   * Get flowVariable
   * @return flowVariable
  **/
  @ApiModelProperty(value = "")
  public ConditionFlowVariable getFlowVariable() {
    return flowVariable;
  }

  public void setFlowVariable(ConditionFlowVariable flowVariable) {
    this.flowVariable = flowVariable;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ConditionValue conditionValue = (ConditionValue) o;
    return Objects.equals(this.displayName, conditionValue.displayName) &&
        Objects.equals(this.type, conditionValue.type) &&
        Objects.equals(this.docPropName, conditionValue.docPropName) &&
        Objects.equals(this.constant, conditionValue.constant) &&
        Objects.equals(this.field, conditionValue.field) &&
        Objects.equals(this.expression, conditionValue.expression) &&
        Objects.equals(this.flowVariable, conditionValue.flowVariable);
  }

  @Override
  public int hashCode() {
    return Objects.hash(displayName, type, docPropName, constant, field, expression, flowVariable);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ConditionValue {\n");
    
    sb.append("    displayName: ").append(toIndentedString(displayName)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    docPropName: ").append(toIndentedString(docPropName)).append("\n");
    sb.append("    constant: ").append(toIndentedString(constant)).append("\n");
    sb.append("    field: ").append(toIndentedString(field)).append("\n");
    sb.append("    expression: ").append(toIndentedString(expression)).append("\n");
    sb.append("    flowVariable: ").append(toIndentedString(flowVariable)).append("\n");
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

