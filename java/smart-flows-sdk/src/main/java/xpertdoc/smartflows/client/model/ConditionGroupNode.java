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
 * ConditionGroupNode
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class ConditionGroupNode {
  @SerializedName("id")
  private String id = null;

  @SerializedName("group")
  private ConditionGroup group = null;

  @SerializedName("condition")
  private Condition condition = null;

  public ConditionGroupNode id(String id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }

  public ConditionGroupNode group(ConditionGroup group) {
    this.group = group;
    return this;
  }

   /**
   * Get group
   * @return group
  **/
  @ApiModelProperty(value = "")
  public ConditionGroup getGroup() {
    return group;
  }

  public void setGroup(ConditionGroup group) {
    this.group = group;
  }

  public ConditionGroupNode condition(Condition condition) {
    this.condition = condition;
    return this;
  }

   /**
   * Get condition
   * @return condition
  **/
  @ApiModelProperty(value = "")
  public Condition getCondition() {
    return condition;
  }

  public void setCondition(Condition condition) {
    this.condition = condition;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ConditionGroupNode conditionGroupNode = (ConditionGroupNode) o;
    return Objects.equals(this.id, conditionGroupNode.id) &&
        Objects.equals(this.group, conditionGroupNode.group) &&
        Objects.equals(this.condition, conditionGroupNode.condition);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, group, condition);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ConditionGroupNode {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    group: ").append(toIndentedString(group)).append("\n");
    sb.append("    condition: ").append(toIndentedString(condition)).append("\n");
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

