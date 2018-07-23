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
 * FlowBody
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class FlowBody {
  @SerializedName("postProcessingSteps")
  private List<IdWithName> postProcessingSteps = null;

  @SerializedName("preZones")
  private List<FlowZone> preZones = null;

  @SerializedName("genDocZone")
  private FlowZone genDocZone = null;

  @SerializedName("postZones")
  private List<FlowZone> postZones = null;

  public FlowBody postProcessingSteps(List<IdWithName> postProcessingSteps) {
    this.postProcessingSteps = postProcessingSteps;
    return this;
  }

  public FlowBody addPostProcessingStepsItem(IdWithName postProcessingStepsItem) {
    if (this.postProcessingSteps == null) {
      this.postProcessingSteps = new ArrayList<IdWithName>();
    }
    this.postProcessingSteps.add(postProcessingStepsItem);
    return this;
  }

   /**
   * Get postProcessingSteps
   * @return postProcessingSteps
  **/
  @ApiModelProperty(value = "")
  public List<IdWithName> getPostProcessingSteps() {
    return postProcessingSteps;
  }

  public void setPostProcessingSteps(List<IdWithName> postProcessingSteps) {
    this.postProcessingSteps = postProcessingSteps;
  }

  public FlowBody preZones(List<FlowZone> preZones) {
    this.preZones = preZones;
    return this;
  }

  public FlowBody addPreZonesItem(FlowZone preZonesItem) {
    if (this.preZones == null) {
      this.preZones = new ArrayList<FlowZone>();
    }
    this.preZones.add(preZonesItem);
    return this;
  }

   /**
   * Get preZones
   * @return preZones
  **/
  @ApiModelProperty(value = "")
  public List<FlowZone> getPreZones() {
    return preZones;
  }

  public void setPreZones(List<FlowZone> preZones) {
    this.preZones = preZones;
  }

  public FlowBody genDocZone(FlowZone genDocZone) {
    this.genDocZone = genDocZone;
    return this;
  }

   /**
   * Get genDocZone
   * @return genDocZone
  **/
  @ApiModelProperty(value = "")
  public FlowZone getGenDocZone() {
    return genDocZone;
  }

  public void setGenDocZone(FlowZone genDocZone) {
    this.genDocZone = genDocZone;
  }

  public FlowBody postZones(List<FlowZone> postZones) {
    this.postZones = postZones;
    return this;
  }

  public FlowBody addPostZonesItem(FlowZone postZonesItem) {
    if (this.postZones == null) {
      this.postZones = new ArrayList<FlowZone>();
    }
    this.postZones.add(postZonesItem);
    return this;
  }

   /**
   * Get postZones
   * @return postZones
  **/
  @ApiModelProperty(value = "")
  public List<FlowZone> getPostZones() {
    return postZones;
  }

  public void setPostZones(List<FlowZone> postZones) {
    this.postZones = postZones;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlowBody flowBody = (FlowBody) o;
    return Objects.equals(this.postProcessingSteps, flowBody.postProcessingSteps) &&
        Objects.equals(this.preZones, flowBody.preZones) &&
        Objects.equals(this.genDocZone, flowBody.genDocZone) &&
        Objects.equals(this.postZones, flowBody.postZones);
  }

  @Override
  public int hashCode() {
    return Objects.hash(postProcessingSteps, preZones, genDocZone, postZones);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlowBody {\n");
    
    sb.append("    postProcessingSteps: ").append(toIndentedString(postProcessingSteps)).append("\n");
    sb.append("    preZones: ").append(toIndentedString(preZones)).append("\n");
    sb.append("    genDocZone: ").append(toIndentedString(genDocZone)).append("\n");
    sb.append("    postZones: ").append(toIndentedString(postZones)).append("\n");
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

